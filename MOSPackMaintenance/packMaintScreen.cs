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

            searchParameters = new List<string>() { "9", "N", "1", "A", string.Empty };

            Filter_Parameters filterParams = app.Parse_Filter_Parameters_ToModel(searchParameters);

            DataTable returnedPackData = app.Return_CleansedData_ToDataTable(filterParams);

            Bind_Data_ToDGV(this.dgvPackMaintView, returnedPackData);
        }

        private void PopulateFilterBox(ComboBox cbDeptFilter)
        {
            
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

            Dictionary<string, DataTable> drilledDetails = app.Return_DrillDownDetail_ToDictionary(packId);

            Bind_DDDetails_ToDGV(drilledDetails);
        }

        private void Bind_DDDetails_ToDGV(Dictionary<string, DataTable> drilledDetails)
        {
            foreach (var detail in drilledDetails)
            {
                DataGridView _dgv = Decipher_DetailsDGV_ToDGV(detail.Key);

                Bind_Data_ToDGV(_dgv, detail.Value);
            }
        }

        private DataGridView Decipher_DetailsDGV_ToDGV(string key)
        {
            DataGridView result = new DataGridView();

            switch (key)
            {
                case "Department":
                    result = this.dgvPackDepartments;
                    break;
                case "PackCodes":
                    result = this.dgvPackCodes;
                    break;
                case "Product":
                    result = this.dgvProductsInPack;
                    break;
                case "Size":
                    result = this.dgvSizesInPack;
                    break;
            }

            return result;
        }

        private void Bind_Data_ToDGV(DataGridView dataGridView, DataTable dataTable)
        {
            dataGridView.DataSource = dataTable;
            dataGridView.AutoResizeColumns();
            dataGridView.Refresh();
        }
    }
}
