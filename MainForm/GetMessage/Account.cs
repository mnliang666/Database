using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database.MainForm.GetMessage {
    public partial class Account : Form {
        public Account() {
            InitializeComponent();
        }

        private void butCheck_Click_1(object sender, EventArgs e) {
            DataTable buyDataTable,sellDataTable;
            if (!(stateTime.Value < endTime.Value)) {
                MessageBox.Show("日期选择错误，起始时间应不大于终止时间！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                SqlParameter[] buyParaValues = { 
                    new SqlParameter("@StateTime", SqlDbType.DateTime),
                    new SqlParameter("@EndTime", SqlDbType.DateTime)
                };
                buyParaValues[0].Value = stateTime.Value.ToString();
                buyParaValues[1].Value = endTime.Value.ToString();
                buyDataTable = Manipulation.Manipulation.readStoredProcedure("Sum_Buy", buyParaValues);
                buyData.DataSource = buyDataTable;
                SqlParameter[] sellParaValues = {
                    new SqlParameter("@StateTime", SqlDbType.DateTime),
                    new SqlParameter("@EndTime", SqlDbType.DateTime)
                };
                sellParaValues[0].Value = stateTime.Value.ToString();
                sellParaValues[1].Value = endTime.Value.ToString();
                sellDataTable = Manipulation.Manipulation.readStoredProcedure("Sum_Sell", sellParaValues);
                sellData.DataSource = sellDataTable;
                sum.Text = sumText(buyDataTable,sellDataTable);
            }
            
        }
        private float getSumMoney(DataTable data) {
            float sum = 0;
            for(int i = 0; i < data.Rows.Count; i++) {
                sum += float.Parse(data.Rows[i][2].ToString()) * float.Parse(data.Rows[i][3].ToString());
            }
            return sum;
        }
        private String sumText(DataTable buyDataTable,DataTable sellDataTable) {
            float buy = getSumMoney(buyDataTable);
            float sell = getSumMoney(sellDataTable);
            Console.WriteLine(buy + "  " + sell);
            return String.Format("总支出{0}元  总收入{1}元  总利润{2}元", buy, sell, sell - buy);
        }
    }
}
