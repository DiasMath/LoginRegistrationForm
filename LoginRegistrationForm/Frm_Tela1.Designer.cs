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
            this.SuspendLayout();
            // 
            // Lbl_FrmTelaLogado_Welcome
            // 
            this.Lbl_FrmTelaLogado_Welcome.AutoSize = true;
            this.Lbl_FrmTelaLogado_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FrmTelaLogado_Welcome.Location = new System.Drawing.Point(321, 195);
            this.Lbl_FrmTelaLogado_Welcome.Name = "Lbl_FrmTelaLogado_Welcome";
            this.Lbl_FrmTelaLogado_Welcome.Size = new System.Drawing.Size(115, 25);
            this.Lbl_FrmTelaLogado_Welcome.TabIndex = 1;
            this.Lbl_FrmTelaLogado_Welcome.Text = "Welcome!";
            // 
            // Frm_TelaLogado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_FrmTelaLogado_Welcome);
            this.Name = "Frm_TelaLogado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_TelaLogado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_FrmTelaLogado_Welcome;
    }
}