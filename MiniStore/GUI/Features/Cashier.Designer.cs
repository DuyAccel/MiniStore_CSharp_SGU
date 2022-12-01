namespace MiniStore.GUI.Features
{
    partial class Cashier
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
            this.Cashier_tab = new System.Windows.Forms.TabControl();
            this.Payment_tab = new System.Windows.Forms.TabPage();
            this.payment1 = new MiniStore.GUI.Features.Payment();
            this.Invoices_tab = new System.Windows.Forms.TabPage();
            this.invoices1 = new MiniStore.GUI.Features.Invoices();
            this.Cashier_tab.SuspendLayout();
            this.Payment_tab.SuspendLayout();
            this.Invoices_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cashier_tab
            // 
            this.Cashier_tab.Controls.Add(this.Payment_tab);
            this.Cashier_tab.Controls.Add(this.Invoices_tab);
            this.Cashier_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cashier_tab.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cashier_tab.Location = new System.Drawing.Point(0, 0);
            this.Cashier_tab.Name = "Cashier_tab";
            this.Cashier_tab.SelectedIndex = 0;
            this.Cashier_tab.Size = new System.Drawing.Size(1161, 565);
            this.Cashier_tab.TabIndex = 0;
            // 
            // Payment_tab
            // 
            this.Payment_tab.Controls.Add(this.payment1);
            this.Payment_tab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_tab.Location = new System.Drawing.Point(4, 34);
            this.Payment_tab.Name = "Payment_tab";
            this.Payment_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Payment_tab.Size = new System.Drawing.Size(1153, 527);
            this.Payment_tab.TabIndex = 0;
            this.Payment_tab.Text = "Payment";
            this.Payment_tab.UseVisualStyleBackColor = true;
            // 
            // payment1
            // 
            this.payment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payment1.Location = new System.Drawing.Point(3, 3);
            this.payment1.Margin = new System.Windows.Forms.Padding(9);
            this.payment1.Name = "payment1";
            this.payment1.Size = new System.Drawing.Size(1147, 521);
            this.payment1.TabIndex = 0;
            // 
            // Invoices_tab
            // 
            this.Invoices_tab.Controls.Add(this.invoices1);
            this.Invoices_tab.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoices_tab.Location = new System.Drawing.Point(4, 34);
            this.Invoices_tab.Margin = new System.Windows.Forms.Padding(0);
            this.Invoices_tab.Name = "Invoices_tab";
            this.Invoices_tab.Size = new System.Drawing.Size(1153, 527);
            this.Invoices_tab.TabIndex = 1;
            this.Invoices_tab.Text = "Invoice Management";
            this.Invoices_tab.UseVisualStyleBackColor = true;
            // 
            // invoices1
            // 
            this.invoices1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoices1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoices1.Location = new System.Drawing.Point(0, 0);
            this.invoices1.Margin = new System.Windows.Forms.Padding(5);
            this.invoices1.Name = "invoices1";
            this.invoices1.Size = new System.Drawing.Size(1153, 527);
            this.invoices1.TabIndex = 0;
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.Cashier_tab);
            this.Name = "Cashier";
            this.Size = new System.Drawing.Size(1161, 565);
            this.Cashier_tab.ResumeLayout(false);
            this.Payment_tab.ResumeLayout(false);
            this.Invoices_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Cashier_tab;
        private System.Windows.Forms.TabPage Payment_tab;
        private System.Windows.Forms.TabPage Invoices_tab;
        private Payment payment1;
        private Invoices invoices1;
    }
}
