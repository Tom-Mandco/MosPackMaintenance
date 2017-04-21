namespace MCO.Applications.MOSPackMaintenance
{
    using System.Windows.Forms;
    using System.Data;
    using Interfaces;
    using Data.MosPackMaintenance.Models;
    using System.Collections.Generic;

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

        private void Run()
        {
            DataTable sizeRangesDT = app.Return_AllSizeRanges_ToDataTable();

            Bind_Data_ToDGV(this.dgvSizeRanges, sizeRangesDT);
        }

        private void Bind_Data_ToDGV(DataGridView dataGridView, DataTable dataTable)
        {
            dataGridView.DataSource = dataTable;
            dataGridView.AutoResizeColumns();
            dataGridView.Refresh();
        }
    }
}
