namespace AppCSharp
{
    partial class Form1
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
            BtnClick = new Button();
            SuspendLayout();
            // 
            // BtnClick
            // 
            BtnClick.Location = new Point(252, 169);
            BtnClick.Name = "BtnClick";
            BtnClick.Size = new Size(201, 29);
            BtnClick.TabIndex = 0;
            BtnClick.Text = "Clique-moi !";
            BtnClick.UseVisualStyleBackColor = true;
            BtnClick.Click += BtnClick_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnClick);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnClick;
    }
}
