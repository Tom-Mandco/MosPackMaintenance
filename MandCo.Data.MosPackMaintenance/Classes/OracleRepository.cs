namespace MCO.Data.MosPackMaintenance.Classes
{
    using Interfaces;
    using Data;
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    using System;

    public class OracleRepository : OracleBase, IRepository
    {
        public OracleRepository(string connectionString)
    : base(connectionString)
        {
        }

        public IEnumerable<Raw_Pack_Data> GetAllPacks(Filter_Parameters filterParams)
        {
            using (new SharedConnection(dbConnection))
            {
                var result = dbConnection.Query<Raw_Pack_Data>(SqlLoader.GetSql("Fetch_Packs"),
                                                               filterParams.Department,
                                                               filterParams.Sub_Department,
                                                               filterParams.Section,
                                                               filterParams.Range,
                                                               filterParams.Sub_Range
                                                               );
                return result.Any() ? result : null;
            }
        }



        public Product_Details GetProductDetails(string packId)
        {
            using (new SharedConnection(dbConnection))
            {
                var result = dbConnection.Query<Product_Details>(SqlLoader.GetSql("Fetch_ProductDetails"),
                                                               packId
                                                               );
                return result.Any() ? result.First() : null;
            }
        }

        public IEnumerable<T> GetFurtherDetail<T>(string packId, string drillDownDetail)
        {
            string _query = "";

            Dictionary<string, string> queryTable = new Dictionary<string, string>()
            {
                { "Department", "Fetch_DepartmentDetails"},
                { "PackCodes", "Fetch_PackCodes"},
                { "Product", "Fetch_ProductDetails"},
                { "Size", "Fetch_SizeDetails"}
            };

            if(queryTable.Keys.Contains(drillDownDetail))
            {
                _query = queryTable[drillDownDetail];
            }

            using (new SharedConnection(dbConnection))
            {
                var result = dbConnection.Query<T>(SqlLoader.GetSql(_query),
                                                               packId
                                                               );

                return result.Any() ? result : default(IEnumerable<T>);
            }
        }

        public IEnumerable<Filter_Data> GetAllSubRanges()
        {
            using (new SharedConnection(dbConnection))
            {
                var result = dbConnection.Query<Filter_Data>(SqlLoader.GetSql("Fetch_AllActiveSubRanges"));

                return result.Any() ? result : null;
            }
        }

        public IEnumerable<Size_Ranges> GetAllSizeRanges()
        {
            using (new SharedConnection(dbConnection))
            {
                var result = dbConnection.Query<Size_Ranges>(SqlLoader.GetSql("Fetch_AllSizeRanges"));

                return result.Any() ? result : null;
            }
        }

        public IEnumerable<Size_Details> GetSizes_ForSizeRange(string sizeRange)
        {
            using (new SharedConnection(dbConnection))
            {
                var result = dbConnection.Query<Size_Details>(SqlLoader.GetSql("Fetch_SizesBySizeRange"), sizeRange);

                return result.Any() ? result : null;
            }
        }

        public string GetNextPackID()
        {
            using (new SharedConnection(dbConnection))
            {
                var result = dbConnection.Query<string>(SqlLoader.GetSql("Fetch_NextPackID"));
                return result.Any() ? result.First() : null;
            }
        }

        public void Insert_NewPackHeader(New_Pack newPack)
        {
            using (new SharedConnection(dbConnection))
            {
                dbConnection.Execute(SqlLoader.GetSql("Insert_NewPackHeader"),
                                                       newPack.PackId,
                                                       newPack.PackName,
                                                       newPack.Return_TotalSizes_ToInt(),
                                                       newPack.Return_TotalUnits_ToInt()
                                                       );
            }
        }

        public void Insert_NewPackDetail(New_Pack newPack)
        {
            using (new SharedConnection(dbConnection))
            {
                string _sqlInsertQuery = "INSERT ALL ";

                string _sqlInsertHeaders = "INTO hir_Pack_makeup (pack_id, size_code, units_qty, display_sequence)";

                foreach (New_Pack_Sizes packSize in newPack.SizeList)
                {
                    _sqlInsertQuery += string.Format("{0} VALUES ('{1}',{2},{3},{4}) ",
                                               _sqlInsertHeaders,
                                               newPack.PackId, 
                                               packSize.Size_Code, 
                                               packSize.Qty,
                                               packSize.Display_Sequence
                                               );
                }

                _sqlInsertQuery += "SELECT * FROM dual";

                dbConnection.Execute(_sqlInsertQuery);
            }
        }
    }
}
