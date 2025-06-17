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
    public partial class Form1 : RibbonForm, IModuleRibbon
    {
        public RibbonControl GetRibbon() => ribbon;
        public Form1()
        {
            InitializeComponent();
            GetCurentModule()?.MergeRibbonWithParent(this);

            tabbedControlGroup.SelectedPageChanged += (s, e) =>
                GetCurentModule()?.MergeRibbonWithParent(this);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Refreshing");
        }

        private IModuleRibbon? GetCurentModule()
        {
            return tabbedControlGroup.SelectedTabPageIndex switch
            {
                0 => homeUserControl1,
                1 => listUserControl1,
                2 => profileUserControl1,
                _ => null
            };
        }
    }
}