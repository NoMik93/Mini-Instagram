namespace Server
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
            this.lb_IP = new System.Windows.Forms.Label();
            this.lb_Port = new System.Windows.Forms.Label();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.bt_Start = new System.Windows.Forms.Button();
            this.lb_MemberList = new System.Windows.Forms.Label();
            this.lb_Log = new System.Windows.Forms.Label();
            this.tb_ServerLog = new System.Windows.Forms.TextBox();
            this.lv_MemberList = new System.Windows.Forms.ListView();
            this.columnIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPassWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lb_IP
            // 
            this.lb_IP.AutoSize = true;
            this.lb_IP.Location = new System.Drawing.Point(12, 18);
            this.lb_IP.Name = "lb_IP";
            this.lb_IP.Size = new System.Drawing.Size(20, 12);
            this.lb_IP.TabIndex = 0;
            this.lb_IP.Text = "IP:";
            // 
            // lb_Port
            // 
            this.lb_Port.AutoSize = true;
            this.lb_Port.Location = new System.Drawing.Point(307, 18);
            this.lb_Port.Name = "lb_Port";
            this.lb_Port.Size = new System.Drawing.Size(31, 12);
            this.lb_Port.TabIndex = 1;
            this.lb_Port.Text = "Port:";
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(38, 15);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(254, 21);
            this.tb_IP.TabIndex = 2;
            // 
            // tb_Port
            // 
            this.tb_Port.Location = new System.Drawing.Point(344, 15);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(100, 21);
            this.tb_Port.TabIndex = 3;
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(474, 13);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(75, 23);
            this.bt_Start.TabIndex = 4;
            this.bt_Start.Text = "Start";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // lb_MemberList
            // 
            this.lb_MemberList.AutoSize = true;
            this.lb_MemberList.Location = new System.Drawing.Point(12, 53);
            this.lb_MemberList.Name = "lb_MemberList";
            this.lb_MemberList.Size = new System.Drawing.Size(126, 12);
            this.lb_MemberList.TabIndex = 5;
            this.lb_MemberList.Text = "Member Account List";
            // 
            // lb_Log
            // 
            this.lb_Log.AutoSize = true;
            this.lb_Log.Location = new System.Drawing.Point(285, 53);
            this.lb_Log.Name = "lb_Log";
            this.lb_Log.Size = new System.Drawing.Size(66, 12);
            this.lb_Log.TabIndex = 6;
            this.lb_Log.Text = "Server Log";
            // 
            // tb_ServerLog
            // 
            this.tb_ServerLog.Location = new System.Drawing.Point(287, 68);
            this.tb_ServerLog.Multiline = true;
            this.tb_ServerLog.Name = "tb_ServerLog";
            this.tb_ServerLog.Size = new System.Drawing.Size(265, 325);
            this.tb_ServerLog.TabIndex = 8;
            // 
            // lv_MemberList
            // 
            this.lv_MemberList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIndex,
            this.columnID,
            this.columnPassWord});
            this.lv_MemberList.Location = new System.Drawing.Point(12, 68);
            this.lv_MemberList.Name = "lv_MemberList";
            this.lv_MemberList.Size = new System.Drawing.Size(269, 325);
            this.lv_MemberList.TabIndex = 9;
            this.lv_MemberList.UseCompatibleStateImageBehavior = false;
            this.lv_MemberList.View = System.Windows.Forms.View.Details;
            // 
            // columnIndex
            // 
            this.columnIndex.Text = "Index";
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnPassWord
            // 
            this.columnPassWord.Text = "PassWord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 405);
            this.Controls.Add(this.lv_MemberList);
            this.Controls.Add(this.tb_ServerLog);
            this.Controls.Add(this.lb_Log);
            this.Controls.Add(this.lb_MemberList);
            this.Controls.Add(this.bt_Start);
            this.Controls.Add(this.tb_Port);
            this.Controls.Add(this.tb_IP);
            this.Controls.Add(this.lb_Port);
            this.Controls.Add(this.lb_IP);
            this.Name = "Form1";
            this.Text = "Mini Instagram Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_IP;
        private System.Windows.Forms.Label lb_Port;
        private System.Windows.Forms.ListView lv_MemberList;
        private System.Windows.Forms.TextBox tb_ServerLog;
        private System.Windows.Forms.Label lb_Log;
        private System.Windows.Forms.Label lb_MemberList;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.ColumnHeader columnIndex;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnPassWord;
    }
}

