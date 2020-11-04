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
    public partial class F_NewUser : Form
    {
        string id;
        public F_NewUser(string incomingId)
        {
            InitializeComponent();
            id = incomingId;
        }

        private void F_NewUser_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> accessType = new Dictionary<string, string>();
            accessType.Add("0", "Intern");
            accessType.Add("1", "Operator");
            accessType.Add("2", "Supervisor");
            accessType.Add("3", "Manager");
            cb_accessLevel.Items.Clear();
            cb_accessLevel.DataSource = new BindingSource(accessType, null);
            cb_accessLevel.DisplayMember = "Value";
            cb_accessLevel.ValueMember = "Key";

            if (id != "new")
            {
                this.Text = "Edit user";
                DataTable table = new DataTable();
                table = Db.GetPerId(Int32.Parse(id), "users");
                tb_name.Text = table.Rows[0].Field<string>("T_NAME");
                tb_username.Text = table.Rows[0].Field<string>("T_USERNAME");
                tb_password.Text = table.Rows[0].Field<string>("T_PASSWORD");
                cb_accessLevel.SelectedValue = table.Rows[0].Field<Int64>("N_ACCESSLEVEL").ToString();
                pb_photo.ImageLocation = table.Rows[0].Field<string>("T_PHOTO");
            }
            else
            {
                btn_save.Enabled = false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (verifyInput(tb_username.Text, tb_username) || verifyInput(tb_password.Text, tb_password))
            {
                return;
            }
            User thisUser = new User();
            thisUser.name = tb_name.Text;
            thisUser.username = tb_username.Text;
            thisUser.password = tb_password.Text;
            thisUser.accessLevel = Convert.ToInt32(cb_accessLevel.SelectedValue);
            thisUser.photo = pb_photo.ImageLocation;
            if(pb_photo.ImageLocation == "" || pb_photo.ImageLocation == null)
            {
                if (MessageBox.Show("No photo added! \nProceed?", "No photo added", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            if (id != "new")
            {
                Db.SaveUser(thisUser,id);
            }
            else
            {
                Db.SaveUser(thisUser,null);
            }
            btn_cancel_Click(this, null);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
            tb_username.Clear();
            tb_password.Clear();
            cb_accessLevel.SelectedValue = 0;
            pb_photo.ImageLocation = null;
            Close();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
            tb_username.Clear();
            tb_password.Clear();
            cb_accessLevel.SelectedValue = 0;
            pb_photo.Image = null;
        }

        private void btn_addPhoto_Click(object sender, EventArgs e)
        {
            this.pickPhoto.Title = "Choose a photo";
            pickPhoto.FileName = "";
            pickPhoto.InitialDirectory = @"Desktop";
            pickPhoto.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (pickPhoto.ShowDialog() == DialogResult.OK)
            {
                pb_photo.ImageLocation = pickPhoto.FileName;
            }
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            validateSaveButton();
        }
        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            validateSaveButton();
        }
        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            validateSaveButton();
        }

        private void validateSaveButton()
        {
            if (tb_name.Text != "" && tb_username.Text != "" && tb_password.Text != "")
            {
                btn_save.Enabled = true;
            }
            else
            {
                btn_save.Enabled = false;
            }
        }

        private bool verifyInput(string content, TextBox input)
        {
            if (content.Contains(" "))
            {
                MessageBox.Show("'Spaces' are not alowed!");
                input.Focus();
                return true;
            }
            return false;
        }

        
    }
}
