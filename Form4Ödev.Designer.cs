﻿namespace Windows_Form
{
    partial class F4ö
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
            this.txtb3 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb3
            // 
            this.txtb3.Location = new System.Drawing.Point(22, 78);
            this.txtb3.Name = "txtb3";
            this.txtb3.Size = new System.Drawing.Size(158, 20);
            this.txtb3.TabIndex = 0;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(22, 125);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(158, 77);
            this.b1.TabIndex = 1;
            this.b1.Text = "button1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F4ö
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.txtb3);
            this.Name = "F4ö";
            this.Text = "Form4Ödev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb3;
        private System.Windows.Forms.Button b1;
    }
}