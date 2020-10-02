using System;
using System.Windows.Forms;

namespace Database.MainForm.GetMessage {
    class InformationManage {
        /**
         * 插入
         */
        public static void insert(string[] values,DataGridView view,int index) {
            for (int i = 0; i < values.Length; i++) {
                view.Rows[index].Cells[i].Value = values[i];
            }
        }
        /**
         * 移除
         */
        public static void remove(DataGridView view, int index) {
            if (index >= 0) {
                view.Rows.Remove(view.Rows.SharedRow(index));
            }
        }
        /**
         * 清空内容
         */
        public static void clear(DataGridView view) {
            view.Rows.Clear();
        }
        /**
         * 判断是否为空
         */
        public static Boolean isEmpty(string[] values) {
            foreach(string value in values) {
                if (value.Equals("")) {
                    return false;
                }
            }
            return true;
        }
    }
}
