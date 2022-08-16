namespace Windows_Form
{
    partial class Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bC = new System.Windows.Forms.Button();
            this.bM = new System.Windows.Forms.Button();
            this.bE = new System.Windows.Forms.Button();
            this.bB = new System.Windows.Forms.Button();
            this.bCa = new System.Windows.Forms.Button();
            this.bT = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(389, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 0;
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(470, 140);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(75, 23);
            this.bC.TabIndex = 1;
            this.bC.Text = "-";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bM
            // 
            this.bM.Location = new System.Drawing.Point(389, 232);
            this.bM.Name = "bM";
            this.bM.Size = new System.Drawing.Size(75, 23);
            this.bM.TabIndex = 1;
            this.bM.Text = "½";
            this.bM.UseVisualStyleBackColor = true;
            this.bM.Click += new System.EventHandler(this.bM_Click);
            // 
            // bE
            // 
            this.bE.Location = new System.Drawing.Point(470, 232);
            this.bE.Name = "bE";
            this.bE.Size = new System.Drawing.Size(75, 23);
            this.bE.TabIndex = 1;
            this.bE.Text = "=";
            this.bE.UseVisualStyleBackColor = true;
            this.bE.Click += new System.EventHandler(this.bE_Click);
            // 
            // bB
            // 
            this.bB.Location = new System.Drawing.Point(470, 190);
            this.bB.Name = "bB";
            this.bB.Size = new System.Drawing.Size(75, 23);
            this.bB.TabIndex = 1;
            this.bB.Text = "%";
            this.bB.UseVisualStyleBackColor = true;
            this.bB.Click += new System.EventHandler(this.bB_Click);
            // 
            // bCa
            // 
            this.bCa.Location = new System.Drawing.Point(389, 190);
            this.bCa.Name = "bCa";
            this.bCa.Size = new System.Drawing.Size(75, 23);
            this.bCa.TabIndex = 1;
            this.bCa.Text = "X";
            this.bCa.UseVisualStyleBackColor = true;
            this.bCa.Click += new System.EventHandler(this.bCa_Click);
            // 
            // bT
            // 
            this.bT.Location = new System.Drawing.Point(389, 140);
            this.bT.Name = "bT";
            this.bT.Size = new System.Drawing.Size(75, 23);
            this.bT.TabIndex = 1;
            this.bT.Text = "+";
            this.bT.UseVisualStyleBackColor = true;
            this.bT.Click += new System.EventHandler(this.bT_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(551, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 0;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bM);
            this.Controls.Add(this.bB);
            this.Controls.Add(this.bE);
            this.Controls.Add(this.bCa);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bT);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bM;
        private System.Windows.Forms.Button bE;
        private System.Windows.Forms.Button bB;
        private System.Windows.Forms.Button bCa;
        private System.Windows.Forms.Button bT;
        private System.Windows.Forms.TextBox textBox2;
    }
}