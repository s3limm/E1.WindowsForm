namespace Windows_Form
{
    partial class F2
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
            this.txb1 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(156, 78);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(225, 20);
            this.txb1.TabIndex = 0;
            this.txb1.TextChanged += new System.EventHandler(this.txb1_TextChanged);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(209, 129);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(100, 65);
            this.b1.TabIndex = 1;
            this.b1.Text = "button1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // F2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.txb1);
            this.Name = "F2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Button b1;
    }
}