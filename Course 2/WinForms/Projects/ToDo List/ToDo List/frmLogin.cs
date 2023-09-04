using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ToDo_List
{
    
    public partial class frmLogin : Form
    {
        private UsersFileManager jsonManager;

        public frmLogin()
        {
            InitializeComponent();

            //Создание экземпляра класса JsonFileManager с указанием пути к файлу JSON
            jsonManager = new UsersFileManager("users.json");
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (jsonManager.IsUserExists(new User(txtEmail.Text, txtPassword.Text))) // Если есть такой пользователь
            {
                new frmMain(txtEmail.Text).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void btnCreateAc_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }


        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizeWindow_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }
    }
}
