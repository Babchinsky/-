using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_List
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" && txtPassword.Text == "" && txtComPas.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtComPas.Text)
            {
                MessageBox.Show("Your Account has been Successfully Created", "Registration Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords does not mathc, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPas.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPas.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtComPas.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
