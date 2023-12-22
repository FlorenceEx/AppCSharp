namespace AppTechnicien
{
    partial class FrmConnexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblTitre = new Label();
            textBox1 = new TextBox();
            BtnConnexion = new Button();
            LblLogin = new Label();
            LblMotDePasse = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // LblTitre
            // 
            LblTitre.AutoSize = true;
            LblTitre.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            LblTitre.Location = new Point(290, 26);
            LblTitre.Name = "LblTitre";
            LblTitre.Size = new Size(413, 81);
            LblTitre.TabIndex = 1;
            LblTitre.Text = "Se connecter";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(364, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 71);
            textBox1.TabIndex = 2;
            // 
            // BtnConnexion
            // 
            BtnConnexion.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnConnexion.Location = new Point(364, 498);
            BtnConnexion.Name = "BtnConnexion";
            BtnConnexion.Size = new Size(298, 95);
            BtnConnexion.TabIndex = 3;
            BtnConnexion.Text = "Connexion";
            BtnConnexion.UseVisualStyleBackColor = true;
            BtnConnexion.Click += BtnConnexion_Click;
            // 
            // LblLogin
            // 
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblLogin.Location = new Point(177, 169);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(169, 65);
            LblLogin.TabIndex = 4;
            LblLogin.Text = "Login :";
            // 
            // LblMotDePasse
            // 
            LblMotDePasse.AutoSize = true;
            LblMotDePasse.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblMotDePasse.Location = new Point(12, 331);
            LblMotDePasse.Name = "LblMotDePasse";
            LblMotDePasse.Size = new Size(334, 65);
            LblMotDePasse.TabIndex = 5;
            LblMotDePasse.Text = "Mot de passe :";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(364, 331);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(413, 71);
            textBox2.TabIndex = 6;
            // 
            // FrmConnexion
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 649);
            Controls.Add(textBox2);
            Controls.Add(LblMotDePasse);
            Controls.Add(LblLogin);
            Controls.Add(BtnConnexion);
            Controls.Add(textBox1);
            Controls.Add(LblTitre);
            Name = "FrmConnexion";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblTitre;
        private TextBox textBox1;
        private Button BtnConnexion;
        private Label LblLogin;
        private Label LblMotDePasse;
        private TextBox textBox2;
    }
}
