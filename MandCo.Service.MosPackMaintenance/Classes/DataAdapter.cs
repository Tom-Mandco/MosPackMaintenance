namespace MCO.Service.MosPackMaintenance.Classes
{
    using System.Collections.Generic;
    using Interfaces;
    using Data.MosPackMaintenance.Models;
    using System.Data;
    using System;

    public class DataAdapter : IAdaptData
    {
        private readonly IDataTableFactory dtFactory;
        private readonly IDataTableMapper dtMapper;

        public DataAdapter(IDataTableFactory dtFactory, IDataTableMapper dtMapper)
        {
            this.dtFactory = dtFactory;
            this.dtMapper = dtMapper;
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

        public DataTable CreateNew_DrillDownDetails_ToDataTable(string detailIdentifier)
        {
            DataTable result = dtFactory.CreateNew_DrillDownDetail_ToDataTable(detailIdentifier);

            return result;
        }

        public DataTable Map_Details_ToDataTable(DataTable dataTable, IEnumerable<Department_Details> detail)
        {
            return dtMapper.Map_DrillDownDetail_ToDataTable(dataTable, detail);
        }

        public DataTable Map_Details_ToDataTable(DataTable dataTable, IEnumerable<PackCode_Details> detail)
        {
            return dtMapper.Map_DrillDownDetail_ToDataTable(dataTable, detail);
        }

        public DataTable Map_Details_ToDataTable(DataTable dataTable, IEnumerable<Product_Details> detail)
        {
            return dtMapper.Map_DrillDownDetail_ToDataTable(dataTable, detail);
        }

        public DataTable Map_Details_ToDataTable(DataTable dataTable, IEnumerable<Size_Details> detail)
        {
            return dtMapper.Map_DrillDownDetail_ToDataTable(dataTable, detail);
        }

        public DataTable Map_SizeRanges_ToDataTable(IEnumerable<Size_Ranges> sizeRanges)
        {
            
        }
    }
}
