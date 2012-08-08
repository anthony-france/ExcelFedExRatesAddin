namespace FedExShipToolsAddin
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl5 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl6 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl7 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl8 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl9 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl10 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl11 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl12 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl13 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl14 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl15 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl16 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl17 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl18 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl19 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl20 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl21 = this.Factory.CreateRibbonDropDownItem();
            this.tabShipTools = this.Factory.CreateRibbonTab();
            this.grpInsert = this.Factory.CreateRibbonGroup();
            this.box1 = this.Factory.CreateRibbonBox();
            this.txtOriginZip = this.Factory.CreateRibbonEditBox();
            this.txtOriginCountry = this.Factory.CreateRibbonEditBox();
            this.box3 = this.Factory.CreateRibbonBox();
            this.txtDestinationZip = this.Factory.CreateRibbonEditBox();
            this.txtDestinationCountry = this.Factory.CreateRibbonEditBox();
            this.grpPackageInfo = this.Factory.CreateRibbonGroup();
            this.box2 = this.Factory.CreateRibbonBox();
            this.selectServiceType = this.Factory.CreateRibbonDropDown();
            this.box4 = this.Factory.CreateRibbonBox();
            this.txtPackageWeight = this.Factory.CreateRibbonEditBox();
            this.grpSetRanges = this.Factory.CreateRibbonGroup();
            this.grpAutomate = this.Factory.CreateRibbonGroup();
            this.box5 = this.Factory.CreateRibbonBox();
            this.btnInsertRateSingle = this.Factory.CreateRibbonButton();
            this.btnSetOriginRange = this.Factory.CreateRibbonButton();
            this.btnSetDestinationRange = this.Factory.CreateRibbonButton();
            this.btnSetOutputRange = this.Factory.CreateRibbonButton();
            this.btnInsetRateMatrix = this.Factory.CreateRibbonButton();
            this.btnInsertDistanceMatrix = this.Factory.CreateRibbonButton();
            this.bgwInsertMatrix = new System.ComponentModel.BackgroundWorker();
            this.tabShipTools.SuspendLayout();
            this.grpInsert.SuspendLayout();
            this.box1.SuspendLayout();
            this.box3.SuspendLayout();
            this.grpPackageInfo.SuspendLayout();
            this.box2.SuspendLayout();
            this.box4.SuspendLayout();
            this.grpSetRanges.SuspendLayout();
            this.grpAutomate.SuspendLayout();
            this.box5.SuspendLayout();
            // 
            // tabShipTools
            // 
            this.tabShipTools.Groups.Add(this.grpInsert);
            this.tabShipTools.Groups.Add(this.grpPackageInfo);
            this.tabShipTools.Groups.Add(this.grpSetRanges);
            this.tabShipTools.Groups.Add(this.grpAutomate);
            this.tabShipTools.Label = "FedEx Shipping Tools";
            this.tabShipTools.Name = "tabShipTools";
            // 
            // grpInsert
            // 
            this.grpInsert.DialogLauncher = ribbonDialogLauncherImpl1;
            this.grpInsert.Items.Add(this.box1);
            this.grpInsert.Items.Add(this.box3);
            this.grpInsert.Items.Add(this.box5);
            this.grpInsert.Label = "Quick Insert";
            this.grpInsert.Name = "grpInsert";
            // 
            // box1
            // 
            this.box1.Items.Add(this.txtOriginZip);
            this.box1.Items.Add(this.txtOriginCountry);
            this.box1.Name = "box1";
            // 
            // txtOriginZip
            // 
            this.txtOriginZip.Label = "Origin Zip:";
            this.txtOriginZip.Name = "txtOriginZip";
            this.txtOriginZip.Text = null;
            // 
            // txtOriginCountry
            // 
            this.txtOriginCountry.Label = "editBox1";
            this.txtOriginCountry.MaxLength = 2;
            this.txtOriginCountry.Name = "txtOriginCountry";
            this.txtOriginCountry.ShowLabel = false;
            this.txtOriginCountry.Text = "US";
            // 
            // box3
            // 
            this.box3.Items.Add(this.txtDestinationZip);
            this.box3.Items.Add(this.txtDestinationCountry);
            this.box3.Name = "box3";
            // 
            // txtDestinationZip
            // 
            this.txtDestinationZip.Label = "Destination Zip:";
            this.txtDestinationZip.Name = "txtDestinationZip";
            this.txtDestinationZip.Text = null;
            // 
            // txtDestinationCountry
            // 
            this.txtDestinationCountry.Label = "editBox1";
            this.txtDestinationCountry.MaxLength = 2;
            this.txtDestinationCountry.Name = "txtDestinationCountry";
            this.txtDestinationCountry.ShowLabel = false;
            this.txtDestinationCountry.Text = "US";
            // 
            // grpPackageInfo
            // 
            this.grpPackageInfo.Items.Add(this.box2);
            this.grpPackageInfo.Items.Add(this.box4);
            this.grpPackageInfo.Label = "Package Information";
            this.grpPackageInfo.Name = "grpPackageInfo";
            // 
            // box2
            // 
            this.box2.Items.Add(this.selectServiceType);
            this.box2.Name = "box2";
            // 
            // selectServiceType
            // 
            ribbonDropDownItemImpl1.Label = "EUROPE_FIRST_INTERNATIONAL_PRIORITY";
            ribbonDropDownItemImpl2.Label = "FEDEX_1_DAY_FREIGHT";
            ribbonDropDownItemImpl3.Label = "FEDEX_2_DAY";
            ribbonDropDownItemImpl4.Label = "FEDEX_2_DAY_AM";
            ribbonDropDownItemImpl5.Label = "FEDEX_2_DAY_FREIGHT";
            ribbonDropDownItemImpl6.Label = "FEDEX_3_DAY_FREIGHT";
            ribbonDropDownItemImpl7.Label = "FEDEX_EXPRESS_SAVER";
            ribbonDropDownItemImpl8.Label = "FEDEX_FIRST_FREIGHT";
            ribbonDropDownItemImpl9.Label = "FEDEX_FREIGHT_ECONOMY";
            ribbonDropDownItemImpl10.Label = "FEDEX_FREIGHT_PRIORITY";
            ribbonDropDownItemImpl11.Label = "FEDEX_GROUND";
            ribbonDropDownItemImpl12.Label = "FIRST_OVERNIGHT";
            ribbonDropDownItemImpl13.Label = "GROUND_HOME_DELIVERY";
            ribbonDropDownItemImpl14.Label = "INTERNATIONAL_ECONOMY";
            ribbonDropDownItemImpl15.Label = "INTERNATIONAL_ECONOMY_FREIGHT";
            ribbonDropDownItemImpl16.Label = "INTERNATIONAL_FIRST";
            ribbonDropDownItemImpl17.Label = "INTERNATIONAL_PRIORITY";
            ribbonDropDownItemImpl18.Label = "INTERNATIONAL_PRIORITY_FREIGHT";
            ribbonDropDownItemImpl19.Label = "PRIORITY_OVERNIGHT";
            ribbonDropDownItemImpl20.Label = "SMART_POST";
            ribbonDropDownItemImpl21.Label = "STANDARD_OVERNIGHT";
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl1);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl2);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl3);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl4);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl5);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl6);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl7);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl8);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl9);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl10);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl11);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl12);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl13);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl14);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl15);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl16);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl17);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl18);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl19);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl20);
            this.selectServiceType.Items.Add(ribbonDropDownItemImpl21);
            this.selectServiceType.Label = "Service Type";
            this.selectServiceType.Name = "selectServiceType";
            this.selectServiceType.SizeString = "EUROPE_FIRST_INTERNATIONAL_PRIORITY";
            // 
            // box4
            // 
            this.box4.Items.Add(this.txtPackageWeight);
            this.box4.Name = "box4";
            // 
            // txtPackageWeight
            // 
            this.txtPackageWeight.Label = "Weight (lbs):";
            this.txtPackageWeight.Name = "txtPackageWeight";
            this.txtPackageWeight.Text = "2";
            // 
            // grpSetRanges
            // 
            this.grpSetRanges.Items.Add(this.btnSetOriginRange);
            this.grpSetRanges.Items.Add(this.btnSetDestinationRange);
            this.grpSetRanges.Items.Add(this.btnSetOutputRange);
            this.grpSetRanges.Label = "Set Ranges";
            this.grpSetRanges.Name = "grpSetRanges";
            // 
            // grpAutomate
            // 
            this.grpAutomate.Items.Add(this.btnInsetRateMatrix);
            this.grpAutomate.Items.Add(this.btnInsertDistanceMatrix);
            this.grpAutomate.Label = "AutoFill";
            this.grpAutomate.Name = "grpAutomate";
            // 
            // box5
            // 
            this.box5.Items.Add(this.btnInsertRateSingle);
            this.box5.Name = "box5";
            // 
            // btnInsertRateSingle
            // 
            this.btnInsertRateSingle.Image = global::FedExShipToolsAddin.Properties.Resources.mail;
            this.btnInsertRateSingle.Label = "Insert Rate Estimate";
            this.btnInsertRateSingle.Name = "btnInsertRateSingle";
            this.btnInsertRateSingle.ShowImage = true;
            this.btnInsertRateSingle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnInsertRateSingle_Click);
            // 
            // btnSetOriginRange
            // 
            this.btnSetOriginRange.Image = global::FedExShipToolsAddin.Properties.Resources.ui_select_range_icon;
            this.btnSetOriginRange.Label = "Origin";
            this.btnSetOriginRange.Name = "btnSetOriginRange";
            this.btnSetOriginRange.ShowImage = true;
            this.btnSetOriginRange.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSetOriginRange_Click);
            // 
            // btnSetDestinationRange
            // 
            this.btnSetDestinationRange.Image = global::FedExShipToolsAddin.Properties.Resources.ui_select_range_icon;
            this.btnSetDestinationRange.Label = "Destination";
            this.btnSetDestinationRange.Name = "btnSetDestinationRange";
            this.btnSetDestinationRange.ShowImage = true;
            this.btnSetDestinationRange.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSetDestinationRange_Click);
            // 
            // btnSetOutputRange
            // 
            this.btnSetOutputRange.Image = global::FedExShipToolsAddin.Properties.Resources.ui_select_range_icon;
            this.btnSetOutputRange.Label = "Output";
            this.btnSetOutputRange.Name = "btnSetOutputRange";
            this.btnSetOutputRange.ShowImage = true;
            this.btnSetOutputRange.Visible = false;
            this.btnSetOutputRange.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSetOutputRange_Click);
            // 
            // btnInsetRateMatrix
            // 
            this.btnInsetRateMatrix.Image = global::FedExShipToolsAddin.Properties.Resources.mail1;
            this.btnInsetRateMatrix.Label = "Inset Rate Matrix";
            this.btnInsetRateMatrix.Name = "btnInsetRateMatrix";
            this.btnInsetRateMatrix.ShowImage = true;
            this.btnInsetRateMatrix.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnInsetRateMatrix_Click);
            // 
            // btnInsertDistanceMatrix
            // 
            this.btnInsertDistanceMatrix.Image = global::FedExShipToolsAddin.Properties.Resources.b_measure_off;
            this.btnInsertDistanceMatrix.Label = "Insert Distance Matrix";
            this.btnInsertDistanceMatrix.Name = "btnInsertDistanceMatrix";
            this.btnInsertDistanceMatrix.ShowImage = true;
            this.btnInsertDistanceMatrix.Visible = false;
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabShipTools);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tabShipTools.ResumeLayout(false);
            this.tabShipTools.PerformLayout();
            this.grpInsert.ResumeLayout(false);
            this.grpInsert.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.box3.ResumeLayout(false);
            this.box3.PerformLayout();
            this.grpPackageInfo.ResumeLayout(false);
            this.grpPackageInfo.PerformLayout();
            this.box2.ResumeLayout(false);
            this.box2.PerformLayout();
            this.box4.ResumeLayout(false);
            this.box4.PerformLayout();
            this.grpSetRanges.ResumeLayout(false);
            this.grpSetRanges.PerformLayout();
            this.grpAutomate.ResumeLayout(false);
            this.grpAutomate.PerformLayout();
            this.box5.ResumeLayout(false);
            this.box5.PerformLayout();

        }

        #endregion

        private Microsoft.Office.Tools.Ribbon.RibbonTab tabShipTools;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpSetRanges;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSetOriginRange;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSetDestinationRange;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSetOutputRange;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpAutomate;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpInsert;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox txtDestinationZip;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInsertRateSingle;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInsetRateMatrix;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox txtOriginZip;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox txtOriginCountry;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox txtDestinationCountry;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnInsertDistanceMatrix;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpPackageInfo;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box2;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox txtPackageWeight;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown selectServiceType;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box3;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box4;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box5;
        private System.ComponentModel.BackgroundWorker bgwInsertMatrix;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
