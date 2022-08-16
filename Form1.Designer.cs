namespace Windows_Form
{
    partial class F1
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
            this.b5 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b5.Location = new System.Drawing.Point(203, 124);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(116, 54);
            this.b5.TabIndex = 0;
            this.b5.Text = "btn1";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            this.b5.MouseLeave += new System.EventHandler(this.b5_MouseLeave);
            this.b5.MouseHover += new System.EventHandler(this.b5_MouseHover);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b2.Location = new System.Drawing.Point(408, 36);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(116, 54);
            this.b2.TabIndex = 0;
            this.b2.Text = "yanlış";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            this.b2.MouseLeave += new System.EventHandler(this.b2_MouseLeave);
            this.b2.MouseHover += new System.EventHandler(this.b2_MouseHover);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b4.Location = new System.Drawing.Point(408, 230);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(116, 54);
            this.b4.TabIndex = 0;
            this.b4.Text = "yanlış";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            this.b4.MouseLeave += new System.EventHandler(this.b4_MouseLeave);
            this.b4.MouseHover += new System.EventHandler(this.b4_MouseHover);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b3.Location = new System.Drawing.Point(40, 230);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(116, 54);
            this.b3.TabIndex = 0;
            this.b3.Text = "yanlış";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            this.b3.MouseLeave += new System.EventHandler(this.b3_MouseLeave);
            this.b3.MouseHover += new System.EventHandler(this.b3_MouseHover);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b1.Location = new System.Drawing.Point(40, 24);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(116, 54);
            this.b1.TabIndex = 0;
            this.b1.Text = "Dogru";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            this.b1.MouseHover += new System.EventHandler(this.b1_MouseHover);
            // 
            // F1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(536, 319);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b5);
            this.Name = "F1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b1;
    }
}

