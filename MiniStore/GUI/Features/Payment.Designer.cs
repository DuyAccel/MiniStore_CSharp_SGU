namespace MiniStore.GUI.Features
{
    partial class Payment
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Quantity_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.Invoice_grbx = new System.Windows.Forms.GroupBox();
            this.Invoice_gridview = new System.Windows.Forms.DataGridView();
            this.Total_label = new System.Windows.Forms.Label();
            this.InvoiceID_label = new System.Windows.Forms.Label();
            this.Search_tab = new System.Windows.Forms.TabControl();
            this.Searc_tab1 = new System.Windows.Forms.TabPage();
            this.Search_gridview = new System.Windows.Forms.DataGridView();
            this.SearchAdvance_panel = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Recieved_label = new System.Windows.Forms.Label();
            this.Return_tabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Plus_btn = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Remove_btn = new MiniStore.Costumized.CostumButton();
            this.Edit_btn = new MiniStore.Costumized.CostumButton();
            this.Add_btn = new MiniStore.Costumized.CostumButton();
            this.Quantity_txt = new MiniStore.Costumized.CostumTextbox();
            this.ID_txt = new MiniStore.Costumized.CostumTextbox();
            this.Confirm_btn = new MiniStore.Costumized.CostumButton();
            this.Cancel_btn = new MiniStore.Costumized.CostumButton();
            this.Return_txt = new MiniStore.Costumized.CostumTextbox();
            this.Recieved_txt = new MiniStore.Costumized.CostumTextbox();
            this.Total_txt = new MiniStore.Costumized.CostumTextbox();
            this.Search_btn = new MiniStore.Costumized.CostumButton();
            this.Search_txt = new MiniStore.Costumized.CostumTextbox();
            this.InvoiceID_txt = new MiniStore.Costumized.CostumTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Invoice_grbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_gridview)).BeginInit();
            this.Search_tab.SuspendLayout();
            this.Searc_tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_gridview)).BeginInit();
            this.SearchAdvance_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.Remove_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Edit_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Add_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Plus_btn);
            this.splitContainer1.Panel1.Controls.Add(this.iconButton1);
            this.splitContainer1.Panel1.Controls.Add(this.Quantity_label);
            this.splitContainer1.Panel1.Controls.Add(this.Quantity_txt);
            this.splitContainer1.Panel1.Controls.Add(this.ID_label);
            this.splitContainer1.Panel1.Controls.Add(this.ID_txt);
            this.splitContainer1.Panel1.Controls.Add(this.Invoice_grbx);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Confirm_btn);
            this.splitContainer1.Panel2.Controls.Add(this.Cancel_btn);
            this.splitContainer1.Panel2.Controls.Add(this.Return_tabel);
            this.splitContainer1.Panel2.Controls.Add(this.Return_txt);
            this.splitContainer1.Panel2.Controls.Add(this.Recieved_label);
            this.splitContainer1.Panel2.Controls.Add(this.Recieved_txt);
            this.splitContainer1.Panel2.Controls.Add(this.Total_label);
            this.splitContainer1.Panel2.Controls.Add(this.Total_txt);
            this.splitContainer1.Panel2.Controls.Add(this.InvoiceID_label);
            this.splitContainer1.Panel2.Controls.Add(this.Search_tab);
            this.splitContainer1.Panel2.Controls.Add(this.InvoiceID_txt);
            this.splitContainer1.Size = new System.Drawing.Size(1161, 565);
            this.splitContainer1.SplitterDistance = 776;
            this.splitContainer1.TabIndex = 0;
            // 
            // Quantity_label
            // 
            this.Quantity_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_label.Location = new System.Drawing.Point(44, 425);
            this.Quantity_label.Name = "Quantity_label";
            this.Quantity_label.Size = new System.Drawing.Size(164, 35);
            this.Quantity_label.TabIndex = 4;
            this.Quantity_label.Text = "Quantity:";
            this.Quantity_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ID_label
            // 
            this.ID_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.Location = new System.Drawing.Point(44, 364);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(164, 35);
            this.ID_label.TabIndex = 2;
            this.ID_label.Text = "ProductID:";
            this.ID_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Invoice_grbx
            // 
            this.Invoice_grbx.Controls.Add(this.Invoice_gridview);
            this.Invoice_grbx.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoice_grbx.Location = new System.Drawing.Point(20, 18);
            this.Invoice_grbx.Name = "Invoice_grbx";
            this.Invoice_grbx.Size = new System.Drawing.Size(735, 320);
            this.Invoice_grbx.TabIndex = 0;
            this.Invoice_grbx.TabStop = false;
            this.Invoice_grbx.Text = "Products";
            // 
            // Invoice_gridview
            // 
            this.Invoice_gridview.AllowUserToAddRows = false;
            this.Invoice_gridview.AllowUserToDeleteRows = false;
            this.Invoice_gridview.AllowUserToOrderColumns = true;
            this.Invoice_gridview.AllowUserToResizeColumns = false;
            this.Invoice_gridview.AllowUserToResizeRows = false;
            this.Invoice_gridview.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Invoice_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Invoice_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Invoice_gridview.Location = new System.Drawing.Point(3, 24);
            this.Invoice_gridview.Name = "Invoice_gridview";
            this.Invoice_gridview.RowHeadersWidth = 51;
            this.Invoice_gridview.RowTemplate.Height = 24;
            this.Invoice_gridview.Size = new System.Drawing.Size(729, 293);
            this.Invoice_gridview.TabIndex = 0;
            // 
            // Total_label
            // 
            this.Total_label.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_label.Location = new System.Drawing.Point(17, 78);
            this.Total_label.Name = "Total_label";
            this.Total_label.Size = new System.Drawing.Size(114, 35);
            this.Total_label.TabIndex = 10;
            this.Total_label.Text = "Total:";
            this.Total_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InvoiceID_label
            // 
            this.InvoiceID_label.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceID_label.Location = new System.Drawing.Point(17, 32);
            this.InvoiceID_label.Name = "InvoiceID_label";
            this.InvoiceID_label.Size = new System.Drawing.Size(114, 35);
            this.InvoiceID_label.TabIndex = 8;
            this.InvoiceID_label.Text = "ID:";
            this.InvoiceID_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Search_tab
            // 
            this.Search_tab.Controls.Add(this.Searc_tab1);
            this.Search_tab.Controls.Add(this.tabPage2);
            this.Search_tab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_tab.Location = new System.Drawing.Point(14, 301);
            this.Search_tab.Name = "Search_tab";
            this.Search_tab.SelectedIndex = 0;
            this.Search_tab.Size = new System.Drawing.Size(355, 251);
            this.Search_tab.TabIndex = 0;
            // 
            // Searc_tab1
            // 
            this.Searc_tab1.Controls.Add(this.Search_gridview);
            this.Searc_tab1.Controls.Add(this.SearchAdvance_panel);
            this.Searc_tab1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searc_tab1.Location = new System.Drawing.Point(4, 32);
            this.Searc_tab1.Name = "Searc_tab1";
            this.Searc_tab1.Padding = new System.Windows.Forms.Padding(3);
            this.Searc_tab1.Size = new System.Drawing.Size(347, 215);
            this.Searc_tab1.TabIndex = 0;
            this.Searc_tab1.Text = "Search";
            this.Searc_tab1.UseVisualStyleBackColor = true;
            // 
            // Search_gridview
            // 
            this.Search_gridview.AllowUserToAddRows = false;
            this.Search_gridview.AllowUserToDeleteRows = false;
            this.Search_gridview.AllowUserToOrderColumns = true;
            this.Search_gridview.AllowUserToResizeColumns = false;
            this.Search_gridview.AllowUserToResizeRows = false;
            this.Search_gridview.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Search_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Search_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search_gridview.Location = new System.Drawing.Point(3, 47);
            this.Search_gridview.Name = "Search_gridview";
            this.Search_gridview.RowHeadersWidth = 51;
            this.Search_gridview.RowTemplate.Height = 24;
            this.Search_gridview.Size = new System.Drawing.Size(341, 165);
            this.Search_gridview.TabIndex = 1;
            // 
            // SearchAdvance_panel
            // 
            this.SearchAdvance_panel.Controls.Add(this.Search_btn);
            this.SearchAdvance_panel.Controls.Add(this.Search_txt);
            this.SearchAdvance_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchAdvance_panel.Location = new System.Drawing.Point(3, 3);
            this.SearchAdvance_panel.Name = "SearchAdvance_panel";
            this.SearchAdvance_panel.Size = new System.Drawing.Size(341, 44);
            this.SearchAdvance_panel.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(347, 215);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Barcode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Recieved_label
            // 
            this.Recieved_label.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recieved_label.Location = new System.Drawing.Point(17, 124);
            this.Recieved_label.Name = "Recieved_label";
            this.Recieved_label.Size = new System.Drawing.Size(114, 35);
            this.Recieved_label.TabIndex = 12;
            this.Recieved_label.Text = "Recieved:";
            this.Recieved_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Return_tabel
            // 
            this.Return_tabel.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_tabel.Location = new System.Drawing.Point(17, 170);
            this.Return_tabel.Name = "Return_tabel";
            this.Return_tabel.Size = new System.Drawing.Size(114, 35);
            this.Return_tabel.TabIndex = 14;
            this.Return_tabel.Text = "Return:";
            this.Return_tabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(505, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 183);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Plus_btn
            // 
            this.Plus_btn.BackColor = System.Drawing.Color.Transparent;
            this.Plus_btn.FlatAppearance.BorderSize = 0;
            this.Plus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus_btn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.Plus_btn.IconColor = System.Drawing.Color.LimeGreen;
            this.Plus_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Plus_btn.Location = new System.Drawing.Point(390, 422);
            this.Plus_btn.Name = "Plus_btn";
            this.Plus_btn.Size = new System.Drawing.Size(58, 38);
            this.Plus_btn.TabIndex = 6;
            this.Plus_btn.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(214, 422);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(58, 38);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Remove_btn
            // 
            this.Remove_btn.BackColor = System.Drawing.Color.Crimson;
            this.Remove_btn.BackgroundColor = System.Drawing.Color.Crimson;
            this.Remove_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Remove_btn.BorderRadius = 20;
            this.Remove_btn.BorderSize = 0;
            this.Remove_btn.FlatAppearance.BorderSize = 0;
            this.Remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_btn.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_btn.ForeColor = System.Drawing.Color.White;
            this.Remove_btn.Location = new System.Drawing.Point(49, 493);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(135, 51);
            this.Remove_btn.TabIndex = 9;
            this.Remove_btn.Text = "Remove";
            this.Remove_btn.TextColor = System.Drawing.Color.White;
            this.Remove_btn.UseVisualStyleBackColor = false;
            // 
            // Edit_btn
            // 
            this.Edit_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Edit_btn.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.Edit_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Edit_btn.BorderRadius = 20;
            this.Edit_btn.BorderSize = 0;
            this.Edit_btn.FlatAppearance.BorderSize = 0;
            this.Edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_btn.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_btn.ForeColor = System.Drawing.Color.White;
            this.Edit_btn.Location = new System.Drawing.Point(190, 493);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(135, 51);
            this.Edit_btn.TabIndex = 8;
            this.Edit_btn.Text = "Edit";
            this.Edit_btn.TextColor = System.Drawing.Color.White;
            this.Edit_btn.UseVisualStyleBackColor = false;
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.Add_btn.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.Add_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Add_btn.BorderRadius = 20;
            this.Add_btn.BorderSize = 0;
            this.Add_btn.FlatAppearance.BorderSize = 0;
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.White;
            this.Add_btn.Location = new System.Drawing.Point(331, 493);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(135, 51);
            this.Add_btn.TabIndex = 7;
            this.Add_btn.Text = "Add";
            this.Add_btn.TextColor = System.Drawing.Color.White;
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Quantity_txt
            // 
            this.Quantity_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Quantity_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Quantity_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Quantity_txt.BorderSize = 2;
            this.Quantity_txt.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_txt.ForeColor = System.Drawing.Color.Black;
            this.Quantity_txt.IsFocused = false;
            this.Quantity_txt.Location = new System.Drawing.Point(275, 422);
            this.Quantity_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Quantity_txt.Multiline = false;
            this.Quantity_txt.Name = "Quantity_txt";
            this.Quantity_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Quantity_txt.PasswordChar = false;
            this.Quantity_txt.Size = new System.Drawing.Size(110, 38);
            this.Quantity_txt.TabIndex = 3;
            this.Quantity_txt.Texts = "";
            this.Quantity_txt.UnderlinedStyle = false;
            // 
            // ID_txt
            // 
            this.ID_txt.BackColor = System.Drawing.SystemColors.Window;
            this.ID_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ID_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ID_txt.BorderSize = 2;
            this.ID_txt.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_txt.ForeColor = System.Drawing.Color.Black;
            this.ID_txt.IsFocused = false;
            this.ID_txt.Location = new System.Drawing.Point(215, 361);
            this.ID_txt.Margin = new System.Windows.Forms.Padding(4);
            this.ID_txt.Multiline = false;
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Padding = new System.Windows.Forms.Padding(7);
            this.ID_txt.PasswordChar = false;
            this.ID_txt.Size = new System.Drawing.Size(233, 38);
            this.ID_txt.TabIndex = 1;
            this.ID_txt.Texts = "";
            this.ID_txt.UnderlinedStyle = false;
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.Confirm_btn.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.Confirm_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Confirm_btn.BorderRadius = 20;
            this.Confirm_btn.BorderSize = 0;
            this.Confirm_btn.FlatAppearance.BorderSize = 0;
            this.Confirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_btn.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_btn.ForeColor = System.Drawing.Color.White;
            this.Confirm_btn.Location = new System.Drawing.Point(208, 236);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(128, 41);
            this.Confirm_btn.TabIndex = 15;
            this.Confirm_btn.Text = "Confirm";
            this.Confirm_btn.TextColor = System.Drawing.Color.White;
            this.Confirm_btn.UseVisualStyleBackColor = false;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.Crimson;
            this.Cancel_btn.BackgroundColor = System.Drawing.Color.Crimson;
            this.Cancel_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Cancel_btn.BorderRadius = 20;
            this.Cancel_btn.BorderSize = 0;
            this.Cancel_btn.FlatAppearance.BorderSize = 0;
            this.Cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_btn.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.ForeColor = System.Drawing.Color.White;
            this.Cancel_btn.Location = new System.Drawing.Point(49, 236);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(128, 41);
            this.Cancel_btn.TabIndex = 12;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.TextColor = System.Drawing.Color.White;
            this.Cancel_btn.UseVisualStyleBackColor = false;
            // 
            // Return_txt
            // 
            this.Return_txt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Return_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Return_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Return_txt.BorderSize = 2;
            this.Return_txt.Enabled = false;
            this.Return_txt.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_txt.ForeColor = System.Drawing.Color.Black;
            this.Return_txt.IsFocused = false;
            this.Return_txt.Location = new System.Drawing.Point(138, 167);
            this.Return_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Return_txt.Multiline = false;
            this.Return_txt.Name = "Return_txt";
            this.Return_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Return_txt.PasswordChar = false;
            this.Return_txt.Size = new System.Drawing.Size(231, 38);
            this.Return_txt.TabIndex = 13;
            this.Return_txt.Texts = "";
            this.Return_txt.UnderlinedStyle = false;
            // 
            // Recieved_txt
            // 
            this.Recieved_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Recieved_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Recieved_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Recieved_txt.BorderSize = 2;
            this.Recieved_txt.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recieved_txt.ForeColor = System.Drawing.Color.Black;
            this.Recieved_txt.IsFocused = false;
            this.Recieved_txt.Location = new System.Drawing.Point(138, 121);
            this.Recieved_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Recieved_txt.Multiline = false;
            this.Recieved_txt.Name = "Recieved_txt";
            this.Recieved_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Recieved_txt.PasswordChar = false;
            this.Recieved_txt.Size = new System.Drawing.Size(231, 38);
            this.Recieved_txt.TabIndex = 11;
            this.Recieved_txt.Texts = "";
            this.Recieved_txt.UnderlinedStyle = false;
            // 
            // Total_txt
            // 
            this.Total_txt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Total_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Total_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Total_txt.BorderSize = 2;
            this.Total_txt.Enabled = false;
            this.Total_txt.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_txt.ForeColor = System.Drawing.Color.Black;
            this.Total_txt.IsFocused = false;
            this.Total_txt.Location = new System.Drawing.Point(138, 75);
            this.Total_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Total_txt.Multiline = false;
            this.Total_txt.Name = "Total_txt";
            this.Total_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Total_txt.PasswordChar = false;
            this.Total_txt.Size = new System.Drawing.Size(231, 38);
            this.Total_txt.TabIndex = 9;
            this.Total_txt.Texts = "";
            this.Total_txt.UnderlinedStyle = false;
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Search_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Search_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Search_btn.BorderRadius = 20;
            this.Search_btn.BorderSize = 0;
            this.Search_btn.FlatAppearance.BorderSize = 0;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.ForeColor = System.Drawing.Color.White;
            this.Search_btn.Location = new System.Drawing.Point(231, 5);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(97, 33);
            this.Search_btn.TabIndex = 1;
            this.Search_btn.Text = "Search";
            this.Search_btn.TextColor = System.Drawing.Color.White;
            this.Search_btn.UseVisualStyleBackColor = false;
            // 
            // Search_txt
            // 
            this.Search_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Search_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Search_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Search_txt.BorderSize = 2;
            this.Search_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_txt.ForeColor = System.Drawing.Color.DimGray;
            this.Search_txt.IsFocused = false;
            this.Search_txt.Location = new System.Drawing.Point(8, 5);
            this.Search_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Search_txt.Multiline = false;
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Search_txt.PasswordChar = false;
            this.Search_txt.Size = new System.Drawing.Size(216, 35);
            this.Search_txt.TabIndex = 0;
            this.Search_txt.Texts = "";
            this.Search_txt.UnderlinedStyle = false;
            // 
            // InvoiceID_txt
            // 
            this.InvoiceID_txt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.InvoiceID_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.InvoiceID_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.InvoiceID_txt.BorderSize = 2;
            this.InvoiceID_txt.Enabled = false;
            this.InvoiceID_txt.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceID_txt.ForeColor = System.Drawing.Color.Black;
            this.InvoiceID_txt.IsFocused = false;
            this.InvoiceID_txt.Location = new System.Drawing.Point(138, 29);
            this.InvoiceID_txt.Margin = new System.Windows.Forms.Padding(4);
            this.InvoiceID_txt.Multiline = false;
            this.InvoiceID_txt.Name = "InvoiceID_txt";
            this.InvoiceID_txt.Padding = new System.Windows.Forms.Padding(7);
            this.InvoiceID_txt.PasswordChar = false;
            this.InvoiceID_txt.Size = new System.Drawing.Size(231, 38);
            this.InvoiceID_txt.TabIndex = 7;
            this.InvoiceID_txt.Texts = "";
            this.InvoiceID_txt.UnderlinedStyle = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(1161, 565);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Invoice_grbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_gridview)).EndInit();
            this.Search_tab.ResumeLayout(false);
            this.Searc_tab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Search_gridview)).EndInit();
            this.SearchAdvance_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox Invoice_grbx;
        private System.Windows.Forms.DataGridView Invoice_gridview;
        private System.Windows.Forms.TabControl Search_tab;
        private System.Windows.Forms.TabPage Searc_tab1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Search_gridview;
        private System.Windows.Forms.Panel SearchAdvance_panel;
        private Costumized.CostumButton Search_btn;
        private Costumized.CostumTextbox Search_txt;
        private System.Windows.Forms.Label ID_label;
        private Costumized.CostumTextbox ID_txt;
        private System.Windows.Forms.Label Quantity_label;
        private Costumized.CostumTextbox Quantity_txt;
        private FontAwesome.Sharp.IconButton Plus_btn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label InvoiceID_label;
        private Costumized.CostumTextbox InvoiceID_txt;
        private Costumized.CostumButton Add_btn;
        private System.Windows.Forms.Label Total_label;
        private Costumized.CostumTextbox Total_txt;
        private System.Windows.Forms.Label Recieved_label;
        private Costumized.CostumTextbox Recieved_txt;
        private System.Windows.Forms.Label Return_tabel;
        private Costumized.CostumTextbox Return_txt;
        private Costumized.CostumButton Remove_btn;
        private Costumized.CostumButton Edit_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Costumized.CostumButton Confirm_btn;
        private Costumized.CostumButton Cancel_btn;
    }
}
