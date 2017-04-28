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
    }
}
