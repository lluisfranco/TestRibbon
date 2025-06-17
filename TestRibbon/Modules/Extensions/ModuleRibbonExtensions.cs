using DevExpress.XtraLayout;
using TestRibbon;

namespace TestRibbon
{
    public static class ModuleRibbonExtensions
    {
        public static IModuleRibbon MergeRibbonWithParent(
            this IModuleRibbon module, IModuleRibbon parentmodule)
        {
            parentmodule.GetRibbon().UnMergeRibbon();
            parentmodule.GetRibbon().MergeRibbon(module.GetRibbon());
            if (parentmodule is Form form)
            {
                var mdiparentmodule = form.MdiParent as IModuleRibbon;
                mdiparentmodule?.GetRibbon().UnMergeRibbon();
                mdiparentmodule?.GetRibbon().MergeRibbon(parentmodule.GetRibbon());
            }
            return module;
        }
    }
}


//GetCurentModule()?.MergeRibbonWithParent(this);

//tabbedControlGroup.SelectedPageChanged += (s, e) =>
//    GetCurentModule()?.MergeRibbonWithParent(this);

//private IModuleRibbon? GetCurentModule()
//{
//    return tabbedControlGroup.SelectedTabPageIndex switch
//    {
//        0 => homeUserControl1,
//        1 => listUserControl1,
//        2 => profileUserControl1,
//        _ => null
//    };
//}
