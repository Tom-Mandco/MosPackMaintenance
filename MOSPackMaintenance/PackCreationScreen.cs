namespace MCO.Applications.MOSPackMaintenance
{
    using System.Windows.Forms;
    using System.Data;
    using Interfaces;
    using System;
    using Data.MosPackMaintenance.Models;

    public partial class PackCreationScreen : Form
    {
        private readonly ILog logger;
        private readonly IApp app;

        public PackCreationScreen(ILog logger, IApp app)
        {
            this.logger = logger;
            this.app = app;

            InitializeComponent();
        }

        private void PackCreationScreen_Load(object sender, System.EventArgs e)
        {
            Run();
        }

        private void dgvSizeRanges_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            PopulateSizesBySizeRangeTable(e.RowIndex);
        }

        private void dgvSizeRatios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    senderGrid.Rows.RemoveAt(e.RowIndex);
                }

                senderGrid.Refresh();
            }
            catch (Exception ex)
            {
                logger.Warn(ex.Message);
                logger.Warn(ex.StackTrace);
            }
        }

        private void dgvSizesBySizeRange_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    string sizeCode = senderGrid.Rows[e.RowIndex].Cells["Size Code"].Value.ToString();
                    string sizeName = senderGrid.Rows[e.RowIndex].Cells["Size Description"].Value.ToString();

                    AddNewPackSizeRatioToDataGrid(sizeCode, sizeName);
                }

            }
            catch (Exception ex)
            {
                logger.Warn(ex.Message);
                logger.Warn(ex.StackTrace);
            }
        }

        private void dgvSizeRatios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int totalQtyOfPacks = 0;

            foreach (DataGridViewRow _row in senderGrid.Rows)
            {
                int ratioQty = 0;

                int.TryParse(_row.Cells[2].Value.ToString(), out ratioQty);

                totalQtyOfPacks += ratioQty;
            }

            tbQtyInPack.Text = totalQtyOfPacks.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            New_Pack newPack = app.Return_NewPack_ToModel(this.tbPackId.Text,
                                                          this.tbPackName.Text,
                                                          this.dgvSizeRatios);

            bool _isValidPack = app.Validate_NewPack_IsUnique(newPack);

            if (_isValidPack)
            {
                app.Insert_NewPack_ToDB(newPack);
                Run();
            }
        }

        private void Run()
        {
            RefreshForm();

            DataTable sizeRangesDT = app.Return_AllSizeRanges_ToDataTable();

            Bind_Data_ToDGV(this.dgvSizeRanges, sizeRangesDT);

            AddButtonToDataGridView(this.dgvSizesBySizeRange, "Add");
            AddButtonToDataGridView(this.dgvSizeRatios, "Delete");
        }

        private void RefreshForm()
        {
            this.tbPackId.Text = app.Return_NextPackID_ToString();
            this.tbPackName.Text = string.Empty;
            this.tbQtyInPack.Text = "0";

            foreach (var _row in dgvSizeRatios.Rows)
            {
                this.dgvSizeRanges.Rows.RemoveAt(0);
            }
            
        }

        private void PopulateSizesBySizeRangeTable(int rowIndex)
        {
            string sizeRangeID = this.dgvSizeRanges.Rows[rowIndex].Cells[0].Value.ToString();

            DataTable sizesBySizeRangeDT = app.Return_SizesBySizeRange_ToDataTable(sizeRangeID);

            Bind_Data_ToDGV(this.dgvSizesBySizeRange, sizesBySizeRangeDT);
        }

        

        private void Bind_Data_ToDGV(DataGridView dataGridView, DataTable dataTable)
        {
            dataGridView.DataSource = dataTable;
            dataGridView.AutoResizeColumns();
            dataGridView.Refresh();
        }

        public void AddButtonToDataGridView(DataGridView dgv, string btnText)
        {
            
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = btnText + "SizeCol";
            btnColumn.HeaderText = btnText + " Size";
            btnColumn.Width = 100;
            btnColumn.ReadOnly = false;
            btnColumn.FillWeight = 10;
            btnColumn.Text = btnText;
            btnColumn.UseColumnTextForButtonValue = true;

            if (!dgv.Columns.Contains(btnColumn.Name))
                dgv.Columns.Add(btnColumn);

            dgv.AutoResizeColumns();
            dgv.Refresh();
        }

        private void AddNewPackSizeRatioToDataGrid(string sizeCode, string sizeName)
        {
            DataGridView _dgv = this.dgvSizeRatios;
            bool _validLine = app.Validate_SizeRatioRow_DoesNotContainDuplicateValue(sizeCode, this.dgvSizeRatios);

            if (_validLine)
            {
                this.dgvSizeRatios.Rows.Add(sizeCode, sizeName, 0);
            }
        }

    }
}

