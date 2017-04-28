namespace MCO.Service.MosPackMaintenance.Interfaces
{
    using Data.MosPackMaintenance.Models;
    using System.Collections.Generic;
    using System.Data;

    public interface IAdaptData
    {
        IEnumerable<Cleansed_Pack_Data> Return_InterprettedData_ToCleansedData(IEnumerable<Raw_Pack_Data> rawPackData);

        DataTable Return_CleansedPacks_ToDataTable(IEnumerable<Cleansed_Pack_Data> cleansedPackData);
        DataTable CreateNew_DrillDownDetails_ToDataTable(string detailIdentifier);
        DataTable Map_Details_ToDataTable(DataTable dataTable, IEnumerable<Department_Details> detail);
        DataTable Map_Details_ToDataTable(DataTable dataTable, IEnumerable<PackCode_Details> detail);
        DataTable Map_Details_ToDataTable(DataTable dataTable, IEnumerable<Product_Details> detail);
        DataTable Map_Details_ToDataTable(DataTable dataTable, IEnumerable<Size_Details> detail);
        DataTable Map_SizeRanges_ToDataTable(IEnumerable<Size_Ranges> sizeRanges);
        DataTable Map_SizesBySizeRange_ToDataTable(IEnumerable<Size_Details> sizeDetails);
    }
}
