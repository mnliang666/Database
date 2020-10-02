using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database.MainForm {
    public partial class ChangePassword : Form {
        public ChangePassword() {
            InitializeComponent();
        }
        private SqlConnection sqlConnection;
        private void butCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void butCon_Click(object sender, EventArgs e) {
            string queryLanguage = String.Format("SELECT Pasword FROM [Account] WHERE ID = '{0}'", account.Text);
            if (account.Text == "" || oldPassword.Text == "" || newPassword.Text == "" || confirmPassword.Text == "") {
                MessageBox.Show("请将信息填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (newPassword.Text != confirmPassword.Text) {
                MessageBox.Show("密码不一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                sqlConnection = Connect.Connect.connectSql();
                if (sqlConnection != null) {
                    Connect.Connect.openSql(sqlConnection);
                }
                SqlDataReader reader = Manipulation.Manipulation.query(queryLanguage, sqlConnection);
                if (reader.Read()) {
                    if (oldPassword.Text == reader.GetString(0).Trim()) {
                        SqlConnection connection = Connect.Connect.connectSql();
                        Connect.Connect.openSql(connection);
                        string updateLanguage = String.Format("UPDATE Account SET Pasword = '{0}' WHERE ID = '{1}'", newPassword.Text, account.Text);
                        if (Manipulation.Manipulation.update(updateLanguage, connection)) {
                            MessageBox.Show("密码修改成功,请重新登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        } else {
                            MessageBox.Show("密码修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    } else {
                        MessageBox.Show("旧密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else {
                    MessageBox.Show("账号错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                reader.Close();
                Connect.Connect.closeSql(sqlConnection);
                SysForms.SysForms.manage.Visible = false;
                SysForms.SysForms.login.Visible = true;
            }
        }
    }
}
