using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database.MainForm.GetMessage {
    public partial class Drug : Form {
        public Drug() {
            InitializeComponent();
        }
        private int index = -1;
        private bool flag = false;
        /**
         * 加入按钮点击事件
         */
        private void butAdd_Click(object sender, System.EventArgs e) {
            string[] values = { drugNum.Text, customerNum.Text, drugPrice.Text, supplyNum.Text, orderTime.Value.ToString() };
            if (InformationManage.isEmpty(values)) {
                index = setDrugMessage.Rows.Add();
                flag = true;
                InformationManage.insert(values, setDrugMessage, index);
            } else {
                MessageBox.Show("请将信息填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /**
         * 撤销按钮点击事件
         */
        private void butCancel_Click(object sender, System.EventArgs e) {
            if (index <= 0) {
                flag = false;
                InformationManage.clear(setDrugMessage);
            } else {
                InformationManage.remove(setDrugMessage, index);
                index--;
            }
        }
        /**
         * 插入数据库按钮点击事件
         */
        private void butInsertSQL_Click(object sender, System.EventArgs e) {
            if (!flag) {
                MessageBox.Show("待插入的数据为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                bool temp = false;
                for (int i = 0; i <= index; i++) {
                    SqlParameter[] insertParaValues = {
                        new SqlParameter("@DrugNum", SqlDbType.Char),
                        new SqlParameter("@CustomerNum", SqlDbType.Char),
                        new SqlParameter("@DemandPrice", SqlDbType.Real),
                        new SqlParameter("@DemandNum", SqlDbType.Int),
                        new SqlParameter("@DamandTime", SqlDbType.DateTime),
                };
                    for (int j = 0; j < 5; j++) {
                        insertParaValues[j].Value = setDrugMessage.Rows[i].Cells[j].Value.ToString();
                    }
                    temp = Manipulation.Manipulation.insertStoredProcedure("Insert_DemandShip", insertParaValues);
                    if (temp) {
                        SqlParameter[] MinusParaValues = {
                        new SqlParameter("@DrugNum", SqlDbType.Char),
                        new SqlParameter("@DemandNum", SqlDbType.Int)
                    };
                        MinusParaValues[0].Value = setDrugMessage.Rows[i].Cells[0].Value.ToString();
                        MinusParaValues[1].Value = setDrugMessage.Rows[i].Cells[3].Value.ToString();
                        Manipulation.Manipulation.insertStoredProcedure("Minus_Drug", MinusParaValues);
                        temp = false;
                    }
                }
                if (temp) {
                    MessageBox.Show("所有数据插入成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                InformationManage.clear(setDrugMessage);
            }
            
        }
        /**
         * 检索按钮点击事件
         */
        private void butCheck_Click(object sender, System.EventArgs e) {
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
