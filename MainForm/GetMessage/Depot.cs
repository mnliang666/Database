using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database.MainForm.GetMessage {
    public partial class Depot : Form {
        public Depot() {
            InitializeComponent();
        }
        private int index = -1;
        private bool flag = false;
        private void butAdd_Click(object sender, EventArgs e) {
            string[] values = { depotNum.Text, depotCapacity.Text, staffNum.Text, depotTell.Text };
            if (InformationManage.isEmpty(values)) {
                index = setDepotMessage.Rows.Add();
                flag = true;
                InformationManage.insert(values, setDepotMessage, index);
            } else {
                MessageBox.Show("请将信息填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butCancel_Click(object sender, EventArgs e) {
            if (index <= 0) {
                flag = false;
                InformationManage.clear(setDepotMessage);
            } else {
                InformationManage.remove(setDepotMessage, index);
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
                        new SqlParameter("@DepotNum", SqlDbType.Char),
                        new SqlParameter("@DepotCapacity", SqlDbType.Int),
                        new SqlParameter("@StaffNum", SqlDbType.Char),
                        new SqlParameter("@DepotTell", SqlDbType.Char)
                };
                    for (int j = 0; j < 4; j++) {
                        paraValues[j].Value = setDepotMessage.Rows[i].Cells[j].Value.ToString();
                    }
                    temp = Manipulation.Manipulation.insertStoredProcedure("Insert_Depot", paraValues);
                }
                if (temp) {
                    MessageBox.Show("所有数据插入成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                InformationManage.clear(setDepotMessage);
            }
        }

        private void butCheck_Click(object sender, EventArgs e) {
            if (checkDepotNum.Text.Equals("")) {
                MessageBox.Show("仓库编号不可为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                DataTable data;
                SqlParameter paraValues = new SqlParameter("@DepotNum", SqlDbType.Char);
                paraValues.Value = checkDepotNum.Text;
                data = Manipulation.Manipulation.readStoredProcedure("Find_Depot", paraValues);
                getDepotMessage.DataSource = data;
            }
        }

        private void butDelete_Click(object sender, EventArgs e) {
            if (!checkDepotNum.Text.Equals("")) {
                bool temp;
                SqlParameter paraValues = new SqlParameter("@DepotNum", SqlDbType.Char);
                paraValues.Value = checkDepotNum.Text;
                temp = Manipulation.Manipulation.deleteStoredProcedure("Out_Depot", paraValues);
                if (temp) {
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}