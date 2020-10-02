using Database.MainForm;
using Database.MainForm.GetMessage;
using System;
using System.Windows.Forms;

namespace Database {
    public partial class Manage : Form {
        public Manage() {
            InitializeComponent();
        }
        /**
         * 退出系统菜单按钮点击事件
         */
        private void exitSys_Click(object sender, EventArgs e) {
            if (MessageBox.Show("确定要退出系统吗?", "退出系统", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                SysForms.SysForms.login.Close();
                SysForms.SysForms.login = null;
            }
        }
        /**
         * 注销登录菜单按钮点击事件
         */
        private void exitLogIn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("即将注销你的登录!", "注销", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                SetVisibleCore(false);
                SysForms.SysForms.login.Show();
            }
        }
        /**
         * 主窗体的Closing事件
         */
        private void Manage_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("确定要退出系统吗?", "退出系统", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
                e.Cancel = true;
            } else {
                SysForms.SysForms.login.Close();
                SysForms.SysForms.login = null;
            }
        }
        /**
         * 药品订单菜单按钮点击事件
         */
        private void order_Click(object sender, EventArgs e) {
            Drug drug = new Drug();
            drug.MdiParent = this;
            drug.Dock = DockStyle.Fill;
            drug.Show();
        }
        /**
         * 员工管理菜单按钮点击事件
         */
        private void staff_Click(object sender, EventArgs e) {
            Staff staff = new Staff();
            staff.MdiParent = this;
            staff.Dock = DockStyle.Fill;
            staff.Show();
        }
        /**
         * 供应商信息检索菜单按钮点击事件
         */
        private void supplier_Click(object sender, EventArgs e) {
            Supplier supplier = new Supplier();
            supplier.MdiParent = this;
            supplier.Dock = DockStyle.Fill;
            supplier.Show();
        }
        /**
         * 客户信息检索菜单按钮点击事件
         */
        private void customer_Click(object sender, EventArgs e) {
            Customer customer = new Customer();
            customer.MdiParent = this;
            customer.Dock = DockStyle.Fill;
            customer.Show();
        }
        /**
         * 仓库信息管理菜单按钮点击事件
         */
        private void depot_Click(object sender, EventArgs e) {
            Depot depot = new Depot();
            depot.MdiParent = this;
            depot.Dock = DockStyle.Fill;
            depot.Show();
        }
        /**
         * 进货管理菜单按钮点击事件
         */
        private void purchase_Click(object sender, EventArgs e) {
            Purchase purchase = new Purchase();
            purchase.MdiParent = this;
            purchase.Dock = DockStyle.Fill;
            purchase.Show();
        }
        /**
         * 修改密码菜单按钮点击事件
         */
        private void changePaswd_Click(object sender, EventArgs e) {
            new ChangePassword().Show();
        }

        private void checkAccount_Click(object sender, EventArgs e) {
            Account account = new Account();
            account.MdiParent = this;
            account.Dock = DockStyle.Fill;
            account.Show();
        }

    }
}
