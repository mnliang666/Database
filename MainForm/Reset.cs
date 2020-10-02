using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Database.MainForm {
    public partial class Reset : Form {
        public Reset() {
            InitializeComponent();
        }
        private SqlConnection sqlConnection;
        /**
         * 取消按钮点击事件
         */
        private void butCancel_Click(object sender, EventArgs e) {
            Close();
        }
        /**
         * 重置按钮点击事件
         */
        private void butReset_Click(object sender, EventArgs e) {            
            string queryLanguage = String.Format("SELECT Name FROM [Account] WHERE ID = '{0}'", account.Text);
            if (account.Text == "" || name.Text == "" || newPassword.Text == "" || confirmPassword.Text == "") {
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
                    if(name.Text == reader.GetString(0).Trim()) {
                        SqlConnection connection = Connect.Connect.connectSql();
                        Connect.Connect.openSql(connection);
                        string updateLanguage = String.Format("UPDATE Account SET Pasword = '{0}' WHERE ID = '{1}'", newPassword.Text, account.Text);
                        if (Manipulation.Manipulation.update(updateLanguage, connection)) {
                            MessageBox.Show("密码修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        } else {
                            MessageBox.Show("密码修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }    
                    } else {
                        MessageBox.Show("姓名错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else {
                    MessageBox.Show("账号错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                reader.Close();
                Connect.Connect.closeSql(sqlConnection);
            }
            
        }
    }
}
