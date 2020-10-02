using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database.MainForm.GetMessage {
    public partial class Supplier : Form {
        public Supplier() {
            InitializeComponent();
        }
        private int index = -1;
        private bool flag = false;
        private void butAdd_Click(object sender, EventArgs e) {
            string[] values = { supplierNum.Text, supplierName.Text, supplierTell.Text, supplierAddress.Text };
            if (InformationManage.isEmpty(values)) {
                flag = true;
                index = setSupplierMessage.Rows.Add();
                InformationManage.insert(values, setSupplierMessage, index);
            } else {
                MessageBox.Show("请将信息填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void butCancel_Click(object sender, EventArgs e) {
            if (index <= 0) {
                flag = false;
                InformationManage.clear(setSupplierMessage);
            } else {
                InformationManage.remove(setSupplierMessage, index);
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
                        new SqlParameter("@SupplierNum", SqlDbType.Char),
                        new SqlParameter("@SupplierName", SqlDbType.Char),
                        new SqlParameter("@SupplierTell", SqlDbType.Char),
                        new SqlParameter("@SupplierAdress", SqlDbType.Char)
                    };
                    for (int j = 0; j < 4; j++) {
                        paraValues[j].Value = setSupplierMessage.Rows[i].Cells[j].Value.ToString();
                    }
                    temp = Manipulation.Manipulation.insertStoredProcedure("Insert_Supplier", paraValues);
                }
                if (temp) {
                    MessageBox.Show("所有数据插入成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                InformationManage.clear(setSupplierMessage);
            }
            
        }

        private void butCheck_Click(object sender, EventArgs e) {
            if (checkSupplierNum.Text.Equals("")) {
                MessageBox.Show("供应商编号不可为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                DataTable data;
                SqlParameter paraValues = new SqlParameter("@SupplierNum", SqlDbType.Char);
                paraValues.Value = checkSupplierNum.Text;
                data = Manipulation.Manipulation.readStoredProcedure("Find_Sipplier", paraValues);
                getSupplierMessage.DataSource = data;
            }
        }

        private void butDelete_Click(object sender, EventArgs e) {
            if (!checkSupplierNum.Text.Equals("")) {
                bool temp;
                SqlParameter paraValues = new SqlParameter("@SupplierNum", SqlDbType.Char);
                paraValues.Value = checkSupplierNum.Text;
                temp = Manipulation.Manipulation.deleteStoredProcedure("Out_Supplier", paraValues);
                if (temp) {
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
