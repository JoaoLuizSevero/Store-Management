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
        public F_NewUser()
        {
            InitializeComponent();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.name = tb_name.Text;
            newUser.username = tb_username.Text;
            newUser.password = tb_password.Text;
            newUser.accessLevel = Convert.ToInt32(nb_accessLevel.Value);
            newUser.photo = pb_photo.ImageLocation;

            Db.NewUser(newUser);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
            tb_username.Clear();
            tb_password.Clear();
            nb_accessLevel.Value = 0;
            Close();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
            tb_username.Clear();
            tb_password.Clear();
            nb_accessLevel.Value = 0;
            pb_photo.Image = null;
        }

        private void btn_addPhoto_Click(object sender, EventArgs e)
        {
            this.pickPhoto.Title = "Choose photo";
            pickPhoto.FileName = "";
            pickPhoto.InitialDirectory = @"Desktop";
            pickPhoto.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (pickPhoto.ShowDialog() == DialogResult.OK)
            {
                pb_photo.ImageLocation = pickPhoto.FileName;
            }
        }
    }
}
