namespace LoginRegistrationForm
{
    partial class Frm_TelaLogado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_FrmTelaLogado_Welcome = new System.Windows.Forms.Label();
            this.Lbl_FrmTela1_Close = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_FrmTelaLogado_Welcome
            // 
            this.Lbl_FrmTelaLogado_Welcome.AutoSize = true;
            this.Lbl_FrmTelaLogado_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FrmTelaLogado_Welcome.Location = new System.Drawing.Point(255, 179);
            this.Lbl_FrmTelaLogado_Welcome.Name = "Lbl_FrmTelaLogado_Welcome";
            this.Lbl_FrmTelaLogado_Welcome.Size = new System.Drawing.Size(115, 25);
            this.Lbl_FrmTelaLogado_Welcome.TabIndex = 1;
            this.Lbl_FrmTelaLogado_Welcome.Text = "Welcome!";
            // 
            // Lbl_FrmTela1_Close
            // 
            this.Lbl_FrmTela1_Close.AutoSize = true;
            this.Lbl_FrmTela1_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_FrmTela1_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FrmTela1_Close.Location = new System.Drawing.Point(605, 9);
            this.Lbl_FrmTela1_Close.Name = "Lbl_FrmTela1_Close";
            this.Lbl_FrmTela1_Close.Size = new System.Drawing.Size(18, 18);
            this.Lbl_FrmTela1_Close.TabIndex = 22;
            this.Lbl_FrmTela1_Close.Text = "X";
            this.Lbl_FrmTela1_Close.Click += new System.EventHandler(this.Lbl_FrmTela1_Close_Click);
            // 
            // Frm_TelaLogado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 412);
            this.Controls.Add(this.Lbl_FrmTela1_Close);
            this.Controls.Add(this.Lbl_FrmTelaLogado_Welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_TelaLogado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_TelaLogado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_FrmTelaLogado_Welcome;
        private System.Windows.Forms.Label Lbl_FrmTela1_Close;
    }
}