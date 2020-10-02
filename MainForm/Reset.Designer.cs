namespace Database.MainForm {
    partial class Reset {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用 户 名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓    名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "新 密 码：";
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(131, 43);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(186, 25);
            this.account.TabIndex = 3;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(131, 99);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(186, 25);
            this.name.TabIndex = 4;
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(131, 156);
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '*';
            this.newPassword.Size = new System.Drawing.Size(186, 25);
            this.newPassword.TabIndex = 5;
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(131, 213);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '*';
            this.confirmPassword.Size = new System.Drawing.Size(186, 25);
            this.confirmPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "确认密码：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butCancel);
            this.groupBox1.Controls.Add(this.butReset);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.confirmPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.newPassword);
            this.groupBox1.Controls.Add(this.account);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Location = new System.Drawing.Point(32, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 345);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // butCancel
            // 
            this.butCancel.FlatAppearance.BorderSize = 0;
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.ForeColor = System.Drawing.Color.Gray;
            this.butCancel.Location = new System.Drawing.Point(253, 255);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 27);
            this.butCancel.TabIndex = 10;
            this.butCancel.Text = "取 消";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(57, 288);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(258, 28);
            this.butReset.TabIndex = 9;
            this.butReset.Text = "重  置";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 19F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(134, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "重置密码";
            // 
            // Reset
            // 
            this.AcceptButton = this.butReset;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(418, 444);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "重置密码";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butCancel;
    }
}