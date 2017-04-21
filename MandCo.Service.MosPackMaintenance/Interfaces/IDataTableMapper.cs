namespace MCO.Service.MosPackMaintenance.Interfaces
{
    using System.Data;
    using Data.MosPackMaintenance.Models;
    using System.Collections.Generic;

    public interface IDataTableMapper
    {
        DataTable Map_DrillDownDetail_ToDataTable(DataTable dataTable, IEnumerable<Department_Details> detail);
        DataTable Map_DrillDownDetail_ToDataTable(DataTable dataTable, IEnumerable<PackCode_Details> detail);
        DataTable Map_DrillDownDetail_ToDataTable(DataTable dataTable, IEnumerable<Product_Details> detail);
        DataTable Map_DrillDownDetail_ToDataTable(DataTable dataTable, IEnumerable<Size_Details> detail);
    }
}
