namespace MCO.Applications.MOSPackMaintenance
{
    partial class PackMaintScreen
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
            this.gbFilterCriteria = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblThing5 = new System.Windows.Forms.Label();
            this.cbSubRangeFilter = new System.Windows.Forms.ComboBox();
            this.lblThing4 = new System.Windows.Forms.Label();
            this.cbRangeFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSectionFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSubDeptFilter = new System.Windows.Forms.ComboBox();
            this.lblWhateverMateNooneLooksAtTheseAnyway = new System.Windows.Forms.Label();
            this.cbDeptFilter = new System.Windows.Forms.ComboBox();
            this.gbExtendedInfo = new System.Windows.Forms.GroupBox();
            this.txtPackName = new System.Windows.Forms.TextBox();
            this.txtPackID = new System.Windows.Forms.TextBox();
            this.lblPackName = new System.Windows.Forms.Label();
            this.lblPackID = new System.Windows.Forms.Label();
            this.dgvPackMaintView = new System.Windows.Forms.DataGridView();
            this.dgvSizesInPack = new System.Windows.Forms.DataGridView();
            this.gbSizesInUse = new System.Windows.Forms.GroupBox();
            this.gbProductsInPack = new System.Windows.Forms.GroupBox();
            this.dgvProductsInPack = new System.Windows.Forms.DataGridView();
            this.gbDepartmentsUsingPack = new System.Windows.Forms.GroupBox();
            this.dgvPackDepartments = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPackCodes = new System.Windows.Forms.DataGridView();
            this.gbPackListing = new System.Windows.Forms.GroupBox();
            this.btnAddNewPack = new System.Windows.Forms.Button();
            this.btnReplicatePack = new System.Windows.Forms.Button();
            this.btnUpdatePackInfo = new System.Windows.Forms.Button();
            this.lblDeptDescription = new System.Windows.Forms.Label();
            this.lblSubDeptDescription = new System.Windows.Forms.Label();
            this.lblSectionDescription = new System.Windows.Forms.Label();
            this.lblRangeDescription = new System.Windows.Forms.Label();
            this.lblSubRangeDescription = new System.Windows.Forms.Label();
            this.gbFilterCriteria.SuspendLayout();
            this.gbExtendedInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackMaintView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizesInPack)).BeginInit();
            this.gbSizesInUse.SuspendLayout();
            this.gbProductsInPack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsInPack)).BeginInit();
            this.gbDepartmentsUsingPack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackDepartments)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackCodes)).BeginInit();
            this.gbPackListing.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilterCriteria
            // 
            this.gbFilterCriteria.Controls.Add(this.lblSubRangeDescription);
            this.gbFilterCriteria.Controls.Add(this.lblRangeDescription);
            this.gbFilterCriteria.Controls.Add(this.lblSectionDescription);
            this.gbFilterCriteria.Controls.Add(this.lblSubDeptDescription);
            this.gbFilterCriteria.Controls.Add(this.lblDeptDescription);
            this.gbFilterCriteria.Controls.Add(this.btnSubmit);
            this.gbFilterCriteria.Controls.Add(this.lblThing5);
            this.gbFilterCriteria.Controls.Add(this.cbSubRangeFilter);
            this.gbFilterCriteria.Controls.Add(this.lblThing4);
            this.gbFilterCriteria.Controls.Add(this.cbRangeFilter);
            this.gbFilterCriteria.Controls.Add(this.label2);
            this.gbFilterCriteria.Controls.Add(this.cbSectionFilter);
            this.gbFilterCriteria.Controls.Add(this.label1);
            this.gbFilterCriteria.Controls.Add(this.cbSubDeptFilter);
            this.gbFilterCriteria.Controls.Add(this.lblWhateverMateNooneLooksAtTheseAnyway);
            this.gbFilterCriteria.Controls.Add(this.cbDeptFilter);
            this.gbFilterCriteria.Location = new System.Drawing.Point(12, 18);
            this.gbFilterCriteria.Name = "gbFilterCriteria";
            this.gbFilterCriteria.Size = new System.Drawing.Size(232, 341);
            this.gbFilterCriteria.TabIndex = 0;
            this.gbFilterCriteria.TabStop = false;
            this.gbFilterCriteria.Text = "Search Criteria";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(6, 318);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(217, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Search Packs";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblThing5
            // 
            this.lblThing5.AutoSize = true;
            this.lblThing5.Location = new System.Drawing.Point(6, 251);
            this.lblThing5.Name = "lblThing5";
            this.lblThing5.Size = new System.Drawing.Size(61, 13);
            this.lblThing5.TabIndex = 9;
            this.lblThing5.Text = "Sub Range";
            // 
            // cbSubRangeFilter
            // 
            this.cbSubRangeFilter.FormattingEnabled = true;
            this.cbSubRangeFilter.Items.AddRange(new object[] {
            "(all)",
            "1",
            "2",
            "3",
            "4"});
            this.cbSubRangeFilter.Location = new System.Drawing.Point(130, 247);
            this.cbSubRangeFilter.Name = "cbSubRangeFilter";
            this.cbSubRangeFilter.Size = new System.Drawing.Size(93, 21);
            this.cbSubRangeFilter.TabIndex = 8;
            this.cbSubRangeFilter.Tag = "searchFilter";
            this.cbSubRangeFilter.Text = "(all)";
            // 
            // lblThing4
            // 
            this.lblThing4.AutoSize = true;
            this.lblThing4.Location = new System.Drawing.Point(6, 197);
            this.lblThing4.Name = "lblThing4";
            this.lblThing4.Size = new System.Drawing.Size(39, 13);
            this.lblThing4.TabIndex = 7;
            this.lblThing4.Text = "Range";
            // 
            // cbRangeFilter
            // 
            this.cbRangeFilter.FormattingEnabled = true;
            this.cbRangeFilter.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbRangeFilter.Location = new System.Drawing.Point(130, 193);
            this.cbRangeFilter.Name = "cbRangeFilter";
            this.cbRangeFilter.Size = new System.Drawing.Size(93, 21);
            this.cbRangeFilter.TabIndex = 6;
            this.cbRangeFilter.Tag = "searchFilter";
            this.cbRangeFilter.Text = "(all)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Section";
            // 
            // cbSectionFilter
            // 
            this.cbSectionFilter.FormattingEnabled = true;
            this.cbSectionFilter.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbSectionFilter.Location = new System.Drawing.Point(130, 139);
            this.cbSectionFilter.Name = "cbSectionFilter";
            this.cbSectionFilter.Size = new System.Drawing.Size(93, 21);
            this.cbSectionFilter.TabIndex = 4;
            this.cbSectionFilter.Tag = "searchFilter";
            this.cbSectionFilter.Text = "(all)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sub Department";
            // 
            // cbSubDeptFilter
            // 
            this.cbSubDeptFilter.FormattingEnabled = true;
            this.cbSubDeptFilter.Items.AddRange(new object[] {
            "P",
            "N",
            "K",
            "L"});
            this.cbSubDeptFilter.Location = new System.Drawing.Point(130, 85);
            this.cbSubDeptFilter.Name = "cbSubDeptFilter";
            this.cbSubDeptFilter.Size = new System.Drawing.Size(93, 21);
            this.cbSubDeptFilter.TabIndex = 2;
            this.cbSubDeptFilter.Tag = "searchFilter";
            this.cbSubDeptFilter.Text = "(all)";
            // 
            // lblWhateverMateNooneLooksAtTheseAnyway
            // 
            this.lblWhateverMateNooneLooksAtTheseAnyway.AutoSize = true;
            this.lblWhateverMateNooneLooksAtTheseAnyway.Location = new System.Drawing.Point(6, 35);
            this.lblWhateverMateNooneLooksAtTheseAnyway.Name = "lblWhateverMateNooneLooksAtTheseAnyway";
            this.lblWhateverMateNooneLooksAtTheseAnyway.Size = new System.Drawing.Size(62, 13);
            this.lblWhateverMateNooneLooksAtTheseAnyway.TabIndex = 1;
            this.lblWhateverMateNooneLooksAtTheseAnyway.Text = "Department";
            // 
            // cbDeptFilter
            // 
            this.cbDeptFilter.FormattingEnabled = true;
            this.cbDeptFilter.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbDeptFilter.Location = new System.Drawing.Point(130, 31);
            this.cbDeptFilter.Name = "cbDeptFilter";
            this.cbDeptFilter.Size = new System.Drawing.Size(93, 21);
            this.cbDeptFilter.TabIndex = 0;
            this.cbDeptFilter.Tag = "searchFilter";
            this.cbDeptFilter.Text = "(all)";
            // 
            // gbExtendedInfo
            // 
            this.gbExtendedInfo.Controls.Add(this.btnUpdatePackInfo);
            this.gbExtendedInfo.Controls.Add(this.btnReplicatePack);
            this.gbExtendedInfo.Controls.Add(this.txtPackName);
            this.gbExtendedInfo.Controls.Add(this.btnAddNewPack);
            this.gbExtendedInfo.Controls.Add(this.txtPackID);
            this.gbExtendedInfo.Controls.Add(this.lblPackName);
            this.gbExtendedInfo.Controls.Add(this.lblPackID);
            this.gbExtendedInfo.Location = new System.Drawing.Point(12, 365);
            this.gbExtendedInfo.Name = "gbExtendedInfo";
            this.gbExtendedInfo.Size = new System.Drawing.Size(232, 240);
            this.gbExtendedInfo.TabIndex = 1;
            this.gbExtendedInfo.TabStop = false;
            this.gbExtendedInfo.Text = "Extended Information";
            // 
            // txtPackName
            // 
            this.txtPackName.Location = new System.Drawing.Point(9, 94);
            this.txtPackName.Name = "txtPackName";
            this.txtPackName.Size = new System.Drawing.Size(217, 20);
            this.txtPackName.TabIndex = 5;
            this.txtPackName.Text = "S-XXL 12322 Ratio";
            // 
            // txtPackID
            // 
            this.txtPackID.Enabled = false;
            this.txtPackID.Location = new System.Drawing.Point(9, 43);
            this.txtPackID.Name = "txtPackID";
            this.txtPackID.Size = new System.Drawing.Size(217, 20);
            this.txtPackID.TabIndex = 4;
            this.txtPackID.Text = "00358";
            // 
            // lblPackName
            // 
            this.lblPackName.AutoSize = true;
            this.lblPackName.Location = new System.Drawing.Point(6, 78);
            this.lblPackName.Name = "lblPackName";
            this.lblPackName.Size = new System.Drawing.Size(66, 13);
            this.lblPackName.TabIndex = 1;
            this.lblPackName.Text = "Pack Name:";
            // 
            // lblPackID
            // 
            this.lblPackID.AutoSize = true;
            this.lblPackID.Location = new System.Drawing.Point(6, 27);
            this.lblPackID.Name = "lblPackID";
            this.lblPackID.Size = new System.Drawing.Size(49, 13);
            this.lblPackID.TabIndex = 0;
            this.lblPackID.Text = "Pack ID:";
            // 
            // dgvPackMaintView
            // 
            this.dgvPackMaintView.AllowUserToAddRows = false;
            this.dgvPackMaintView.AllowUserToDeleteRows = false;
            this.dgvPackMaintView.AllowUserToOrderColumns = true;
            this.dgvPackMaintView.AllowUserToResizeRows = false;
            this.dgvPackMaintView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackMaintView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPackMaintView.Location = new System.Drawing.Point(6, 19);
            this.dgvPackMaintView.MultiSelect = false;
            this.dgvPackMaintView.Name = "dgvPackMaintView";
            this.dgvPackMaintView.RowHeadersVisible = false;
            this.dgvPackMaintView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPackMaintView.Size = new System.Drawing.Size(361, 562);
            this.dgvPackMaintView.TabIndex = 2;
            this.dgvPackMaintView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackMaintView_RowEnter);
            // 
            // dgvSizesInPack
            // 
            this.dgvSizesInPack.AllowUserToAddRows = false;
            this.dgvSizesInPack.AllowUserToDeleteRows = false;
            this.dgvSizesInPack.AllowUserToResizeRows = false;
            this.dgvSizesInPack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSizesInPack.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSizesInPack.Location = new System.Drawing.Point(6, 19);
            this.dgvSizesInPack.Name = "dgvSizesInPack";
            this.dgvSizesInPack.RowHeadersVisible = false;
            this.dgvSizesInPack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSizesInPack.Size = new System.Drawing.Size(212, 245);
            this.dgvSizesInPack.TabIndex = 4;
            // 
            // gbSizesInUse
            // 
            this.gbSizesInUse.Controls.Add(this.dgvSizesInPack);
            this.gbSizesInUse.Location = new System.Drawing.Point(955, 335);
            this.gbSizesInUse.Name = "gbSizesInUse";
            this.gbSizesInUse.Size = new System.Drawing.Size(226, 270);
            this.gbSizesInUse.TabIndex = 3;
            this.gbSizesInUse.TabStop = false;
            this.gbSizesInUse.Text = "Sizes In Use";
            // 
            // gbProductsInPack
            // 
            this.gbProductsInPack.Controls.Add(this.dgvProductsInPack);
            this.gbProductsInPack.Location = new System.Drawing.Point(630, 335);
            this.gbProductsInPack.Name = "gbProductsInPack";
            this.gbProductsInPack.Size = new System.Drawing.Size(319, 270);
            this.gbProductsInPack.TabIndex = 5;
            this.gbProductsInPack.TabStop = false;
            this.gbProductsInPack.Text = "Products utilizing this pack";
            // 
            // dgvProductsInPack
            // 
            this.dgvProductsInPack.AllowUserToAddRows = false;
            this.dgvProductsInPack.AllowUserToDeleteRows = false;
            this.dgvProductsInPack.AllowUserToResizeRows = false;
            this.dgvProductsInPack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsInPack.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductsInPack.Location = new System.Drawing.Point(6, 19);
            this.dgvProductsInPack.Name = "dgvProductsInPack";
            this.dgvProductsInPack.RowHeadersVisible = false;
            this.dgvProductsInPack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductsInPack.Size = new System.Drawing.Size(307, 245);
            this.dgvProductsInPack.TabIndex = 4;
            // 
            // gbDepartmentsUsingPack
            // 
            this.gbDepartmentsUsingPack.Controls.Add(this.dgvPackDepartments);
            this.gbDepartmentsUsingPack.Location = new System.Drawing.Point(630, 18);
            this.gbDepartmentsUsingPack.Name = "gbDepartmentsUsingPack";
            this.gbDepartmentsUsingPack.Size = new System.Drawing.Size(376, 311);
            this.gbDepartmentsUsingPack.TabIndex = 6;
            this.gbDepartmentsUsingPack.TabStop = false;
            this.gbDepartmentsUsingPack.Text = "Other Departments using this pack";
            // 
            // dgvPackDepartments
            // 
            this.dgvPackDepartments.AllowUserToAddRows = false;
            this.dgvPackDepartments.AllowUserToDeleteRows = false;
            this.dgvPackDepartments.AllowUserToResizeRows = false;
            this.dgvPackDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackDepartments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPackDepartments.Location = new System.Drawing.Point(6, 19);
            this.dgvPackDepartments.Name = "dgvPackDepartments";
            this.dgvPackDepartments.RowHeadersVisible = false;
            this.dgvPackDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPackDepartments.Size = new System.Drawing.Size(364, 286);
            this.dgvPackDepartments.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPackCodes);
            this.groupBox2.Location = new System.Drawing.Point(1012, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 311);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pack Codes ";
            // 
            // dgvPackCodes
            // 
            this.dgvPackCodes.AllowUserToAddRows = false;
            this.dgvPackCodes.AllowUserToDeleteRows = false;
            this.dgvPackCodes.AllowUserToResizeRows = false;
            this.dgvPackCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackCodes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPackCodes.Location = new System.Drawing.Point(6, 19);
            this.dgvPackCodes.Name = "dgvPackCodes";
            this.dgvPackCodes.RowHeadersVisible = false;
            this.dgvPackCodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPackCodes.Size = new System.Drawing.Size(155, 286);
            this.dgvPackCodes.TabIndex = 4;
            // 
            // gbPackListing
            // 
            this.gbPackListing.Controls.Add(this.dgvPackMaintView);
            this.gbPackListing.Location = new System.Drawing.Point(250, 18);
            this.gbPackListing.Name = "gbPackListing";
            this.gbPackListing.Size = new System.Drawing.Size(374, 581);
            this.gbPackListing.TabIndex = 7;
            this.gbPackListing.TabStop = false;
            this.gbPackListing.Text = "Pack Listing";
            // 
            // btnAddNewPack
            // 
            this.btnAddNewPack.Location = new System.Drawing.Point(6, 182);
            this.btnAddNewPack.Name = "btnAddNewPack";
            this.btnAddNewPack.Size = new System.Drawing.Size(217, 23);
            this.btnAddNewPack.TabIndex = 11;
            this.btnAddNewPack.Text = "Add New Pack";
            this.btnAddNewPack.UseVisualStyleBackColor = true;
            // 
            // btnReplicatePack
            // 
            this.btnReplicatePack.Location = new System.Drawing.Point(6, 211);
            this.btnReplicatePack.Name = "btnReplicatePack";
            this.btnReplicatePack.Size = new System.Drawing.Size(217, 23);
            this.btnReplicatePack.TabIndex = 12;
            this.btnReplicatePack.Text = "Replicate Current Pack";
            this.btnReplicatePack.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePackInfo
            // 
            this.btnUpdatePackInfo.Location = new System.Drawing.Point(6, 153);
            this.btnUpdatePackInfo.Name = "btnUpdatePackInfo";
            this.btnUpdatePackInfo.Size = new System.Drawing.Size(217, 23);
            this.btnUpdatePackInfo.TabIndex = 13;
            this.btnUpdatePackInfo.Text = "Update Pack Information";
            this.btnUpdatePackInfo.UseVisualStyleBackColor = true;
            // 
            // lblDeptDescription
            // 
            this.lblDeptDescription.AutoSize = true;
            this.lblDeptDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDeptDescription.Location = new System.Drawing.Point(7, 62);
            this.lblDeptDescription.Name = "lblDeptDescription";
            this.lblDeptDescription.Size = new System.Drawing.Size(68, 13);
            this.lblDeptDescription.TabIndex = 11;
            this.lblDeptDescription.Text = "(Department)";
            // 
            // lblSubDeptDescription
            // 
            this.lblSubDeptDescription.AutoSize = true;
            this.lblSubDeptDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSubDeptDescription.Location = new System.Drawing.Point(7, 116);
            this.lblSubDeptDescription.Name = "lblSubDeptDescription";
            this.lblSubDeptDescription.Size = new System.Drawing.Size(87, 13);
            this.lblSubDeptDescription.TabIndex = 12;
            this.lblSubDeptDescription.Text = "(SubDepartment)";
            // 
            // lblSectionDescription
            // 
            this.lblSectionDescription.AutoSize = true;
            this.lblSectionDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSectionDescription.Location = new System.Drawing.Point(7, 170);
            this.lblSectionDescription.Name = "lblSectionDescription";
            this.lblSectionDescription.Size = new System.Drawing.Size(49, 13);
            this.lblSectionDescription.TabIndex = 13;
            this.lblSectionDescription.Text = "(Section)";
            // 
            // lblRangeDescription
            // 
            this.lblRangeDescription.AutoSize = true;
            this.lblRangeDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRangeDescription.Location = new System.Drawing.Point(7, 224);
            this.lblRangeDescription.Name = "lblRangeDescription";
            this.lblRangeDescription.Size = new System.Drawing.Size(45, 13);
            this.lblRangeDescription.TabIndex = 14;
            this.lblRangeDescription.Text = "(Range)";
            // 
            // lblSubRangeDescription
            // 
            this.lblSubRangeDescription.AutoSize = true;
            this.lblSubRangeDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSubRangeDescription.Location = new System.Drawing.Point(7, 278);
            this.lblSubRangeDescription.Name = "lblSubRangeDescription";
            this.lblSubRangeDescription.Size = new System.Drawing.Size(64, 13);
            this.lblSubRangeDescription.TabIndex = 15;
            this.lblSubRangeDescription.Text = "(SubRange)";
            // 
            // PackMaintScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 617);
            this.Controls.Add(this.gbPackListing);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbDepartmentsUsingPack);
            this.Controls.Add(this.gbProductsInPack);
            this.Controls.Add(this.gbSizesInUse);
            this.Controls.Add(this.gbExtendedInfo);
            this.Controls.Add(this.gbFilterCriteria);
            this.Name = "PackMaintScreen";
            this.Text = "MOS Pack Maintenance Screen";
            this.Load += new System.EventHandler(this.PackMaintScreen_Load);
            this.gbFilterCriteria.ResumeLayout(false);
            this.gbFilterCriteria.PerformLayout();
            this.gbExtendedInfo.ResumeLayout(false);
            this.gbExtendedInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackMaintView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizesInPack)).EndInit();
            this.gbSizesInUse.ResumeLayout(false);
            this.gbProductsInPack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsInPack)).EndInit();
            this.gbDepartmentsUsingPack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackDepartments)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackCodes)).EndInit();
            this.gbPackListing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilterCriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSectionFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSubDeptFilter;
        private System.Windows.Forms.Label lblWhateverMateNooneLooksAtTheseAnyway;
        private System.Windows.Forms.ComboBox cbDeptFilter;
        private System.Windows.Forms.GroupBox gbExtendedInfo;
        private System.Windows.Forms.Label lblPackID;
        public System.Windows.Forms.DataGridView dgvPackMaintView;
        private System.Windows.Forms.Label lblThing5;
        private System.Windows.Forms.ComboBox cbSubRangeFilter;
        private System.Windows.Forms.Label lblThing4;
        private System.Windows.Forms.ComboBox cbRangeFilter;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPackName;
        private System.Windows.Forms.DataGridView dgvSizesInPack;
        private System.Windows.Forms.GroupBox gbSizesInUse;
        private System.Windows.Forms.GroupBox gbProductsInPack;
        private System.Windows.Forms.DataGridView dgvProductsInPack;
        private System.Windows.Forms.GroupBox gbDepartmentsUsingPack;
        private System.Windows.Forms.DataGridView dgvPackDepartments;
        private System.Windows.Forms.TextBox txtPackName;
        private System.Windows.Forms.TextBox txtPackID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbPackListing;
        public System.Windows.Forms.DataGridView dgvPackCodes;
        private System.Windows.Forms.Button btnUpdatePackInfo;
        private System.Windows.Forms.Button btnReplicatePack;
        private System.Windows.Forms.Button btnAddNewPack;
        private System.Windows.Forms.Label lblSubRangeDescription;
        private System.Windows.Forms.Label lblRangeDescription;
        private System.Windows.Forms.Label lblSectionDescription;
        private System.Windows.Forms.Label lblSubDeptDescription;
        private System.Windows.Forms.Label lblDeptDescription;
    }
}