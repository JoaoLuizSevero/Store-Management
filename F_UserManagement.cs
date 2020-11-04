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
    public partial class F_UserManagement : Form
    {
        public F_UserManagement()
        {
            InitializeComponent();
        }

        private void btn_newUser_Click(object sender, EventArgs e)
        {
            F_NewUser f_NewUser = new F_NewUser("new");
            f_NewUser.ShowDialog();
            updateDgv();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateDgv()
        {
            dgv_users.DataSource = Db.GetAllUsers();
        }

        private void F_UserManagement_Load(object sender, EventArgs e)
        {
            updateDgv();
            dgv_users.Columns[0].Width = 40;
            dgv_users.Columns[1].Width = 150;
            dgv_users.Columns[2].Width = 95;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm user delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Db.Delete(dgv_users.CurrentRow.Cells[0].Value.ToString(),"users");
                dgv_users.Rows.Remove(dgv_users.CurrentRow);
                updateDgv();
            }
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {
            F_NewUser f_NewUser = new F_NewUser(dgv_users.CurrentRow.Cells[0].Value.ToString());
            f_NewUser.ShowDialog();
            updateDgv();
        }
    }
}
