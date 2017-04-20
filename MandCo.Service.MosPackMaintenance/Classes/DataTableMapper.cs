namespace MCO.Service.MosPackMaintenance.Classes
{
    using System;
    using System.Data;
    using Interfaces;
    using Data.MosPackMaintenance.Models;

    public class DataTableMapper : IDataTableMapper
    {
        public DataTable Map_DrillDownDetail_ToDataTable(DataTable dataTable, PackCode_Details details)
        {
            dataTable.Rows.Add(details.Pack_Code);

            return dataTable;
        }

        public DataTable Map_DrillDownDetail_ToDataTable(DataTable dataTable, Size_Details details)
        {
            dataTable.Rows.Add(details.Size_Code,
                               details.Size_Description);

            return dataTable;
        }

        public DataTable Map_DrillDownDetail_ToDataTable(DataTable dataTable, Product_Details details)
        {
            dataTable.Rows.Add(details.Prodcut_Number,
                               details.Prodcut_Description);

            return dataTable;
        }

        public DataTable Map_DrillDownDetail_ToDataTable(DataTable dataTable, Department_Details details)
        {
            dataTable.Rows.Add(details.Department,
                               details.Department_Description,
                               details.SubRange_Description);

            return dataTable;
        }
    }
}
