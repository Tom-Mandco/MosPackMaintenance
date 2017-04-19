namespace MCO.Applications.MOSPackMaintenance.Classes
{
    using Interfaces;
    using Data.MosPackMaintenance.Models;
    using Service.MosPackMaintenance.Interfaces;
    using System.Collections.Generic;
    using System.Data;

    public class DataHandler : IDataHandler
    {
        private readonly ILog logger;
        private readonly IPerformLookup performLookup;
        private readonly IAdaptData dataAdapter;

        public DataHandler(ILog logger, IPerformLookup performLookup, IAdaptData dataAdapter)
        {
            this.logger = logger;
            this.performLookup = performLookup;
            this.dataAdapter = dataAdapter;
        }

        public IEnumerable<Cleansed_Pack_Data> Return_CleansedPackData_ToModel(IEnumerable<Raw_Pack_Data> rawPackData)
        {
            return dataAdapter.Return_InterprettedData_ToCleansedData(rawPackData);
        }

        public IEnumerable<Raw_Pack_Data> Return_RawPackData_ToModel(Filter_Parameters filterParams)
        {
            return performLookup.Lookup_RawPackData(filterParams);
        }

        public DataTable Map_CleansedPackData_InToDataTable(IEnumerable<Cleansed_Pack_Data> cleansedPackData)
        {
            return dataAdapter.Return_CleansedPacks_ToDataTable(cleansedPackData);
        }

    }
}
