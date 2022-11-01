namespace AgentIntegrationTest
{
    partial class TestBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UninitializeBtn = new System.Windows.Forms.Button();
            this.MakeCallTo = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.StartAgent = new System.Windows.Forms.Button();
            this.InitializeBtn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.StrtWAgent_btn = new System.Windows.Forms.Button();
            this.CloseAgent = new System.Windows.Forms.Button();
            this.NumberHere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.extpass_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.brokerserver_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sitename_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.brokerport_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.webserver_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.extension_txt = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.loginid_txt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CallSessionID_txt = new System.Windows.Forms.TextBox();
            this.AnswerCall_btn = new System.Windows.Forms.Button();
            this.HldCall_Btn = new System.Windows.Forms.Button();
            this.Tfto_Btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Current User Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Check if Agent is Already Running";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UninitializeBtn
            // 
            this.UninitializeBtn.Location = new System.Drawing.Point(6, 60);
            this.UninitializeBtn.Name = "UninitializeBtn";
            this.UninitializeBtn.Size = new System.Drawing.Size(155, 39);
            this.UninitializeBtn.TabIndex = 2;
            this.UninitializeBtn.Text = "Uni-Initialized Connection";
            this.UninitializeBtn.UseVisualStyleBackColor = true;
            this.UninitializeBtn.Click += new System.EventHandler(this.UninitializeBtn_Click);
            // 
            // MakeCallTo
            // 
            this.MakeCallTo.Location = new System.Drawing.Point(24, 21);
            this.MakeCallTo.Name = "MakeCallTo";
            this.MakeCallTo.Size = new System.Drawing.Size(154, 39);
            this.MakeCallTo.TabIndex = 3;
            this.MakeCallTo.Text = "Make Call to";
            this.MakeCallTo.UseVisualStyleBackColor = true;
            this.MakeCallTo.Click += new System.EventHandler(this.MakeCallTo_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "Make Ready(Call/Chat/Email)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 105);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 36);
            this.button6.TabIndex = 5;
            this.button6.Text = "Check if App is Registered";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // StartAgent
            // 
            this.StartAgent.Location = new System.Drawing.Point(6, 194);
            this.StartAgent.Name = "StartAgent";
            this.StartAgent.Size = new System.Drawing.Size(155, 37);
            this.StartAgent.TabIndex = 6;
            this.StartAgent.Text = "Start the Agent";
            this.StartAgent.UseVisualStyleBackColor = true;
            this.StartAgent.Click += new System.EventHandler(this.button7_Click);
            // 
            // InitializeBtn
            // 
            this.InitializeBtn.Location = new System.Drawing.Point(6, 60);
            this.InitializeBtn.Name = "InitializeBtn";
            this.InitializeBtn.Size = new System.Drawing.Size(155, 39);
            this.InitializeBtn.TabIndex = 7;
            this.InitializeBtn.Text = "Initialized Connection";
            this.InitializeBtn.UseVisualStyleBackColor = true;
            this.InitializeBtn.Click += new System.EventHandler(this.InitializeBtn_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(24, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(154, 40);
            this.button9.TabIndex = 8;
            this.button9.Text = "Get  On Call Info";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // StrtWAgent_btn
            // 
            this.StrtWAgent_btn.Location = new System.Drawing.Point(6, 19);
            this.StrtWAgent_btn.Name = "StrtWAgent_btn";
            this.StrtWAgent_btn.Size = new System.Drawing.Size(155, 40);
            this.StrtWAgent_btn.TabIndex = 9;
            this.StrtWAgent_btn.Text = "Start the Agent With Credential(brightson)";
            this.StrtWAgent_btn.UseVisualStyleBackColor = true;
            this.StrtWAgent_btn.Click += new System.EventHandler(this.StrtWAgent_btn_Click);
            // 
            // CloseAgent
            // 
            this.CloseAgent.Location = new System.Drawing.Point(6, 193);
            this.CloseAgent.Name = "CloseAgent";
            this.CloseAgent.Size = new System.Drawing.Size(155, 37);
            this.CloseAgent.TabIndex = 10;
            this.CloseAgent.Text = "Close the Agent";
            this.CloseAgent.UseVisualStyleBackColor = true;
            this.CloseAgent.Click += new System.EventHandler(this.button11_Click);
            // 
            // NumberHere
            // 
            this.NumberHere.Location = new System.Drawing.Point(184, 40);
            this.NumberHere.Name = "NumberHere";
            this.NumberHere.Size = new System.Drawing.Size(123, 20);
            this.NumberHere.TabIndex = 11;
            this.NumberHere.Text = "637";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Insert Number Here";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 147);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(155, 40);
            this.button12.TabIndex = 13;
            this.button12.Text = "Make Not  Ready(Call/Chat/Email)";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.extpass_txt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.brokerserver_txt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.sitename_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.password_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.brokerport_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.webserver_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.extension_txt);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.loginid_txt);
            this.groupBox1.Controls.Add(this.StrtWAgent_btn);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.StartAgent);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.CloseAgent);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.InitializeBtn);
            this.groupBox1.Controls.Add(this.UninitializeBtn);
            this.groupBox1.Location = new System.Drawing.Point(426, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 332);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agent Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Extension Password";
            // 
            // extpass_txt
            // 
            this.extpass_txt.Location = new System.Drawing.Point(282, 85);
            this.extpass_txt.Name = "extpass_txt";
            this.extpass_txt.Size = new System.Drawing.Size(100, 20);
            this.extpass_txt.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Broker Server";
            // 
            // brokerserver_txt
            // 
            this.brokerserver_txt.Location = new System.Drawing.Point(167, 172);
            this.brokerserver_txt.Name = "brokerserver_txt";
            this.brokerserver_txt.Size = new System.Drawing.Size(100, 20);
            this.brokerserver_txt.TabIndex = 28;
            this.brokerserver_txt.Text = "suria-solidus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Site Name";
            // 
            // sitename_txt
            // 
            this.sitename_txt.Location = new System.Drawing.Point(281, 130);
            this.sitename_txt.Name = "sitename_txt";
            this.sitename_txt.Size = new System.Drawing.Size(100, 20);
            this.sitename_txt.TabIndex = 26;
            this.sitename_txt.Text = "suria-solidus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Password*";
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(281, 40);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(100, 20);
            this.password_txt.TabIndex = 24;
            this.password_txt.Text = "brightson";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Broker Port";
            // 
            // brokerport_txt
            // 
            this.brokerport_txt.Location = new System.Drawing.Point(281, 172);
            this.brokerport_txt.Name = "brokerport_txt";
            this.brokerport_txt.Size = new System.Drawing.Size(100, 20);
            this.brokerport_txt.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Web Server";
            // 
            // webserver_txt
            // 
            this.webserver_txt.Location = new System.Drawing.Point(167, 130);
            this.webserver_txt.Name = "webserver_txt";
            this.webserver_txt.Size = new System.Drawing.Size(100, 20);
            this.webserver_txt.TabIndex = 18;
            this.webserver_txt.Text = "suria-solidus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Extension*";
            // 
            // extension_txt
            // 
            this.extension_txt.Location = new System.Drawing.Point(167, 85);
            this.extension_txt.Name = "extension_txt";
            this.extension_txt.Size = new System.Drawing.Size(100, 20);
            this.extension_txt.TabIndex = 16;
            this.extension_txt.Text = "637";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(167, 21);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(51, 13);
            this.lbl_name.TabIndex = 15;
            this.lbl_name.Text = "logon ID*";
            // 
            // loginid_txt
            // 
            this.loginid_txt.Location = new System.Drawing.Point(167, 40);
            this.loginid_txt.Name = "loginid_txt";
            this.loginid_txt.Size = new System.Drawing.Size(100, 20);
            this.loginid_txt.TabIndex = 14;
            this.loginid_txt.Text = "brightson";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.CallSessionID_txt);
            this.groupBox3.Controls.Add(this.AnswerCall_btn);
            this.groupBox3.Controls.Add(this.HldCall_Btn);
            this.groupBox3.Controls.Add(this.Tfto_Btn);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.NumberHere);
            this.groupBox3.Controls.Add(this.MakeCallTo);
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 211);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Call Control";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Call Session ID";
            // 
            // CallSessionID_txt
            // 
            this.CallSessionID_txt.Location = new System.Drawing.Point(184, 85);
            this.CallSessionID_txt.Name = "CallSessionID_txt";
            this.CallSessionID_txt.ReadOnly = true;
            this.CallSessionID_txt.Size = new System.Drawing.Size(126, 20);
            this.CallSessionID_txt.TabIndex = 16;
            // 
            // AnswerCall_btn
            // 
            this.AnswerCall_btn.Location = new System.Drawing.Point(24, 66);
            this.AnswerCall_btn.Name = "AnswerCall_btn";
            this.AnswerCall_btn.Size = new System.Drawing.Size(154, 39);
            this.AnswerCall_btn.TabIndex = 15;
            this.AnswerCall_btn.Text = "Answer Call";
            this.AnswerCall_btn.UseVisualStyleBackColor = true;
            this.AnswerCall_btn.Click += new System.EventHandler(this.AnswerCall_btn_Click);
            // 
            // HldCall_Btn
            // 
            this.HldCall_Btn.Location = new System.Drawing.Point(24, 111);
            this.HldCall_Btn.Name = "HldCall_Btn";
            this.HldCall_Btn.Size = new System.Drawing.Size(154, 39);
            this.HldCall_Btn.TabIndex = 14;
            this.HldCall_Btn.Text = "Hold Call";
            this.HldCall_Btn.UseVisualStyleBackColor = true;
            this.HldCall_Btn.Click += new System.EventHandler(this.HldCall_Btn_Click);
            // 
            // Tfto_Btn
            // 
            this.Tfto_Btn.Location = new System.Drawing.Point(24, 162);
            this.Tfto_Btn.Name = "Tfto_Btn";
            this.Tfto_Btn.Size = new System.Drawing.Size(154, 39);
            this.Tfto_Btn.TabIndex = 13;
            this.Tfto_Btn.Text = "Transfer to";
            this.Tfto_Btn.UseVisualStyleBackColor = true;
            this.Tfto_Btn.Click += new System.EventHandler(this.Tfto_Btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(12, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(408, 115);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Get Information";
            // 
            // TestBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 387);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "TestBoard";
            this.Text = "TestBoard";
            this.Load += new System.EventHandler(this.TestBoard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button UninitializeBtn;
        private System.Windows.Forms.Button MakeCallTo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button StartAgent;
        private System.Windows.Forms.Button InitializeBtn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button StrtWAgent_btn;
        private System.Windows.Forms.Button CloseAgent;
        private System.Windows.Forms.TextBox NumberHere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button HldCall_Btn;
        private System.Windows.Forms.Button Tfto_Btn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox extpass_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox brokerserver_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sitename_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox brokerport_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox webserver_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox extension_txt;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox loginid_txt;
        private System.Windows.Forms.Button AnswerCall_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CallSessionID_txt;
    }
}

