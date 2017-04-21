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
            this.lblPackName = new System.Windows.Forms.Label();
            this.lblQtyInPack = new System.Windows.Forms.Label();
            this.gbSizeRanges = new System.Windows.Forms.GroupBox();
            this.dgvSizeRanges = new System.Windows.Forms.DataGridView();
            this.gbSizePicker = new System.Windows.Forms.GroupBox();
            this.dgvSizePicker = new System.Windows.Forms.DataGridView();
            this.lblPackId = new System.Windows.Forms.Label();
            this.tbPackId = new System.Windows.Forms.TextBox();
            this.tbQtyInPack = new System.Windows.Forms.TextBox();
            this.tbPackName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSizeRatios = new System.Windows.Forms.DataGridView();
            this.gbSizeRanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizeRanges)).BeginInit();
            this.gbSizePicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizePicker)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizeRatios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPackName
            // 
            this.lblPackName.AutoSize = true;
            this.lblPackName.Location = new System.Drawing.Point(19, 35);
            this.lblPackName.Name = "lblPackName";
            this.lblPackName.Size = new System.Drawing.Size(63, 13);
            this.lblPackName.TabIndex = 0;
            this.lblPackName.Text = "Pack Name";
            // 
            // lblQtyInPack
            // 
            this.lblQtyInPack.AutoSize = true;
            this.lblQtyInPack.Location = new System.Drawing.Point(19, 61);
            this.lblQtyInPack.Name = "lblQtyInPack";
            this.lblQtyInPack.Size = new System.Drawing.Size(62, 13);
            this.lblQtyInPack.TabIndex = 1;
            this.lblQtyInPack.Text = "Qty in Pack";
            // 
            // gbSizeRanges
            // 
            this.gbSizeRanges.Controls.Add(this.dgvSizeRanges);
            this.gbSizeRanges.Location = new System.Drawing.Point(22, 84);
            this.gbSizeRanges.Name = "gbSizeRanges";
            this.gbSizeRanges.Size = new System.Drawing.Size(250, 277);
            this.gbSizeRanges.TabIndex = 2;
            this.gbSizeRanges.TabStop = false;
            this.gbSizeRanges.Text = "Size Ranges";
            // 
            // dgvSizeRanges
            // 
            this.dgvSizeRanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSizeRanges.Location = new System.Drawing.Point(6, 19);
            this.dgvSizeRanges.Name = "dgvSizeRanges";
            this.dgvSizeRanges.Size = new System.Drawing.Size(240, 252);
            this.dgvSizeRanges.TabIndex = 0;
            // 
            // gbSizePicker
            // 
            this.gbSizePicker.Controls.Add(this.dgvSizePicker);
            this.gbSizePicker.Location = new System.Drawing.Point(278, 84);
            this.gbSizePicker.Name = "gbSizePicker";
            this.gbSizePicker.Size = new System.Drawing.Size(252, 277);
            this.gbSizePicker.TabIndex = 3;
            this.gbSizePicker.TabStop = false;
            this.gbSizePicker.Text = "Sizes in New Pack";
            // 
            // dgvSizePicker
            // 
            this.dgvSizePicker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSizePicker.Location = new System.Drawing.Point(6, 19);
            this.dgvSizePicker.Name = "dgvSizePicker";
            this.dgvSizePicker.Size = new System.Drawing.Size(240, 252);
            this.dgvSizePicker.TabIndex = 4;
            // 
            // lblPackId
            // 
            this.lblPackId.AutoSize = true;
            this.lblPackId.Location = new System.Drawing.Point(19, 9);
            this.lblPackId.Name = "lblPackId";
            this.lblPackId.Size = new System.Drawing.Size(46, 13);
            this.lblPackId.TabIndex = 4;
            this.lblPackId.Text = "Pack ID";
            // 
            // tbPackId
            // 
            this.tbPackId.Enabled = false;
            this.tbPackId.Location = new System.Drawing.Point(113, 6);
            this.tbPackId.Name = "tbPackId";
            this.tbPackId.Size = new System.Drawing.Size(100, 20);
            this.tbPackId.TabIndex = 5;
            // 
            // tbQtyInPack
            // 
            this.tbQtyInPack.Location = new System.Drawing.Point(113, 58);
            this.tbQtyInPack.Name = "tbQtyInPack";
            this.tbQtyInPack.Size = new System.Drawing.Size(100, 20);
            this.tbQtyInPack.TabIndex = 6;
            // 
            // tbPackName
            // 
            this.tbPackName.Location = new System.Drawing.Point(113, 32);
            this.tbPackName.Name = "tbPackName";
            this.tbPackName.Size = new System.Drawing.Size(100, 20);
            this.tbPackName.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSizeRatios);
            this.groupBox1.Location = new System.Drawing.Point(536, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 277);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size Ratios";
            // 
            // dgvSizeRatios
            // 
            this.dgvSizeRatios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSizeRatios.Location = new System.Drawing.Point(6, 19);
            this.dgvSizeRatios.Name = "dgvSizeRatios";
            this.dgvSizeRatios.Size = new System.Drawing.Size(240, 252);
            this.dgvSizeRatios.TabIndex = 4;
            // 
            // PackCreationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 373);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPackName);
            this.Controls.Add(this.tbQtyInPack);
            this.Controls.Add(this.tbPackId);
            this.Controls.Add(this.lblPackId);
            this.Controls.Add(this.gbSizePicker);
            this.Controls.Add(this.gbSizeRanges);
            this.Controls.Add(this.lblQtyInPack);
            this.Controls.Add(this.lblPackName);
            this.Name = "PackCreationScreen";
            this.Text = "PackCreationScreen";
            this.Load += new System.EventHandler(this.PackCreationScreen_Load);
            this.gbSizeRanges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizeRanges)).EndInit();
            this.gbSizePicker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizePicker)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizeRatios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPackName;
        private System.Windows.Forms.Label lblQtyInPack;
        private System.Windows.Forms.GroupBox gbSizeRanges;
        private System.Windows.Forms.DataGridView dgvSizeRanges;
        private System.Windows.Forms.GroupBox gbSizePicker;
        private System.Windows.Forms.DataGridView dgvSizePicker;
        private System.Windows.Forms.Label lblPackId;
        private System.Windows.Forms.TextBox tbPackId;
        private System.Windows.Forms.TextBox tbQtyInPack;
        private System.Windows.Forms.TextBox tbPackName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSizeRatios;
    }
}