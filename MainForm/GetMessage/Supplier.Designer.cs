namespace Database.MainForm.GetMessage {
    partial class Supplier {
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
            this.getSupplierMessage = new System.Windows.Forms.DataGridView();
            this.butDelete = new System.Windows.Forms.Button();
            this.checkSupplierNum = new System.Windows.Forms.TextBox();
            this.butCheck = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.supplierTell = new System.Windows.Forms.TextBox();
            this.supplierAddress = new System.Windows.Forms.TextBox();
            this.supplierNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butInsertSQL = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.setSupplierMessage = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getSupplierMessage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setSupplierMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.getSupplierMessage);
            this.groupBox2.Controls.Add(this.butDelete);
            this.groupBox2.Controls.Add(this.checkSupplierNum);
            this.groupBox2.Controls.Add(this.butCheck);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 11F);
            this.groupBox2.Location = new System.Drawing.Point(11, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1510, 325);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "供应商信息检索";
            // 
            // getSupplierMessage
            // 
            this.getSupplierMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.getSupplierMessage.BackgroundColor = System.Drawing.Color.White;
            this.getSupplierMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getSupplierMessage.Location = new System.Drawing.Point(19, 37);
            this.getSupplierMessage.Name = "getSupplierMessage";
            this.getSupplierMessage.RowHeadersWidth = 51;
            this.getSupplierMessage.RowTemplate.Height = 27;
            this.getSupplierMessage.Size = new System.Drawing.Size(1471, 243);
            this.getSupplierMessage.TabIndex = 15;
            // 
            // butDelete
            // 
            this.butDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butDelete.Font = new System.Drawing.Font("宋体", 9F);
            this.butDelete.Location = new System.Drawing.Point(438, 286);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(116, 27);
            this.butDelete.TabIndex = 2;
            this.butDelete.Text = "删除此供应商";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // checkSupplierNum
            // 
            this.checkSupplierNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkSupplierNum.Font = new System.Drawing.Font("宋体", 9F);
            this.checkSupplierNum.Location = new System.Drawing.Point(170, 287);
            this.checkSupplierNum.Name = "checkSupplierNum";
            this.checkSupplierNum.Size = new System.Drawing.Size(159, 25);
            this.checkSupplierNum.TabIndex = 0;
            // 
            // butCheck
            // 
            this.butCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butCheck.Font = new System.Drawing.Font("宋体", 9F);
            this.butCheck.Location = new System.Drawing.Point(346, 286);
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
            this.label7.Location = new System.Drawing.Point(72, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "供应商编号：";
            // 
            // supplierTell
            // 
            this.supplierTell.Font = new System.Drawing.Font("宋体", 9F);
            this.supplierTell.Location = new System.Drawing.Point(168, 156);
            this.supplierTell.Name = "supplierTell";
            this.supplierTell.Size = new System.Drawing.Size(200, 25);
            this.supplierTell.TabIndex = 3;
            // 
            // supplierAddress
            // 
            this.supplierAddress.Font = new System.Drawing.Font("宋体", 9F);
            this.supplierAddress.Location = new System.Drawing.Point(168, 98);
            this.supplierAddress.Name = "supplierAddress";
            this.supplierAddress.Size = new System.Drawing.Size(586, 25);
            this.supplierAddress.TabIndex = 2;
            // 
            // supplierNum
            // 
            this.supplierNum.Font = new System.Drawing.Font("宋体", 9F);
            this.supplierNum.Location = new System.Drawing.Point(168, 42);
            this.supplierNum.Name = "supplierNum";
            this.supplierNum.Size = new System.Drawing.Size(200, 25);
            this.supplierNum.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.Location = new System.Drawing.Point(64, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "地     址：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(450, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "供应商名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(64, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "联系方式：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(64, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "供应商编号：";
            // 
            // butInsertSQL
            // 
            this.butInsertSQL.Font = new System.Drawing.Font("宋体", 9F);
            this.butInsertSQL.Location = new System.Drawing.Point(1388, 185);
            this.butInsertSQL.Name = "butInsertSQL";
            this.butInsertSQL.Size = new System.Drawing.Size(102, 31);
            this.butInsertSQL.TabIndex = 7;
            this.butInsertSQL.Text = "插入数据库";
            this.butInsertSQL.UseVisualStyleBackColor = true;
            this.butInsertSQL.Click += new System.EventHandler(this.butInsertSQL_Click);
            // 
            // butAdd
            // 
            this.butAdd.Font = new System.Drawing.Font("宋体", 9F);
            this.butAdd.Location = new System.Drawing.Point(554, 159);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 32);
            this.butAdd.TabIndex = 4;
            this.butAdd.Text = "添  加";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.butCancel);
            this.groupBox1.Controls.Add(this.setSupplierMessage);
            this.groupBox1.Controls.Add(this.supplierName);
            this.groupBox1.Controls.Add(this.butInsertSQL);
            this.groupBox1.Controls.Add(this.supplierTell);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.butAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.supplierAddress);
            this.groupBox1.Controls.Add(this.supplierNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 11F);
            this.groupBox1.Location = new System.Drawing.Point(11, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1510, 222);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "供应商信息插入";
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Font = new System.Drawing.Font("宋体", 9F);
            this.butCancel.Location = new System.Drawing.Point(679, 159);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 32);
            this.butCancel.TabIndex = 5;
            this.butCancel.Text = "撤  销";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // setSupplierMessage
            // 
            this.setSupplierMessage.BackgroundColor = System.Drawing.Color.White;
            this.setSupplierMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.setSupplierMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.setSupplierMessage.Location = new System.Drawing.Point(788, 27);
            this.setSupplierMessage.Name = "setSupplierMessage";
            this.setSupplierMessage.RowHeadersWidth = 51;
            this.setSupplierMessage.RowTemplate.Height = 27;
            this.setSupplierMessage.Size = new System.Drawing.Size(702, 154);
            this.setSupplierMessage.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "供应商编号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "供应商名称";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "联系方式";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "供应商地址";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 160;
            // 
            // supplierName
            // 
            this.supplierName.Font = new System.Drawing.Font("宋体", 9F);
            this.supplierName.Location = new System.Drawing.Point(554, 42);
            this.supplierName.Name = "supplierName";
            this.supplierName.Size = new System.Drawing.Size(200, 25);
            this.supplierName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("仿宋", 23F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(581, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(386, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "供应商信息管理系统";
            // 
            // Supplier
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
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getSupplierMessage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setSupplierMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.TextBox checkSupplierNum;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox supplierTell;
        private System.Windows.Forms.TextBox supplierAddress;
        private System.Windows.Forms.TextBox supplierNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butInsertSQL;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox supplierName;
        private System.Windows.Forms.DataGridView setSupplierMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView getSupplierMessage;
        private System.Windows.Forms.Button butCancel;
    }
}