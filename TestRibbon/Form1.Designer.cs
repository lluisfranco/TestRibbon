namespace TestRibbon
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            svgImageCollection32 = new DevExpress.Utils.SvgImageCollection(components);
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            layoutControl = new DevExpress.XtraLayout.LayoutControl();
            profileUserControl1 = new ProfileUserControl();
            listUserControl1 = new ListUserControl();
            homeUserControl1 = new HomeUserControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            tabbedControlGroup = new DevExpress.XtraLayout.TabbedControlGroup();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection32).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl).BeginInit();
            layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabbedControlGroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Images = svgImageCollection32;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, barButtonItem1, barButtonItem2, barButtonItem3 });
            ribbon.LargeImages = svgImageCollection32;
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 4;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(808, 158);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // svgImageCollection32
            // 
            svgImageCollection32.ImageSize = new Size(32, 32);
            svgImageCollection32.Add("AccountTemplate", "TestRibbon.Resources.Images.AccountingGateway.AccountTemplate.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Configuration", "TestRibbon.Resources.Images.AccountingGateway.Configuration.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("EntryTypeCredit", "TestRibbon.Resources.Images.AccountingGateway.EntryTypeCredit.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("EntryTypeDebit", "TestRibbon.Resources.Images.AccountingGateway.EntryTypeDebit.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("MoveNextStep", "TestRibbon.Resources.Images.AccountingGateway.MoveNextStep.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("MovePrevStep", "TestRibbon.Resources.Images.AccountingGateway.MovePrevStep.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("RecalcPlusvalues", "TestRibbon.Resources.Images.AccountingGateway.RecalcPlusvalues.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("SyncGains", "TestRibbon.Resources.Images.AccountingGateway.SyncGains.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("SyncMovements", "TestRibbon.Resources.Images.AccountingGateway.SyncMovements.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Template", "TestRibbon.Resources.Images.AccountingGateway.Template.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("TemplateCondition", "TestRibbon.Resources.Images.AccountingGateway.TemplateCondition.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Unsync", "TestRibbon.Resources.Images.AccountingGateway.Unsync.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("AccountType", "TestRibbon.Resources.Images.Accounts.AccountType.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("AccountType100", "TestRibbon.Resources.Images.Accounts.AccountType100.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("AccountType200", "TestRibbon.Resources.Images.Accounts.AccountType200.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("AccountType300", "TestRibbon.Resources.Images.Accounts.AccountType300.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("AccountType400", "TestRibbon.Resources.Images.Accounts.AccountType400.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("AccountType500", "TestRibbon.Resources.Images.Accounts.AccountType500.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("AccountType600", "TestRibbon.Resources.Images.Accounts.AccountType600.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("AccountType700", "TestRibbon.Resources.Images.Accounts.AccountType700.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("AccountTypeAll", "TestRibbon.Resources.Images.Accounts.AccountTypeAll.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Behaviors", "TestRibbon.Resources.Images.Admin.Behaviors.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Country", "TestRibbon.Resources.Images.Admin.Country.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("CustomList", "TestRibbon.Resources.Images.Admin.CustomList.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Language", "TestRibbon.Resources.Images.Admin.Language.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("MetadataDefinitions", "TestRibbon.Resources.Images.Admin.MetadataDefinitions.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Region", "TestRibbon.Resources.Images.Admin.Region.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Signature", "TestRibbon.Resources.Images.Admin.Signature.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Town", "TestRibbon.Resources.Images.Admin.Town.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("ValueType", "TestRibbon.Resources.Images.Admin.ValueType.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("AppIcon", "TestRibbon.Resources.Images._FimargeApp.AppIcon.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("AppIconFullSize", "TestRibbon.Resources.Images._FimargeApp.AppIconFullSize.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("AppIconGray", "TestRibbon.Resources.Images._FimargeApp.AppIconGray.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("AppIconGreen", "TestRibbon.Resources.Images._FimargeApp.AppIconGreen.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("AssetClassification", "TestRibbon.Resources.Images._FimargeApp.AssetClassification.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Audit_ChangeEMail", "TestRibbon.Resources.Images._FimargeApp.Audit_ChangeEMail.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Audit_ChangePassword", "TestRibbon.Resources.Images._FimargeApp.Audit_ChangePassword.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Audit_ChangeProfilePicture", "TestRibbon.Resources.Images._FimargeApp.Audit_ChangeProfilePicture.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Audit_Login", "TestRibbon.Resources.Images._FimargeApp.Audit_Login.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Audit_LoginFail", "TestRibbon.Resources.Images._FimargeApp.Audit_LoginFail.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Audit_ResetPassword", "TestRibbon.Resources.Images._FimargeApp.Audit_ResetPassword.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Audit_ResetPasswordUpdated", "TestRibbon.Resources.Images._FimargeApp.Audit_ResetPasswordUpdated.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Delete", "TestRibbon.Resources.Images._FimargeApp.Delete.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("DockPane", "TestRibbon.Resources.Images._FimargeApp.DockPane.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("DocTypePersonalId", "TestRibbon.Resources.Images._FimargeApp.DocTypePersonalId.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("DocTypeReport", "TestRibbon.Resources.Images._FimargeApp.DocTypeReport.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("EagleIcon", "TestRibbon.Resources.Images._FimargeApp.EagleIcon.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("EagleIcon2", "TestRibbon.Resources.Images._FimargeApp.EagleIcon2.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Edit", "TestRibbon.Resources.Images._FimargeApp.Edit.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("EditImpersonatedLogin", "TestRibbon.Resources.Images._FimargeApp.EditImpersonatedLogin.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("FindImpersonatedLogin", "TestRibbon.Resources.Images._FimargeApp.FindImpersonatedLogin.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("ghost", "TestRibbon.Resources.Images._FimargeApp.ghost.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Home", "TestRibbon.Resources.Images._FimargeApp.Home.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("ImpersonateThis", "TestRibbon.Resources.Images._FimargeApp.ImpersonateThis.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Info", "TestRibbon.Resources.Images._FimargeApp.Info.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("LayoutManagement", "TestRibbon.Resources.Images._FimargeApp.LayoutManagement.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("LoginsList", "TestRibbon.Resources.Images._FimargeApp.LoginsList.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("NewAppLogo", "TestRibbon.Resources.Images._FimargeApp.NewAppLogo.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("NewImpersonation", "TestRibbon.Resources.Images._FimargeApp.NewImpersonation.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("NewLogin", "TestRibbon.Resources.Images._FimargeApp.NewLogin.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Open", "TestRibbon.Resources.Images._FimargeApp.Open.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("PortfolioListAdd", "TestRibbon.Resources.Images._FimargeApp.PortfolioListAdd.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("PortfolioListEdit", "TestRibbon.Resources.Images._FimargeApp.PortfolioListEdit.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("PortfolioListRemove", "TestRibbon.Resources.Images._FimargeApp.PortfolioListRemove.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Profile", "TestRibbon.Resources.Images._FimargeApp.Profile.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("RevealPasswordMedium", "TestRibbon.Resources.Images._FimargeApp.RevealPasswordMedium.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("RoleAdmin", "TestRibbon.Resources.Images._FimargeApp.RoleAdmin.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("RoleStandard", "TestRibbon.Resources.Images._FimargeApp.RoleStandard.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Settings", "TestRibbon.Resources.Images._FimargeApp.Settings.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Swagger", "TestRibbon.Resources.Images._FimargeApp.Swagger.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("TypeAll", "TestRibbon.Resources.Images._FimargeApp.TypeAll.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("TypeImpersonate", "TestRibbon.Resources.Images._FimargeApp.TypeImpersonate.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("TypeLogin", "TestRibbon.Resources.Images._FimargeApp.TypeLogin.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("UserChangePassword", "TestRibbon.Resources.Images._FimargeApp.UserChangePassword.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("UserImpersonate", "TestRibbon.Resources.Images._FimargeApp.UserImpersonate.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("UserLogin", "TestRibbon.Resources.Images._FimargeApp.UserLogin.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("UserProfileEmpty", "TestRibbon.Resources.Images._FimargeApp.UserProfileEmpty.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("UserResetPassword", "TestRibbon.Resources.Images._FimargeApp.UserResetPassword.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("Warning", "TestRibbon.Resources.Images._FimargeApp.Warning.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("_FimargeApp", "TestRibbon.Resources.Images._FimargeApp._FimargeApp.svg", "TestRibbon.Resources");
            svgImageCollection32.Add("_FimargeApp_615x615", "TestRibbon.Resources.Images._FimargeApp._FimargeApp_615x615.svg", "TestRibbon.Resources");
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Refresh";
            barButtonItem1.Id = 1;
            barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Profile";
            barButtonItem2.Id = 2;
            barButtonItem2.ImageOptions.LargeImageKey = "UserProfileEmpty";
            barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "Accounts";
            barButtonItem3.Id = 3;
            barButtonItem3.ImageOptions.LargeImageIndex = 18;
            barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "FALCON";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem3);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Options";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 632);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(808, 24);
            // 
            // layoutControl
            // 
            layoutControl.Controls.Add(profileUserControl1);
            layoutControl.Controls.Add(listUserControl1);
            layoutControl.Controls.Add(homeUserControl1);
            layoutControl.Dock = DockStyle.Fill;
            layoutControl.Images = svgImageCollection32;
            layoutControl.Location = new Point(0, 158);
            layoutControl.Name = "layoutControl";
            layoutControl.Root = Root;
            layoutControl.Size = new Size(808, 474);
            layoutControl.TabIndex = 2;
            layoutControl.Text = "layoutControl1";
            // 
            // profileUserControl1
            // 
            profileUserControl1.Location = new Point(66, 24);
            profileUserControl1.Name = "profileUserControl1";
            profileUserControl1.Size = new Size(718, 426);
            profileUserControl1.TabIndex = 6;
            // 
            // listUserControl1
            // 
            listUserControl1.Location = new Point(66, 24);
            listUserControl1.Name = "listUserControl1";
            listUserControl1.Size = new Size(718, 426);
            listUserControl1.TabIndex = 5;
            // 
            // homeUserControl1
            // 
            homeUserControl1.Location = new Point(66, 24);
            homeUserControl1.Name = "homeUserControl1";
            homeUserControl1.Size = new Size(718, 426);
            homeUserControl1.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { tabbedControlGroup });
            Root.Name = "Root";
            Root.Size = new Size(808, 474);
            Root.TextVisible = false;
            // 
            // tabbedControlGroup
            // 
            tabbedControlGroup.Location = new Point(0, 0);
            tabbedControlGroup.Name = "tabbedControlGroup";
            tabbedControlGroup.SelectedTabPage = layoutControlGroup1;
            tabbedControlGroup.Size = new Size(788, 454);
            tabbedControlGroup.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup1, layoutControlGroup2, layoutControlGroup3 });
            tabbedControlGroup.TextLocation = DevExpress.Utils.Locations.Left;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.CaptionImageOptions.ImageIndex = 11;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            layoutControlGroup1.Location = new Point(0, 0);
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new Size(722, 430);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = homeUserControl1;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(722, 430);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            layoutControlGroup2.CaptionImageOptions.ImageIndex = 16;
            layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2 });
            layoutControlGroup2.Location = new Point(0, 0);
            layoutControlGroup2.Name = "layoutControlGroup2";
            layoutControlGroup2.Size = new Size(722, 430);
            layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = listUserControl1;
            layoutControlItem2.Location = new Point(0, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(722, 430);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            layoutControlGroup3.CaptionImageOptions.ImageIndex = 35;
            layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem3 });
            layoutControlGroup3.Location = new Point(0, 0);
            layoutControlGroup3.Name = "layoutControlGroup3";
            layoutControlGroup3.Size = new Size(722, 430);
            layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = profileUserControl1;
            layoutControlItem3.Location = new Point(0, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(722, 430);
            layoutControlItem3.TextVisible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 656);
            Controls.Add(layoutControl);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "Form1";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection32).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl).EndInit();
            layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabbedControlGroup).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.Utils.SvgImageCollection svgImageCollection32;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private HomeUserControl homeUserControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private ProfileUserControl profileUserControl1;
        private ListUserControl listUserControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}