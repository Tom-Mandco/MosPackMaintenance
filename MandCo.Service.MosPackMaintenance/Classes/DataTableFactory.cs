namespace MCO.Service.MosPackMaintenance.Classes
{
    using Interfaces;
    using System.Data;
    using System;
    using System.Collections.Generic;

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

        public DataTable CreateNew_DrillDownDetail_ToDataTable(string detailIdentifier)
        {
            DataTable result = new DataTable();

            string[] headers = Return_DetailHeaders_ToArray(detailIdentifier);

            foreach (var header in headers)
            {
                result.Columns.Add(header);
            }

            return result;
        }

        public DataTable CreateNew_SizeRanges_ToDataTable()
        {
            DataTable result = new DataTable();

            result.Columns.Add("Size Range");
            result.Columns.Add("Size Range Description");
            result.Columns.Add("Department Code");
            result.Columns.Add("Sub Department Code");

            return result;
        }

        private string[] Return_DetailHeaders_ToArray(string detailIdentifier)
        {
            List<string> result = new List<string>();

            switch (detailIdentifier)
            {
                case "Department":
                    result.Add("Department");
                    result.Add("Department Description");
                    result.Add("SubRange Description");
                    break;
                case "PackCodes":
                    result.Add("Pack Code");
                    break;
                case "Product":
                    result.Add("Product Number");
                    result.Add("Product Description");
                    break;
                case "Size":
                    result.Add("Size Code");
                    result.Add("Size Description");
                    break;
            }

            return result.ToArray();
        }
    }
}
