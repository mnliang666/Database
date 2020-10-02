namespace Database.MainForm.GetMessage {
    partial class Account {
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
            this.butCheck = new System.Windows.Forms.Button();
            this.sellData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buyData = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sum = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.stateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellData)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // butCheck
            // 
            this.butCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butCheck.Font = new System.Drawing.Font("宋体", 9F);
            this.butCheck.Location = new System.Drawing.Point(706, 276);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(59, 27);
            this.butCheck.TabIndex = 1;
            this.butCheck.Text = "检索";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.butCheck_Click_1);
            // 
            // sellData
            // 
            this.sellData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sellData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellData.BackgroundColor = System.Drawing.Color.White;
            this.sellData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellData.Location = new System.Drawing.Point(17, 33);
            this.sellData.Name = "sellData";
            this.sellData.RowHeadersWidth = 51;
            this.sellData.RowTemplate.Height = 27;
            this.sellData.Size = new System.Drawing.Size(1477, 231);
            this.sellData.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buyData);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 11F);
            this.groupBox1.Location = new System.Drawing.Point(11, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1510, 271);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "支出订单";
            // 
            // buyData
            // 
            this.buyData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buyData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.buyData.BackgroundColor = System.Drawing.Color.White;
            this.buyData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyData.Location = new System.Drawing.Point(17, 30);
            this.buyData.Name = "buyData";
            this.buyData.RowHeadersWidth = 51;
            this.buyData.RowTemplate.Height = 27;
            this.buyData.Size = new System.Drawing.Size(1477, 221);
            this.buyData.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("仿宋", 23F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(639, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 39);
            this.label6.TabIndex = 15;
            this.label6.Text = "账目查询系统";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F);
            this.label7.Location = new System.Drawing.Point(72, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "起始日期：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sum);
            this.groupBox2.Controls.Add(this.endTime);
            this.groupBox2.Controls.Add(this.stateTime);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.sellData);
            this.groupBox2.Controls.Add(this.butCheck);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 11F);
            this.groupBox2.Location = new System.Drawing.Point(11, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1510, 316);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "收入订单";
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.ForeColor = System.Drawing.Color.Red;
            this.sum.Location = new System.Drawing.Point(1043, 280);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(0, 19);
            this.sum.TabIndex = 22;
            // 
            // endTime
            // 
            this.endTime.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.endTime.Location = new System.Drawing.Point(484, 275);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(200, 28);
            this.endTime.TabIndex = 21;
            // 
            // stateTime
            // 
            this.stateTime.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.stateTime.Location = new System.Drawing.Point(160, 275);
            this.stateTime.Name = "stateTime";
            this.stateTime.Size = new System.Drawing.Size(200, 28);
            this.stateTime.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(396, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "终止日期：";
            // 
            // Account
            // 
            this.AcceptButton = this.butCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.Text = "Account";
            ((System.ComponentModel.ISupportInitialize)(this.sellData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buyData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.DataGridView sellData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView buyData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.DateTimePicker stateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sum;
    }
}