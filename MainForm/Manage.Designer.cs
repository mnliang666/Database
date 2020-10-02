namespace Database {
    partial class Manage {
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
            this.components = new System.ComponentModel.Container();
            this.systemMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.order = new System.Windows.Forms.ToolStripMenuItem();
            this.信息检索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staff = new System.Windows.Forms.ToolStripMenuItem();
            this.customer = new System.Windows.Forms.ToolStripMenuItem();
            this.depot = new System.Windows.Forms.ToolStripMenuItem();
            this.supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.出库登记CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchase = new System.Windows.Forms.ToolStripMenuItem();
            this.账目查询LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.个人中心PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePaswd = new System.Windows.Forms.ToolStripMenuItem();
            this.exitLogIn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSys = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // systemMenu
            // 
            this.systemMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.systemMenu.Name = "contextMenuStrip1";
            this.systemMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.信息检索ToolStripMenuItem,
            this.出库登记CToolStripMenuItem,
            this.账目查询LToolStripMenuItem,
            this.个人中心PToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1702, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "系统管理";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.order});
            this.系统管理ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5F);
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.系统管理ToolStripMenuItem.Text = "销售管理(&M)";
            // 
            // order
            // 
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(158, 26);
            this.order.Text = "填写订单";
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // 信息检索ToolStripMenuItem
            // 
            this.信息检索ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staff,
            this.customer,
            this.depot,
            this.supplier});
            this.信息检索ToolStripMenuItem.Name = "信息检索ToolStripMenuItem";
            this.信息检索ToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.信息检索ToolStripMenuItem.Text = "信息管理(&S)";
            // 
            // staff
            // 
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(218, 26);
            this.staff.Text = "员工信息管理(&S)";
            this.staff.Click += new System.EventHandler(this.staff_Click);
            // 
            // customer
            // 
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(218, 26);
            this.customer.Text = "客户信息管理(&C)";
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // depot
            // 
            this.depot.Name = "depot";
            this.depot.Size = new System.Drawing.Size(218, 26);
            this.depot.Text = "仓库信息管理(&D)";
            this.depot.Click += new System.EventHandler(this.depot_Click);
            // 
            // supplier
            // 
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(218, 26);
            this.supplier.Text = "供应商信息管理(&U)";
            this.supplier.Click += new System.EventHandler(this.supplier_Click);
            // 
            // 出库登记CToolStripMenuItem
            // 
            this.出库登记CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchase});
            this.出库登记CToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5F);
            this.出库登记CToolStripMenuItem.Name = "出库登记CToolStripMenuItem";
            this.出库登记CToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.出库登记CToolStripMenuItem.Text = "入库查询(&C)";
            // 
            // purchase
            // 
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(158, 26);
            this.purchase.Text = "进货管理";
            this.purchase.Click += new System.EventHandler(this.purchase_Click);
            // 
            // 账目查询LToolStripMenuItem
            // 
            this.账目查询LToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAccount});
            this.账目查询LToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5F);
            this.账目查询LToolStripMenuItem.Name = "账目查询LToolStripMenuItem";
            this.账目查询LToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
            this.账目查询LToolStripMenuItem.Text = "账目查询(&L)";
            // 
            // checkAccount
            // 
            this.checkAccount.Name = "checkAccount";
            this.checkAccount.Size = new System.Drawing.Size(158, 26);
            this.checkAccount.Text = "账目明细";
            this.checkAccount.Click += new System.EventHandler(this.checkAccount_Click);
            // 
            // 个人中心PToolStripMenuItem
            // 
            this.个人中心PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePaswd,
            this.exitLogIn,
            this.exitSys});
            this.个人中心PToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5F);
            this.个人中心PToolStripMenuItem.Name = "个人中心PToolStripMenuItem";
            this.个人中心PToolStripMenuItem.Size = new System.Drawing.Size(108, 25);
            this.个人中心PToolStripMenuItem.Text = "个人中心(&P)";
            // 
            // changePaswd
            // 
            this.changePaswd.Name = "changePaswd";
            this.changePaswd.Size = new System.Drawing.Size(224, 26);
            this.changePaswd.Text = "修改密码(&C)";
            this.changePaswd.Click += new System.EventHandler(this.changePaswd_Click);
            // 
            // exitLogIn
            // 
            this.exitLogIn.Name = "exitLogIn";
            this.exitLogIn.Size = new System.Drawing.Size(224, 26);
            this.exitLogIn.Text = "退出登录(&E)";
            this.exitLogIn.Click += new System.EventHandler(this.exitLogIn_Click);
            // 
            // exitSys
            // 
            this.exitSys.Name = "exitSys";
            this.exitSys.Size = new System.Drawing.Size(224, 26);
            this.exitSys.Text = "退出系统(&S)";
            this.exitSys.Click += new System.EventHandler(this.exitSys_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 731);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1702, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusUser
            // 
            this.statusUser.Name = "statusUser";
            this.statusUser.Size = new System.Drawing.Size(0, 16);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1702, 753);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "江西理工大学校医院药品管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manage_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip systemMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库登记CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账目查询LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人中心PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAccount;
        private System.Windows.Forms.ToolStripMenuItem changePaswd;
        private System.Windows.Forms.ToolStripMenuItem exitSys;
        private System.Windows.Forms.ToolStripMenuItem order;
        private System.Windows.Forms.ToolStripMenuItem exitLogIn;
        private System.Windows.Forms.ToolStripMenuItem 信息检索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staff;
        private System.Windows.Forms.ToolStripMenuItem customer;
        private System.Windows.Forms.ToolStripMenuItem supplier;
        private System.Windows.Forms.ToolStripMenuItem depot;
        private System.Windows.Forms.ToolStripMenuItem purchase;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusUser;
    }
}