using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database.MainForm.GetMessage {
    public partial class Customer : Form {
        private bool flag = false;
        private int index = -1;
        public Customer() {
            InitializeComponent();
        }
        private void butAdd_Click(object sender, EventArgs e) {
            string[] values = { cusNum.Text, cusName.Text, cusTell.Text };
            if (InformationManage.isEmpty(values)) {
                index = setCusMessage.Rows.Add();
                flag = true;
                InformationManage.insert(values, setCusMessage, index);
            } else {
                MessageBox.Show("请将信息填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void butCancel_Click(object sender, EventArgs e) {
            if (index <= 0) {
                InformationManage.clear(setCusMessage);
                flag = false;
            } else {
                InformationManage.remove(setCusMessage, index);
                index--;
            }
        }

        private void butInsertSQL_Click(object sender, EventArgs e) {
            if (!flag) {
                MessageBox.Show("待插入的数据为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                bool temp = false;
                for (int i = 0; i <= index; i++) {
                    SqlParameter[] paraValues = {
                        new SqlParameter("@CustomerNum", SqlDbType.Char),
                        new SqlParameter("@CustomerName", SqlDbType.Char),
                        new SqlParameter("@CustomerTell", SqlDbType.Char)
                    };
                    for (int j = 0; j < 3; j++) {
                        paraValues[j].Value = setCusMessage.Rows[i].Cells[j].Value.ToString();
                    }
                    temp = Manipulation.Manipulation.insertStoredProcedure("Insert_Customer", paraValues);
                }
                if (temp) {
                    MessageBox.Show("所有数据插入成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                InformationManage.clear(setCusMessage);
            }
        }

        private void butCheck_Click(object sender, EventArgs e) {
            if (checkStaffNum.Text.Equals("")) {
                MessageBox.Show("员工编号不可为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                SqlParameter paraValues = new SqlParameter("@CustomerNum", SqlDbType.Char);
                paraValues.Value = checkStaffNum.Text;
                DataTable data = Manipulation.Manipulation.readStoredProcedure("Find_Customer", paraValues);
                getCusMessage.DataSource = data;
            }
        }

        private void butDelete_Click(object sender, EventArgs e) {
            if (!checkStaffNum.Text.Equals("")) {
                bool temp;
                SqlParameter paraValues = new SqlParameter("@CustomerNum", SqlDbType.Char);
                paraValues.Value = checkStaffNum.Text;
                temp = Manipulation.Manipulation.deleteStoredProcedure("Out_Customer", paraValues);
                if (temp) {
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}