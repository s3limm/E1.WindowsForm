namespace Windows_Form
{
    partial class F3
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
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.txtb3 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(156, 201);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(152, 20);
            this.txtb2.TabIndex = 0;
            // 
            // txtb3
            // 
            this.txtb3.Location = new System.Drawing.Point(477, 201);
            this.txtb3.Name = "txtb3";
            this.txtb3.Size = new System.Drawing.Size(151, 20);
            this.txtb3.TabIndex = 1;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(156, 250);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(152, 57);
            this.b1.TabIndex = 2;
            this.b1.Text = "button1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.txtb3);
            this.Controls.Add(this.txtb2);
            this.Name = "F3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.F3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.TextBox txtb3;
        private System.Windows.Forms.Button b1;
    }
}