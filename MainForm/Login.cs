using Database.MainForm;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }
        //数据库连接对象
        private SqlConnection sqlConnection;
        /**
         * 登录界面登录按钮点击事件
         */
        private void butLogin_Click(object sender, EventArgs e) {
            sqlConnection = Connect.Connect.connectSql();
            if (sqlConnection != null) {
                //打开数据库
                Connect.Connect.openSql(sqlConnection);
            }
            string queryLanguage = String.Format("SELECT Pasword FROM [Account] WHERE ID = '{0}'", account.Text);
            if (account.Text == "" && password.Text == "") {
                MessageBox.Show("账号密码不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (account.Text == "" && password.Text != "") {
                MessageBox.Show("账号不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (account.Text != "" && password.Text == "") {
                MessageBox.Show("密码不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                //读取内容
                SqlDataReader reader = Manipulation.Manipulation.query(queryLanguage,sqlConnection);
                if (reader.Read()) {
                    //判断密码是否匹配，如果匹配则登陆系统
                    if(password.Text.Equals(reader.GetString(0).Trim())) {
                        SysForms.SysForms.manage = new Manage();
                        SysForms.SysForms.manage.Show();
                        password.Text = "";
                        Visible = false;
                    } else {
                        MessageBox.Show("密码错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else {
                    MessageBox.Show("账号不存在!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                reader.Close();
            }
            //关闭数据库
            Connect.Connect.closeSql(sqlConnection);
        }

        /**
         * 忘记密码按钮点击事件
         */
        private void butChangePass_Click(object sender, EventArgs e) {
            new Reset().Show();
        }
    }
}
