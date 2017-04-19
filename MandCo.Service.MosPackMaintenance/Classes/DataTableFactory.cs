namespace MCO.Service.MosPackMaintenance.Classes
{
    using Interfaces;
    using System.Data;

    public class DataTableFactory : IDataTableFactory
    {
        public DataTable CreateNew_CleansedPackData_ToDataTable()
        {
            DataTable result = new DataTable();

            result.Columns.Add("Pack Name");
            result.Columns.Add("Pack Id");
            result.Columns.Add("Number of Sizes");
            result.Columns.Add("No of Units");

            return result;
        }
    }
}
