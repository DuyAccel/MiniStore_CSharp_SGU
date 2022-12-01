namespace MiniStore.GUI.Features
{
    partial class Inventory
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
            this.Inventory_tab = new System.Windows.Forms.TabControl();
            this.Product_tab = new System.Windows.Forms.TabPage();
            this.qlProduct1 = new Kho.QLProduct();
            this.Input_tab = new System.Windows.Forms.TabPage();
            this.input1 = new MiniStore.GUI.Items.Input();
            this.Output_tab = new System.Windows.Forms.TabPage();
            this.Inventory_tab.SuspendLayout();
            this.Product_tab.SuspendLayout();
            this.Input_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inventory_tab
            // 
            this.Inventory_tab.Controls.Add(this.Product_tab);
            this.Inventory_tab.Controls.Add(this.Input_tab);
            this.Inventory_tab.Controls.Add(this.Output_tab);
            this.Inventory_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inventory_tab.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_tab.Location = new System.Drawing.Point(0, 0);
            this.Inventory_tab.Name = "Inventory_tab";
            this.Inventory_tab.SelectedIndex = 0;
            this.Inventory_tab.Size = new System.Drawing.Size(1161, 565);
            this.Inventory_tab.TabIndex = 0;
            // 
            // Product_tab
            // 
            this.Product_tab.Controls.Add(this.qlProduct1);
            this.Product_tab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_tab.Location = new System.Drawing.Point(4, 38);
            this.Product_tab.Margin = new System.Windows.Forms.Padding(0);
            this.Product_tab.Name = "Product_tab";
            this.Product_tab.Size = new System.Drawing.Size(1153, 523);
            this.Product_tab.TabIndex = 0;
            this.Product_tab.Text = "Product";
            this.Product_tab.UseVisualStyleBackColor = true;
            // 
            // qlProduct1
            // 
            this.qlProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qlProduct1.Location = new System.Drawing.Point(0, 0);
            this.qlProduct1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.qlProduct1.Name = "qlProduct1";
            this.qlProduct1.Size = new System.Drawing.Size(1153, 523);
            this.qlProduct1.TabIndex = 0;
            // 
            // Input_tab
            // 
            this.Input_tab.Controls.Add(this.input1);
            this.Input_tab.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_tab.Location = new System.Drawing.Point(4, 38);
            this.Input_tab.Name = "Input_tab";
            this.Input_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Input_tab.Size = new System.Drawing.Size(1153, 523);
            this.Input_tab.TabIndex = 1;
            this.Input_tab.Text = "Input";
            this.Input_tab.UseVisualStyleBackColor = true;
            // 
            // input1
            // 
            this.input1.BackColor = System.Drawing.Color.White;
            this.input1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(3, 3);
            this.input1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(1147, 517);
            this.input1.TabIndex = 0;
            // 
            // Output_tab
            // 
            this.Output_tab.Location = new System.Drawing.Point(4, 38);
            this.Output_tab.Name = "Output_tab";
            this.Output_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Output_tab.Size = new System.Drawing.Size(1153, 523);
            this.Output_tab.TabIndex = 2;
            this.Output_tab.Text = "Output";
            this.Output_tab.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.Inventory_tab);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(1161, 565);
            this.Inventory_tab.ResumeLayout(false);
            this.Product_tab.ResumeLayout(false);
            this.Input_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Inventory_tab;
        private System.Windows.Forms.TabPage Product_tab;
        private System.Windows.Forms.TabPage Input_tab;
        private Kho.QLProduct qlProduct1;
        private Items.Input input1;
        private System.Windows.Forms.TabPage Output_tab;
    }
}
