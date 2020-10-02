namespace Database.MainForm.GetMessage {
    partial class Depot {
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
            this.butInsertSQL = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.staffNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.depotTell = new System.Windows.Forms.TextBox();
            this.depotCapacity = new System.Windows.Forms.TextBox();
            this.depotNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.butCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butDelete = new System.Windows.Forms.Button();
            this.checkDepotNum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.getDepotMessage = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.setDepotMessage = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDepotMessage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setDepotMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("仿宋", 23F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(581, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(345, 39);
            this.label6.TabIndex = 15;
            this.label6.Text = "仓库信息管理系统";
            // 
            // butInsertSQL
            // 
            this.butInsertSQL.Font = new System.Drawing.Font("宋体", 9F);
            this.butInsertSQL.Location = new System.Drawing.Point(1365, 187);
            this.butInsertSQL.Name = "butInsertSQL";
            this.butInsertSQL.Size = new System.Drawing.Size(125, 31);
            this.butInsertSQL.TabIndex = 7;
            this.butInsertSQL.Text = "插入到数据库";
            this.butInsertSQL.UseVisualStyleBackColor = true;
            this.butInsertSQL.Click += new System.EventHandler(this.butInsertSQL_Click);
            // 
            // butAdd
            // 
            this.butAdd.Font = new System.Drawing.Font("宋体", 9F);
            this.butAdd.Location = new System.Drawing.Point(554, 149);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 32);
            this.butAdd.TabIndex = 4;
            this.butAdd.Text = "添  加";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // staffNum
            // 
            this.staffNum.Font = new System.Drawing.Font("宋体", 9F);
            this.staffNum.Location = new System.Drawing.Point(168, 102);
            this.staffNum.Name = "staffNum";
            this.staffNum.Size = new System.Drawing.Size(200, 25);
            this.staffNum.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(64, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "管理员编号：";
            // 
            // depotTell
            // 
            this.depotTell.Font = new System.Drawing.Font("宋体", 9F);
            this.depotTell.Location = new System.Drawing.Point(554, 102);
            this.depotTell.Name = "depotTell";
            this.depotTell.Size = new System.Drawing.Size(200, 25);
            this.depotTell.TabIndex = 3;
            // 
            // depotCapacity
            // 
            this.depotCapacity.Font = new System.Drawing.Font("宋体", 9F);
            this.depotCapacity.Location = new System.Drawing.Point(554, 42);
            this.depotCapacity.Name = "depotCapacity";
            this.depotCapacity.Size = new System.Drawing.Size(200, 25);
            this.depotCapacity.TabIndex = 1;
            // 
            // depotNum
            // 
            this.depotNum.Font = new System.Drawing.Font("宋体", 9F);
            this.depotNum.Location = new System.Drawing.Point(168, 42);
            this.depotNum.Name = "depotNum";
            this.depotNum.Size = new System.Drawing.Size(200, 25);
            this.depotNum.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.Location = new System.Drawing.Point(450, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "仓库容量：";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(450, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "联系电话：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(64, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库编号：";
            // 
            // butDelete
            // 
            this.butDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butDelete.Font = new System.Drawing.Font("宋体", 9F);
            this.butDelete.Location = new System.Drawing.Point(438, 286);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(116, 27);
            this.butDelete.TabIndex = 2;
            this.butDelete.Text = "删除此仓库";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // checkDepotNum
            // 
            this.checkDepotNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkDepotNum.Font = new System.Drawing.Font("宋体", 9F);
            this.checkDepotNum.Location = new System.Drawing.Point(170, 287);
            this.checkDepotNum.Name = "checkDepotNum";
            this.checkDepotNum.Size = new System.Drawing.Size(159, 25);
            this.checkDepotNum.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.getDepotMessage);
            this.groupBox2.Controls.Add(this.butDelete);
            this.groupBox2.Controls.Add(this.checkDepotNum);
            this.groupBox2.Controls.Add(this.butCheck);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 11F);
            this.groupBox2.Location = new System.Drawing.Point(11, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1510, 325);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "仓库信息检索";
            // 
            // getDepotMessage
            // 
            this.getDepotMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.getDepotMessage.BackgroundColor = System.Drawing.Color.White;
            this.getDepotMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getDepotMessage.Location = new System.Drawing.Point(17, 30);
            this.getDepotMessage.Name = "getDepotMessage";
            this.getDepotMessage.RowHeadersWidth = 51;
            this.getDepotMessage.RowTemplate.Height = 27;
            this.getDepotMessage.Size = new System.Drawing.Size(1475, 236);
            this.getDepotMessage.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F);
            this.label7.Location = new System.Drawing.Point(72, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "仓库编号：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.butCancel);
            this.groupBox1.Controls.Add(this.setDepotMessage);
            this.groupBox1.Controls.Add(this.staffNum);
            this.groupBox1.Controls.Add(this.butInsertSQL);
            this.groupBox1.Controls.Add(this.butAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.depotTell);
            this.groupBox1.Controls.Add(this.depotCapacity);
            this.groupBox1.Controls.Add(this.depotNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 11F);
            this.groupBox1.Location = new System.Drawing.Point(11, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1510, 222);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "仓库信息插入";
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Font = new System.Drawing.Font("宋体", 9F);
            this.butCancel.Location = new System.Drawing.Point(679, 149);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 32);
            this.butCancel.TabIndex = 5;
            this.butCancel.Text = "撤  销";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // setDepotMessage
            // 
            this.setDepotMessage.BackgroundColor = System.Drawing.Color.White;
            this.setDepotMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.setDepotMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.setDepotMessage.Location = new System.Drawing.Point(826, 31);
            this.setDepotMessage.Name = "setDepotMessage";
            this.setDepotMessage.RowHeadersWidth = 51;
            this.setDepotMessage.RowTemplate.Height = 27;
            this.setDepotMessage.Size = new System.Drawing.Size(664, 150);
            this.setDepotMessage.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "仓库编号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "仓库容量";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "管理员编号";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "联系电话";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Depot
            // 
            this.AcceptButton = this.butAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Depot";
            this.Text = "Depot";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDepotMessage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setDepotMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butInsertSQL;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.TextBox staffNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox depotTell;
        private System.Windows.Forms.TextBox depotCapacity;
        private System.Windows.Forms.TextBox depotNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.TextBox checkDepotNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView getDepotMessage;
        private System.Windows.Forms.DataGridView setDepotMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button butCancel;
    }
}