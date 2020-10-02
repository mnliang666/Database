using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database.Connect {
    class Connect {
        private const string CONNECT = @"Data Source = .\SQLEXPRESS;Initial Catalog = TEST;Integrated Security = true";
        /**
         * 连接数据库
         */
        public static SqlConnection connectSql() {
            try {
                return new SqlConnection(CONNECT);
            }catch(Exception e) {
                MessageBox.Show("连接数据库失败!\n" + e.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        /**
         * 打开数据库
         */
        public static Boolean openSql(SqlConnection sqlConnection) {
            try {
                sqlConnection.Open();
                return true;
            } catch (Exception e) {
                MessageBox.Show("打开数据库失败!\n" + e.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /**
         * 关闭数据库
         */
        public static Boolean closeSql(SqlConnection sqlConnection) {
            try {
                sqlConnection.Close();
                return true;
            }catch(Exception e) {
                MessageBox.Show("关闭数据库失败!\n" + e.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
