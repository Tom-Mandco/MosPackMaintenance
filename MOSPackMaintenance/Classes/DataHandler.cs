namespace MCO.Applications.MOSPackMaintenance.Classes
{
    using Interfaces;
    using Data.MosPackMaintenance.Models;
    using Service.MosPackMaintenance.Interfaces;
    using System.Collections.Generic;
    using System.Data;
    using System;

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

        public DataTable Return_dtDrillDownObject_ToModel(string packId, string drillDownIdentifier)
        {
            DataTable result;
            
            logger.Trace("Drill Down Identifier: {0}", drillDownIdentifier);

            result = dataAdapter.CreateNew_DrillDownDetails_ToDataTable(drillDownIdentifier);

            switch (drillDownIdentifier)
            {
                case "Department":
                    logger.Trace("Department case initiated");

                    IEnumerable<Department_Details> _departmentDetail;
                    _departmentDetail = performLookup.GetDetail<Department_Details>(packId, drillDownIdentifier);
                    result = dataAdapter.Map_Details_ToDataTable(result, _departmentDetail);
                    break;

                case "PackCodes":
                    logger.Trace("Pack case initiated");

                    IEnumerable<PackCode_Details> _packCodeDetail;
                    _packCodeDetail = performLookup.GetDetail<PackCode_Details>(packId, drillDownIdentifier);
                    result = dataAdapter.Map_Details_ToDataTable(result, _packCodeDetail);
                    break;

                case "Product":
                    logger.Trace("Product case initiated");

                    IEnumerable<Product_Details> _productDetail;
                    _productDetail = performLookup.GetDetail<Product_Details>(packId, drillDownIdentifier);
                    result = dataAdapter.Map_Details_ToDataTable(result, _productDetail);
                    break;

                case "Size":
                    logger.Trace("Size Department case initiated");

                    IEnumerable<Size_Details> _sizeDetail;
                    _sizeDetail = performLookup.GetDetail<Size_Details>(packId, drillDownIdentifier);
                    result = dataAdapter.Map_Details_ToDataTable(result, _sizeDetail);
                    break;

                default:
                    logger.Warn("Invalid Drill down identifier");
                    break;
            }

            return result.IsInitialized ? result : null;
        }

        public IEnumerable<Filter_Data> Return_FilterData_ToModel()
        {
            return performLookup.GetAllSubRanges();
        }

        public IEnumerable<Size_Ranges> Return_AllSizeRanges_ToModel()
        {
            return performLookup.GetAllSizeRanges();
        }

        public DataTable Return_SizeRanges_ToDataTable(IEnumerable<Size_Ranges> sizeRanges)
        {
            return dataAdapter.Map_SizeRanges_ToDataTable(sizeRanges);
        }
    }
}
