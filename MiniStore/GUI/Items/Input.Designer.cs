namespace MiniStore.GUI.Items
{
    partial class Input
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
            this.Spliter = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Plus_btn = new FontAwesome.Sharp.IconButton();
            this.Minus_btn = new FontAwesome.Sharp.IconButton();
            this.Quantity_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.Invoice_grbx = new System.Windows.Forms.GroupBox();
            this.Invoice_gridview = new System.Windows.Forms.DataGridView();
            this.Paying_label = new System.Windows.Forms.Label();
            this.User_label = new System.Windows.Forms.Label();
            this.Search_tab = new System.Windows.Forms.TabControl();
            this.Searc_tab1 = new System.Windows.Forms.TabPage();
            this.Search_gridview = new System.Windows.Forms.DataGridView();
            this.SearchAdvance_panel = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Barcode_pic = new System.Windows.Forms.PictureBox();
            this.Remove_btn = new MiniStore.Costumized.CostumButton();
            this.Edit_btn = new MiniStore.Costumized.CostumButton();
            this.Add_btn = new MiniStore.Costumized.CostumButton();
            this.Quantity_txt = new MiniStore.Costumized.CostumTextbox();
            this.ID_txt = new MiniStore.Costumized.CostumTextbox();
            this.Confirm_btn = new MiniStore.Costumized.CostumButton();
            this.Cancel_btn = new MiniStore.Costumized.CostumButton();
            this.Paying_txt = new MiniStore.Costumized.CostumTextbox();
            this.Search_btn = new MiniStore.Costumized.CostumButton();
            this.Search_txt = new MiniStore.Costumized.CostumTextbox();
            this.Stop_btn = new MiniStore.Costumized.CostumButton();
            this.Scan_btn = new MiniStore.Costumized.CostumButton();
            this.User_txt = new MiniStore.Costumized.CostumTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.Spliter)).BeginInit();
            this.Spliter.Panel1.SuspendLayout();
            this.Spliter.Panel2.SuspendLayout();
            this.Spliter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Invoice_grbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_gridview)).BeginInit();
            this.Search_tab.SuspendLayout();
            this.Searc_tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_gridview)).BeginInit();
            this.SearchAdvance_panel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Barcode_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Spliter
            // 
            this.Spliter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spliter.Location = new System.Drawing.Point(0, 0);
            this.Spliter.Name = "Spliter";
            // 
            // Spliter.Panel1
            // 
            this.Spliter.Panel1.AccessibleName = "";
            this.Spliter.Panel1.Controls.Add(this.pictureBox1);
            this.Spliter.Panel1.Controls.Add(this.Remove_btn);
            this.Spliter.Panel1.Controls.Add(this.Edit_btn);
            this.Spliter.Panel1.Controls.Add(this.Add_btn);
            this.Spliter.Panel1.Controls.Add(this.Plus_btn);
            this.Spliter.Panel1.Controls.Add(this.Minus_btn);
            this.Spliter.Panel1.Controls.Add(this.Quantity_label);
            this.Spliter.Panel1.Controls.Add(this.Quantity_txt);
            this.Spliter.Panel1.Controls.Add(this.ID_label);
            this.Spliter.Panel1.Controls.Add(this.ID_txt);
            this.Spliter.Panel1.Controls.Add(this.Invoice_grbx);
            // 
            // Spliter.Panel2
            // 
            this.Spliter.Panel2.Controls.Add(this.Confirm_btn);
            this.Spliter.Panel2.Controls.Add(this.Cancel_btn);
            this.Spliter.Panel2.Controls.Add(this.Paying_label);
            this.Spliter.Panel2.Controls.Add(this.Paying_txt);
            this.Spliter.Panel2.Controls.Add(this.User_label);
            this.Spliter.Panel2.Controls.Add(this.Search_tab);
            this.Spliter.Panel2.Controls.Add(this.User_txt);
            this.Spliter.Size = new System.Drawing.Size(1161, 602);
            this.Spliter.SplitterDistance = 771;
            this.Spliter.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(503, 390);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
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
            this.Plus_btn.Location = new System.Drawing.Point(388, 451);
            this.Plus_btn.Name = "Plus_btn";
            this.Plus_btn.Size = new System.Drawing.Size(58, 38);
            this.Plus_btn.TabIndex = 17;
            this.Plus_btn.UseVisualStyleBackColor = false;
            this.Plus_btn.Click += new System.EventHandler(this.Plus_btn_Click);
            // 
            // Minus_btn
            // 
            this.Minus_btn.FlatAppearance.BorderSize = 0;
            this.Minus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus_btn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.Minus_btn.IconColor = System.Drawing.Color.Red;
            this.Minus_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Minus_btn.Location = new System.Drawing.Point(212, 451);
            this.Minus_btn.Name = "Minus_btn";
            this.Minus_btn.Size = new System.Drawing.Size(58, 38);
            this.Minus_btn.TabIndex = 16;
            this.Minus_btn.UseVisualStyleBackColor = true;
            this.Minus_btn.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Quantity_label
            // 
            this.Quantity_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_label.Location = new System.Drawing.Point(42, 454);
            this.Quantity_label.Name = "Quantity_label";
            this.Quantity_label.Size = new System.Drawing.Size(164, 35);
            this.Quantity_label.TabIndex = 15;
            this.Quantity_label.Text = "Quantity:";
            this.Quantity_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ID_label
            // 
            this.ID_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.Location = new System.Drawing.Point(42, 393);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(164, 35);
            this.ID_label.TabIndex = 13;
            this.ID_label.Text = "ProductID:";
            this.ID_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Invoice_grbx
            // 
            this.Invoice_grbx.Controls.Add(this.Invoice_gridview);
            this.Invoice_grbx.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoice_grbx.Location = new System.Drawing.Point(18, 47);
            this.Invoice_grbx.Name = "Invoice_grbx";
            this.Invoice_grbx.Size = new System.Drawing.Size(735, 320);
            this.Invoice_grbx.TabIndex = 11;
            this.Invoice_grbx.TabStop = false;
            this.Invoice_grbx.Text = "Products";
            // 
            // Invoice_gridview
            // 
            this.Invoice_gridview.AllowUserToAddRows = false;
            this.Invoice_gridview.AllowUserToDeleteRows = false;
            this.Invoice_gridview.AllowUserToResizeColumns = false;
            this.Invoice_gridview.AllowUserToResizeRows = false;
            this.Invoice_gridview.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Invoice_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Invoice_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Invoice_gridview.Location = new System.Drawing.Point(3, 24);
            this.Invoice_gridview.Name = "Invoice_gridview";
            this.Invoice_gridview.ReadOnly = true;
            this.Invoice_gridview.RowHeadersVisible = false;
            this.Invoice_gridview.RowHeadersWidth = 51;
            this.Invoice_gridview.RowTemplate.Height = 24;
            this.Invoice_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Invoice_gridview.Size = new System.Drawing.Size(729, 293);
            this.Invoice_gridview.TabIndex = 0;
            // 
            // Paying_label
            // 
            this.Paying_label.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paying_label.Location = new System.Drawing.Point(19, 138);
            this.Paying_label.Name = "Paying_label";
            this.Paying_label.Size = new System.Drawing.Size(114, 35);
            this.Paying_label.TabIndex = 23;
            this.Paying_label.Text = "Paying:";
            this.Paying_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // User_label
            // 
            this.User_label.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_label.Location = new System.Drawing.Point(19, 75);
            this.User_label.Name = "User_label";
            this.User_label.Size = new System.Drawing.Size(114, 35);
            this.User_label.TabIndex = 18;
            this.User_label.Text = "Reciever:";
            this.User_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Search_tab
            // 
            this.Search_tab.Controls.Add(this.Searc_tab1);
            this.Search_tab.Controls.Add(this.tabPage2);
            this.Search_tab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_tab.Location = new System.Drawing.Point(16, 284);
            this.Search_tab.Name = "Search_tab";
            this.Search_tab.SelectedIndex = 0;
            this.Search_tab.Size = new System.Drawing.Size(355, 289);
            this.Search_tab.TabIndex = 16;
            // 
            // Searc_tab1
            // 
            this.Searc_tab1.Controls.Add(this.Search_gridview);
            this.Searc_tab1.Controls.Add(this.SearchAdvance_panel);
            this.Searc_tab1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searc_tab1.Location = new System.Drawing.Point(4, 32);
            this.Searc_tab1.Name = "Searc_tab1";
            this.Searc_tab1.Padding = new System.Windows.Forms.Padding(3);
            this.Searc_tab1.Size = new System.Drawing.Size(347, 253);
            this.Searc_tab1.TabIndex = 0;
            this.Searc_tab1.Text = "Search";
            this.Searc_tab1.UseVisualStyleBackColor = true;
            // 
            // Search_gridview
            // 
            this.Search_gridview.AllowUserToAddRows = false;
            this.Search_gridview.AllowUserToDeleteRows = false;
            this.Search_gridview.AllowUserToResizeRows = false;
            this.Search_gridview.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Search_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Search_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search_gridview.Location = new System.Drawing.Point(3, 47);
            this.Search_gridview.Name = "Search_gridview";
            this.Search_gridview.ReadOnly = true;
            this.Search_gridview.RowHeadersVisible = false;
            this.Search_gridview.RowHeadersWidth = 51;
            this.Search_gridview.RowTemplate.Height = 24;
            this.Search_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Search_gridview.Size = new System.Drawing.Size(341, 203);
            this.Search_gridview.TabIndex = 1;
            this.Search_gridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Search_gridview_CellDoubleClick);
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
            this.tabPage2.Controls.Add(this.Stop_btn);
            this.tabPage2.Controls.Add(this.Scan_btn);
            this.tabPage2.Controls.Add(this.Barcode_pic);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(347, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Barcode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Barcode_pic
            // 
            this.Barcode_pic.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Barcode_pic.Location = new System.Drawing.Point(6, 6);
            this.Barcode_pic.Name = "Barcode_pic";
            this.Barcode_pic.Size = new System.Drawing.Size(335, 195);
            this.Barcode_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Barcode_pic.TabIndex = 0;
            this.Barcode_pic.TabStop = false;
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
            this.Remove_btn.Location = new System.Drawing.Point(47, 522);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(135, 51);
            this.Remove_btn.TabIndex = 20;
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
            this.Edit_btn.Location = new System.Drawing.Point(188, 522);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(135, 51);
            this.Edit_btn.TabIndex = 19;
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
            this.Add_btn.Location = new System.Drawing.Point(329, 522);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(135, 51);
            this.Add_btn.TabIndex = 18;
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
            this.Quantity_txt.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_txt.ForeColor = System.Drawing.Color.Black;
            this.Quantity_txt.IsFocused = false;
            this.Quantity_txt.Location = new System.Drawing.Point(273, 451);
            this.Quantity_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Quantity_txt.Multiline = false;
            this.Quantity_txt.Name = "Quantity_txt";
            this.Quantity_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Quantity_txt.PasswordChar = false;
            this.Quantity_txt.Size = new System.Drawing.Size(110, 42);
            this.Quantity_txt.TabIndex = 14;
            this.Quantity_txt.Texts = "";
            this.Quantity_txt.UnderlinedStyle = false;
            // 
            // ID_txt
            // 
            this.ID_txt.BackColor = System.Drawing.SystemColors.Window;
            this.ID_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ID_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ID_txt.BorderSize = 2;
            this.ID_txt.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_txt.ForeColor = System.Drawing.Color.Black;
            this.ID_txt.IsFocused = false;
            this.ID_txt.Location = new System.Drawing.Point(273, 390);
            this.ID_txt.Margin = new System.Windows.Forms.Padding(4);
            this.ID_txt.Multiline = false;
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Padding = new System.Windows.Forms.Padding(7);
            this.ID_txt.PasswordChar = false;
            this.ID_txt.Size = new System.Drawing.Size(110, 42);
            this.ID_txt.TabIndex = 12;
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
            this.Confirm_btn.Location = new System.Drawing.Point(213, 218);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(128, 41);
            this.Confirm_btn.TabIndex = 26;
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
            this.Cancel_btn.Location = new System.Drawing.Point(54, 218);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(128, 41);
            this.Cancel_btn.TabIndex = 22;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.TextColor = System.Drawing.Color.White;
            this.Cancel_btn.UseVisualStyleBackColor = false;
            // 
            // Paying_txt
            // 
            this.Paying_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Paying_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Paying_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Paying_txt.BorderSize = 2;
            this.Paying_txt.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paying_txt.ForeColor = System.Drawing.Color.Black;
            this.Paying_txt.IsFocused = false;
            this.Paying_txt.Location = new System.Drawing.Point(140, 135);
            this.Paying_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Paying_txt.Multiline = false;
            this.Paying_txt.Name = "Paying_txt";
            this.Paying_txt.Padding = new System.Windows.Forms.Padding(7);
            this.Paying_txt.PasswordChar = false;
            this.Paying_txt.Size = new System.Drawing.Size(231, 38);
            this.Paying_txt.TabIndex = 21;
            this.Paying_txt.Texts = "";
            this.Paying_txt.UnderlinedStyle = false;
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
            // Stop_btn
            // 
            this.Stop_btn.BackColor = System.Drawing.Color.Crimson;
            this.Stop_btn.BackgroundColor = System.Drawing.Color.Crimson;
            this.Stop_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Stop_btn.BorderRadius = 20;
            this.Stop_btn.BorderSize = 0;
            this.Stop_btn.FlatAppearance.BorderSize = 0;
            this.Stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop_btn.ForeColor = System.Drawing.Color.White;
            this.Stop_btn.Location = new System.Drawing.Point(182, 207);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(150, 40);
            this.Stop_btn.TabIndex = 2;
            this.Stop_btn.Text = "Stop";
            this.Stop_btn.TextColor = System.Drawing.Color.White;
            this.Stop_btn.UseVisualStyleBackColor = false;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // Scan_btn
            // 
            this.Scan_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Scan_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Scan_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Scan_btn.BorderRadius = 20;
            this.Scan_btn.BorderSize = 0;
            this.Scan_btn.FlatAppearance.BorderSize = 0;
            this.Scan_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scan_btn.ForeColor = System.Drawing.Color.White;
            this.Scan_btn.Location = new System.Drawing.Point(12, 207);
            this.Scan_btn.Name = "Scan_btn";
            this.Scan_btn.Size = new System.Drawing.Size(150, 40);
            this.Scan_btn.TabIndex = 1;
            this.Scan_btn.Text = "Scan";
            this.Scan_btn.TextColor = System.Drawing.Color.White;
            this.Scan_btn.UseVisualStyleBackColor = false;
            this.Scan_btn.Click += new System.EventHandler(this.Scan_btn_Click);
            // 
            // User_txt
            // 
            this.User_txt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.User_txt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.User_txt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.User_txt.BorderSize = 2;
            this.User_txt.Enabled = false;
            this.User_txt.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_txt.ForeColor = System.Drawing.Color.Black;
            this.User_txt.IsFocused = false;
            this.User_txt.Location = new System.Drawing.Point(140, 72);
            this.User_txt.Margin = new System.Windows.Forms.Padding(4);
            this.User_txt.Multiline = false;
            this.User_txt.Name = "User_txt";
            this.User_txt.Padding = new System.Windows.Forms.Padding(7);
            this.User_txt.PasswordChar = false;
            this.User_txt.Size = new System.Drawing.Size(231, 38);
            this.User_txt.TabIndex = 17;
            this.User_txt.Texts = "";
            this.User_txt.UnderlinedStyle = false;
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Spliter);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Input";
            this.Size = new System.Drawing.Size(1161, 602);
            this.Spliter.Panel1.ResumeLayout(false);
            this.Spliter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Spliter)).EndInit();
            this.Spliter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Invoice_grbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_gridview)).EndInit();
            this.Search_tab.ResumeLayout(false);
            this.Searc_tab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Search_gridview)).EndInit();
            this.SearchAdvance_panel.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Barcode_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Spliter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Costumized.CostumButton Remove_btn;
        private Costumized.CostumButton Edit_btn;
        private Costumized.CostumButton Add_btn;
        private FontAwesome.Sharp.IconButton Plus_btn;
        private FontAwesome.Sharp.IconButton Minus_btn;
        private System.Windows.Forms.Label Quantity_label;
        private Costumized.CostumTextbox Quantity_txt;
        private System.Windows.Forms.Label ID_label;
        private Costumized.CostumTextbox ID_txt;
        private System.Windows.Forms.GroupBox Invoice_grbx;
        private System.Windows.Forms.DataGridView Invoice_gridview;
        private Costumized.CostumButton Confirm_btn;
        private Costumized.CostumButton Cancel_btn;
        private System.Windows.Forms.Label Paying_label;
        private Costumized.CostumTextbox Paying_txt;
        private System.Windows.Forms.Label User_label;
        private System.Windows.Forms.TabControl Search_tab;
        private System.Windows.Forms.TabPage Searc_tab1;
        private System.Windows.Forms.DataGridView Search_gridview;
        private System.Windows.Forms.Panel SearchAdvance_panel;
        private Costumized.CostumButton Search_btn;
        private Costumized.CostumTextbox Search_txt;
        private System.Windows.Forms.TabPage tabPage2;
        private Costumized.CostumTextbox User_txt;
        private Costumized.CostumButton Scan_btn;
        private System.Windows.Forms.PictureBox Barcode_pic;
        private Costumized.CostumButton Stop_btn;
    }
}
