namespace DASPP
{
    partial class USER_LOGIN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.hidepass2 = new System.Windows.Forms.CheckBox();
            this.LOGIN_BUTTON = new System.Windows.Forms.Button();
            this.PASS_LOGIN = new System.Windows.Forms.TextBox();
            this.UN_LOGIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.END = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hidepass = new System.Windows.Forms.CheckBox();
            this.VERIFICATION = new System.Windows.Forms.Button();
            this.SIGNUP = new System.Windows.Forms.Button();
            this.CONPASS_BOX = new System.Windows.Forms.TextBox();
            this.PASS_BOX = new System.Windows.Forms.TextBox();
            this.USERNAME_BOX = new System.Windows.Forms.TextBox();
            this.CNT_BOX = new System.Windows.Forms.TextBox();
            this.MAIL_BOX = new System.Windows.Forms.TextBox();
            this.LN_BOX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FN_BOX = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.hidepass2);
            this.panel1.Controls.Add(this.LOGIN_BUTTON);
            this.panel1.Controls.Add(this.PASS_LOGIN);
            this.panel1.Controls.Add(this.UN_LOGIN);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 577);
            this.panel1.TabIndex = 2;
            // 
            // hidepass2
            // 
            this.hidepass2.AutoSize = true;
            this.hidepass2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidepass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidepass2.ForeColor = System.Drawing.Color.Cyan;
            this.hidepass2.Location = new System.Drawing.Point(148, 330);
            this.hidepass2.Name = "hidepass2";
            this.hidepass2.Size = new System.Drawing.Size(56, 20);
            this.hidepass2.TabIndex = 53;
            this.hidepass2.Text = "HIDE";
            this.hidepass2.UseVisualStyleBackColor = true;
            this.hidepass2.CheckedChanged += new System.EventHandler(this.hidepass2_CheckedChanged);
            // 
            // LOGIN_BUTTON
            // 
            this.LOGIN_BUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.LOGIN_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOGIN_BUTTON.ForeColor = System.Drawing.Color.Cyan;
            this.LOGIN_BUTTON.Location = new System.Drawing.Point(69, 418);
            this.LOGIN_BUTTON.Name = "LOGIN_BUTTON";
            this.LOGIN_BUTTON.Size = new System.Drawing.Size(100, 23);
            this.LOGIN_BUTTON.TabIndex = 48;
            this.LOGIN_BUTTON.Text = "LOGIN";
            this.LOGIN_BUTTON.UseVisualStyleBackColor = false;
            this.LOGIN_BUTTON.Click += new System.EventHandler(this.LOGIN_BUTTON_Click);
            // 
            // PASS_LOGIN
            // 
            this.PASS_LOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PASS_LOGIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PASS_LOGIN.ForeColor = System.Drawing.Color.Silver;
            this.PASS_LOGIN.Location = new System.Drawing.Point(21, 303);
            this.PASS_LOGIN.Name = "PASS_LOGIN";
            this.PASS_LOGIN.Size = new System.Drawing.Size(183, 20);
            this.PASS_LOGIN.TabIndex = 52;
            this.PASS_LOGIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PASS_LOGIN_KeyPress);
            // 
            // UN_LOGIN
            // 
            this.UN_LOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.UN_LOGIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UN_LOGIN.ForeColor = System.Drawing.Color.Silver;
            this.UN_LOGIN.Location = new System.Drawing.Point(21, 247);
            this.UN_LOGIN.Name = "UN_LOGIN";
            this.UN_LOGIN.Size = new System.Drawing.Size(183, 20);
            this.UN_LOGIN.TabIndex = 49;
            this.UN_LOGIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UN_LOGIN_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 12);
            this.label4.TabIndex = 51;
            this.label4.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(12, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 50;
            this.label3.Text = "PASSWORD";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DASPP.Properties.Resources.icons8_home_64;
            this.pictureBox2.Location = new System.Drawing.Point(195, 527);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Cyan;
            this.button3.Location = new System.Drawing.Point(0, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 66);
            this.button3.TabIndex = 11;
            this.button3.Text = "HOME";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DASPP.Properties.Resources._820a4feaba794e6ab7a9a64365cd35af;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // END
            // 
            this.END.FlatAppearance.BorderSize = 0;
            this.END.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.END.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.END.ForeColor = System.Drawing.Color.LightGray;
            this.END.Location = new System.Drawing.Point(905, 12);
            this.END.Name = "END";
            this.END.Size = new System.Drawing.Size(34, 23);
            this.END.TabIndex = 13;
            this.END.Text = "X";
            this.END.UseVisualStyleBackColor = true;
            this.END.Click += new System.EventHandler(this.END_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(403, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 55);
            this.label2.TabIndex = 44;
            this.label2.Text = "USER SIGN UP";
            // 
            // hidepass
            // 
            this.hidepass.AutoSize = true;
            this.hidepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidepass.ForeColor = System.Drawing.Color.Cyan;
            this.hidepass.Location = new System.Drawing.Point(825, 396);
            this.hidepass.Name = "hidepass";
            this.hidepass.Size = new System.Drawing.Size(56, 20);
            this.hidepass.TabIndex = 63;
            this.hidepass.Text = "HIDE";
            this.hidepass.UseVisualStyleBackColor = true;
            this.hidepass.CheckedChanged += new System.EventHandler(this.hidepass_CheckedChanged);
            // 
            // VERIFICATION
            // 
            this.VERIFICATION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VERIFICATION.ForeColor = System.Drawing.Color.Cyan;
            this.VERIFICATION.Location = new System.Drawing.Point(825, 221);
            this.VERIFICATION.Name = "VERIFICATION";
            this.VERIFICATION.Size = new System.Drawing.Size(75, 23);
            this.VERIFICATION.TabIndex = 62;
            this.VERIFICATION.Text = "VERIFY";
            this.VERIFICATION.UseVisualStyleBackColor = true;
            this.VERIFICATION.Click += new System.EventHandler(this.VERIFICATION_Click);
            // 
            // SIGNUP
            // 
            this.SIGNUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SIGNUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SIGNUP.ForeColor = System.Drawing.Color.Cyan;
            this.SIGNUP.Location = new System.Drawing.Point(683, 497);
            this.SIGNUP.Name = "SIGNUP";
            this.SIGNUP.Size = new System.Drawing.Size(100, 23);
            this.SIGNUP.TabIndex = 47;
            this.SIGNUP.Text = "SIGN UP";
            this.SIGNUP.UseVisualStyleBackColor = false;
            this.SIGNUP.Click += new System.EventHandler(this.SIGNUP_Click);
            // 
            // CONPASS_BOX
            // 
            this.CONPASS_BOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CONPASS_BOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CONPASS_BOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONPASS_BOX.ForeColor = System.Drawing.Color.Silver;
            this.CONPASS_BOX.Location = new System.Drawing.Point(536, 414);
            this.CONPASS_BOX.Name = "CONPASS_BOX";
            this.CONPASS_BOX.Size = new System.Drawing.Size(247, 31);
            this.CONPASS_BOX.TabIndex = 61;
            this.CONPASS_BOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CONPASS_BOX_KeyPress);
            // 
            // PASS_BOX
            // 
            this.PASS_BOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PASS_BOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PASS_BOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASS_BOX.ForeColor = System.Drawing.Color.Silver;
            this.PASS_BOX.Location = new System.Drawing.Point(536, 367);
            this.PASS_BOX.Name = "PASS_BOX";
            this.PASS_BOX.Size = new System.Drawing.Size(247, 31);
            this.PASS_BOX.TabIndex = 60;
            this.PASS_BOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PASS_BOX_KeyPress);
            // 
            // USERNAME_BOX
            // 
            this.USERNAME_BOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.USERNAME_BOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.USERNAME_BOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME_BOX.ForeColor = System.Drawing.Color.Silver;
            this.USERNAME_BOX.Location = new System.Drawing.Point(536, 317);
            this.USERNAME_BOX.Name = "USERNAME_BOX";
            this.USERNAME_BOX.Size = new System.Drawing.Size(247, 31);
            this.USERNAME_BOX.TabIndex = 59;
            this.USERNAME_BOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.USERNAME_BOX_KeyPress);
            // 
            // CNT_BOX
            // 
            this.CNT_BOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CNT_BOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CNT_BOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNT_BOX.ForeColor = System.Drawing.Color.Silver;
            this.CNT_BOX.Location = new System.Drawing.Point(536, 266);
            this.CNT_BOX.Name = "CNT_BOX";
            this.CNT_BOX.Size = new System.Drawing.Size(247, 31);
            this.CNT_BOX.TabIndex = 58;
            this.CNT_BOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CNT_BOX_KeyPress_1);
            // 
            // MAIL_BOX
            // 
            this.MAIL_BOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.MAIL_BOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MAIL_BOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAIL_BOX.ForeColor = System.Drawing.Color.Silver;
            this.MAIL_BOX.Location = new System.Drawing.Point(536, 214);
            this.MAIL_BOX.Name = "MAIL_BOX";
            this.MAIL_BOX.Size = new System.Drawing.Size(247, 31);
            this.MAIL_BOX.TabIndex = 57;
            this.MAIL_BOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MAIL_BOX_KeyPress);
            // 
            // LN_BOX
            // 
            this.LN_BOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.LN_BOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LN_BOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LN_BOX.ForeColor = System.Drawing.Color.Silver;
            this.LN_BOX.Location = new System.Drawing.Point(536, 162);
            this.LN_BOX.Name = "LN_BOX";
            this.LN_BOX.Size = new System.Drawing.Size(247, 31);
            this.LN_BOX.TabIndex = 56;
            this.LN_BOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LN_BOX_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(398, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 16);
            this.label9.TabIndex = 55;
            this.label9.Text = "CONFIRM PASS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(398, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 54;
            this.label8.Text = "PASSWORD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(398, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 53;
            this.label7.Text = "USERNAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(398, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "CONTACT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(398, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "EMAIL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(398, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "L.NAME";
            // 
            // FN_BOX
            // 
            this.FN_BOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.FN_BOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FN_BOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FN_BOX.ForeColor = System.Drawing.Color.Silver;
            this.FN_BOX.Location = new System.Drawing.Point(536, 113);
            this.FN_BOX.Name = "FN_BOX";
            this.FN_BOX.Size = new System.Drawing.Size(247, 31);
            this.FN_BOX.TabIndex = 48;
            this.FN_BOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FN_BOX_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightGray;
            this.label16.Location = new System.Drawing.Point(398, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 49;
            this.label16.Text = "F.NAME";
            // 
            // USER_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.hidepass);
            this.Controls.Add(this.VERIFICATION);
            this.Controls.Add(this.SIGNUP);
            this.Controls.Add(this.CONPASS_BOX);
            this.Controls.Add(this.PASS_BOX);
            this.Controls.Add(this.USERNAME_BOX);
            this.Controls.Add(this.CNT_BOX);
            this.Controls.Add(this.MAIL_BOX);
            this.Controls.Add(this.LN_BOX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FN_BOX);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.END);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "USER_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.USER_LOGIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button END;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox hidepass2;
        private System.Windows.Forms.Button LOGIN_BUTTON;
        private System.Windows.Forms.TextBox PASS_LOGIN;
        private System.Windows.Forms.TextBox UN_LOGIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox hidepass;
        private System.Windows.Forms.Button VERIFICATION;
        private System.Windows.Forms.Button SIGNUP;
        private System.Windows.Forms.TextBox CONPASS_BOX;
        private System.Windows.Forms.TextBox PASS_BOX;
        private System.Windows.Forms.TextBox USERNAME_BOX;
        private System.Windows.Forms.TextBox CNT_BOX;
        private System.Windows.Forms.TextBox MAIL_BOX;
        private System.Windows.Forms.TextBox LN_BOX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FN_BOX;
        private System.Windows.Forms.Label label16;
    }
}