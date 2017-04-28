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

        public IEnumerable<Size_Ranges> GetAllSizeRanges()
        {
            return oracleRepo.GetAllSizeRanges();
        }

        public IEnumerable<Size_Details> getSizesBySizeRange(string sizeRange)
        {
            return oracleRepo.GetSizes_ForSizeRange(sizeRange);
        }

        public IEnumerable<Filter_Data> GetAllSubRanges()
        {
            return oracleRepo.GetAllSubRanges();
        }

        public IEnumerable<T> GetDetail<T>(string packId, string drillDownDetail)
        {
            var result = oracleRepo.GetFurtherDetail<T>(packId, drillDownDetail);

            return result;
        }

        public IEnumerable<Raw_Pack_Data> Lookup_RawPackData(Filter_Parameters filterParams)
        {
            IEnumerable<Raw_Pack_Data> result = oracleRepo.GetAllPacks(filterParams);

            return result;
        }

        public string GetNextPackID()
        {
            return oracleRepo.GetNextPackID();
        }
    }
}
