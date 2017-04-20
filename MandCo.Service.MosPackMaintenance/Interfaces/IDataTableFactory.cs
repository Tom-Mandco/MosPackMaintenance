namespace MCO.Service.MosPackMaintenance.Interfaces
{
    using System.Data;

    public interface IDataTableFactory
    {
        DataTable CreateNew_CleansedPackData_ToDataTable();
        DataTable CreateNew_DrillDownDetail_ToDataTable(string detailIdentifier);
    }
}
