namespace MCO.Service.MosPackMaintenance.Classes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Data.MosPackMaintenance.Models;
    using Data.MosPackMaintenance.Interfaces;

    public class PerformLookup : IPerformLookup
    {
        private readonly IRepository oracleRepo;

        public PerformLookup(IRepository oracleRepo)
        {
            this.oracleRepo = oracleRepo;
        }

        public IEnumerable<Raw_Pack_Data> Lookup_RawPackData(FilterParameters filterParams)
        {
            IEnumerable<Raw_Pack_Data> result = oracleRepo.GetAllPacks(filterParams);

            return result;
        }
    }
}
