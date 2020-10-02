using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database.MainForm.GetMessage {
    public partial class Purchase : Form {
        public Purchase() {
            InitializeComponent();
        }
        private int index = -1;
        private bool flag = false;
        private void butAdd_Click(object sender, EventArgs e) {
            string[] values = { drugNum.Text, drugName.Text, birthday.Value.ToString(), validity.Value.ToString(), drugFunction.Text,
                supplierNum.Text, supplierPrice.Text, supplyNum.Text, supplyTime.Value.ToString()
            };
            if (InformationManage.isEmpty(values)) {
                index = setPurchaseMessage.Rows.Add();
                flag = true;
                InformationManage.insert(values, setPurchaseMessage, index);
            } else {
                MessageBox.Show("请将信息填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void butCancel_Click(object sender, EventArgs e) {
            if (index <= 0) {
                flag = false;
                InformationManage.clear(setPurchaseMessage);
            } else {
                InformationManage.remove(setPurchaseMessage, index);
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
                        new SqlParameter("@DrugNum", SqlDbType.Char),
                        new SqlParameter("@DrugName", SqlDbType.Char),
                        new SqlParameter("@Birthday", SqlDbType.Char),
                        new SqlParameter("@Validity", SqlDbType.Char),
                        new SqlParameter("@DrugFunction", SqlDbType.Char),
                        new SqlParameter("@SupplierNum", SqlDbType.Char),
                        new SqlParameter("@SupplierPrice", SqlDbType.Char),
                        new SqlParameter("@SupplyNum", SqlDbType.Char),
                        new SqlParameter("@SupplyTime", SqlDbType.Char)
                    };
                    for (int j = 0; j < 9; j++) {
                        paraValues[j].Value = setPurchaseMessage.Rows[i].Cells[j].Value.ToString();
                    }
                    temp = Manipulation.Manipulation.insertStoredProcedure("Insert_SupplierShip", paraValues);
                    if (temp) {
                        SqlParameter[] MinusParaValues = {
                        new SqlParameter("@DrugNum", SqlDbType.Char),
                        new SqlParameter("@SupplyNum", SqlDbType.Int)
                    };
                        MinusParaValues[0].Value = setPurchaseMessage.Rows[i].Cells[0].Value.ToString();
                        MinusParaValues[1].Value = setPurchaseMessage.Rows[i].Cells[7].Value.ToString();
                        Manipulation.Manipulation.insertStoredProcedure("Add_Drug", MinusParaValues);
                        temp = false;
                    }
                }
                if (temp) {
                    MessageBox.Show("所有数据插入成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                InformationManage.clear(setPurchaseMessage);
            }
            
        }

        private void butCheck_Click(object sender, EventArgs e) {
            if (checkDrugNum.Text.Equals("")) {
                MessageBox.Show("药品名称不可为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                DataTable data;
                SqlParameter paraValues = new SqlParameter("@DrugName", SqlDbType.Char);
                paraValues.Value = checkDrugNum.Text;
                data = Manipulation.Manipulation.readStoredProcedure("Find_Buy_Drug", paraValues);
                getDrugMessage.DataSource = data;
            }
        }
    }
}
