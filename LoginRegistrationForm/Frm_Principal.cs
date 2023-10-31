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
    }
}
