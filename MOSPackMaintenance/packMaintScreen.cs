namespace MCO.Applications.MOSPackMaintenance
{
    using Interfaces;
    using Data.MosPackMaintenance.Models;
    using System.Data;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using System;

    public partial class PackMaintScreen : Form
    {
        private readonly ILog logger;
        private readonly IApp app;

        private List<string> searchParameters;

        public PackMaintScreen(ILog logger, IApp app)
        {
            this.logger = logger;
            this.app = app;

            InitializeComponent();
        }

        private void PackMaintScreen_Load(object sender, System.EventArgs e)
        {
            run();
        }

        private void run()
        {
            PopulateFilterBox(cbDeptFilter);

            searchParameters = new List<string>()
            {
                "9",
                "N",
                "1",
                "A",
                string.Empty
            };

            Filter_Parameters filterParams = app.Parse_FilterParameters_ToModel(searchParameters);

            DataTable returnedPackData = app.Return_CleansedData_ToDataTable(filterParams);

            BindDataToDGV(this.dgvPackMaintView, returnedPackData);
        }

        private void PopulateFilterBox(ComboBox cbDeptFilter)
        {
            
        }

        private void BindDataToDGV(DataGridView packsDGV, DataTable dataTable)
        {
            packsDGV.DataSource = dataTable;
            packsDGV.AutoResizeColumns();
            packsDGV.Refresh();
        }

        private void dgvPackMaintView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Populate_DrillDownInformation(e.RowIndex);
        }

        private void Populate_DrillDownInformation(int rowIndex)
        {
            string packName = this.dgvPackMaintView.Rows[rowIndex].Cells[0].Value.ToString();
            string packId = this.dgvPackMaintView.Rows[rowIndex].Cells[1].Value.ToString();

            txtPackName.Text = packName;
            txtPackID.Text = packId;
        }
    }
}
