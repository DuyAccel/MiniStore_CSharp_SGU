﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.GUI.Items
{
    public partial class Confirmation : UserControl
    {
        public Form parent;
        public bool Confimation = false;
        public Confirmation(string message)
        {
            InitializeComponent();
            this.Message_label.Text = message;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parent.Close();
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            Confimation = true;
            this.Dispose();
            parent.Close();
        }
    }
}
