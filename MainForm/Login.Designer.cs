namespace Database {
    partial class Login {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.butLogin = new System.Windows.Forms.Button();
            this.butChangePass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(51, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11F);
            this.label3.Location = new System.Drawing.Point(50, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "密  码：";
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(132, 143);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(175, 25);
            this.account.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(132, 211);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(175, 25);
            this.password.TabIndex = 4;
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.Cyan;
            this.butLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butLogin.Font = new System.Drawing.Font("宋体", 10F);
            this.butLogin.Location = new System.Drawing.Point(27, 327);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(280, 35);
            this.butLogin.TabIndex = 5;
            this.butLogin.Text = "登  录";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // butChangePass
            // 
            this.butChangePass.FlatAppearance.BorderSize = 0;
            this.butChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butChangePass.Font = new System.Drawing.Font("宋体", 9F);
            this.butChangePass.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.butChangePass.Location = new System.Drawing.Point(225, 272);
            this.butChangePass.Name = "butChangePass";
            this.butChangePass.Size = new System.Drawing.Size(82, 27);
            this.butChangePass.TabIndex = 6;
            this.butChangePass.Text = "重置密码";
            this.butChangePass.UseVisualStyleBackColor = true;
            this.butChangePass.Click += new System.EventHandler(this.butChangePass_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 41);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.butChangePass);
            this.groupBox1.Controls.Add(this.butLogin);
            this.groupBox1.Controls.Add(this.account);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(614, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 403);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(321, 103);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 41);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(105, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 47);
            this.label1.TabIndex = 10;
            this.label1.Text = "药品销售管理系统";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(131, 166);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(377, 255);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.butLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Button butChangePass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

