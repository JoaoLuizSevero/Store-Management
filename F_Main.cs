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
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }

        private void OpenForm(int requiredLevel, Form f)
        {
            if (Globals.isLogged)
            {
                if (Globals.accessLevel >= requiredLevel)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Access denied!");
                }
            }
            else
            {
                MessageBox.Show("Login required!");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }                
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (Globals.isLogged)
            {
                if (MessageBox.Show("User already logged in! \nDo you want logoff?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lb_user.Text = "";
                    lb_function.Text = "";
                    pb_photo.Image = null;
                    Globals.accessLevel = 0;
                    Globals.userLogged = "";
                    Globals.isLogged = false;
                    F_Login f_Login = new F_Login(this);
                    f_Login.ShowDialog();
                }
                else
                {
                    return;
                }
            }
            else
            {
                F_Login f_Login = new F_Login(this);
                f_Login.ShowDialog();
            }
        }

        private void btn_logoff_Click(object sender, EventArgs e)
        {
            if(Globals.isLogged == false)
            {
                MessageBox.Show("No user logged in!");
                return;
            }
            lb_user.Text = "";
            lb_function.Text = "";
            pb_photo.Image = null;
            Globals.accessLevel = 0;
            Globals.isLogged = false;
            Globals.userLogged = "";
            MessageBox.Show("user logged off!");
        }

        private void btn_userManagement_Click(object sender, EventArgs e)
        {
            F_UserManagement f_UserManagement = new F_UserManagement();
            OpenForm(3, f_UserManagement);
        }

        private void btn_itemManagement_Click(object sender, EventArgs e)
        {
            F_ItemManagement f_ItemManagement = new F_ItemManagement();
            OpenForm(2, f_ItemManagement);
        }

        private void btn_salesManagement_Click(object sender, EventArgs e)
        {
            F_SalesManagement f_SalesManagement = new F_SalesManagement();
            OpenForm(0, f_SalesManagement);
        }

        private void btn_salesRecord_Click(object sender, EventArgs e)
        {
            F_SalesRecord f_SalesRecord = new F_SalesRecord();
            OpenForm(1, f_SalesRecord);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://www.instagram.com/visual.cult/?hl=pt-br");
        }
    }
}
