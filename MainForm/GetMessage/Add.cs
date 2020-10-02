using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database.MainForm.GetMessage {
    class Add {
        public static void insert(string[] values,DataGridView view) {
            int index = view.Rows.Add();
            for (int i = 0; i < values.Length; i++) {
                view.Rows[index].Cells[i].Value = values[i];
            }
        }
    }
}
