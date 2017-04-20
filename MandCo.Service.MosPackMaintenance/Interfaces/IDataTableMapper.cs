namespace MCO.Service.MosPackMaintenance.Interfaces
{
    using System.Data;
    using Data.MosPackMaintenance.Models;

    public interface IDataTableMapper
    {
        DataTable Map_DrillDownDetail_ToDataTable(DataTable dataTable, Department_Details detail);
        DataTable Map_DrillDownDetail_ToDataTable(DataTable dataTable, PackCode_Details detail);
        DataTable Map_DrillDownDetail_ToDataTable(DataTable dataTable, Product_Details detail);
        DataTable Map_DrillDownDetail_ToDataTable(DataTable dataTable, Size_Details detail);
    }
}
