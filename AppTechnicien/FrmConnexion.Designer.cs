﻿namespace AppTechnicien
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
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 62);
            label1.Name = "label1";
            label1.Size = new Size(90, 37);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(180, 120);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(592, 96);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // FrmConnexion
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 438);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "FrmConnexion";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private RichTextBox richTextBox1;
    }
}