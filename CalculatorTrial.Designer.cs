namespace Windows_Form
{
    partial class CalculatorTrial
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
            this.bT = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bCa = new System.Windows.Forms.Button();
            this.bBö = new System.Windows.Forms.Button();
            this.bM = new System.Windows.Forms.Button();
            this.bE = new System.Windows.Forms.Button();
            this.tx1 = new System.Windows.Forms.TextBox();
            this.tx2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bT
            // 
            this.bT.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bT.Location = new System.Drawing.Point(0, 303);
            this.bT.Name = "bT";
            this.bT.Size = new System.Drawing.Size(150, 147);
            this.bT.TabIndex = 2;
            this.bT.Text = "+";
            this.bT.UseVisualStyleBackColor = true;
            this.bT.Click += new System.EventHandler(this.bT_Click);
            // 
            // bC
            // 
            this.bC.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bC.Location = new System.Drawing.Point(156, 303);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(150, 147);
            this.bC.TabIndex = 2;
            this.bC.Text = "-";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bCa
            // 
            this.bCa.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCa.Location = new System.Drawing.Point(312, 303);
            this.bCa.Name = "bCa";
            this.bCa.Size = new System.Drawing.Size(150, 147);
            this.bCa.TabIndex = 2;
            this.bCa.Text = "x";
            this.bCa.UseVisualStyleBackColor = true;
            this.bCa.Click += new System.EventHandler(this.bCa_Click);
            // 
            // bBö
            // 
            this.bBö.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBö.Location = new System.Drawing.Point(468, 303);
            this.bBö.Name = "bBö";
            this.bBö.Size = new System.Drawing.Size(150, 147);
            this.bBö.TabIndex = 2;
            this.bBö.Text = "/";
            this.bBö.UseVisualStyleBackColor = true;
            this.bBö.Click += new System.EventHandler(this.bBö_Click);
            // 
            // bM
            // 
            this.bM.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bM.Location = new System.Drawing.Point(624, 303);
            this.bM.Name = "bM";
            this.bM.Size = new System.Drawing.Size(150, 147);
            this.bM.TabIndex = 2;
            this.bM.Text = "%";
            this.bM.UseVisualStyleBackColor = true;
            this.bM.Click += new System.EventHandler(this.bM_Click);
            // 
            // bE
            // 
            this.bE.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bE.Location = new System.Drawing.Point(624, 150);
            this.bE.Name = "bE";
            this.bE.Size = new System.Drawing.Size(150, 147);
            this.bE.TabIndex = 2;
            this.bE.Text = "=";
            this.bE.UseVisualStyleBackColor = true;
            this.bE.Click += new System.EventHandler(this.bE_Click);
            // 
            // tx1
            // 
            this.tx1.Location = new System.Drawing.Point(54, 75);
            this.tx1.Name = "tx1";
            this.tx1.Size = new System.Drawing.Size(314, 20);
            this.tx1.TabIndex = 3;
            // 
            // tx2
            // 
            this.tx2.Location = new System.Drawing.Point(451, 75);
            this.tx2.Name = "tx2";
            this.tx2.Size = new System.Drawing.Size(272, 20);
            this.tx2.TabIndex = 4;
            // 
            // CalculatorTrial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tx2);
            this.Controls.Add(this.tx1);
            this.Controls.Add(this.bE);
            this.Controls.Add(this.bM);
            this.Controls.Add(this.bBö);
            this.Controls.Add(this.bCa);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bT);
            this.Name = "CalculatorTrial";
            this.Text = "CalculatorTrial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bT;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bCa;
        private System.Windows.Forms.Button bBö;
        private System.Windows.Forms.Button bM;
        private System.Windows.Forms.Button bE;
        private System.Windows.Forms.TextBox tx1;
        private System.Windows.Forms.TextBox tx2;
    }
}