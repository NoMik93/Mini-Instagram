using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Server
{
    public partial class Form1 : Form
    {
        TcpListener server;
        Thread sThread;
        IPAddress ipAddr;

        bool b_start = false;
        bool image = false;

        string nextDo = "";
        string path = "";
        int memberPostNum = 0;
        string loginID = "";

        StreamReader sr;
        StreamWriter sw;

        public Form1()
        {
            InitializeComponent();
            SetIp();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sThread.Abort();
            ServerStop();
        }

        private void btn_exit_click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void SetIp()
        {
            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress addr in hostEntry.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipAddr = addr;
                    break;
                }
            }
            if (ipAddr == null)
                ipAddr = IPAddress.Loopback;

            tb_IP.Text = ipAddr.ToString();
            tb_IP.ReadOnly = true;
        }

        private void SetDirectory()
        {
            sLog("C:\\Instagram를 서버 디렉토리로 설정");
            if (Directory.Exists(@"C:\Instagram"))
                SetMemberList();
            else
            {
                Directory.CreateDirectory(@"C:\Instagram");
                File.CreateText(@"C:\Instagram\Member.txt").Close();
                File.CreateText(@"C:\Instagram\Post.txt").Close();
            }
        }

        private void SetMemberList()
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                lv_MemberList.Items.Clear();
            }));

            try
            {
                if (sr != null)
                    sr.Close();
                sr = new StreamReader(@"C:\Instagram\Member.txt");
                string line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] str = line.Split(':');
                    ListViewItem item = new ListViewItem(i.ToString());
                    foreach (string st in str)
                        item.SubItems.Add(st);
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        lv_MemberList.Items.Add(item);
                    }));
                    i++;
                    string dir = @"C:\\Instagram\\" + str[0];
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                        File.WriteAllText(dir + "\\" + str[0] + ".txt", "0");
                    }
                }
                sr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            if (!b_start)
            {
                if (tb_IP.Text == "" || tb_Port.Text == "")
                {
                    if (tb_IP.Text == "")
                        MessageBox.Show("IP를 입력하세요.");
                    else
                        MessageBox.Show("Port번호를 입력하세요.");
                    return;
                }
                else
                {
                    SetDirectory();
                    tb_Port.ReadOnly = true;
                    b_start = true;
                    sLog("Server 시작");
                    bt_Start.Text = "Stop";
                    bt_Start.ForeColor = Color.Red;

                    sThread = new Thread(new ThreadStart(ServerStart));
                    sThread.IsBackground = true;
                    sThread.Start();
                }
            }
            else
            {
                b_start = false;
                tb_Port.ReadOnly = false;
                sLog("Server 정지");
                bt_Start.Text = "Start";
                bt_Start.ForeColor = Color.Black;
                ServerStop();
            }
        }

        public void ServerStart()
        {
            server = new TcpListener(ipAddr, int.Parse(tb_Port.Text.ToString()));
            server.Start();
            sLog("클라이언트 기다리는 중...");

            while (b_start)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();
                    Thread tcpHandlerThread = new Thread(new ParameterizedThreadStart(TcpHandler));
                    tcpHandlerThread.Start(client);
                }
                catch (Exception e) { }
            }
        }

        private void TcpHandler(object client)
        {
            TcpClient mClient = client as TcpClient;
            NetworkStream stream = mClient.GetStream();

            while (b_start)
            {
                try
                {
                    string str = "";
                    Image imag = null;
                    if (!image)
                    {
                        byte[] message = new byte[4096];
                        int byteRead = stream.Read(message, 0, message.Length);
                        str = Encoding.UTF8.GetString(message, 0, byteRead);
                    }
                    else
                    {
                        byte[] img = new byte[4096];
                        int byteRead = stream.Read(img, 0, img.Length);
                        imag = Image.FromStream(new MemoryStream(img));
                    }

                    if (nextDo == "")
                        DoIt(mClient, stream, str);
                    else
                        DoIt(nextDo, mClient, stream, str, imag);
                }
                catch (Exception e)
                {
                    sLog("클라이언트의 연결이 끊어졌습니다.");
                    return;
                }
            }

        }

        public void DoIt(TcpClient client, NetworkStream stream, string str)
        {
            switch (str)
            {
                case "connect":
                    sLog("클라이언트와 연결되었습니다.");
                    sLog("");
                    return;
                case "disconnect":
                    sLog("클라이언트와 연결해제되었습니다.");
                    sLog("");
                    return;
                case "login":
                case "logout":
                case "join":
                case "search":
                case "upload-text":
                    nextDo = str;
                    break;
                case "upload-image":
                    image = true;
                    nextDo = str;
                    break;
                default:
                    return;
            }
        }

        public void DoIt(string todo, TcpClient client, NetworkStream stream, string str, Image img)
        {
            switch (todo)
            {
                case "login":
                    string[] idpw = str.Split(':');
                    if (SearchMember(idpw[0], idpw[1]))
                    {
                        byte[] msg1 = new byte[4096];
                        msg1 = Encoding.UTF8.GetBytes("success");
                        stream.Write(msg1, 0, msg1.Length);

                        sLog(idpw[0] + "님이 로그인하셨습니다.");
                        loginID = idpw[0];
                        path = "C:\\Instagram\\" + loginID + "\\";
                        StreamReader sr1 = new StreamReader(path + loginID + ".txt");
                        string num = sr1.ReadLine();
                        memberPostNum = int.Parse(num);
                    }
                    else
                    {
                        byte[] msg2 = new byte[4096];
                        msg2 = Encoding.UTF8.GetBytes("fail");
                        stream.Write(msg2, 0, msg2.Length);
                    }
                    break;
                case "logout":
                    sLog(str + "님이 로그아웃하셨습니다.");
                    break;
                case "join":
                    string[] idpw2 = str.Split(':');
                    if (SearchMember(idpw2[0]))
                    {
                        byte[] msg3 = new byte[4096];
                        msg3 = Encoding.UTF8.GetBytes("fail");
                        stream.Write(msg3, 0, msg3.Length);
                    }
                    else
                    {
                        AddMember(idpw2[0], idpw2[1]);
                        byte[] msg4 = new byte[4096];
                        msg4 = Encoding.UTF8.GetBytes("success");
                        stream.Write(msg4, 0, msg4.Length);
                        sLog(idpw2[0] + "님이 회원가입하셨습니다.");
                    }
                    break;
                case "search":
                    string result = SearchMembers(str);
                    if (result == "")
                        result = "no:id";
                    byte[] msg5 = new byte[4096];
                    msg5 = Encoding.UTF8.GetBytes(result);
                    stream.Write(msg5, 0, msg5.Length);
                    break;
                case "upload-text":
                    byte[] message = new byte[4096];
                    int byteRead = stream.Read(message, 0, message.Length);
                    str = Encoding.UTF8.GetString(message, 0, byteRead);
                    File.WriteAllText(path + memberPostNum + ".txt", str);
                    break;
                case "upload-image":
                    img.Save(path + memberPostNum + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
            }
            nextDo = "";
        }

        public bool SearchMember(string id)
        {
            try
            {
                if (sr != null)
                    sr.Close();
                sr = new StreamReader(@"C:\Instagram\Member.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] id2 = line.Split(':');
                    if (id2[0].Equals(id))
                        return true;
                }
                sr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return false;
        }

        public bool SearchMember(string id, string pw)
        {
            try
            {
                if (sr != null)
                    sr.Close();
                sr = new StreamReader(@"C:\Instagram\Member.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                    if (line.Equals(id + ":" + pw))
                        return true;
                sr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return false;
        }

        public void AddMember(string id, string pw)
        {
            try
            {
                if (sr != null)
                    sr.Close();
                sw = new StreamWriter(@"C:\Instagram\Member.txt", true);
                sw.WriteLine("{0}:{1}", id, pw);
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            SetMemberList();
        }

        public string SearchMembers(string target)
        {
            string ids = "";
            try
            {
                if (sr != null)
                    sr.Close();
                sr = new StreamReader(@"C:\Instagram\Member.txt");
                string line;
                if (target == "all:id")
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] id2 = line.Split(':');
                            if (!id2[0].Equals(loginID))
                                ids += id2[0] + ":";

                    }
                else
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] id2 = line.Split(':');
                        if (id2[0].Contains(target))
                            if (!id2[0].Equals(loginID))
                                ids += id2[0] + ":";

                    }
                sr.Close();
            }
            catch { }
            return ids;
        }

        public void ServerStop()
        {
            server.Stop();
            sThread.Abort();
        }

        public void sLog(string log)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    tb_ServerLog.AppendText(log + "\n");
                    tb_ServerLog.ScrollToCaret();
                }));
            }
            catch (InvalidOperationException e)
            {

            }
        }
    }
}
