namespace MiniStore.GUI.Features
{
    partial class Invoices
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
            this.Invoices_grp = new System.Windows.Forms.GroupBox();
            this.Invoices_gridview = new System.Windows.Forms.DataGridView();
            this.Tool_panel = new System.Windows.Forms.Panel();
            this.Filter_label = new System.Windows.Forms.Label();
            this.Update_btn = new MiniStore.Costumized.CostumButton();
            this.Remove_btn = new MiniStore.Costumized.CostumButton();
            this.Filter_cbo = new System.Windows.Forms.ComboBox();
            this.Search_btn = new MiniStore.Costumized.CostumButton();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.Invoices_grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Invoices_gridview)).BeginInit();
            this.Tool_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Invoices_grp
            // 
            this.Invoices_grp.Controls.Add(this.Invoices_gridview);
            this.Invoices_grp.Controls.Add(this.Tool_panel);
            this.Invoices_grp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Invoices_grp.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoices_grp.Location = new System.Drawing.Point(10, 10);
            this.Invoices_grp.Margin = new System.Windows.Forms.Padding(8);
            this.Invoices_grp.Name = "Invoices_grp";
            this.Invoices_grp.Padding = new System.Windows.Forms.Padding(8);
            this.Invoices_grp.Size = new System.Drawing.Size(1141, 545);
            this.Invoices_grp.TabIndex = 0;
            this.Invoices_grp.TabStop = false;
            this.Invoices_grp.Text = "Invoices";
            // 
            // Invoices_gridview
            // 
            this.Invoices_gridview.AllowUserToAddRows = false;
            this.Invoices_gridview.AllowUserToDeleteRows = false;
            this.Invoices_gridview.AllowUserToOrderColumns = true;
            this.Invoices_gridview.AllowUserToResizeColumns = false;
            this.Invoices_gridview.AllowUserToResizeRows = false;
            this.Invoices_gridview.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Invoices_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Invoices_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Invoices_gridview.Location = new System.Drawing.Point(8, 99);
            this.Invoices_gridview.Name = "Invoices_gridview";
            this.Invoices_gridview.RowHeadersWidth = 51;
            this.Invoices_gridview.RowTemplate.Height = 24;
            this.Invoices_gridview.Size = new System.Drawing.Size(1125, 438);
            this.Invoices_gridview.TabIndex = 1;
            // 
            // Tool_panel
            // 
            this.Tool_panel.Controls.Add(this.Filter_label);
            this.Tool_panel.Controls.Add(this.Update_btn);
            this.Tool_panel.Controls.Add(this.Remove_btn);
            this.Tool_panel.Controls.Add(this.Filter_cbo);
            this.Tool_panel.Controls.Add(this.Search_btn);
            this.Tool_panel.Controls.Add(this.Search_txt);
            this.Tool_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tool_panel.Location = new System.Drawing.Point(8, 36);
            this.Tool_panel.Name = "Tool_panel";
            this.Tool_panel.Size = new System.Drawing.Size(1125, 63);
            this.Tool_panel.TabIndex = 2;
            // 
            // Filter_label
            // 
            this.Filter_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Filter_label.AutoSize = true;
            this.Filter_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_label.Location = new System.Drawing.Point(486, 16);
            this.Filter_label.Name = "Filter_label";
            this.Filter_label.Size = new System.Drawing.Size(87, 27);
            this.Filter_label.TabIndex = 19;
            this.Filter_label.Text = "Filter:";
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Update_btn.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.Update_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Update_btn.BorderRadius = 20;
            this.Update_btn.BorderSize = 0;
            this.Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_btn.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.ForeColor = System.Drawing.Color.White;
            this.Update_btn.Location = new System.Drawing.Point(3, 3);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(142, 45);
            this.Update_btn.TabIndex = 17;
            this.Update_btn.Text = "Update";
            this.Update_btn.TextColor = System.Drawing.Color.White;
            this.Update_btn.UseVisualStyleBackColor = false;
            // 
            // Remove_btn
            // 
            this.Remove_btn.BackColor = System.Drawing.Color.Crimson;
            this.Remove_btn.BackgroundColor = System.Drawing.Color.Crimson;
            this.Remove_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Remove_btn.BorderRadius = 20;
            this.Remove_btn.BorderSize = 0;
            this.Remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_btn.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_btn.ForeColor = System.Drawing.Color.White;
            this.Remove_btn.Location = new System.Drawing.Point(151, 3);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(142, 45);
            this.Remove_btn.TabIndex = 18;
            this.Remove_btn.Text = "Refund";
            this.Remove_btn.TextColor = System.Drawing.Color.White;
            this.Remove_btn.UseVisualStyleBackColor = false;
            // 
            // Filter_cbo
            // 
            this.Filter_cbo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Filter_cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filter_cbo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_cbo.FormattingEnabled = true;
            this.Filter_cbo.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Tên nhân viên",
            "Số điện thoại"});
            this.Filter_cbo.Location = new System.Drawing.Point(579, 16);
            this.Filter_cbo.Name = "Filter_cbo";
            this.Filter_cbo.Size = new System.Drawing.Size(187, 33);
            this.Filter_cbo.TabIndex = 15;
            // 
            // Search_btn
            // 
            this.Search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Search_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Search_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Search_btn.BorderRadius = 20;
            this.Search_btn.BorderSize = 0;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.ForeColor = System.Drawing.Color.White;
            this.Search_btn.Location = new System.Drawing.Point(967, 3);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(142, 45);
            this.Search_btn.TabIndex = 14;
            this.Search_btn.Text = "Search";
            this.Search_btn.TextColor = System.Drawing.Color.White;
            this.Search_btn.UseVisualStyleBackColor = true;
            // 
            // Search_txt
            // 
            this.Search_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_txt.Location = new System.Drawing.Point(772, 15);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(189, 34);
            this.Search_txt.TabIndex = 13;
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Invoices_grp);
            this.Name = "Invoices";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1161, 565);
            this.Invoices_grp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Invoices_gridview)).EndInit();
            this.Tool_panel.ResumeLayout(false);
            this.Tool_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Invoices_grp;
        private System.Windows.Forms.DataGridView Invoices_gridview;
        private System.Windows.Forms.Panel Tool_panel;
        private Costumized.CostumButton Update_btn;
        private Costumized.CostumButton Remove_btn;
        private System.Windows.Forms.ComboBox Filter_cbo;
        private Costumized.CostumButton Search_btn;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.Label Filter_label;
    }
}
