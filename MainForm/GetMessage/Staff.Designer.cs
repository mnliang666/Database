namespace Database.MainForm.GetMessage {
    partial class Staff {
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.setStaffMessage = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butInsertSQL = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.radioWom = new System.Windows.Forms.RadioButton();
            this.radioMan = new System.Windows.Forms.RadioButton();
            this.staffTime = new System.Windows.Forms.DateTimePicker();
            this.staffName = new System.Windows.Forms.TextBox();
            this.staffDuty = new System.Windows.Forms.TextBox();
            this.staffNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkStaffNum = new System.Windows.Forms.TextBox();
            this.butCheck = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.getStaffMessage = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setStaffMessage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getStaffMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("仿宋", 23F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(597, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(345, 39);
            this.label6.TabIndex = 5;
            this.label6.Text = "员工信息管理系统";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.butCancel);
            this.groupBox1.Controls.Add(this.setStaffMessage);
            this.groupBox1.Controls.Add(this.butInsertSQL);
            this.groupBox1.Controls.Add(this.butAdd);
            this.groupBox1.Controls.Add(this.radioWom);
            this.groupBox1.Controls.Add(this.radioMan);
            this.groupBox1.Controls.Add(this.staffTime);
            this.groupBox1.Controls.Add(this.staffName);
            this.groupBox1.Controls.Add(this.staffDuty);
            this.groupBox1.Controls.Add(this.staffNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 11F);
            this.groupBox1.Location = new System.Drawing.Point(20, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1492, 222);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "员工信息插入";
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Font = new System.Drawing.Font("宋体", 9F);
            this.butCancel.Location = new System.Drawing.Point(679, 149);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 32);
            this.butCancel.TabIndex = 29;
            this.butCancel.Text = "撤  销";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // setStaffMessage
            // 
            this.setStaffMessage.BackgroundColor = System.Drawing.Color.White;
            this.setStaffMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.setStaffMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.setStaffMessage.Location = new System.Drawing.Point(796, 28);
            this.setStaffMessage.Name = "setStaffMessage";
            this.setStaffMessage.RowHeadersWidth = 51;
            this.setStaffMessage.RowTemplate.Height = 27;
            this.setStaffMessage.Size = new System.Drawing.Size(676, 150);
            this.setStaffMessage.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "员工编号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "员工姓名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "性别";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "入职时间";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "职务";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // butInsertSQL
            // 
            this.butInsertSQL.Font = new System.Drawing.Font("宋体", 9F);
            this.butInsertSQL.Location = new System.Drawing.Point(1347, 185);
            this.butInsertSQL.Name = "butInsertSQL";
            this.butInsertSQL.Size = new System.Drawing.Size(125, 31);
            this.butInsertSQL.TabIndex = 15;
            this.butInsertSQL.Text = "插入到数据库";
            this.butInsertSQL.UseVisualStyleBackColor = true;
            this.butInsertSQL.Click += new System.EventHandler(this.butInsertSQL_Click);
            // 
            // butAdd
            // 
            this.butAdd.Font = new System.Drawing.Font("宋体", 9F);
            this.butAdd.Location = new System.Drawing.Point(554, 150);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 32);
            this.butAdd.TabIndex = 13;
            this.butAdd.Text = "添  加";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // radioWom
            // 
            this.radioWom.AutoSize = true;
            this.radioWom.Font = new System.Drawing.Font("宋体", 9F);
            this.radioWom.Location = new System.Drawing.Point(250, 103);
            this.radioWom.Name = "radioWom";
            this.radioWom.Size = new System.Drawing.Size(43, 19);
            this.radioWom.TabIndex = 11;
            this.radioWom.TabStop = true;
            this.radioWom.Text = "女";
            this.radioWom.UseVisualStyleBackColor = true;
            // 
            // radioMan
            // 
            this.radioMan.AutoSize = true;
            this.radioMan.Font = new System.Drawing.Font("宋体", 9F);
            this.radioMan.Location = new System.Drawing.Point(168, 103);
            this.radioMan.Name = "radioMan";
            this.radioMan.Size = new System.Drawing.Size(43, 19);
            this.radioMan.TabIndex = 10;
            this.radioMan.TabStop = true;
            this.radioMan.Text = "男";
            this.radioMan.UseVisualStyleBackColor = true;
            // 
            // staffTime
            // 
            this.staffTime.Font = new System.Drawing.Font("宋体", 9F);
            this.staffTime.Location = new System.Drawing.Point(554, 96);
            this.staffTime.Name = "staffTime";
            this.staffTime.Size = new System.Drawing.Size(200, 25);
            this.staffTime.TabIndex = 9;
            this.staffTime.Value = new System.DateTime(2020, 1, 6, 0, 0, 0, 0);
            // 
            // staffName
            // 
            this.staffName.Font = new System.Drawing.Font("宋体", 9F);
            this.staffName.Location = new System.Drawing.Point(554, 42);
            this.staffName.Name = "staffName";
            this.staffName.Size = new System.Drawing.Size(200, 25);
            this.staffName.TabIndex = 7;
            // 
            // staffDuty
            // 
            this.staffDuty.Font = new System.Drawing.Font("宋体", 9F);
            this.staffDuty.Location = new System.Drawing.Point(168, 156);
            this.staffDuty.Name = "staffDuty";
            this.staffDuty.Size = new System.Drawing.Size(200, 25);
            this.staffDuty.TabIndex = 6;
            // 
            // staffNum
            // 
            this.staffNum.Font = new System.Drawing.Font("宋体", 9F);
            this.staffNum.Location = new System.Drawing.Point(168, 42);
            this.staffNum.Name = "staffNum";
            this.staffNum.Size = new System.Drawing.Size(200, 25);
            this.staffNum.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.Location = new System.Drawing.Point(64, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "职    务：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F);
            this.label4.Location = new System.Drawing.Point(449, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "入职时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(64, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "员工性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(449, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(64, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工编号：";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F);
            this.label7.Location = new System.Drawing.Point(63, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "员工编号：";
            // 
            // checkStaffNum
            // 
            this.checkStaffNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkStaffNum.Font = new System.Drawing.Font("宋体", 9F);
            this.checkStaffNum.Location = new System.Drawing.Point(140, 287);
            this.checkStaffNum.Name = "checkStaffNum";
            this.checkStaffNum.Size = new System.Drawing.Size(159, 25);
            this.checkStaffNum.TabIndex = 7;
            // 
            // butCheck
            // 
            this.butCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butCheck.Font = new System.Drawing.Font("宋体", 9F);
            this.butCheck.Location = new System.Drawing.Point(316, 286);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(59, 27);
            this.butCheck.TabIndex = 8;
            this.butCheck.Text = "检索";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.butCheck_Click);
            // 
            // butDelete
            // 
            this.butDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butDelete.Font = new System.Drawing.Font("宋体", 9F);
            this.butDelete.Location = new System.Drawing.Point(408, 286);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(98, 27);
            this.butDelete.TabIndex = 9;
            this.butDelete.Text = "删除此员工";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.getStaffMessage);
            this.groupBox2.Controls.Add(this.butDelete);
            this.groupBox2.Controls.Add(this.checkStaffNum);
            this.groupBox2.Controls.Add(this.butCheck);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 11F);
            this.groupBox2.Location = new System.Drawing.Point(20, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1492, 325);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "员工信息检索";
            // 
            // getStaffMessage
            // 
            this.getStaffMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.getStaffMessage.BackgroundColor = System.Drawing.Color.White;
            this.getStaffMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getStaffMessage.Location = new System.Drawing.Point(20, 37);
            this.getStaffMessage.Name = "getStaffMessage";
            this.getStaffMessage.RowHeadersWidth = 51;
            this.getStaffMessage.RowTemplate.Height = 27;
            this.getStaffMessage.Size = new System.Drawing.Size(1452, 243);
            this.getStaffMessage.TabIndex = 18;
            // 
            // Staff
            // 
            this.AcceptButton = this.butAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.Text = "Staff";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setStaffMessage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getStaffMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butInsertSQL;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.RadioButton radioWom;
        private System.Windows.Forms.RadioButton radioMan;
        private System.Windows.Forms.DateTimePicker staffTime;
        private System.Windows.Forms.TextBox staffName;
        private System.Windows.Forms.TextBox staffDuty;
        private System.Windows.Forms.TextBox staffNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox checkStaffNum;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView setStaffMessage;
        private System.Windows.Forms.DataGridView getStaffMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button butCancel;
    }
}