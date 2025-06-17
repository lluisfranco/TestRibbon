using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
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
    public partial class ProfileUserControl : XtraUserControl, IModuleRibbon
    {
        public RibbonControl GetRibbon() => ribbon;
        public ProfileUserControl()
        {
            InitializeComponent();
        }
    }
}
