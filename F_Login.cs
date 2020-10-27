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
    public partial class F_Login : Form
    {
        F_Main formMain;

        public F_Login(F_Main f)
        {
            InitializeComponent();
            formMain = f;
            btn_login.Enabled = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            if (verifyInput(username, tb_username) || verifyInput(password, tb_password))
            {
                return;
            }
            DataTable dataUser = Db.GetUser(username,password);
            if (dataUser.Rows.Count == 1)
            {
                formMain.lb_user.Text = dataUser.Rows[0].Field<string>("T_USERNAME");
                Globals.accessLevel = int.Parse(dataUser.Rows[0].Field<Int64>("N_ACCESSLEVEL").ToString());
                Globals.isLogged = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Cannot find user "+ username + "!");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_username.Clear();
            tb_password.Clear();
            this.Close();
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            validateLoginButton();
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            validateLoginButton();
        }

        private void validateLoginButton()
        {
            if(tb_username.Text != "" && tb_password.Text != "")
            {
                btn_login.Enabled = true;
            }
            else
            {
                btn_login.Enabled = false;
            }
        }
        private bool verifyInput(string content, TextBox input)
        {
            if (content.Contains(" "))
            {
                MessageBox.Show("Spaces are not alowed!");
                input.Focus();
                return true;
            }
            return false;
        }
    }
}
