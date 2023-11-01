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
        SqlConnection connect = new SqlConnection(@"Data Source=MDIAS\SQLEXPRESS;Initial Catalog=LOGINWINFORM;Integrated Security=True");

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
            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    String checkUsername = " SELECT * FROM cadastro WHERE USERNAME = '"
                        + TxtBox_FrmSignUp_Email.Text.Trim() +  "'";

                    using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if(table.Rows.Count >= 1)
                        {
                            MessageBox.Show(TxtBox_FrmSignUp_Email.Text + "is already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO cadastro(EMAIL, USERNAME, PASSWORD, DATE_CREATED) " +
                                "VALUES(@email, @username, @pass, @date)";


                            DateTime date = DateTime.Today;

                            using(SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@email", TxtBox_FrmSignUp_Email.Text.Trim());
                                cmd.Parameters.AddWithValue("@username", TxtBox_FrmSignUp_Username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", TxtBox_FrmSignUp_Password.Text.Trim());
                                cmd.Parameters.AddWithValue("@date", date);
                                

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Frm_Principal pForm = new Frm_Principal();
                                pForm.Show();
                                this.Hide();
                            }
                        }
                    }


                } catch (Exception ex)
                {
                    MessageBox.Show("Error Connectiong Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void CkBox_FrmSignUp_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CkBox_FrmSignUp_ShowPassword.Checked)
            {
                TxtBox_FrmSignUp_Password.PasswordChar = '\0';
            }
            else
            {
                TxtBox_FrmSignUp_Password.PasswordChar = '*';
            }
        }
    }
}
