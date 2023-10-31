namespace LoginRegistrationForm
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pn_White = new System.Windows.Forms.Panel();
            this.Pn_Blue = new System.Windows.Forms.Panel();
            this.Lbl_TxtWelcome = new System.Windows.Forms.Label();
            this.Lbl_TxtUsername = new System.Windows.Forms.Label();
            this.TxtBox_Username = new System.Windows.Forms.TextBox();
            this.TxtBox_Password = new System.Windows.Forms.TextBox();
            this.Lbl_TxtPassword = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.CkBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.Lbl_DontHave = new System.Windows.Forms.Label();
            this.Lbl_Register = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Close = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pn_White.SuspendLayout();
            this.Pn_Blue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pn_White
            // 
            this.Pn_White.BackColor = System.Drawing.Color.White;
            this.Pn_White.Controls.Add(this.Lbl_Close);
            this.Pn_White.Controls.Add(this.Lbl_Register);
            this.Pn_White.Controls.Add(this.Lbl_DontHave);
            this.Pn_White.Controls.Add(this.CkBox_ShowPassword);
            this.Pn_White.Controls.Add(this.Btn_Login);
            this.Pn_White.Controls.Add(this.TxtBox_Password);
            this.Pn_White.Controls.Add(this.Lbl_TxtPassword);
            this.Pn_White.Controls.Add(this.TxtBox_Username);
            this.Pn_White.Controls.Add(this.Lbl_TxtUsername);
            this.Pn_White.Controls.Add(this.Lbl_TxtWelcome);
            this.Pn_White.Controls.Add(this.Pn_Blue);
            this.Pn_White.Location = new System.Drawing.Point(0, 0);
            this.Pn_White.Name = "Pn_White";
            this.Pn_White.Size = new System.Drawing.Size(635, 412);
            this.Pn_White.TabIndex = 0;
            // 
            // Pn_Blue
            // 
            this.Pn_Blue.BackColor = System.Drawing.Color.MidnightBlue;
            this.Pn_Blue.Controls.Add(this.pictureBox1);
            this.Pn_Blue.Controls.Add(this.Lbl_Titulo);
            this.Pn_Blue.Location = new System.Drawing.Point(0, 0);
            this.Pn_Blue.Name = "Pn_Blue";
            this.Pn_Blue.Size = new System.Drawing.Size(273, 412);
            this.Pn_Blue.TabIndex = 0;
            // 
            // Lbl_TxtWelcome
            // 
            this.Lbl_TxtWelcome.AutoSize = true;
            this.Lbl_TxtWelcome.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TxtWelcome.Location = new System.Drawing.Point(289, 44);
            this.Lbl_TxtWelcome.Name = "Lbl_TxtWelcome";
            this.Lbl_TxtWelcome.Size = new System.Drawing.Size(144, 19);
            this.Lbl_TxtWelcome.TabIndex = 1;
            this.Lbl_TxtWelcome.Text = "Welcome Back!";
            // 
            // Lbl_TxtUsername
            // 
            this.Lbl_TxtUsername.AutoSize = true;
            this.Lbl_TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TxtUsername.Location = new System.Drawing.Point(290, 117);
            this.Lbl_TxtUsername.Name = "Lbl_TxtUsername";
            this.Lbl_TxtUsername.Size = new System.Drawing.Size(70, 16);
            this.Lbl_TxtUsername.TabIndex = 2;
            this.Lbl_TxtUsername.Text = "Username";
            // 
            // TxtBox_Username
            // 
            this.TxtBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Username.Location = new System.Drawing.Point(293, 136);
            this.TxtBox_Username.Multiline = true;
            this.TxtBox_Username.Name = "TxtBox_Username";
            this.TxtBox_Username.Size = new System.Drawing.Size(263, 24);
            this.TxtBox_Username.TabIndex = 3;
            // 
            // TxtBox_Password
            // 
            this.TxtBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Password.Location = new System.Drawing.Point(293, 197);
            this.TxtBox_Password.Multiline = true;
            this.TxtBox_Password.Name = "TxtBox_Password";
            this.TxtBox_Password.PasswordChar = '*';
            this.TxtBox_Password.Size = new System.Drawing.Size(263, 24);
            this.TxtBox_Password.TabIndex = 5;
            // 
            // Lbl_TxtPassword
            // 
            this.Lbl_TxtPassword.AutoSize = true;
            this.Lbl_TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TxtPassword.Location = new System.Drawing.Point(290, 178);
            this.Lbl_TxtPassword.Name = "Lbl_TxtPassword";
            this.Lbl_TxtPassword.Size = new System.Drawing.Size(67, 16);
            this.Lbl_TxtPassword.TabIndex = 4;
            this.Lbl_TxtPassword.Text = "Password";
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.MidnightBlue;
            this.Btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Login.FlatAppearance.BorderSize = 0;
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.ForeColor = System.Drawing.Color.White;
            this.Btn_Login.Location = new System.Drawing.Point(293, 257);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(100, 35);
            this.Btn_Login.TabIndex = 6;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = false;
            // 
            // CkBox_ShowPassword
            // 
            this.CkBox_ShowPassword.AutoSize = true;
            this.CkBox_ShowPassword.ForeColor = System.Drawing.Color.Gray;
            this.CkBox_ShowPassword.Location = new System.Drawing.Point(454, 227);
            this.CkBox_ShowPassword.Name = "CkBox_ShowPassword";
            this.CkBox_ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.CkBox_ShowPassword.TabIndex = 7;
            this.CkBox_ShowPassword.Text = "Show Password";
            this.CkBox_ShowPassword.UseVisualStyleBackColor = true;
            // 
            // Lbl_DontHave
            // 
            this.Lbl_DontHave.AutoSize = true;
            this.Lbl_DontHave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DontHave.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_DontHave.Location = new System.Drawing.Point(290, 366);
            this.Lbl_DontHave.Name = "Lbl_DontHave";
            this.Lbl_DontHave.Size = new System.Drawing.Size(137, 15);
            this.Lbl_DontHave.TabIndex = 8;
            this.Lbl_DontHave.Text = "Don\'t Have an Account?";
            // 
            // Lbl_Register
            // 
            this.Lbl_Register.AutoSize = true;
            this.Lbl_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Register.ForeColor = System.Drawing.Color.Gray;
            this.Lbl_Register.Location = new System.Drawing.Point(465, 366);
            this.Lbl_Register.Name = "Lbl_Register";
            this.Lbl_Register.Size = new System.Drawing.Size(96, 15);
            this.Lbl_Register.TabIndex = 9;
            this.Lbl_Register.Text = "Register Here";
            this.Lbl_Register.Click += new System.EventHandler(this.Lbl_Register_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.LightGray;
            this.Lbl_Titulo.Location = new System.Drawing.Point(52, 192);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(174, 23);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Lawyer Company";
            this.Lbl_Titulo.Click += new System.EventHandler(this.Lbl_MeuNome_Click);
            // 
            // Lbl_Close
            // 
            this.Lbl_Close.AutoSize = true;
            this.Lbl_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Close.Location = new System.Drawing.Point(604, 9);
            this.Lbl_Close.Name = "Lbl_Close";
            this.Lbl_Close.Size = new System.Drawing.Size(18, 18);
            this.Lbl_Close.TabIndex = 10;
            this.Lbl_Close.Text = "X";
            this.Lbl_Close.Click += new System.EventHandler(this.Lbl_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginRegistrationForm.Properties.Resources.icons8_user_male_circle_104px_2;
            this.pictureBox1.Location = new System.Drawing.Point(82, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 103);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.Pn_White);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Pn_White.ResumeLayout(false);
            this.Pn_White.PerformLayout();
            this.Pn_Blue.ResumeLayout(false);
            this.Pn_Blue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pn_White;
        private System.Windows.Forms.Panel Pn_Blue;
        private System.Windows.Forms.Label Lbl_TxtWelcome;
        private System.Windows.Forms.Label Lbl_TxtUsername;
        private System.Windows.Forms.TextBox TxtBox_Username;
        private System.Windows.Forms.TextBox TxtBox_Password;
        private System.Windows.Forms.Label Lbl_TxtPassword;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.CheckBox CkBox_ShowPassword;
        private System.Windows.Forms.Label Lbl_DontHave;
        private System.Windows.Forms.Label Lbl_Register;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Close;
    }
}

