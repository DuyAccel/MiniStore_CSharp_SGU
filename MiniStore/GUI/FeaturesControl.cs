﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.GUI
{
    public partial class FeaturesControl : UserControl
    {
        public FeaturesControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        public void AddFeatures(List<FeatureIcon> features)
        {
            foreach(FeatureIcon feature in features)
            {
                this.FlowFeatures.Controls.Add(feature);
            }
        }
        
    }
}
