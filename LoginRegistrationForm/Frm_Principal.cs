﻿using System;
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
   

    public partial class Frm_Principal : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=MDIAS\SQLEXPRESS;Initial Catalog=LOGINWINFORM;Integrated Security=True");

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

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (TxtBox_FrmPrincipal_Username.Text == "" || TxtBox_FrmPrincipal_Password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String selectData = "SELECT * FROM cadastro WHERE USERNAME = @username AND PASSWORD = @pass";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", TxtBox_FrmPrincipal_Username.Text);
                            cmd.Parameters.AddWithValue("@pass", TxtBox_FrmPrincipal_Password.Text);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged In Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Frm_TelaLogado tlForm = new Frm_TelaLogado();
                                tlForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
