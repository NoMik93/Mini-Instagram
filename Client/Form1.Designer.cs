namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_IP = new System.Windows.Forms.Label();
            this.lb_Port = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lb_PW = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_PW = new System.Windows.Forms.TextBox();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.lb_join = new System.Windows.Forms.Label();
            this.bt_Join = new System.Windows.Forms.Button();
            this.pb_Home = new System.Windows.Forms.PictureBox();
            this.pb_Search = new System.Windows.Forms.PictureBox();
            this.pb_Upload = new System.Windows.Forms.PictureBox();
            this.pb_Profile = new System.Windows.Forms.PictureBox();
            this.pn_Home = new System.Windows.Forms.Panel();
            this.pn_Search = new System.Windows.Forms.Panel();
            this.lv_Search = new System.Windows.Forms.ListView();
            this.bt_Search = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.pn_Upload = new System.Windows.Forms.Panel();
            this.bt_Upload = new System.Windows.Forms.Button();
            this.tb_UploadText = new System.Windows.Forms.TextBox();
            this.pb_UploadPicture = new System.Windows.Forms.PictureBox();
            this.tb_UploadPath = new System.Windows.Forms.TextBox();
            this.bt_UploadSearch = new System.Windows.Forms.Button();
            this.pn_Profile = new System.Windows.Forms.Panel();
            this.bt_ProfileList = new System.Windows.Forms.Button();
            this.bt_ProfileBoard = new System.Windows.Forms.Button();
            this.pn_ProfilePost = new System.Windows.Forms.Panel();
            this.tb_Profile = new System.Windows.Forms.TextBox();
            this.bt_EditProfile = new System.Windows.Forms.Button();
            this.lb_Post = new System.Windows.Forms.Label();
            this.lb_PostNum = new System.Windows.Forms.Label();
            this.pb_ProfilePicture = new System.Windows.Forms.PictureBox();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Upload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Profile)).BeginInit();
            this.pn_Search.SuspendLayout();
            this.pn_Upload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_UploadPicture)).BeginInit();
            this.pn_Profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_IP
            // 
            this.lb_IP.AutoSize = true;
            this.lb_IP.Location = new System.Drawing.Point(12, 48);
            this.lb_IP.Name = "lb_IP";
            this.lb_IP.Size = new System.Drawing.Size(20, 12);
            this.lb_IP.TabIndex = 0;
            this.lb_IP.Text = "IP:";
            // 
            // lb_Port
            // 
            this.lb_Port.AutoSize = true;
            this.lb_Port.Location = new System.Drawing.Point(12, 77);
            this.lb_Port.Name = "lb_Port";
            this.lb_Port.Size = new System.Drawing.Size(31, 12);
            this.lb_Port.TabIndex = 1;
            this.lb_Port.Text = "Port:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb.Location = new System.Drawing.Point(10, 105);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(168, 20);
            this.lb.TabIndex = 2;
            this.lb.Text = "MINI INSTAGRAM";
            // 
            // lb_PW
            // 
            this.lb_PW.AutoSize = true;
            this.lb_PW.Location = new System.Drawing.Point(12, 170);
            this.lb_PW.Name = "lb_PW";
            this.lb_PW.Size = new System.Drawing.Size(66, 12);
            this.lb_PW.TabIndex = 3;
            this.lb_PW.Text = "Password:";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(12, 142);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(20, 12);
            this.lb_ID.TabIndex = 4;
            this.lb_ID.Text = "ID:";
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(81, 45);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(100, 21);
            this.tb_IP.TabIndex = 5;
            // 
            // tb_Port
            // 
            this.tb_Port.Location = new System.Drawing.Point(81, 74);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(100, 21);
            this.tb_Port.TabIndex = 6;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(81, 139);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(100, 21);
            this.tb_ID.TabIndex = 7;
            // 
            // tb_PW
            // 
            this.tb_PW.Location = new System.Drawing.Point(81, 167);
            this.tb_PW.Name = "tb_PW";
            this.tb_PW.Size = new System.Drawing.Size(100, 21);
            this.tb_PW.TabIndex = 8;
            // 
            // bt_Connect
            // 
            this.bt_Connect.Location = new System.Drawing.Point(187, 43);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(65, 52);
            this.bt_Connect.TabIndex = 9;
            this.bt_Connect.Text = "Connect";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(187, 137);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(65, 51);
            this.bt_login.TabIndex = 10;
            this.bt_login.Text = "로그인";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // lb_join
            // 
            this.lb_join.AutoSize = true;
            this.lb_join.Location = new System.Drawing.Point(24, 204);
            this.lb_join.Name = "lb_join";
            this.lb_join.Size = new System.Drawing.Size(115, 12);
            this.lb_join.TabIndex = 11;
            this.lb_join.Text = "아직 계정이 없나요?";
            // 
            // bt_Join
            // 
            this.bt_Join.Location = new System.Drawing.Point(145, 199);
            this.bt_Join.Name = "bt_Join";
            this.bt_Join.Size = new System.Drawing.Size(75, 23);
            this.bt_Join.TabIndex = 12;
            this.bt_Join.Text = "회원가입";
            this.bt_Join.UseVisualStyleBackColor = true;
            this.bt_Join.Click += new System.EventHandler(this.bt_Join_Click);
            // 
            // pb_Home
            // 
            this.pb_Home.Image = ((System.Drawing.Image)(resources.GetObject("pb_Home.Image")));
            this.pb_Home.Location = new System.Drawing.Point(258, 599);
            this.pb_Home.Name = "pb_Home";
            this.pb_Home.Size = new System.Drawing.Size(100, 100);
            this.pb_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Home.TabIndex = 13;
            this.pb_Home.TabStop = false;
            this.pb_Home.Click += new System.EventHandler(this.pb_Home_Click);
            // 
            // pb_Search
            // 
            this.pb_Search.Image = ((System.Drawing.Image)(resources.GetObject("pb_Search.Image")));
            this.pb_Search.Location = new System.Drawing.Point(378, 599);
            this.pb_Search.Name = "pb_Search";
            this.pb_Search.Size = new System.Drawing.Size(100, 100);
            this.pb_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Search.TabIndex = 14;
            this.pb_Search.TabStop = false;
            this.pb_Search.Click += new System.EventHandler(this.pb_Search_Click);
            // 
            // pb_Upload
            // 
            this.pb_Upload.Image = ((System.Drawing.Image)(resources.GetObject("pb_Upload.Image")));
            this.pb_Upload.Location = new System.Drawing.Point(499, 599);
            this.pb_Upload.Name = "pb_Upload";
            this.pb_Upload.Size = new System.Drawing.Size(100, 100);
            this.pb_Upload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Upload.TabIndex = 15;
            this.pb_Upload.TabStop = false;
            this.pb_Upload.Click += new System.EventHandler(this.pb_Upload_Click);
            // 
            // pb_Profile
            // 
            this.pb_Profile.Image = ((System.Drawing.Image)(resources.GetObject("pb_Profile.Image")));
            this.pb_Profile.Location = new System.Drawing.Point(618, 599);
            this.pb_Profile.Name = "pb_Profile";
            this.pb_Profile.Size = new System.Drawing.Size(100, 100);
            this.pb_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Profile.TabIndex = 16;
            this.pb_Profile.TabStop = false;
            this.pb_Profile.Click += new System.EventHandler(this.pb_MyPage_Click);
            // 
            // pn_Home
            // 
            this.pn_Home.Location = new System.Drawing.Point(258, 20);
            this.pn_Home.Name = "pn_Home";
            this.pn_Home.Size = new System.Drawing.Size(460, 560);
            this.pn_Home.TabIndex = 17;
            this.pn_Home.Visible = false;
            // 
            // pn_Search
            // 
            this.pn_Search.Controls.Add(this.lv_Search);
            this.pn_Search.Controls.Add(this.bt_Search);
            this.pn_Search.Controls.Add(this.tb_Search);
            this.pn_Search.Location = new System.Drawing.Point(258, 20);
            this.pn_Search.Name = "pn_Search";
            this.pn_Search.Size = new System.Drawing.Size(460, 560);
            this.pn_Search.TabIndex = 18;
            this.pn_Search.Visible = false;
            // 
            // lv_Search
            // 
            this.lv_Search.Location = new System.Drawing.Point(13, 51);
            this.lv_Search.Name = "lv_Search";
            this.lv_Search.Size = new System.Drawing.Size(428, 489);
            this.lv_Search.TabIndex = 2;
            this.lv_Search.UseCompatibleStateImageBehavior = false;
            this.lv_Search.View = System.Windows.Forms.View.List;
            // 
            // bt_Search
            // 
            this.bt_Search.Location = new System.Drawing.Point(344, 13);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(75, 23);
            this.bt_Search.TabIndex = 1;
            this.bt_Search.Text = "찾기";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(13, 15);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(302, 21);
            this.tb_Search.TabIndex = 0;
            // 
            // pn_Upload
            // 
            this.pn_Upload.Controls.Add(this.bt_Upload);
            this.pn_Upload.Controls.Add(this.tb_UploadText);
            this.pn_Upload.Controls.Add(this.pb_UploadPicture);
            this.pn_Upload.Controls.Add(this.tb_UploadPath);
            this.pn_Upload.Controls.Add(this.bt_UploadSearch);
            this.pn_Upload.Location = new System.Drawing.Point(258, 20);
            this.pn_Upload.Name = "pn_Upload";
            this.pn_Upload.Size = new System.Drawing.Size(460, 560);
            this.pn_Upload.TabIndex = 19;
            this.pn_Upload.Visible = false;
            // 
            // bt_Upload
            // 
            this.bt_Upload.Location = new System.Drawing.Point(26, 505);
            this.bt_Upload.Name = "bt_Upload";
            this.bt_Upload.Size = new System.Drawing.Size(400, 35);
            this.bt_Upload.TabIndex = 4;
            this.bt_Upload.Text = "게시물 등록하기";
            this.bt_Upload.UseVisualStyleBackColor = true;
            this.bt_Upload.Click += new System.EventHandler(this.bt_Upload_Click);
            // 
            // tb_UploadText
            // 
            this.tb_UploadText.Location = new System.Drawing.Point(26, 346);
            this.tb_UploadText.Multiline = true;
            this.tb_UploadText.Name = "tb_UploadText";
            this.tb_UploadText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_UploadText.Size = new System.Drawing.Size(400, 153);
            this.tb_UploadText.TabIndex = 3;
            // 
            // pb_UploadPicture
            // 
            this.pb_UploadPicture.Location = new System.Drawing.Point(26, 40);
            this.pb_UploadPicture.Name = "pb_UploadPicture";
            this.pb_UploadPicture.Size = new System.Drawing.Size(400, 300);
            this.pb_UploadPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_UploadPicture.TabIndex = 2;
            this.pb_UploadPicture.TabStop = false;
            // 
            // tb_UploadPath
            // 
            this.tb_UploadPath.Location = new System.Drawing.Point(107, 13);
            this.tb_UploadPath.Name = "tb_UploadPath";
            this.tb_UploadPath.Size = new System.Drawing.Size(319, 21);
            this.tb_UploadPath.TabIndex = 1;
            // 
            // bt_UploadSearch
            // 
            this.bt_UploadSearch.Location = new System.Drawing.Point(26, 11);
            this.bt_UploadSearch.Name = "bt_UploadSearch";
            this.bt_UploadSearch.Size = new System.Drawing.Size(75, 23);
            this.bt_UploadSearch.TabIndex = 0;
            this.bt_UploadSearch.Text = "찾기";
            this.bt_UploadSearch.UseVisualStyleBackColor = true;
            this.bt_UploadSearch.Click += new System.EventHandler(this.bt_UploadSearch_Click);
            // 
            // pn_Profile
            // 
            this.pn_Profile.Controls.Add(this.bt_ProfileList);
            this.pn_Profile.Controls.Add(this.bt_ProfileBoard);
            this.pn_Profile.Controls.Add(this.pn_ProfilePost);
            this.pn_Profile.Controls.Add(this.tb_Profile);
            this.pn_Profile.Controls.Add(this.bt_EditProfile);
            this.pn_Profile.Controls.Add(this.lb_Post);
            this.pn_Profile.Controls.Add(this.lb_PostNum);
            this.pn_Profile.Controls.Add(this.pb_ProfilePicture);
            this.pn_Profile.Location = new System.Drawing.Point(258, 20);
            this.pn_Profile.Name = "pn_Profile";
            this.pn_Profile.Size = new System.Drawing.Size(460, 560);
            this.pn_Profile.TabIndex = 20;
            this.pn_Profile.Visible = false;
            // 
            // bt_ProfileList
            // 
            this.bt_ProfileList.Location = new System.Drawing.Point(241, 215);
            this.bt_ProfileList.Name = "bt_ProfileList";
            this.bt_ProfileList.Size = new System.Drawing.Size(150, 35);
            this.bt_ProfileList.TabIndex = 26;
            this.bt_ProfileList.Text = "리스트";
            this.bt_ProfileList.UseVisualStyleBackColor = true;
            // 
            // bt_ProfileBoard
            // 
            this.bt_ProfileBoard.Location = new System.Drawing.Point(51, 215);
            this.bt_ProfileBoard.Name = "bt_ProfileBoard";
            this.bt_ProfileBoard.Size = new System.Drawing.Size(150, 35);
            this.bt_ProfileBoard.TabIndex = 25;
            this.bt_ProfileBoard.Text = "바둑판";
            this.bt_ProfileBoard.UseVisualStyleBackColor = true;
            // 
            // pn_ProfilePost
            // 
            this.pn_ProfilePost.Location = new System.Drawing.Point(26, 265);
            this.pn_ProfilePost.Name = "pn_ProfilePost";
            this.pn_ProfilePost.Size = new System.Drawing.Size(400, 275);
            this.pn_ProfilePost.TabIndex = 24;
            // 
            // tb_Profile
            // 
            this.tb_Profile.Location = new System.Drawing.Point(26, 155);
            this.tb_Profile.MaxLength = 400;
            this.tb_Profile.Multiline = true;
            this.tb_Profile.Name = "tb_Profile";
            this.tb_Profile.Size = new System.Drawing.Size(400, 49);
            this.tb_Profile.TabIndex = 21;
            // 
            // bt_EditProfile
            // 
            this.bt_EditProfile.Location = new System.Drawing.Point(194, 78);
            this.bt_EditProfile.Name = "bt_EditProfile";
            this.bt_EditProfile.Size = new System.Drawing.Size(212, 64);
            this.bt_EditProfile.TabIndex = 23;
            this.bt_EditProfile.Text = "프로필 수정";
            this.bt_EditProfile.UseVisualStyleBackColor = true;
            // 
            // lb_Post
            // 
            this.lb_Post.AutoSize = true;
            this.lb_Post.Location = new System.Drawing.Point(274, 51);
            this.lb_Post.Name = "lb_Post";
            this.lb_Post.Size = new System.Drawing.Size(41, 12);
            this.lb_Post.TabIndex = 22;
            this.lb_Post.Text = "게시물";
            // 
            // lb_PostNum
            // 
            this.lb_PostNum.AutoSize = true;
            this.lb_PostNum.Location = new System.Drawing.Point(287, 37);
            this.lb_PostNum.Name = "lb_PostNum";
            this.lb_PostNum.Size = new System.Drawing.Size(11, 12);
            this.lb_PostNum.TabIndex = 21;
            this.lb_PostNum.Text = "0";
            // 
            // pb_ProfilePicture
            // 
            this.pb_ProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("pb_ProfilePicture.Image")));
            this.pb_ProfilePicture.Location = new System.Drawing.Point(26, 13);
            this.pb_ProfilePicture.Name = "pb_ProfilePicture";
            this.pb_ProfilePicture.Size = new System.Drawing.Size(130, 130);
            this.pb_ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ProfilePicture.TabIndex = 0;
            this.pb_ProfilePicture.TabStop = false;
            this.pb_ProfilePicture.Click += new System.EventHandler(this.pb_ProfilePicture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.pb_Profile);
            this.Controls.Add(this.pb_Upload);
            this.Controls.Add(this.pb_Search);
            this.Controls.Add(this.pb_Home);
            this.Controls.Add(this.bt_Join);
            this.Controls.Add(this.lb_join);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.bt_Connect);
            this.Controls.Add(this.tb_PW);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.tb_Port);
            this.Controls.Add(this.tb_IP);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.lb_PW);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lb_Port);
            this.Controls.Add(this.lb_IP);
            this.Controls.Add(this.pn_Profile);
            this.Controls.Add(this.pn_Upload);
            this.Controls.Add(this.pn_Search);
            this.Controls.Add(this.pn_Home);
            this.Name = "Form1";
            this.Text = "프로필 수정";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Upload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Profile)).EndInit();
            this.pn_Search.ResumeLayout(false);
            this.pn_Search.PerformLayout();
            this.pn_Upload.ResumeLayout(false);
            this.pn_Upload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_UploadPicture)).EndInit();
            this.pn_Profile.ResumeLayout(false);
            this.pn_Profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_IP;
        private System.Windows.Forms.Label lb_Port;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lb_PW;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_PW;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label lb_join;
        private System.Windows.Forms.Button bt_Join;
        private System.Windows.Forms.PictureBox pb_Home;
        private System.Windows.Forms.PictureBox pb_Search;
        private System.Windows.Forms.PictureBox pb_Upload;
        private System.Windows.Forms.PictureBox pb_Profile;
        private System.Windows.Forms.Panel pn_Home;
        private System.Windows.Forms.Panel pn_Search;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.ListView lv_Search;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Panel pn_Upload;
        private System.Windows.Forms.Button bt_UploadSearch;
        private System.Windows.Forms.TextBox tb_UploadPath;
        private System.Windows.Forms.TextBox tb_UploadText;
        private System.Windows.Forms.PictureBox pb_UploadPicture;
        private System.Windows.Forms.Button bt_Upload;
        private System.Windows.Forms.Panel pn_Profile;
        private System.Windows.Forms.Button bt_ProfileList;
        private System.Windows.Forms.Button bt_ProfileBoard;
        private System.Windows.Forms.Panel pn_ProfilePost;
        private System.Windows.Forms.TextBox tb_Profile;
        private System.Windows.Forms.Button bt_EditProfile;
        private System.Windows.Forms.Label lb_Post;
        private System.Windows.Forms.Label lb_PostNum;
        private System.Windows.Forms.PictureBox pb_ProfilePicture;
        private System.Windows.Forms.OpenFileDialog openFD;
    }
}

