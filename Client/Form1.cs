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

namespace Client
{
    public partial class Form1 : Form
    {
        TcpClient client;
        IPAddress ipAddr = null;
        int port = 0;
        NetworkStream stream;

        Color basic = Color.FromArgb(240, 240, 240);

        private bool b_start = false;
        private bool b_login = false;

        public Form1()
        {
            InitializeComponent();
            openFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFD.Filter = "jpg (*.jpg)| *.jpg";
        }

        private void bt_Connect_Click(object sender, EventArgs e)
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
                    ipAddr = IPAddress.Parse(tb_IP.Text);
                    port = int.Parse(tb_Port.Text);
                    client = new TcpClient();
                    Connect();
                }
            }
            else
            {
                tb_IP.ReadOnly = false;
                tb_Port.ReadOnly = false;
                b_start = false;
                tb_ID.Enabled = false;
                tb_PW.Enabled = false;
                bt_login.Enabled = false;
                bt_Join.Enabled = false;
                bt_Connect.Text = "Connect";
                bt_Connect.ForeColor = Color.Black;
                Send("disconnect");
                Disconnect();
            }
        }

        public void Connect()
        {
            try
            {
                client.Connect(ipAddr, port);
                stream = client.GetStream();
            }
            catch
            {
                b_start = false;
                MessageBox.Show("연결에 실패하였습니다.");
                return;
            }
            b_start = true;
            tb_IP.ReadOnly = true;
            tb_Port.ReadOnly = true;
            b_start = true;
            tb_ID.Enabled = true;
            tb_PW.Enabled = true;
            bt_login.Enabled = true;
            bt_Join.Enabled = true;
            bt_Connect.Text = "Disconnect";
            bt_Connect.ForeColor = Color.Red;

            Send("connect");
        }

        public void Disconnect()
        {
            client.Close();
            stream.Close();
        }

        private void pb_Home_Click(object sender, EventArgs e)
        {
            if (!b_login)
                return;
            pn_Home.Visible = true;
            pn_Search.Visible = false;
            pn_Upload.Visible = false;
            pn_Profile.Visible = false;
            pb_Home.BackColor = Color.LightSkyBlue;
            pb_Search.BackColor = basic;
            pb_Upload.BackColor = basic;
            pb_Profile.BackColor = basic;
        }

        private void pb_Search_Click(object sender, EventArgs e)
        {
            if (!b_login)
                return;
            pn_Home.Visible = false;
            pn_Search.Visible = true;
            pn_Upload.Visible = false;
            pn_Profile.Visible = false;
            pb_Home.BackColor = basic;
            pb_Search.BackColor = Color.LightSkyBlue;
            pb_Upload.BackColor = basic;
            pb_Profile.BackColor = basic;
            bt_Search_Click(sender, e);
        }

        private void pb_Upload_Click(object sender, EventArgs e)
        {
            if (!b_login)
                return;
            pn_Home.Visible = false;
            pn_Search.Visible = false;
            pn_Upload.Visible = true;
            pn_Profile.Visible = false;
            pb_Home.BackColor = basic;
            pb_Search.BackColor = basic;
            pb_Upload.BackColor = Color.LightSkyBlue;
            pb_Profile.BackColor = basic;
        }

        private void pb_MyPage_Click(object sender, EventArgs e)
        {
            if (!b_login)
                return;
            pn_Home.Visible = false;
            pn_Search.Visible = false;
            pn_Upload.Visible = false;
            pn_Profile.Visible = true;
            pb_Home.BackColor = basic;
            pb_Search.BackColor = basic;
            pb_Upload.BackColor = basic;
            pb_Profile.BackColor = Color.LightSkyBlue;
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (!b_login)
            {
                if (tb_ID.Text == "" || tb_PW.Text == "")
                {
                    if (tb_ID.Text == "")
                        MessageBox.Show("아이디를 입력하세요.");
                    else
                        MessageBox.Show("비밀번호를 입력하세요.");
                    return;
                }

                Send("login");
                Send(tb_ID.Text.ToString() + ":" + tb_PW.Text.ToString());

                byte[] recieve = new byte[4096];
                int byteRead = stream.Read(recieve, 0, recieve.Length);
                string check = Encoding.UTF8.GetString(recieve, 0, byteRead);
                if (check == "success")
                {
                    b_login = true;
                    tb_ID.ReadOnly = true;
                    tb_PW.ReadOnly = true;
                    bt_login.Text = "로그아웃";
                    bt_login.ForeColor = Color.Red;
                    bt_Join.Enabled = false;
                }
                else if (check == "fail")
                    MessageBox.Show("아이디 또는 패스워드가 잘못되었습니다.\n계정이없다면 회원가입버튼을 통해 계정을 만드세요.");
            }
            else
            {
                Send("logout");
                Send(tb_ID.Text.ToString());
                b_login = false;
                tb_ID.ReadOnly = false;
                tb_PW.ReadOnly = false;
                bt_login.Text = "로그인";
                bt_Join.Enabled = true;
                bt_login.ForeColor = Color.Black;
                pn_Home.Visible = false;
                pn_Search.Visible = false;
                pn_Upload.Visible = false;
                pn_Profile.Visible = false;
                pb_Home.BackColor = basic;
                pb_Search.BackColor = basic;
                pb_Upload.BackColor = basic;
                pb_Profile.BackColor = basic;
            }
            stream.Flush();
        }

        private void bt_Join_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text == "" || tb_PW.Text == "")
            {
                if (tb_ID.Text == "")
                    MessageBox.Show("아이디를 입력하세요.");
                else
                    MessageBox.Show("비밀번호를 입력하세요.");
                return;
            }

            if (tb_ID.Text.Contains(":"))
            {
                MessageBox.Show(":는 사용할 수 없는 문자입니다.");
                return;
            }

            Send("join");
            string idpw = tb_ID.Text.ToString() + ":" + tb_PW.Text.ToString();
            Send(idpw);

            byte[] recieve = new byte[4096];
            int byteRead = stream.Read(recieve, 0, recieve.Length);
            string check = Encoding.UTF8.GetString(recieve, 0, byteRead);
            if (check == "success")
                MessageBox.Show("회원가입에 성공하였습니다.");
            else if (check == "fail")
                MessageBox.Show("이미 사용 중인 아이디입니다.");
        }

        private void Send(string message)
        {
            byte[] msg = new byte[4096];
            msg = Encoding.UTF8.GetBytes(message);

            stream.Write(msg, 0, msg.Length);
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            Send("search");
            if (tb_Search.Text == "")
                Send("all:id");
            else
                Send(tb_Search.Text);

            byte[] recieve = new byte[4096];
            int byteRead = stream.Read(recieve, 0, recieve.Length);
            string result = Encoding.UTF8.GetString(recieve, 0, byteRead);
            tb_Search.Text = "";
            lv_Search.Items.Clear();
            if (result != "no:id")
            {
                string[] item = result.Split(':');
                foreach (string str in item)
                    lv_Search.Items.Add(str);
            }
        }

        private void bt_UploadSearch_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                tb_UploadPath.Text = openFD.FileName;
                openFD.FileName = "";

                pb_UploadPicture.SizeMode = PictureBoxSizeMode.Zoom;
                pb_UploadPicture.Load(tb_UploadPath.Text);
            }
        }

        private void bt_Upload_Click(object sender, EventArgs e)
        {
            if (tb_UploadPath.Text == "")
            {
                MessageBox.Show("업로드할 이미지를 선택하세요.");
                return;
            }
            Send("upload-text");
            Send(tb_UploadText.Text);
            Send("upload-image");
            Image img = Image.FromFile(tb_UploadPath.Text);
            Send(img);

        }

        private void Send(Image img)
        {
            MemoryStream ms = new MemoryStream();
            try
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ms.Position = 0;
                byte[] data = ms.ToArray();

                stream.Write(data, 0, data.Length);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                ms.Close();
                ms.Dispose();
            }
        }

        private void pb_ProfilePicture_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                pb_ProfilePicture.Load(openFD.FileName);
                openFD.FileName = "";
                pb_ProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
