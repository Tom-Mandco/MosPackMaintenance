namespace MCO.Service.MosPackMaintenance.Classes
{
    using System;
    using System.Data;
    using Interfaces;
    using Data.MosPackMaintenance.Models;
    using System.Collections.Generic;

    public class DataTableMapper : IDataTableMapper
    {
        public DataTable Map_DrillDownDetail_ToDataTable(DataTable dataTable, IEnumerable<PackCode_Details> details)
        {
            foreach (var detail in details)
            {
                dataTable.Rows.Add(detail.Pack_Code);
            }

            return dataTable;
        }

        public DataTable Map_DrillDownDetail_ToDataTable(DataTable dataTable, IEnumerable<Size_Details> details)
        {
            foreach (var detail in details)
            {
                dataTable.Rows.Add(detail.Size_Code,
                                   detail.Size_Description);
            }

            return dataTable;
        }

        public DataTable Map_DrillDownDetail_ToDataTable(DataTable dataTable, IEnumerable<Product_Details> details)
        {
            foreach (var detail in details)
            {
                dataTable.Rows.Add(detail.Product_Number,
                                   detail.Product_Description);
            }

            return dataTable;
        }

        public DataTable Map_DrillDownDetail_ToDataTable(DataTable dataTable, IEnumerable<Department_Details> details)
        {
            foreach (var detail in details)
            {
                dataTable.Rows.Add(detail.Department,
                                   detail.Department_Description,
                                   detail.SubRange_Description);
            }

            return dataTable;
        }

        public DataTable Map_SizeRanges_ToDataTable(DataTable dataTable, IEnumerable<Size_Ranges> sizeRanges)
        {
            foreach (var _sizeRange in sizeRanges)
            {
                dataTable.Rows.Add(_sizeRange.Size_Range,
                                   _sizeRange.Size_Range_Description,
                                   _sizeRange.Department_Code,
                                   _sizeRange.Sub_Department_Code);
            }

            return dataTable;
        }
    }
}
