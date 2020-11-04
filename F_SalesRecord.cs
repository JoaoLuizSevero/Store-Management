using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class F_SalesRecord : Form
    {
        StringReader reader;

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

        private void btn_find_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_sales.Rows)
            {
                if (row.Cells[0].Value.ToString() == ntb_id.Value.ToString())
                {
                    dgv_sales.Rows[row.Index].Selected = true;
                    return;
                }
            }
            MessageBox.Show("Can't find current ID!");
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintVoucher(dgv_sales.Rows[dgv_sales.CurrentCell.RowIndex].Cells[4].Value.ToString());
        }

        private void PrintVoucher(string content)
        {
            printDialog.Document = printDocument;
            printDialog.Document.DocumentName = "voucher-" + dgv_sales.Rows[dgv_sales.CurrentCell.RowIndex].Cells[0].Value.ToString();
            reader = new StringReader(content);
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float marginLeft = e.MarginBounds.Left - 50;
            float marginTop = e.MarginBounds.Top - 50;
            if (marginLeft < 5) marginLeft = 20;
            if (marginTop < 5) marginTop = 20;
            Font contentFont = new Font("TimesNewRoman", 10);
            SolidBrush pen = new SolidBrush(Color.Black);
            string line = reader.ReadLine();
            int cont = 0;
            while (line != null)
            {
                float Y = marginTop + (cont * contentFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(line, contentFont, pen, marginLeft, Y, new StringFormat());
                cont++;
                line = reader.ReadLine();
            }
            pen.Dispose();
        }

    }
}
