using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class F_SalesRecord : Form
    {
        public F_SalesRecord()
        {
            InitializeComponent();
        }

        private void F_SalesRecord_Load(object sender, EventArgs e)
        {
            ntb_id.Controls.RemoveAt(0);
            dgv_sales.DataSource = Db.GetAllSales();
            dgv_sales.Columns[0].Width = 50;
            dgv_sales.Columns[1].Width = 150;
            dgv_sales.Columns[2].Width = 60;
            dgv_sales.Columns[3].Width = 120;
            dgv_sales.Columns[4].Width = 80;
            for (Int32 i = 0; i < dgv_sales.Rows.Count; i++)
            {
                dgv_sales.Rows[i].Cells[4] = new DataGridViewButtonCell();
            }
        }

        private void dgv_sales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                MessageBox.Show(dgv_sales.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
