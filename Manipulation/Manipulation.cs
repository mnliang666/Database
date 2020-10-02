using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database.Manipulation {
    /**
     * 数据库操作类，对数据库查询、更新、删除等操作
     */
    class Manipulation {
        /**
         * 查询函数，返回SqlCommand对象
         */
        public static SqlDataReader query(string queryLanguage, SqlConnection sqlConnection) {
            return (new SqlCommand(queryLanguage, sqlConnection)).ExecuteReader();
        }
        /**
         * 更新函数，用于更新数据库的数据
         */
        public static Boolean update(string updateLanguage, SqlConnection sqlConnection) {
            SqlCommand command = new SqlCommand(updateLanguage, sqlConnection);
            int n = command.ExecuteNonQuery();
            if (n > 0) {
                return true;
            } else {
                return false;
            }
        }
        /**
         * 调用存储过程函数，插入数据
         */
        public static Boolean insertStoredProcedure(string strProcName, params object[] paraValues) {
            SqlConnection sqlConnection = Connect.Connect.connectSql();
            try {
                SqlCommand command = new SqlCommand(strProcName,sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                Connect.Connect.openSql(sqlConnection);
                if (paraValues != null) {
                    command.Parameters.AddRange(paraValues);
                }
                if (command.ExecuteNonQuery() > 0) {
                    return true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Connect.Connect.closeSql(sqlConnection);
            }
            return false;
        }

        /**
         * 调用存储过程函数，得到数据
         */
        public static DataTable readStoredProcedure(string strProcName, params object[] paraValues) {
            SqlConnection sqlConnection = Connect.Connect.connectSql();
            DataTable data = new DataTable();
            try {
                SqlCommand command = new SqlCommand(strProcName,sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                Connect.Connect.openSql(sqlConnection);
                if (paraValues != null) {
                    command.Parameters.AddRange(paraValues);
                }
                using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
                    adapter.Fill(data);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Connect.Connect.closeSql(sqlConnection);
            }
            return data;
        }
        /**
         * 调用存储过程函数，删除数据
         */
        public static Boolean deleteStoredProcedure(string strProcName, params object[] paraValues) {
            SqlConnection sqlConnection = Connect.Connect.connectSql();
            try {
                SqlCommand command = new SqlCommand(strProcName, sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                Connect.Connect.openSql(sqlConnection);
                if (paraValues != null) {
                    command.Parameters.AddRange(paraValues);
                }
                if (command.ExecuteNonQuery() > 0) {
                    return true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                Connect.Connect.closeSql(sqlConnection);
            }
            return false;
        }
    }
}