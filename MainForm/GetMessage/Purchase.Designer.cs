namespace Database.MainForm.GetMessage {
    partial class Purchase {
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
            this.getDrugMessage = new System.Windows.Forms.DataGridView();
            this.checkDrugNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.butCheck = new System.Windows.Forms.Button();
            this.supplyNum = new System.Windows.Forms.TextBox();
            this.drugName = new System.Windows.Forms.TextBox();
            this.supplierPrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.supplyTime = new System.Windows.Forms.DateTimePicker();
            this.validity = new System.Windows.Forms.DateTimePicker();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.butInsertSQL = new System.Windows.Forms.Button();
            this.setPurchaseMessage = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.drugNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.drugFunction = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDrugMessage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setPurchaseMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.getDrugMessage);
            this.groupBox2.Controls.Add(this.checkDrugNum);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.butCheck);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 11F);
            this.groupBox2.Location = new System.Drawing.Point(20, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1492, 269);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "药品信息检索";
            // 
            // getDrugMessage
            // 
            this.getDrugMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.getDrugMessage.BackgroundColor = System.Drawing.Color.White;
            this.getDrugMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getDrugMessage.Location = new System.Drawing.Point(21, 27);
            this.getDrugMessage.Name = "getDrugMessage";
            this.getDrugMessage.RowHeadersWidth = 51;
            this.getDrugMessage.RowTemplate.Height = 27;
            this.getDrugMessage.Size = new System.Drawing.Size(1455, 201);
            this.getDrugMessage.TabIndex = 2;
            // 
            // checkDrugNum
            // 
            this.checkDrugNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkDrugNum.Font = new System.Drawing.Font("宋体", 9F);
            this.checkDrugNum.Location = new System.Drawing.Point(155, 235);
            this.checkDrugNum.Name = "checkDrugNum";
            this.checkDrugNum.Size = new System.Drawing.Size(159, 25);
            this.checkDrugNum.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F);
            this.label7.Location = new System.Drawing.Point(78, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "药品名称：";
            // 
            // butCheck
            // 
            this.butCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butCheck.Font = new System.Drawing.Font("宋体", 9F);
            this.butCheck.Location = new System.Drawing.Point(331, 234);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(59, 27);
            this.butCheck.TabIndex = 1;
            this.butCheck.Text = "检索";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.butCheck_Click);
            // 
            // supplyNum
            // 
            this.supplyNum.Location = new System.Drawing.Point(554, 184);
            this.supplyNum.Name = "supplyNum";
            this.supplyNum.Size = new System.Drawing.Size(200, 28);
            this.supplyNum.TabIndex = 7;
            // 
            // drugName
            // 
            this.drugName.Location = new System.Drawing.Point(554, 38);
            this.drugName.Name = "drugName";
            this.drugName.Size = new System.Drawing.Size(200, 28);
            this.drugName.TabIndex = 1;
            // 
            // supplierPrice
            // 
            this.supplierPrice.Location = new System.Drawing.Point(168, 184);
            this.supplierPrice.Name = "supplierPrice";
            this.supplierPrice.Size = new System.Drawing.Size(200, 28);
            this.supplierPrice.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.drugFunction);
            this.groupBox1.Controls.Add(this.butCancel);
            this.groupBox1.Controls.Add(this.supplyTime);
            this.groupBox1.Controls.Add(this.validity);
            this.groupBox1.Controls.Add(this.birthday);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.butInsertSQL);
            this.groupBox1.Controls.Add(this.setPurchaseMessage);
            this.groupBox1.Controls.Add(this.supplierNum);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.supplyNum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.drugName);
            this.groupBox1.Controls.Add(this.supplierPrice);
            this.groupBox1.Controls.Add(this.butAdd);
            this.groupBox1.Controls.Add(this.drugNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 11F);
            this.groupBox1.Location = new System.Drawing.Point(20, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1492, 297);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "填写订单";
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Font = new System.Drawing.Font("宋体", 9F);
            this.butCancel.Location = new System.Drawing.Point(1092, 246);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 32);
            this.butCancel.TabIndex = 11;
            this.butCancel.Text = "撤  销";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // supplyTime
            // 
            this.supplyTime.Location = new System.Drawing.Point(168, 232);
            this.supplyTime.Name = "supplyTime";
            this.supplyTime.Size = new System.Drawing.Size(200, 28);
            this.supplyTime.TabIndex = 8;
            // 
            // validity
            // 
            this.validity.Location = new System.Drawing.Point(554, 81);
            this.validity.Name = "validity";
            this.validity.Size = new System.Drawing.Size(200, 28);
            this.validity.TabIndex = 3;
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(168, 81);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(200, 28);
            this.birthday.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F);
            this.label12.Location = new System.Drawing.Point(64, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "入库日期：";
            // 
            // butInsertSQL
            // 
            this.butInsertSQL.Font = new System.Drawing.Font("宋体", 9F);
            this.butInsertSQL.Location = new System.Drawing.Point(1356, 246);
            this.butInsertSQL.Name = "butInsertSQL";
            this.butInsertSQL.Size = new System.Drawing.Size(120, 31);
            this.butInsertSQL.TabIndex = 13;
            this.butInsertSQL.Text = "插入到数据库";
            this.butInsertSQL.UseVisualStyleBackColor = true;
            this.butInsertSQL.Click += new System.EventHandler(this.butInsertSQL_Click);
            // 
            // setPurchaseMessage
            // 
            this.setPurchaseMessage.BackgroundColor = System.Drawing.Color.White;
            this.setPurchaseMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.setPurchaseMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.setPurchaseMessage.Location = new System.Drawing.Point(812, 41);
            this.setPurchaseMessage.Name = "setPurchaseMessage";
            this.setPurchaseMessage.RowHeadersWidth = 51;
            this.setPurchaseMessage.RowTemplate.Height = 27;
            this.setPurchaseMessage.Size = new System.Drawing.Size(664, 187);
            this.setPurchaseMessage.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "药品编号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "药品名称";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "生产日期";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "有效期至";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "功能主治";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 170;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "供应商编号";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "购买单价";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "购买数量";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "入库编号";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "入库日期";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // supplierNum
            // 
            this.supplierNum.Location = new System.Drawing.Point(554, 133);
            this.supplierNum.Name = "supplierNum";
            this.supplierNum.Size = new System.Drawing.Size(200, 28);
            this.supplierNum.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F);
            this.label10.Location = new System.Drawing.Point(435, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "供应商编号：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F);
            this.label9.Location = new System.Drawing.Point(64, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "功能主治：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F);
            this.label8.Location = new System.Drawing.Point(450, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "有效期至：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(450, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "购买数量：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(64, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "生产日期：";
            // 
            // butAdd
            // 
            this.butAdd.Font = new System.Drawing.Font("宋体", 9F);
            this.butAdd.Location = new System.Drawing.Point(812, 246);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 31);
            this.butAdd.TabIndex = 10;
            this.butAdd.Text = "添  加";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // drugNum
            // 
            this.drugNum.Font = new System.Drawing.Font("宋体", 9F);
            this.drugNum.Location = new System.Drawing.Point(168, 41);
            this.drugNum.Name = "drugNum";
            this.drugNum.Size = new System.Drawing.Size(200, 25);
            this.drugNum.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.Location = new System.Drawing.Point(64, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "购买单价：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F);
            this.label4.Location = new System.Drawing.Point(450, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "药品名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(64, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "药品编号：";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("仿宋", 23F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(627, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 39);
            this.label6.TabIndex = 18;
            this.label6.Text = "进货管理系统";
            // 
            // drugFunction
            // 
            this.drugFunction.Location = new System.Drawing.Point(168, 133);
            this.drugFunction.Name = "drugFunction";
            this.drugFunction.Size = new System.Drawing.Size(200, 28);
            this.drugFunction.TabIndex = 35;
            // 
            // Purchase
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
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDrugMessage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setPurchaseMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox checkDrugNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.TextBox supplyNum;
        private System.Windows.Forms.TextBox drugName;
        private System.Windows.Forms.TextBox supplierPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView setPurchaseMessage;
        private System.Windows.Forms.TextBox supplierNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.TextBox drugNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butInsertSQL;
        private System.Windows.Forms.DataGridView getDrugMessage;
        private System.Windows.Forms.DateTimePicker supplyTime;
        private System.Windows.Forms.DateTimePicker validity;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.TextBox drugFunction;
    }
}