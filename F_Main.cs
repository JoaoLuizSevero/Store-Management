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

        //private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
        //    OpenForm(2, f_GestaoUsuarios);
        //}

        //private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    F_NovoAluno f_NovoAluno = new F_NovoAluno();
        //    OpenForm(1, f_NovoAluno);
        //}

        //private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    F_Horarios f_Horarios = new F_Horarios();
        //    OpenForm(2, f_Horarios);
        //}

        //private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    F_GestaoProfessores f_GestaoProfessores = new F_GestaoProfessores();
        //    OpenForm(2, f_GestaoProfessores);
        //}



        //private void gestãoDeTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    F_GestaoTurmas f_GestaoTurmas = new F_GestaoTurmas();
        //    OpenForm(2, f_GestaoTurmas);
        //}

        //private void gestãoDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    F_GestaoAlunos f_GestaoAlunos = new F_GestaoAlunos();
        //    OpenForm(1, f_GestaoAlunos);
        //}
    }
}
