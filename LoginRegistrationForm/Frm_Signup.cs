using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LoginRegistrationForm
{
    public partial class Frm_Signup : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MATHEUS\\OneDrive\\Documentos\\LoginData.mdf;Integrated Security=True;Connect Timeout=30");

        public Frm_Signup()
        {
            InitializeComponent();
        }

        private void Lbl_TxtUseraname_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_FrmSignUp_Login_Click(object sender, EventArgs e)
        {
            Frm_Principal pForm = new Frm_Principal();
            pForm.Show();
            this.Hide();
        }

        private void Lbl_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_SignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
