namespace AppBureau
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
            LblConnexion = new Label();
            BtnConnexion = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LblLogin = new Label();
            Lbl = new Label();
            SuspendLayout();
            // 
            // LblConnexion
            // 
            LblConnexion.AutoSize = true;
            LblConnexion.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LblConnexion.Location = new Point(226, 36);
            LblConnexion.Name = "LblConnexion";
            LblConnexion.Size = new Size(219, 38);
            LblConnexion.TabIndex = 0;
            LblConnexion.Text = "SE CONNECTER";
            // 
            // BtnConnexion
            // 
            BtnConnexion.Location = new Point(482, 256);
            BtnConnexion.Name = "BtnConnexion";
            BtnConnexion.Size = new Size(167, 29);
            BtnConnexion.TabIndex = 1;
            BtnConnexion.Text = "Connexion";
            BtnConnexion.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(270, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 27);
            textBox2.TabIndex = 3;
            // 
            // LblLogin
            // 
            LblLogin.AutoSize = true;
            LblLogin.Location = new Point(166, 108);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(58, 20);
            LblLogin.TabIndex = 4;
            LblLogin.Text = "LOGIN :";
            // 
            // Lbl
            // 
            Lbl.AutoSize = true;
            Lbl.Location = new Point(166, 165);
            Lbl.Name = "Lbl";
            Lbl.Size = new Size(50, 20);
            Lbl.TabIndex = 5;
            Lbl.Text = "label2";
            // 
            // FrmConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 312);
            Controls.Add(Lbl);
            Controls.Add(LblLogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(BtnConnexion);
            Controls.Add(LblConnexion);
            Name = "FrmConnexion";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblConnexion;
        private Button BtnConnexion;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label LblLogin;
        private Label Lbl;
    }
}
