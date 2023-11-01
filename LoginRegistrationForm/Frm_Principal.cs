using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegistrationForm
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Lbl_MeuNome_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Register_Click(object sender, EventArgs e)
        {
            Frm_Signup sForm = new Frm_Signup();
            sForm.Show();
            this.Hide();
        }

        private void Lbl_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CkBox_FrmPrincipal_ShowPassword.Checked)
            {
                TxtBox_FrmPrincipal_Password.PasswordChar = '\0';
            }
            else
            {
                TxtBox_FrmPrincipal_Password.PasswordChar = '*';
            }
        }
    }
}
