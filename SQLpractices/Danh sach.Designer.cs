namespace SQLpractices
{
    partial class Danh_sach
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MaVTu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenVTu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DvTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhanTram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "truy van";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaVTu,
            this.TenVTu,
            this.DvTinh,
            this.PhanTram});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(168, 200);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(448, 232);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MaVTu
            // 
            this.MaVTu.Text = "MaVTu";
            // 
            // TenVTu
            // 
            this.TenVTu.Text = "TenVTu";
            this.TenVTu.Width = 120;
            // 
            // DvTinh
            // 
            this.DvTinh.Text = "DvTinh";
            // 
            // PhanTram
            // 
            this.PhanTram.Text = "PhanTram";
            // 
            // Danh_sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "Danh_sach";
            this.Text = "Danh_sach";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MaVTu;
        private System.Windows.Forms.ColumnHeader TenVTu;
        private System.Windows.Forms.ColumnHeader DvTinh;
        private System.Windows.Forms.ColumnHeader PhanTram;
    }
}