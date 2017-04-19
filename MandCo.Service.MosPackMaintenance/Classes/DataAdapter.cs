namespace MCO.Service.MosPackMaintenance.Classes
{
    using System.Collections.Generic;
    using Interfaces;
    using Data.MosPackMaintenance.Models;
    using System.Data;

    public class DataAdapter : IAdaptData
    {
        private readonly IDataTableFactory dtFactory;

        public DataAdapter(IDataTableFactory dtFactory)
        {
            this.dtFactory = dtFactory;
        }

        public IEnumerable<Cleansed_Pack_Data> Return_InterprettedData_ToCleansedData(IEnumerable<Raw_Pack_Data> rawPackData)
        {
            List<Cleansed_Pack_Data> result = new List<Cleansed_Pack_Data>();

            foreach(var rawPack in rawPackData)
            {
                Cleansed_Pack_Data newPack = Map_RawPackData_ToCleansedPackData(rawPack);

                result.Add(newPack);
            }

            return result;
        }

        private Cleansed_Pack_Data Map_RawPackData_ToCleansedPackData(Raw_Pack_Data rawPack)
        {
            Cleansed_Pack_Data result = new Cleansed_Pack_Data()
            {
                Pack_Id = rawPack.PACK_ID,
                Pack_Name = rawPack.PACK_NAME,
                Number_of_Sizes = rawPack.NO_OF_SIZES,
                Number_of_Units = rawPack.NO_OF_UNITS,
            };

            return result;
        }

        public DataTable Return_CleansedPacks_ToDataTable(IEnumerable<Cleansed_Pack_Data> cleansedPackData)
        {
            DataTable result = dtFactory.CreateNew_CleansedPackData_ToDataTable();

            foreach(var pack in cleansedPackData)
            {
                result.Rows.Add(pack.Pack_Name,
                                pack.Pack_Id,
                                pack.Number_of_Sizes,
                                pack.Number_of_Units
                                );
            }

            return result;
        }
    }
}
