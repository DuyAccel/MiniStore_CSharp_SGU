namespace MiniStore
{
    partial class TestControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.costumButton1 = new MiniStore.Costumized.CostumButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.costumButton1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 473);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(206, 241);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(429, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(123, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // costumButton1
            // 
            this.costumButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.costumButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.costumButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.costumButton1.BorderRadius = 20;
            this.costumButton1.BorderSize = 0;
            this.costumButton1.FlatAppearance.BorderSize = 0;
            this.costumButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.costumButton1.ForeColor = System.Drawing.Color.White;
            this.costumButton1.Location = new System.Drawing.Point(479, 357);
            this.costumButton1.Name = "costumButton1";
            this.costumButton1.Size = new System.Drawing.Size(150, 40);
            this.costumButton1.TabIndex = 2;
            this.costumButton1.Text = "costumButton1";
            this.costumButton1.TextColor = System.Drawing.Color.White;
            this.costumButton1.UseVisualStyleBackColor = false;
            // 
            // TestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "TestControl";
            this.Size = new System.Drawing.Size(720, 473);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private MiniStore.Costumized.CostumButton costumButton1;
    }
}
