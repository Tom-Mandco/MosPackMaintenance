namespace MCO.Data.MosPackMaintenance.Classes
{
    using Interfaces;
    using Data;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OracleRepository : OracleBase, IRepository
    {
        public OracleRepository(string connectionString)
    : base(connectionString)
        {
        }

        public IEnumerable<Raw_Pack_Data> GetAllPacks(FilterParameters filterParams)
        {
            using (new SharedConnection(dbConnection))
            {
                var result = dbConnection.Query<Raw_Pack_Data>(SqlLoader.GetSql("FetchPacks"),
                                                               filterParams.Department,
                                                               filterParams.Sub_Department,
                                                               filterParams.Section,
                                                               filterParams.Range,
                                                               filterParams.Sub_Range
                                                               );
                return result.Any() ? result : null;
            }
        }
    }
}
