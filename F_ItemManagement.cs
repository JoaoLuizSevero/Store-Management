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
    public partial class F_ItemManagement : Form
    {
        public F_ItemManagement()
        {
            InitializeComponent();
        }

        private void btn_newItem_Click(object sender, EventArgs e)
        {
            F_NewItem f_NewItem = new F_NewItem("new");
            f_NewItem.ShowDialog();
            updateDgv();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateDgv()
        {
            dgv_items.DataSource = Db.GetAllItems();
        }
        private void F_ItemManagement_Load(object sender, EventArgs e)
        {
            updateDgv();
            dgv_items.Columns[0].Width = 40;
            dgv_items.Columns[1].Width = 150;
            dgv_items.Columns[2].Width = 40;
            dgv_items.Columns[3].Width = 40;
            dgv_items.Columns[4].Width = 100;
            dgv_items.Columns[5].Width = 110;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm item delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Db.Delete(dgv_items.CurrentRow.Cells[0].Value.ToString(),"items");
                dgv_items.Rows.Remove(dgv_items.CurrentRow);
                updateDgv();
            }
        }

        private void btn_editItem_Click(object sender, EventArgs e)
        {
            F_NewItem F_NewItem = new F_NewItem(dgv_items.CurrentRow.Cells[0].Value.ToString());
            F_NewItem.ShowDialog();
            updateDgv();
        }
    }
}
