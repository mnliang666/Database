using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database.MainForm.GetMessage {
    public partial class Staff : Form {
        public Staff() {
            InitializeComponent();
        }
        private int index = -1;
        private bool flag = false; 
        private void butAdd_Click(object sender, EventArgs e) {
            string sex = "";
            if (radioMan.Checked) {
                sex = "男";
            }
            if (radioWom.Checked) {
                sex = "女";
            }
            string[] values = { staffNum.Text, staffName.Text, sex, staffTime.Value.ToString(), staffDuty.Text };
            if (InformationManage.isEmpty(values)) {
                flag = true;
                index = setStaffMessage.Rows.Add();
                InformationManage.insert(values, setStaffMessage, index);
            } else {
                MessageBox.Show("请将信息填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butCancel_Click(object sender, EventArgs e) {
            if (index <= 0) {
                flag = false;
                InformationManage.clear(setStaffMessage);
            } else {
                InformationManage.remove(setStaffMessage, index);
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
                        new SqlParameter("@StaffNum", SqlDbType.Char),
                        new SqlParameter("@StaffName", SqlDbType.Char),
                        new SqlParameter("@StaffSex", SqlDbType.Char),
                        new SqlParameter("@StaffTime", SqlDbType.DateTime),
                        new SqlParameter("@StaffDuty", SqlDbType.Char)
                    };
                    for (int j = 0; j < 5; j++) {
                        paraValues[j].Value = setStaffMessage.Rows[i].Cells[j].Value.ToString();
                    }
                    temp = Manipulation.Manipulation.insertStoredProcedure("Insert_Staff", paraValues);
                }
                if (temp) {
                    MessageBox.Show("所有数据插入成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                InformationManage.clear(setStaffMessage);
            }
        }

        private void butCheck_Click(object sender, EventArgs e) {
            if (checkStaffNum.Text.Equals("")) {
                MessageBox.Show("员工编号不可为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                DataTable data;
                SqlParameter paraValues = new SqlParameter("@StaffNum", SqlDbType.Char);
                paraValues.Value = checkStaffNum.Text;
                data = Manipulation.Manipulation.readStoredProcedure("Find_Staff", paraValues);
                getStaffMessage.DataSource = data;
            }
        }

        private void butDelete_Click(object sender, EventArgs e) {
            if (!checkStaffNum.Text.Equals("")) {
                bool temp;
                SqlParameter paraValues = new SqlParameter("@StaffNum", SqlDbType.Char);
                paraValues.Value = checkStaffNum.Text;
                temp = Manipulation.Manipulation.deleteStoredProcedure("Out_Staff", paraValues);
                if (temp) {
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
