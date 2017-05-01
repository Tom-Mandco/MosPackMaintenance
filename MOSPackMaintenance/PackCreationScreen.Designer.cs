namespace MCO.Applications.MOSPackMaintenance
{
    partial class PackCreationScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPackName = new System.Windows.Forms.Label();
            this.lblQtyInPack = new System.Windows.Forms.Label();
            this.gbSizeRanges = new System.Windows.Forms.GroupBox();
            this.cbSRFilterSubDept = new System.Windows.Forms.ComboBox();
            this.cbSRFilterDept = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSizeRanges = new System.Windows.Forms.DataGridView();
            this.gbSizePicker = new System.Windows.Forms.GroupBox();
            this.dgvSizesBySizeRange = new System.Windows.Forms.DataGridView();
            this.lblPackId = new System.Windows.Forms.Label();
            this.tbPackId = new System.Windows.Forms.TextBox();
            this.tbQtyInPack = new System.Windows.Forms.TextBox();
            this.tbPackName = new System.Windows.Forms.TextBox();
            this.gbSizeRatios = new System.Windows.Forms.GroupBox();
            this.dgvSizeRatios = new System.Windows.Forms.DataGridView();
            this.colSizeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSizeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClearSizeRatioTable = new System.Windows.Forms.Button();
            this.btnMoveSizeRatioUp = new System.Windows.Forms.Button();
            this.btnMoveSizeRatioDown = new System.Windows.Forms.Button();
            this.gbSizeRanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizeRanges)).BeginInit();
            this.gbSizePicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizesBySizeRange)).BeginInit();
            this.gbSizeRatios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizeRatios)).BeginInit();
            this.gbControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPackName
            // 
            this.lblPackName.AutoSize = true;
            this.lblPackName.Location = new System.Drawing.Point(6, 46);
            this.lblPackName.Name = "lblPackName";
            this.lblPackName.Size = new System.Drawing.Size(63, 13);
            this.lblPackName.TabIndex = 0;
            this.lblPackName.Text = "Pack Name";
            // 
            // lblQtyInPack
            // 
            this.lblQtyInPack.AutoSize = true;
            this.lblQtyInPack.Location = new System.Drawing.Point(6, 72);
            this.lblQtyInPack.Name = "lblQtyInPack";
            this.lblQtyInPack.Size = new System.Drawing.Size(62, 13);
            this.lblQtyInPack.TabIndex = 1;
            this.lblQtyInPack.Text = "Qty in Pack";
            // 
            // gbSizeRanges
            // 
            this.gbSizeRanges.Controls.Add(this.cbSRFilterSubDept);
            this.gbSizeRanges.Controls.Add(this.cbSRFilterDept);
            this.gbSizeRanges.Controls.Add(this.label2);
            this.gbSizeRanges.Controls.Add(this.label1);
            this.gbSizeRanges.Controls.Add(this.dgvSizeRanges);
            this.gbSizeRanges.Location = new System.Drawing.Point(223, 12);
            this.gbSizeRanges.Name = "gbSizeRanges";
            this.gbSizeRanges.Size = new System.Drawing.Size(458, 448);
            this.gbSizeRanges.TabIndex = 2;
            this.gbSizeRanges.TabStop = false;
            this.gbSizeRanges.Text = "Size Ranges";
            // 
            // cbSRFilterSubDept
            // 
            this.cbSRFilterSubDept.FormattingEnabled = true;
            this.cbSRFilterSubDept.Location = new System.Drawing.Point(174, 19);
            this.cbSRFilterSubDept.Name = "cbSRFilterSubDept";
            this.cbSRFilterSubDept.Size = new System.Drawing.Size(73, 21);
            this.cbSRFilterSubDept.TabIndex = 4;
            // 
            // cbSRFilterDept
            // 
            this.cbSRFilterDept.FormattingEnabled = true;
            this.cbSRFilterDept.Location = new System.Drawing.Point(39, 19);
            this.cbSRFilterDept.Name = "cbSRFilterDept";
            this.cbSRFilterDept.Size = new System.Drawing.Size(73, 21);
            this.cbSRFilterDept.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SubDept";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dept";
            // 
            // dgvSizeRanges
            // 
            this.dgvSizeRanges.AllowUserToAddRows = false;
            this.dgvSizeRanges.AllowUserToDeleteRows = false;
            this.dgvSizeRanges.AllowUserToResizeRows = false;
            this.dgvSizeRanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSizeRanges.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSizeRanges.Location = new System.Drawing.Point(6, 46);
            this.dgvSizeRanges.MultiSelect = false;
            this.dgvSizeRanges.Name = "dgvSizeRanges";
            this.dgvSizeRanges.ReadOnly = true;
            this.dgvSizeRanges.RowHeadersVisible = false;
            this.dgvSizeRanges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSizeRanges.Size = new System.Drawing.Size(446, 396);
            this.dgvSizeRanges.TabIndex = 0;
            this.dgvSizeRanges.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSizeRanges_RowEnter);
            // 
            // gbSizePicker
            // 
            this.gbSizePicker.Controls.Add(this.dgvSizesBySizeRange);
            this.gbSizePicker.Location = new System.Drawing.Point(687, 12);
            this.gbSizePicker.Name = "gbSizePicker";
            this.gbSizePicker.Size = new System.Drawing.Size(252, 448);
            this.gbSizePicker.TabIndex = 3;
            this.gbSizePicker.TabStop = false;
            this.gbSizePicker.Text = "Sizes in New Pack";
            // 
            // dgvSizesBySizeRange
            // 
            this.dgvSizesBySizeRange.AllowUserToAddRows = false;
            this.dgvSizesBySizeRange.AllowUserToDeleteRows = false;
            this.dgvSizesBySizeRange.AllowUserToResizeColumns = false;
            this.dgvSizesBySizeRange.AllowUserToResizeRows = false;
            this.dgvSizesBySizeRange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSizesBySizeRange.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSizesBySizeRange.Location = new System.Drawing.Point(6, 19);
            this.dgvSizesBySizeRange.MultiSelect = false;
            this.dgvSizesBySizeRange.Name = "dgvSizesBySizeRange";
            this.dgvSizesBySizeRange.RowHeadersVisible = false;
            this.dgvSizesBySizeRange.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSizesBySizeRange.Size = new System.Drawing.Size(240, 423);
            this.dgvSizesBySizeRange.TabIndex = 4;
            this.dgvSizesBySizeRange.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSizesBySizeRange_CellContentClick);
            // 
            // lblPackId
            // 
            this.lblPackId.AutoSize = true;
            this.lblPackId.Location = new System.Drawing.Point(6, 20);
            this.lblPackId.Name = "lblPackId";
            this.lblPackId.Size = new System.Drawing.Size(46, 13);
            this.lblPackId.TabIndex = 4;
            this.lblPackId.Text = "Pack ID";
            // 
            // tbPackId
            // 
            this.tbPackId.Enabled = false;
            this.tbPackId.Location = new System.Drawing.Point(93, 16);
            this.tbPackId.Name = "tbPackId";
            this.tbPackId.Size = new System.Drawing.Size(100, 20);
            this.tbPackId.TabIndex = 5;
            // 
            // tbQtyInPack
            // 
            this.tbQtyInPack.Enabled = false;
            this.tbQtyInPack.Location = new System.Drawing.Point(93, 68);
            this.tbQtyInPack.Name = "tbQtyInPack";
            this.tbQtyInPack.Size = new System.Drawing.Size(100, 20);
            this.tbQtyInPack.TabIndex = 6;
            this.tbQtyInPack.Text = "0";
            // 
            // tbPackName
            // 
            this.tbPackName.Location = new System.Drawing.Point(93, 42);
            this.tbPackName.Name = "tbPackName";
            this.tbPackName.Size = new System.Drawing.Size(100, 20);
            this.tbPackName.TabIndex = 7;
            // 
            // gbSizeRatios
            // 
            this.gbSizeRatios.Controls.Add(this.btnMoveSizeRatioDown);
            this.gbSizeRatios.Controls.Add(this.btnMoveSizeRatioUp);
            this.gbSizeRatios.Controls.Add(this.btnClearSizeRatioTable);
            this.gbSizeRatios.Controls.Add(this.dgvSizeRatios);
            this.gbSizeRatios.Location = new System.Drawing.Point(945, 12);
            this.gbSizeRatios.Name = "gbSizeRatios";
            this.gbSizeRatios.Size = new System.Drawing.Size(321, 448);
            this.gbSizeRatios.TabIndex = 5;
            this.gbSizeRatios.TabStop = false;
            this.gbSizeRatios.Text = "Size Ratios";
            // 
            // dgvSizeRatios
            // 
            this.dgvSizeRatios.AllowUserToAddRows = false;
            this.dgvSizeRatios.AllowUserToDeleteRows = false;
            this.dgvSizeRatios.AllowUserToResizeColumns = false;
            this.dgvSizeRatios.AllowUserToResizeRows = false;
            this.dgvSizeRatios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSizeRatios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSizeCode,
            this.colSizeDesc,
            this.colRatio});
            this.dgvSizeRatios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSizeRatios.Location = new System.Drawing.Point(6, 46);
            this.dgvSizeRatios.MultiSelect = false;
            this.dgvSizeRatios.Name = "dgvSizeRatios";
            this.dgvSizeRatios.RowHeadersVisible = false;
            this.dgvSizeRatios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSizeRatios.Size = new System.Drawing.Size(309, 396);
            this.dgvSizeRatios.TabIndex = 4;
            this.dgvSizeRatios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSizeRatios_CellContentClick);
            this.dgvSizeRatios.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSizeRatios_CellEndEdit);
            // 
            // colSizeCode
            // 
            this.colSizeCode.HeaderText = "Size Code";
            this.colSizeCode.Name = "colSizeCode";
            this.colSizeCode.ReadOnly = true;
            // 
            // colSizeDesc
            // 
            this.colSizeDesc.HeaderText = "Size Description";
            this.colSizeDesc.Name = "colSizeDesc";
            this.colSizeDesc.ReadOnly = true;
            // 
            // colRatio
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.colRatio.DefaultCellStyle = dataGridViewCellStyle1;
            this.colRatio.HeaderText = "Ratio Qty";
            this.colRatio.Name = "colRatio";
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.btnSubmit);
            this.gbControls.Controls.Add(this.tbQtyInPack);
            this.gbControls.Controls.Add(this.lblPackName);
            this.gbControls.Controls.Add(this.tbPackName);
            this.gbControls.Controls.Add(this.lblQtyInPack);
            this.gbControls.Controls.Add(this.lblPackId);
            this.gbControls.Controls.Add(this.tbPackId);
            this.gbControls.Location = new System.Drawing.Point(12, 12);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(205, 448);
            this.gbControls.TabIndex = 8;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "ctrl";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(6, 419);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(193, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "GERRUM IN THEREEEEE";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClearSizeRatioTable
            // 
            this.btnClearSizeRatioTable.Location = new System.Drawing.Point(6, 19);
            this.btnClearSizeRatioTable.Name = "btnClearSizeRatioTable";
            this.btnClearSizeRatioTable.Size = new System.Drawing.Size(148, 23);
            this.btnClearSizeRatioTable.TabIndex = 5;
            this.btnClearSizeRatioTable.Text = "Clear All";
            this.btnClearSizeRatioTable.UseVisualStyleBackColor = true;
            this.btnClearSizeRatioTable.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMoveSizeRatioUp
            // 
            this.btnMoveSizeRatioUp.Location = new System.Drawing.Point(160, 19);
            this.btnMoveSizeRatioUp.Name = "btnMoveSizeRatioUp";
            this.btnMoveSizeRatioUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveSizeRatioUp.TabIndex = 6;
            this.btnMoveSizeRatioUp.Text = "Move Up";
            this.btnMoveSizeRatioUp.UseVisualStyleBackColor = true;
            // 
            // btnMoveSizeRatioDown
            // 
            this.btnMoveSizeRatioDown.Location = new System.Drawing.Point(241, 19);
            this.btnMoveSizeRatioDown.Name = "btnMoveSizeRatioDown";
            this.btnMoveSizeRatioDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveSizeRatioDown.TabIndex = 7;
            this.btnMoveSizeRatioDown.Text = "Move Down";
            this.btnMoveSizeRatioDown.UseVisualStyleBackColor = true;
            // 
            // PackCreationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 466);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.gbSizeRatios);
            this.Controls.Add(this.gbSizePicker);
            this.Controls.Add(this.gbSizeRanges);
            this.Name = "PackCreationScreen";
            this.Text = "PackCreationScreen";
            this.Load += new System.EventHandler(this.PackCreationScreen_Load);
            this.gbSizeRanges.ResumeLayout(false);
            this.gbSizeRanges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizeRanges)).EndInit();
            this.gbSizePicker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizesBySizeRange)).EndInit();
            this.gbSizeRatios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizeRatios)).EndInit();
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPackName;
        private System.Windows.Forms.Label lblQtyInPack;
        private System.Windows.Forms.GroupBox gbSizeRanges;
        private System.Windows.Forms.DataGridView dgvSizeRanges;
        private System.Windows.Forms.GroupBox gbSizePicker;
        private System.Windows.Forms.DataGridView dgvSizesBySizeRange;
        private System.Windows.Forms.Label lblPackId;
        private System.Windows.Forms.TextBox tbPackId;
        private System.Windows.Forms.TextBox tbQtyInPack;
        private System.Windows.Forms.TextBox tbPackName;
        private System.Windows.Forms.GroupBox gbSizeRatios;
        private System.Windows.Forms.DataGridView dgvSizeRatios;
        private System.Windows.Forms.ComboBox cbSRFilterSubDept;
        private System.Windows.Forms.ComboBox cbSRFilterDept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSizeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSizeDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRatio;
        private System.Windows.Forms.Button btnClearSizeRatioTable;
        private System.Windows.Forms.Button btnMoveSizeRatioDown;
        private System.Windows.Forms.Button btnMoveSizeRatioUp;
    }
}