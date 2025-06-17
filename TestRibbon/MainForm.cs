using DevExpress.XtraBars;
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
    public partial class MainForm : RibbonForm, IModuleRibbon
    {
        public RibbonControl GetRibbon() => ribbon;
        public MainForm()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new Form2();
            f.MdiParent = this;
            f.Show();
        }
    }
}