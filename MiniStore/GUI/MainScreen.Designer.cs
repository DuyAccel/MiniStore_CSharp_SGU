namespace MiniStore.GUI
{
    partial class MainScreen
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
            this.TaskbarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Exit_btn = new FontAwesome.Sharp.IconButton();
            this.FullScreen_btn = new FontAwesome.Sharp.IconButton();
            this.Hide_btn = new FontAwesome.Sharp.IconButton();
            this.ScreenPanel = new System.Windows.Forms.Panel();
            this.TaskbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskbarPanel
            // 
            this.TaskbarPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.TaskbarPanel.Controls.Add(this.Exit_btn);
            this.TaskbarPanel.Controls.Add(this.FullScreen_btn);
            this.TaskbarPanel.Controls.Add(this.Hide_btn);
            this.TaskbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaskbarPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.TaskbarPanel.Location = new System.Drawing.Point(0, 0);
            this.TaskbarPanel.Name = "TaskbarPanel";
            this.TaskbarPanel.Size = new System.Drawing.Size(1262, 29);
            this.TaskbarPanel.TabIndex = 0;
            this.TaskbarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskbarPanel_MouseDown);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.Exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Exit_btn.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.Exit_btn.IconColor = System.Drawing.Color.White;
            this.Exit_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Exit_btn.IconSize = 19;
            this.Exit_btn.Location = new System.Drawing.Point(1233, 3);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(26, 23);
            this.Exit_btn.TabIndex = 0;
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // FullScreen_btn
            // 
            this.FullScreen_btn.BackColor = System.Drawing.Color.Transparent;
            this.FullScreen_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FullScreen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullScreen_btn.ForeColor = System.Drawing.Color.Transparent;
            this.FullScreen_btn.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.FullScreen_btn.IconColor = System.Drawing.Color.White;
            this.FullScreen_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FullScreen_btn.IconSize = 19;
            this.FullScreen_btn.Location = new System.Drawing.Point(1201, 3);
            this.FullScreen_btn.Name = "FullScreen_btn";
            this.FullScreen_btn.Size = new System.Drawing.Size(26, 23);
            this.FullScreen_btn.TabIndex = 2;
            this.FullScreen_btn.UseVisualStyleBackColor = false;
            this.FullScreen_btn.Click += new System.EventHandler(this.FullScreen_btn_Click);
            // 
            // Hide_btn
            // 
            this.Hide_btn.BackColor = System.Drawing.Color.Transparent;
            this.Hide_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Hide_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Hide_btn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.Hide_btn.IconColor = System.Drawing.Color.White;
            this.Hide_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Hide_btn.IconSize = 19;
            this.Hide_btn.Location = new System.Drawing.Point(1169, 3);
            this.Hide_btn.Name = "Hide_btn";
            this.Hide_btn.Size = new System.Drawing.Size(26, 23);
            this.Hide_btn.TabIndex = 1;
            this.Hide_btn.UseVisualStyleBackColor = false;
            this.Hide_btn.Click += new System.EventHandler(this.Hide_btn_Click);
            // 
            // ScreenPanel
            // 
            this.ScreenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenPanel.Location = new System.Drawing.Point(0, 29);
            this.ScreenPanel.Name = "ScreenPanel";
            this.ScreenPanel.Size = new System.Drawing.Size(1262, 644);
            this.ScreenPanel.TabIndex = 1;
            // 
            // MainScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1420, 770);
            this.Controls.Add(this.ScreenPanel);
            this.Controls.Add(this.TaskbarPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý siêu thị mini";
            this.TaskbarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TaskbarPanel;
        private FontAwesome.Sharp.IconButton Exit_btn;
        private System.Windows.Forms.Panel ScreenPanel;
        private FontAwesome.Sharp.IconButton FullScreen_btn;
        private FontAwesome.Sharp.IconButton Hide_btn;
    }
}

