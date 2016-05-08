namespace Birthright
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.txtFindProvince = new System.Windows.Forms.TextBox();
            this.lbxTest = new System.Windows.Forms.ListBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabRulers = new System.Windows.Forms.TabPage();
            this.btnDeleteRuler = new System.Windows.Forms.Button();
            this.btnUpdateRuler = new System.Windows.Forms.Button();
            this.txtRulerAbbreviation = new System.Windows.Forms.TextBox();
            this.lblRulerAbbreviation = new System.Windows.Forms.Label();
            this.txtRulerName = new System.Windows.Forms.TextBox();
            this.lblRulerName = new System.Windows.Forms.Label();
            this.lblRulerIDText = new System.Windows.Forms.Label();
            this.lblRulerIDLabel = new System.Windows.Forms.Label();
            this.btnAddNewRuler = new System.Windows.Forms.Button();
            this.dgvRulers = new System.Windows.Forms.DataGridView();
            this.tabRealms = new System.Windows.Forms.TabPage();
            this.btnDeleteRealm = new System.Windows.Forms.Button();
            this.btnUpdateRealm = new System.Windows.Forms.Button();
            this.txtRealmOwner = new System.Windows.Forms.TextBox();
            this.lblRealmOwner = new System.Windows.Forms.Label();
            this.txtRealmName = new System.Windows.Forms.TextBox();
            this.lblRealmName = new System.Windows.Forms.Label();
            this.lblRealmIDText = new System.Windows.Forms.Label();
            this.lblRealmIDLabel = new System.Windows.Forms.Label();
            this.btnAddNewRealm = new System.Windows.Forms.Button();
            this.dgvRealms = new System.Windows.Forms.DataGridView();
            this.tabProvinces = new System.Windows.Forms.TabPage();
            this.cbxProvinceTerrain = new System.Windows.Forms.ComboBox();
            this.cbxProvinceRoad = new System.Windows.Forms.CheckBox();
            this.lblProvinceRoad = new System.Windows.Forms.Label();
            this.txtProvinceLoyalty = new System.Windows.Forms.TextBox();
            this.lblProvinceLoyalty = new System.Windows.Forms.Label();
            this.lblProvinceOwner = new System.Windows.Forms.Label();
            this.lblProvinceSecondaryTerrain = new System.Windows.Forms.Label();
            this.txtProvinceOwner = new System.Windows.Forms.TextBox();
            this.lblProvinceTerrain = new System.Windows.Forms.Label();
            this.btnDeleteProvince = new System.Windows.Forms.Button();
            this.btnUpdateProvince = new System.Windows.Forms.Button();
            this.txtProvinceSize = new System.Windows.Forms.TextBox();
            this.lblProvinceSize = new System.Windows.Forms.Label();
            this.txtProvinceName = new System.Windows.Forms.TextBox();
            this.lblProvinceName = new System.Windows.Forms.Label();
            this.lblProvinceIDText = new System.Windows.Forms.Label();
            this.lblProvinceIDLabel = new System.Windows.Forms.Label();
            this.btnAddProvince = new System.Windows.Forms.Button();
            this.dgvProvinces = new System.Windows.Forms.DataGridView();
            this.ccbProvinceSecondaryTerrain = new Birthright.CheckedComboBox();
            this.tabHoldings = new System.Windows.Forms.TabPage();
            this.cbxHoldingType = new System.Windows.Forms.ComboBox();
            this.lblHoldingOwner = new System.Windows.Forms.Label();
            this.btnDeleteHolding = new System.Windows.Forms.Button();
            this.btnUpdateHolding = new System.Windows.Forms.Button();
            this.txtHoldingSize = new System.Windows.Forms.TextBox();
            this.lblHoldingSize = new System.Windows.Forms.Label();
            this.txtHoldingOwner = new System.Windows.Forms.TextBox();
            this.lblHoldingType = new System.Windows.Forms.Label();
            this.lblHoldingIDText = new System.Windows.Forms.Label();
            this.lblHoldingIDLabel = new System.Windows.Forms.Label();
            this.btnAddHolding = new System.Windows.Forms.Button();
            this.dgvHoldings = new System.Windows.Forms.DataGridView();
            this.cbxTest = new System.Windows.Forms.ComboBox();
            this.lblHoldingLocation = new System.Windows.Forms.Label();
            this.txtHoldingLocaton = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabRulers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRulers)).BeginInit();
            this.tabRealms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealms)).BeginInit();
            this.tabProvinces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvinces)).BeginInit();
            this.tabHoldings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoldings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(6, 6);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(872, 366);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // txtFindProvince
            // 
            this.txtFindProvince.Location = new System.Drawing.Point(1086, 142);
            this.txtFindProvince.Name = "txtFindProvince";
            this.txtFindProvince.Size = new System.Drawing.Size(100, 20);
            this.txtFindProvince.TabIndex = 1;
            this.txtFindProvince.TextChanged += new System.EventHandler(this.SearchBoxTyping);
            // 
            // lbxTest
            // 
            this.lbxTest.FormattingEnabled = true;
            this.lbxTest.Location = new System.Drawing.Point(1086, 12);
            this.lbxTest.Name = "lbxTest";
            this.lbxTest.Size = new System.Drawing.Size(120, 95);
            this.lbxTest.TabIndex = 2;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(1086, 113);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabRulers);
            this.tabControl1.Controls.Add(this.tabRealms);
            this.tabControl1.Controls.Add(this.tabProvinces);
            this.tabControl1.Controls.Add(this.tabHoldings);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1068, 520);
            this.tabControl1.TabIndex = 4;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.dgvMain);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(1060, 494);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabRulers
            // 
            this.tabRulers.Controls.Add(this.btnDeleteRuler);
            this.tabRulers.Controls.Add(this.btnUpdateRuler);
            this.tabRulers.Controls.Add(this.txtRulerAbbreviation);
            this.tabRulers.Controls.Add(this.lblRulerAbbreviation);
            this.tabRulers.Controls.Add(this.txtRulerName);
            this.tabRulers.Controls.Add(this.lblRulerName);
            this.tabRulers.Controls.Add(this.lblRulerIDText);
            this.tabRulers.Controls.Add(this.lblRulerIDLabel);
            this.tabRulers.Controls.Add(this.btnAddNewRuler);
            this.tabRulers.Controls.Add(this.dgvRulers);
            this.tabRulers.Location = new System.Drawing.Point(4, 22);
            this.tabRulers.Name = "tabRulers";
            this.tabRulers.Padding = new System.Windows.Forms.Padding(3);
            this.tabRulers.Size = new System.Drawing.Size(1060, 494);
            this.tabRulers.TabIndex = 1;
            this.tabRulers.Text = "Rulers";
            this.tabRulers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRuler
            // 
            this.btnDeleteRuler.Location = new System.Drawing.Point(196, 445);
            this.btnDeleteRuler.Name = "btnDeleteRuler";
            this.btnDeleteRuler.Size = new System.Drawing.Size(89, 23);
            this.btnDeleteRuler.TabIndex = 10;
            this.btnDeleteRuler.Text = "Delete Ruler";
            this.btnDeleteRuler.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRuler
            // 
            this.btnUpdateRuler.Location = new System.Drawing.Point(101, 445);
            this.btnUpdateRuler.Name = "btnUpdateRuler";
            this.btnUpdateRuler.Size = new System.Drawing.Size(89, 23);
            this.btnUpdateRuler.TabIndex = 9;
            this.btnUpdateRuler.Text = "Update Ruler";
            this.btnUpdateRuler.UseVisualStyleBackColor = true;
            // 
            // txtRulerAbbreviation
            // 
            this.txtRulerAbbreviation.Location = new System.Drawing.Point(182, 402);
            this.txtRulerAbbreviation.Name = "txtRulerAbbreviation";
            this.txtRulerAbbreviation.Size = new System.Drawing.Size(100, 20);
            this.txtRulerAbbreviation.TabIndex = 8;
            // 
            // lblRulerAbbreviation
            // 
            this.lblRulerAbbreviation.Location = new System.Drawing.Point(182, 382);
            this.lblRulerAbbreviation.Name = "lblRulerAbbreviation";
            this.lblRulerAbbreviation.Size = new System.Drawing.Size(100, 23);
            this.lblRulerAbbreviation.TabIndex = 7;
            this.lblRulerAbbreviation.Text = "Ruler Abbreviation";
            // 
            // txtRulerName
            // 
            this.txtRulerName.Location = new System.Drawing.Point(66, 402);
            this.txtRulerName.Name = "txtRulerName";
            this.txtRulerName.Size = new System.Drawing.Size(100, 20);
            this.txtRulerName.TabIndex = 6;
            // 
            // lblRulerName
            // 
            this.lblRulerName.Location = new System.Drawing.Point(66, 382);
            this.lblRulerName.Name = "lblRulerName";
            this.lblRulerName.Size = new System.Drawing.Size(100, 23);
            this.lblRulerName.TabIndex = 5;
            this.lblRulerName.Text = "Ruler Name";
            // 
            // lblRulerIDText
            // 
            this.lblRulerIDText.Location = new System.Drawing.Point(7, 405);
            this.lblRulerIDText.Name = "lblRulerIDText";
            this.lblRulerIDText.Size = new System.Drawing.Size(56, 19);
            this.lblRulerIDText.TabIndex = 4;
            // 
            // lblRulerIDLabel
            // 
            this.lblRulerIDLabel.Location = new System.Drawing.Point(7, 382);
            this.lblRulerIDLabel.Name = "lblRulerIDLabel";
            this.lblRulerIDLabel.Size = new System.Drawing.Size(56, 23);
            this.lblRulerIDLabel.TabIndex = 3;
            this.lblRulerIDLabel.Text = "RulerID";
            // 
            // btnAddNewRuler
            // 
            this.btnAddNewRuler.Location = new System.Drawing.Point(6, 445);
            this.btnAddNewRuler.Name = "btnAddNewRuler";
            this.btnAddNewRuler.Size = new System.Drawing.Size(89, 23);
            this.btnAddNewRuler.TabIndex = 2;
            this.btnAddNewRuler.Text = "Add New Ruler";
            this.btnAddNewRuler.UseVisualStyleBackColor = true;
            // 
            // dgvRulers
            // 
            this.dgvRulers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRulers.Location = new System.Drawing.Point(6, 6);
            this.dgvRulers.Name = "dgvRulers";
            this.dgvRulers.Size = new System.Drawing.Size(872, 366);
            this.dgvRulers.TabIndex = 1;
            this.dgvRulers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // tabRealms
            // 
            this.tabRealms.Controls.Add(this.btnDeleteRealm);
            this.tabRealms.Controls.Add(this.btnUpdateRealm);
            this.tabRealms.Controls.Add(this.txtRealmOwner);
            this.tabRealms.Controls.Add(this.lblRealmOwner);
            this.tabRealms.Controls.Add(this.txtRealmName);
            this.tabRealms.Controls.Add(this.lblRealmName);
            this.tabRealms.Controls.Add(this.lblRealmIDText);
            this.tabRealms.Controls.Add(this.lblRealmIDLabel);
            this.tabRealms.Controls.Add(this.btnAddNewRealm);
            this.tabRealms.Controls.Add(this.dgvRealms);
            this.tabRealms.Location = new System.Drawing.Point(4, 22);
            this.tabRealms.Name = "tabRealms";
            this.tabRealms.Padding = new System.Windows.Forms.Padding(3);
            this.tabRealms.Size = new System.Drawing.Size(1060, 494);
            this.tabRealms.TabIndex = 2;
            this.tabRealms.Text = "Realms";
            this.tabRealms.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRealm
            // 
            this.btnDeleteRealm.Location = new System.Drawing.Point(195, 445);
            this.btnDeleteRealm.Name = "btnDeleteRealm";
            this.btnDeleteRealm.Size = new System.Drawing.Size(86, 34);
            this.btnDeleteRealm.TabIndex = 19;
            this.btnDeleteRealm.Text = "Delete Realm";
            this.btnDeleteRealm.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRealm
            // 
            this.btnUpdateRealm.Location = new System.Drawing.Point(100, 445);
            this.btnUpdateRealm.Name = "btnUpdateRealm";
            this.btnUpdateRealm.Size = new System.Drawing.Size(86, 34);
            this.btnUpdateRealm.TabIndex = 18;
            this.btnUpdateRealm.Text = "Update Realm";
            this.btnUpdateRealm.UseVisualStyleBackColor = true;
            // 
            // txtRealmOwner
            // 
            this.txtRealmOwner.Location = new System.Drawing.Point(181, 405);
            this.txtRealmOwner.Name = "txtRealmOwner";
            this.txtRealmOwner.Size = new System.Drawing.Size(100, 20);
            this.txtRealmOwner.TabIndex = 17;
            // 
            // lblRealmOwner
            // 
            this.lblRealmOwner.Location = new System.Drawing.Point(181, 382);
            this.lblRealmOwner.Name = "lblRealmOwner";
            this.lblRealmOwner.Size = new System.Drawing.Size(100, 23);
            this.lblRealmOwner.TabIndex = 16;
            this.lblRealmOwner.Text = "Realm Owner";
            // 
            // txtRealmName
            // 
            this.txtRealmName.Location = new System.Drawing.Point(65, 405);
            this.txtRealmName.Name = "txtRealmName";
            this.txtRealmName.Size = new System.Drawing.Size(100, 20);
            this.txtRealmName.TabIndex = 15;
            // 
            // lblRealmName
            // 
            this.lblRealmName.Location = new System.Drawing.Point(65, 382);
            this.lblRealmName.Name = "lblRealmName";
            this.lblRealmName.Size = new System.Drawing.Size(100, 23);
            this.lblRealmName.TabIndex = 14;
            this.lblRealmName.Text = "Realm Name";
            // 
            // lblRealmIDText
            // 
            this.lblRealmIDText.Location = new System.Drawing.Point(6, 405);
            this.lblRealmIDText.Name = "lblRealmIDText";
            this.lblRealmIDText.Size = new System.Drawing.Size(56, 19);
            this.lblRealmIDText.TabIndex = 13;
            // 
            // lblRealmIDLabel
            // 
            this.lblRealmIDLabel.Location = new System.Drawing.Point(6, 382);
            this.lblRealmIDLabel.Name = "lblRealmIDLabel";
            this.lblRealmIDLabel.Size = new System.Drawing.Size(56, 23);
            this.lblRealmIDLabel.TabIndex = 12;
            this.lblRealmIDLabel.Text = "Realm ID";
            // 
            // btnAddNewRealm
            // 
            this.btnAddNewRealm.Location = new System.Drawing.Point(5, 445);
            this.btnAddNewRealm.Name = "btnAddNewRealm";
            this.btnAddNewRealm.Size = new System.Drawing.Size(86, 34);
            this.btnAddNewRealm.TabIndex = 11;
            this.btnAddNewRealm.Text = "Add New Realm";
            this.btnAddNewRealm.UseVisualStyleBackColor = true;
            // 
            // dgvRealms
            // 
            this.dgvRealms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRealms.Location = new System.Drawing.Point(6, 6);
            this.dgvRealms.Name = "dgvRealms";
            this.dgvRealms.Size = new System.Drawing.Size(872, 366);
            this.dgvRealms.TabIndex = 1;
            this.dgvRealms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // tabProvinces
            // 
            this.tabProvinces.Controls.Add(this.cbxProvinceTerrain);
            this.tabProvinces.Controls.Add(this.cbxProvinceRoad);
            this.tabProvinces.Controls.Add(this.lblProvinceRoad);
            this.tabProvinces.Controls.Add(this.txtProvinceLoyalty);
            this.tabProvinces.Controls.Add(this.lblProvinceLoyalty);
            this.tabProvinces.Controls.Add(this.lblProvinceOwner);
            this.tabProvinces.Controls.Add(this.lblProvinceSecondaryTerrain);
            this.tabProvinces.Controls.Add(this.txtProvinceOwner);
            this.tabProvinces.Controls.Add(this.lblProvinceTerrain);
            this.tabProvinces.Controls.Add(this.btnDeleteProvince);
            this.tabProvinces.Controls.Add(this.btnUpdateProvince);
            this.tabProvinces.Controls.Add(this.txtProvinceSize);
            this.tabProvinces.Controls.Add(this.lblProvinceSize);
            this.tabProvinces.Controls.Add(this.txtProvinceName);
            this.tabProvinces.Controls.Add(this.lblProvinceName);
            this.tabProvinces.Controls.Add(this.lblProvinceIDText);
            this.tabProvinces.Controls.Add(this.lblProvinceIDLabel);
            this.tabProvinces.Controls.Add(this.btnAddProvince);
            this.tabProvinces.Controls.Add(this.dgvProvinces);
            this.tabProvinces.Controls.Add(this.ccbProvinceSecondaryTerrain);
            this.tabProvinces.Location = new System.Drawing.Point(4, 22);
            this.tabProvinces.Name = "tabProvinces";
            this.tabProvinces.Size = new System.Drawing.Size(1060, 494);
            this.tabProvinces.TabIndex = 3;
            this.tabProvinces.Text = "Provinces";
            this.tabProvinces.UseVisualStyleBackColor = true;
            // 
            // cbxProvinceTerrain
            // 
            this.cbxProvinceTerrain.FormattingEnabled = true;
            this.cbxProvinceTerrain.Location = new System.Drawing.Point(302, 403);
            this.cbxProvinceTerrain.Name = "cbxProvinceTerrain";
            this.cbxProvinceTerrain.Size = new System.Drawing.Size(144, 21);
            this.cbxProvinceTerrain.TabIndex = 41;
            // 
            // cbxProvinceRoad
            // 
            this.cbxProvinceRoad.AutoSize = true;
            this.cbxProvinceRoad.Location = new System.Drawing.Point(887, 404);
            this.cbxProvinceRoad.Name = "cbxProvinceRoad";
            this.cbxProvinceRoad.Size = new System.Drawing.Size(15, 14);
            this.cbxProvinceRoad.TabIndex = 39;
            this.cbxProvinceRoad.UseVisualStyleBackColor = true;
            // 
            // lblProvinceRoad
            // 
            this.lblProvinceRoad.Location = new System.Drawing.Point(884, 381);
            this.lblProvinceRoad.Name = "lblProvinceRoad";
            this.lblProvinceRoad.Size = new System.Drawing.Size(100, 23);
            this.lblProvinceRoad.TabIndex = 38;
            this.lblProvinceRoad.Text = "Province Road";
            // 
            // txtProvinceLoyalty
            // 
            this.txtProvinceLoyalty.Location = new System.Drawing.Point(776, 403);
            this.txtProvinceLoyalty.Name = "txtProvinceLoyalty";
            this.txtProvinceLoyalty.Size = new System.Drawing.Size(100, 20);
            this.txtProvinceLoyalty.TabIndex = 37;
            // 
            // lblProvinceLoyalty
            // 
            this.lblProvinceLoyalty.Location = new System.Drawing.Point(778, 381);
            this.lblProvinceLoyalty.Name = "lblProvinceLoyalty";
            this.lblProvinceLoyalty.Size = new System.Drawing.Size(100, 23);
            this.lblProvinceLoyalty.TabIndex = 36;
            this.lblProvinceLoyalty.Text = "Province Loyalty";
            // 
            // lblProvinceOwner
            // 
            this.lblProvinceOwner.Location = new System.Drawing.Point(662, 380);
            this.lblProvinceOwner.Name = "lblProvinceOwner";
            this.lblProvinceOwner.Size = new System.Drawing.Size(100, 23);
            this.lblProvinceOwner.TabIndex = 34;
            this.lblProvinceOwner.Text = "Province Owner";
            // 
            // lblProvinceSecondaryTerrain
            // 
            this.lblProvinceSecondaryTerrain.Location = new System.Drawing.Point(452, 380);
            this.lblProvinceSecondaryTerrain.Name = "lblProvinceSecondaryTerrain";
            this.lblProvinceSecondaryTerrain.Size = new System.Drawing.Size(100, 23);
            this.lblProvinceSecondaryTerrain.TabIndex = 32;
            this.lblProvinceSecondaryTerrain.Text = "Secondary Terrain";
            // 
            // txtProvinceOwner
            // 
            this.txtProvinceOwner.Location = new System.Drawing.Point(662, 403);
            this.txtProvinceOwner.Name = "txtProvinceOwner";
            this.txtProvinceOwner.Size = new System.Drawing.Size(100, 20);
            this.txtProvinceOwner.TabIndex = 31;
            // 
            // lblProvinceTerrain
            // 
            this.lblProvinceTerrain.Location = new System.Drawing.Point(302, 380);
            this.lblProvinceTerrain.Name = "lblProvinceTerrain";
            this.lblProvinceTerrain.Size = new System.Drawing.Size(100, 23);
            this.lblProvinceTerrain.TabIndex = 30;
            this.lblProvinceTerrain.Text = "Terrain";
            // 
            // btnDeleteProvince
            // 
            this.btnDeleteProvince.Location = new System.Drawing.Point(196, 443);
            this.btnDeleteProvince.Name = "btnDeleteProvince";
            this.btnDeleteProvince.Size = new System.Drawing.Size(90, 35);
            this.btnDeleteProvince.TabIndex = 29;
            this.btnDeleteProvince.Text = "Delete Province";
            this.btnDeleteProvince.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProvince
            // 
            this.btnUpdateProvince.Location = new System.Drawing.Point(101, 443);
            this.btnUpdateProvince.Name = "btnUpdateProvince";
            this.btnUpdateProvince.Size = new System.Drawing.Size(90, 35);
            this.btnUpdateProvince.TabIndex = 28;
            this.btnUpdateProvince.Text = "Update Province";
            this.btnUpdateProvince.UseVisualStyleBackColor = true;
            // 
            // txtProvinceSize
            // 
            this.txtProvinceSize.Location = new System.Drawing.Point(196, 403);
            this.txtProvinceSize.Name = "txtProvinceSize";
            this.txtProvinceSize.Size = new System.Drawing.Size(100, 20);
            this.txtProvinceSize.TabIndex = 27;
            // 
            // lblProvinceSize
            // 
            this.lblProvinceSize.Location = new System.Drawing.Point(196, 380);
            this.lblProvinceSize.Name = "lblProvinceSize";
            this.lblProvinceSize.Size = new System.Drawing.Size(100, 23);
            this.lblProvinceSize.TabIndex = 26;
            this.lblProvinceSize.Text = "Province Size";
            // 
            // txtProvinceName
            // 
            this.txtProvinceName.Location = new System.Drawing.Point(90, 403);
            this.txtProvinceName.Name = "txtProvinceName";
            this.txtProvinceName.Size = new System.Drawing.Size(100, 20);
            this.txtProvinceName.TabIndex = 25;
            // 
            // lblProvinceName
            // 
            this.lblProvinceName.Location = new System.Drawing.Point(90, 380);
            this.lblProvinceName.Name = "lblProvinceName";
            this.lblProvinceName.Size = new System.Drawing.Size(100, 23);
            this.lblProvinceName.TabIndex = 24;
            this.lblProvinceName.Text = "Province Name";
            // 
            // lblProvinceIDText
            // 
            this.lblProvinceIDText.Location = new System.Drawing.Point(7, 403);
            this.lblProvinceIDText.Name = "lblProvinceIDText";
            this.lblProvinceIDText.Size = new System.Drawing.Size(77, 19);
            this.lblProvinceIDText.TabIndex = 23;
            // 
            // lblProvinceIDLabel
            // 
            this.lblProvinceIDLabel.Location = new System.Drawing.Point(7, 380);
            this.lblProvinceIDLabel.Name = "lblProvinceIDLabel";
            this.lblProvinceIDLabel.Size = new System.Drawing.Size(77, 23);
            this.lblProvinceIDLabel.TabIndex = 22;
            this.lblProvinceIDLabel.Text = "Province ID";
            // 
            // btnAddProvince
            // 
            this.btnAddProvince.Location = new System.Drawing.Point(6, 443);
            this.btnAddProvince.Name = "btnAddProvince";
            this.btnAddProvince.Size = new System.Drawing.Size(89, 35);
            this.btnAddProvince.TabIndex = 21;
            this.btnAddProvince.Text = "Add New Province";
            this.btnAddProvince.UseVisualStyleBackColor = true;
            // 
            // dgvProvinces
            // 
            this.dgvProvinces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvinces.Location = new System.Drawing.Point(6, 6);
            this.dgvProvinces.Name = "dgvProvinces";
            this.dgvProvinces.Size = new System.Drawing.Size(872, 366);
            this.dgvProvinces.TabIndex = 20;
            this.dgvProvinces.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // ccbProvinceSecondaryTerrain
            // 
            this.ccbProvinceSecondaryTerrain.CheckOnClick = true;
            this.ccbProvinceSecondaryTerrain.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ccbProvinceSecondaryTerrain.DropDownHeight = 1;
            this.ccbProvinceSecondaryTerrain.FormattingEnabled = true;
            this.ccbProvinceSecondaryTerrain.IntegralHeight = false;
            this.ccbProvinceSecondaryTerrain.Location = new System.Drawing.Point(452, 403);
            this.ccbProvinceSecondaryTerrain.Name = "ccbProvinceSecondaryTerrain";
            this.ccbProvinceSecondaryTerrain.Size = new System.Drawing.Size(204, 21);
            this.ccbProvinceSecondaryTerrain.TabIndex = 40;
            this.ccbProvinceSecondaryTerrain.ValueSeparator = ", ";
            // 
            // tabHoldings
            // 
            this.tabHoldings.Controls.Add(this.lblHoldingLocation);
            this.tabHoldings.Controls.Add(this.txtHoldingLocaton);
            this.tabHoldings.Controls.Add(this.cbxHoldingType);
            this.tabHoldings.Controls.Add(this.lblHoldingOwner);
            this.tabHoldings.Controls.Add(this.btnDeleteHolding);
            this.tabHoldings.Controls.Add(this.btnUpdateHolding);
            this.tabHoldings.Controls.Add(this.txtHoldingSize);
            this.tabHoldings.Controls.Add(this.lblHoldingSize);
            this.tabHoldings.Controls.Add(this.txtHoldingOwner);
            this.tabHoldings.Controls.Add(this.lblHoldingType);
            this.tabHoldings.Controls.Add(this.lblHoldingIDText);
            this.tabHoldings.Controls.Add(this.lblHoldingIDLabel);
            this.tabHoldings.Controls.Add(this.btnAddHolding);
            this.tabHoldings.Controls.Add(this.dgvHoldings);
            this.tabHoldings.Location = new System.Drawing.Point(4, 22);
            this.tabHoldings.Name = "tabHoldings";
            this.tabHoldings.Size = new System.Drawing.Size(1060, 494);
            this.tabHoldings.TabIndex = 4;
            this.tabHoldings.Text = "Holdings";
            this.tabHoldings.UseVisualStyleBackColor = true;
            // 
            // cbxHoldingType
            // 
            this.cbxHoldingType.FormattingEnabled = true;
            this.cbxHoldingType.Location = new System.Drawing.Point(201, 404);
            this.cbxHoldingType.Name = "cbxHoldingType";
            this.cbxHoldingType.Size = new System.Drawing.Size(100, 21);
            this.cbxHoldingType.TabIndex = 52;
            // 
            // lblHoldingOwner
            // 
            this.lblHoldingOwner.Location = new System.Drawing.Point(412, 381);
            this.lblHoldingOwner.Name = "lblHoldingOwner";
            this.lblHoldingOwner.Size = new System.Drawing.Size(100, 23);
            this.lblHoldingOwner.TabIndex = 51;
            this.lblHoldingOwner.Text = "Holding Owner";
            // 
            // btnDeleteHolding
            // 
            this.btnDeleteHolding.Location = new System.Drawing.Point(197, 444);
            this.btnDeleteHolding.Name = "btnDeleteHolding";
            this.btnDeleteHolding.Size = new System.Drawing.Size(90, 35);
            this.btnDeleteHolding.TabIndex = 50;
            this.btnDeleteHolding.Text = "Delete Holding";
            this.btnDeleteHolding.UseVisualStyleBackColor = true;
            // 
            // btnUpdateHolding
            // 
            this.btnUpdateHolding.Location = new System.Drawing.Point(102, 444);
            this.btnUpdateHolding.Name = "btnUpdateHolding";
            this.btnUpdateHolding.Size = new System.Drawing.Size(90, 35);
            this.btnUpdateHolding.TabIndex = 49;
            this.btnUpdateHolding.Text = "Update Holding";
            this.btnUpdateHolding.UseVisualStyleBackColor = true;
            // 
            // txtHoldingSize
            // 
            this.txtHoldingSize.Location = new System.Drawing.Point(306, 404);
            this.txtHoldingSize.Name = "txtHoldingSize";
            this.txtHoldingSize.Size = new System.Drawing.Size(100, 20);
            this.txtHoldingSize.TabIndex = 48;
            // 
            // lblHoldingSize
            // 
            this.lblHoldingSize.Location = new System.Drawing.Point(306, 381);
            this.lblHoldingSize.Name = "lblHoldingSize";
            this.lblHoldingSize.Size = new System.Drawing.Size(100, 23);
            this.lblHoldingSize.TabIndex = 47;
            this.lblHoldingSize.Text = "Holding Size";
            // 
            // txtHoldingOwner
            // 
            this.txtHoldingOwner.Location = new System.Drawing.Point(415, 404);
            this.txtHoldingOwner.Name = "txtHoldingOwner";
            this.txtHoldingOwner.Size = new System.Drawing.Size(100, 20);
            this.txtHoldingOwner.TabIndex = 46;
            // 
            // lblHoldingType
            // 
            this.lblHoldingType.Location = new System.Drawing.Point(200, 381);
            this.lblHoldingType.Name = "lblHoldingType";
            this.lblHoldingType.Size = new System.Drawing.Size(100, 23);
            this.lblHoldingType.TabIndex = 45;
            this.lblHoldingType.Text = "Holding Type";
            // 
            // lblHoldingIDText
            // 
            this.lblHoldingIDText.Location = new System.Drawing.Point(8, 407);
            this.lblHoldingIDText.Name = "lblHoldingIDText";
            this.lblHoldingIDText.Size = new System.Drawing.Size(77, 21);
            this.lblHoldingIDText.TabIndex = 44;
            // 
            // lblHoldingIDLabel
            // 
            this.lblHoldingIDLabel.Location = new System.Drawing.Point(8, 381);
            this.lblHoldingIDLabel.Name = "lblHoldingIDLabel";
            this.lblHoldingIDLabel.Size = new System.Drawing.Size(77, 23);
            this.lblHoldingIDLabel.TabIndex = 43;
            this.lblHoldingIDLabel.Text = "Holding ID";
            // 
            // btnAddHolding
            // 
            this.btnAddHolding.Location = new System.Drawing.Point(7, 444);
            this.btnAddHolding.Name = "btnAddHolding";
            this.btnAddHolding.Size = new System.Drawing.Size(89, 35);
            this.btnAddHolding.TabIndex = 42;
            this.btnAddHolding.Text = "Add New Holding";
            this.btnAddHolding.UseVisualStyleBackColor = true;
            // 
            // dgvHoldings
            // 
            this.dgvHoldings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoldings.Location = new System.Drawing.Point(6, 6);
            this.dgvHoldings.Name = "dgvHoldings";
            this.dgvHoldings.Size = new System.Drawing.Size(872, 366);
            this.dgvHoldings.TabIndex = 21;
            this.dgvHoldings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // cbxTest
            // 
            this.cbxTest.FormattingEnabled = true;
            this.cbxTest.Location = new System.Drawing.Point(1087, 169);
            this.cbxTest.Name = "cbxTest";
            this.cbxTest.Size = new System.Drawing.Size(121, 21);
            this.cbxTest.TabIndex = 5;
            // 
            // lblHoldingLocation
            // 
            this.lblHoldingLocation.Location = new System.Drawing.Point(91, 381);
            this.lblHoldingLocation.Name = "lblHoldingLocation";
            this.lblHoldingLocation.Size = new System.Drawing.Size(100, 23);
            this.lblHoldingLocation.TabIndex = 54;
            this.lblHoldingLocation.Text = "Holding Location";
            // 
            // txtHoldingLocaton
            // 
            this.txtHoldingLocaton.Location = new System.Drawing.Point(94, 404);
            this.txtHoldingLocaton.Name = "txtHoldingLocaton";
            this.txtHoldingLocaton.Size = new System.Drawing.Size(100, 20);
            this.txtHoldingLocaton.TabIndex = 53;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 544);
            this.Controls.Add(this.cbxTest);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lbxTest);
            this.Controls.Add(this.txtFindProvince);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabRulers.ResumeLayout(false);
            this.tabRulers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRulers)).EndInit();
            this.tabRealms.ResumeLayout(false);
            this.tabRealms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealms)).EndInit();
            this.tabProvinces.ResumeLayout(false);
            this.tabProvinces.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvinces)).EndInit();
            this.tabHoldings.ResumeLayout(false);
            this.tabHoldings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoldings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.TextBox txtFindProvince;
        private System.Windows.Forms.ListBox lbxTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabRulers;
        private System.Windows.Forms.Button btnDeleteRuler;
        private System.Windows.Forms.Button btnUpdateRuler;
        private System.Windows.Forms.TextBox txtRulerAbbreviation;
        private System.Windows.Forms.Label lblRulerAbbreviation;
        private System.Windows.Forms.TextBox txtRulerName;
        private System.Windows.Forms.Label lblRulerName;
        private System.Windows.Forms.Label lblRulerIDText;
        private System.Windows.Forms.Label lblRulerIDLabel;
        private System.Windows.Forms.Button btnAddNewRuler;
        private System.Windows.Forms.DataGridView dgvRulers;
        private System.Windows.Forms.TabPage tabRealms;
        private System.Windows.Forms.Button btnDeleteRealm;
        private System.Windows.Forms.Button btnUpdateRealm;
        private System.Windows.Forms.TextBox txtRealmOwner;
        private System.Windows.Forms.Label lblRealmOwner;
        private System.Windows.Forms.TextBox txtRealmName;
        private System.Windows.Forms.Label lblRealmName;
        private System.Windows.Forms.Label lblRealmIDText;
        private System.Windows.Forms.Label lblRealmIDLabel;
        private System.Windows.Forms.Button btnAddNewRealm;
        private System.Windows.Forms.DataGridView dgvRealms;
        private System.Windows.Forms.TabPage tabProvinces;
        private System.Windows.Forms.CheckBox cbxProvinceRoad;
        private System.Windows.Forms.Label lblProvinceRoad;
        private System.Windows.Forms.TextBox txtProvinceLoyalty;
        private System.Windows.Forms.Label lblProvinceLoyalty;
        private System.Windows.Forms.Label lblProvinceOwner;
        private System.Windows.Forms.Label lblProvinceSecondaryTerrain;
        private System.Windows.Forms.TextBox txtProvinceOwner;
        private System.Windows.Forms.Label lblProvinceTerrain;
        private System.Windows.Forms.Button btnDeleteProvince;
        private System.Windows.Forms.Button btnUpdateProvince;
        private System.Windows.Forms.TextBox txtProvinceSize;
        private System.Windows.Forms.Label lblProvinceSize;
        private System.Windows.Forms.TextBox txtProvinceName;
        private System.Windows.Forms.Label lblProvinceName;
        private System.Windows.Forms.Label lblProvinceIDText;
        private System.Windows.Forms.Label lblProvinceIDLabel;
        private System.Windows.Forms.Button btnAddProvince;
        private System.Windows.Forms.DataGridView dgvProvinces;
        private System.Windows.Forms.TabPage tabHoldings;
        private System.Windows.Forms.ComboBox cbxProvinceTerrain;
        private CheckedComboBox ccbProvinceSecondaryTerrain;
        private System.Windows.Forms.ComboBox cbxHoldingType;
        private System.Windows.Forms.Label lblHoldingOwner;
        private System.Windows.Forms.Button btnDeleteHolding;
        private System.Windows.Forms.Button btnUpdateHolding;
        private System.Windows.Forms.TextBox txtHoldingSize;
        private System.Windows.Forms.Label lblHoldingSize;
        private System.Windows.Forms.TextBox txtHoldingOwner;
        private System.Windows.Forms.Label lblHoldingType;
        private System.Windows.Forms.Label lblHoldingIDText;
        private System.Windows.Forms.Label lblHoldingIDLabel;
        private System.Windows.Forms.Button btnAddHolding;
        private System.Windows.Forms.DataGridView dgvHoldings;
        private System.Windows.Forms.ComboBox cbxTest;
        private System.Windows.Forms.Label lblHoldingLocation;
        private System.Windows.Forms.TextBox txtHoldingLocaton;
    }
}

