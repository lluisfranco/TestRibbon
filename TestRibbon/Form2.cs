﻿using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRibbon
{
    public partial class Form2 : RibbonForm, IModuleRibbon
    {
        public RibbonControl GetRibbon() => ribbon;
        public Form2()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Saving");
        }
    }
}