namespace Database.MainForm.GetMessage {
    partial class Drug {
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
            this.checkDrugNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.drugNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butInsertSQL = new System.Windows.Forms.Button();
            this.setDrugMessage = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.supplyNum = new System.Windows.Forms.TextBox();
            this.customerNum = new System.Windows.Forms.TextBox();
            this.drugPrice = new System.Windows.Forms.TextBox();
            this.butCheck = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.getDrugMessage = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setDrugMessage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDrugMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // checkDrugNum
            // 
            this.checkDrugNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkDrugNum.Font = new System.Drawing.Font("宋体", 9F);
            this.checkDrugNum.Location = new System.Drawing.Point(155, 276);
            this.checkDrugNum.Name = "checkDrugNum";
            this.checkDrugNum.Size = new System.Drawing.Size(159, 25);
            this.checkDrugNum.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F);
            this.label7.Location = new System.Drawing.Point(78, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "药品名称：";
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
            this.label5.Location = new System.Drawing.Point(64, 96);
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
            this.label4.Text = "客户编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(450, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "需求数量：";
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
            // butAdd
            // 
            this.butAdd.Font = new System.Drawing.Font("宋体", 9F);
            this.butAdd.Location = new System.Drawing.Point(554, 150);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 31);
            this.butAdd.TabIndex = 5;
            this.butAdd.Text = "添  加";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.butCancel);
            this.groupBox1.Controls.Add(this.butInsertSQL);
            this.groupBox1.Controls.Add(this.setDrugMessage);
            this.groupBox1.Controls.Add(this.orderTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.supplyNum);
            this.groupBox1.Controls.Add(this.customerNum);
            this.groupBox1.Controls.Add(this.drugPrice);
            this.groupBox1.Controls.Add(this.butAdd);
            this.groupBox1.Controls.Add(this.drugNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 11F);
            this.groupBox1.Location = new System.Drawing.Point(20, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1492, 222);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "填写订单";
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Font = new System.Drawing.Font("宋体", 9F);
            this.butCancel.Location = new System.Drawing.Point(679, 150);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 32);
            this.butCancel.TabIndex = 6;
            this.butCancel.Text = "撤  销";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butInsertSQL
            // 
            this.butInsertSQL.Font = new System.Drawing.Font("宋体", 9F);
            this.butInsertSQL.Location = new System.Drawing.Point(1342, 187);
            this.butInsertSQL.Name = "butInsertSQL";
            this.butInsertSQL.Size = new System.Drawing.Size(124, 31);
            this.butInsertSQL.TabIndex = 8;
            this.butInsertSQL.Text = "插入到数据库";
            this.butInsertSQL.UseVisualStyleBackColor = true;
            this.butInsertSQL.Click += new System.EventHandler(this.butInsertSQL_Click);
            // 
            // setDrugMessage
            // 
            this.setDrugMessage.BackgroundColor = System.Drawing.Color.White;
            this.setDrugMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.setDrugMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.setDrugMessage.Location = new System.Drawing.Point(789, 27);
            this.setDrugMessage.Name = "setDrugMessage";
            this.setDrugMessage.RowHeadersWidth = 51;
            this.setDrugMessage.RowTemplate.Height = 27;
            this.setDrugMessage.Size = new System.Drawing.Size(677, 154);
            this.setDrugMessage.TabIndex = 7;
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
            this.Column2.HeaderText = "客户编号";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "购买单价";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "需求数量";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "订单时间";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // orderTime
            // 
            this.orderTime.Location = new System.Drawing.Point(168, 138);
            this.orderTime.Name = "orderTime";
            this.orderTime.Size = new System.Drawing.Size(200, 28);
            this.orderTime.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(64, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "订单时间：";
            // 
            // supplyNum
            // 
            this.supplyNum.Location = new System.Drawing.Point(554, 91);
            this.supplyNum.Name = "supplyNum";
            this.supplyNum.Size = new System.Drawing.Size(200, 28);
            this.supplyNum.TabIndex = 3;
            // 
            // customerNum
            // 
            this.customerNum.Location = new System.Drawing.Point(554, 38);
            this.customerNum.Name = "customerNum";
            this.customerNum.Size = new System.Drawing.Size(200, 28);
            this.customerNum.TabIndex = 1;
            // 
            // drugPrice
            // 
            this.drugPrice.Location = new System.Drawing.Point(168, 87);
            this.drugPrice.Name = "drugPrice";
            this.drugPrice.Size = new System.Drawing.Size(200, 28);
            this.drugPrice.TabIndex = 2;
            // 
            // butCheck
            // 
            this.butCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butCheck.Font = new System.Drawing.Font("宋体", 9F);
            this.butCheck.Location = new System.Drawing.Point(331, 275);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(61, 27);
            this.butCheck.TabIndex = 2;
            this.butCheck.Text = "检 索";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.butCheck_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("仿宋", 23F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(627, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "药品销售系统";
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
            this.groupBox2.Location = new System.Drawing.Point(20, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1492, 310);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "药品信息检索";
            // 
            // getDrugMessage
            // 
            this.getDrugMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.getDrugMessage.BackgroundColor = System.Drawing.Color.White;
            this.getDrugMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getDrugMessage.Location = new System.Drawing.Point(18, 27);
            this.getDrugMessage.Name = "getDrugMessage";
            this.getDrugMessage.RowHeadersWidth = 51;
            this.getDrugMessage.RowTemplate.Height = 27;
            this.getDrugMessage.Size = new System.Drawing.Size(1455, 242);
            this.getDrugMessage.TabIndex = 26;
            // 
            // Drug
            // 
            this.AcceptButton = this.butAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(1532, 643);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Drug";
            this.Text = "Drug";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setDrugMessage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDrugMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox checkDrugNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox drugNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox drugPrice;
        private System.Windows.Forms.TextBox customerNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox supplyNum;
        private System.Windows.Forms.DataGridView setDrugMessage;
        private System.Windows.Forms.DateTimePicker orderTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView getDrugMessage;
        private System.Windows.Forms.Button butInsertSQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button butCancel;
    }
}