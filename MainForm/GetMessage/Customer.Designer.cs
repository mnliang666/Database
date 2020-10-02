namespace Database.MainForm.GetMessage {
    partial class Customer {
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.getCusMessage = new System.Windows.Forms.DataGridView();
            this.butDelete = new System.Windows.Forms.Button();
            this.checkStaffNum = new System.Windows.Forms.TextBox();
            this.butCheck = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cusNum = new System.Windows.Forms.TextBox();
            this.cusTell = new System.Windows.Forms.TextBox();
            this.cusName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butInsertSQL = new System.Windows.Forms.Button();
            this.setCusMessage = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getCusMessage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setCusMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.getCusMessage);
            this.groupBox2.Controls.Add(this.butDelete);
            this.groupBox2.Controls.Add(this.checkStaffNum);
            this.groupBox2.Controls.Add(this.butCheck);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 11F);
            this.groupBox2.Location = new System.Drawing.Point(20, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1492, 325);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "客户信息检索";
            // 
            // getCusMessage
            // 
            this.getCusMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.getCusMessage.BackgroundColor = System.Drawing.Color.White;
            this.getCusMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getCusMessage.Location = new System.Drawing.Point(15, 27);
            this.getCusMessage.Name = "getCusMessage";
            this.getCusMessage.RowHeadersWidth = 51;
            this.getCusMessage.RowTemplate.Height = 27;
            this.getCusMessage.Size = new System.Drawing.Size(1461, 239);
            this.getCusMessage.TabIndex = 18;
            // 
            // butDelete
            // 
            this.butDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butDelete.Font = new System.Drawing.Font("宋体", 9F);
            this.butDelete.Location = new System.Drawing.Point(408, 286);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(98, 27);
            this.butDelete.TabIndex = 2;
            this.butDelete.Text = "删除此客户";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // checkStaffNum
            // 
            this.checkStaffNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkStaffNum.Font = new System.Drawing.Font("宋体", 9F);
            this.checkStaffNum.Location = new System.Drawing.Point(140, 287);
            this.checkStaffNum.Name = "checkStaffNum";
            this.checkStaffNum.Size = new System.Drawing.Size(159, 25);
            this.checkStaffNum.TabIndex = 0;
            // 
            // butCheck
            // 
            this.butCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butCheck.Font = new System.Drawing.Font("宋体", 9F);
            this.butCheck.Location = new System.Drawing.Point(316, 286);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(59, 27);
            this.butCheck.TabIndex = 1;
            this.butCheck.Text = "检索";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.butCheck_Click);
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
            this.label7.Text = "客户编号：";
            // 
            // cusNum
            // 
            this.cusNum.Font = new System.Drawing.Font("宋体", 9F);
            this.cusNum.Location = new System.Drawing.Point(168, 43);
            this.cusNum.Name = "cusNum";
            this.cusNum.Size = new System.Drawing.Size(200, 25);
            this.cusNum.TabIndex = 0;
            // 
            // cusTell
            // 
            this.cusTell.Font = new System.Drawing.Font("宋体", 9F);
            this.cusTell.Location = new System.Drawing.Point(168, 107);
            this.cusTell.Name = "cusTell";
            this.cusTell.Size = new System.Drawing.Size(200, 25);
            this.cusTell.TabIndex = 2;
            // 
            // cusName
            // 
            this.cusName.Font = new System.Drawing.Font("宋体", 9F);
            this.cusName.Location = new System.Drawing.Point(541, 43);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(200, 25);
            this.cusName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.Location = new System.Drawing.Point(81, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "联系方式：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(80, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(453, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户名称：";
            // 
            // butAdd
            // 
            this.butAdd.Font = new System.Drawing.Font("宋体", 9F);
            this.butAdd.Location = new System.Drawing.Point(516, 146);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 32);
            this.butAdd.TabIndex = 3;
            this.butAdd.Text = "添  加";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.butCancel);
            this.groupBox1.Controls.Add(this.butInsertSQL);
            this.groupBox1.Controls.Add(this.setCusMessage);
            this.groupBox1.Controls.Add(this.butAdd);
            this.groupBox1.Controls.Add(this.cusNum);
            this.groupBox1.Controls.Add(this.cusTell);
            this.groupBox1.Controls.Add(this.cusName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 11F);
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1492, 222);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客户信息插入";
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Font = new System.Drawing.Font("宋体", 9F);
            this.butCancel.Location = new System.Drawing.Point(666, 146);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 32);
            this.butCancel.TabIndex = 4;
            this.butCancel.Text = "撤  销";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butInsertSQL
            // 
            this.butInsertSQL.Font = new System.Drawing.Font("宋体", 9F);
            this.butInsertSQL.Location = new System.Drawing.Point(1352, 184);
            this.butInsertSQL.Name = "butInsertSQL";
            this.butInsertSQL.Size = new System.Drawing.Size(124, 31);
            this.butInsertSQL.TabIndex = 6;
            this.butInsertSQL.Text = "插入到数据库";
            this.butInsertSQL.UseVisualStyleBackColor = true;
            this.butInsertSQL.Click += new System.EventHandler(this.butInsertSQL_Click);
            // 
            // setCusMessage
            // 
            this.setCusMessage.BackgroundColor = System.Drawing.Color.White;
            this.setCusMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.setCusMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.setCusMessage.Location = new System.Drawing.Point(829, 28);
            this.setCusMessage.Name = "setCusMessage";
            this.setCusMessage.RowHeadersWidth = 51;
            this.setCusMessage.RowTemplate.Height = 27;
            this.setCusMessage.Size = new System.Drawing.Size(647, 150);
            this.setCusMessage.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "客户编号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 135;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "客户名称";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "联系方式";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 140;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("仿宋", 23F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(597, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(345, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "客户信息管理系统";
            // 
            // Customer
            // 
            this.AcceptButton = this.butAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getCusMessage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setCusMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.TextBox checkStaffNum;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cusNum;
        private System.Windows.Forms.TextBox cusTell;
        private System.Windows.Forms.TextBox cusName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView setCusMessage;
        private System.Windows.Forms.DataGridView getCusMessage;
        private System.Windows.Forms.Button butInsertSQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button butCancel;
    }
}