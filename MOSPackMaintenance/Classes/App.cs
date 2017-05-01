namespace MCO.Applications.MOSPackMaintenance.Classes
{
    using Interfaces;
    using Data.MosPackMaintenance.Models;
    using System.Data;
    using System.Collections.Generic;
    using System;
    using System.Configuration;
    using System.Windows.Forms;

    public class App : IApp
    {
        private readonly ILog logger;
        private readonly IDataHandler dataHandler;
        private readonly IValidationHandler validationHandler;
        private readonly ISerializeObjects objectSerializer;

        #region Initialization
        public App(ILog logger, IDataHandler dataHandler, IValidationHandler rowValidator, ISerializeObjects objectSerializer)
        {
            this.logger = logger;
            this.dataHandler = dataHandler;
            this.validationHandler = rowValidator;
            this.objectSerializer = objectSerializer;
        }
        #endregion

        public DataTable Return_CleansedData_ToDataTable(Filter_Parameters filterParams)
        {
            logger.Info("Retrieval started");

            try
            {
                IEnumerable<Raw_Pack_Data> rawPackData = dataHandler.Return_RawPackData_ToModel(filterParams);

                IEnumerable<Cleansed_Pack_Data> cleansedPackData = dataHandler.Return_CleansedPackData_ToModel(rawPackData);

                DataTable result = dataHandler.Map_CleansedPackData_InToDataTable(cleansedPackData);

                return result;
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);

                return null;
            }
            finally
            {
                //Naaiers
                logger.Info("Retrieval ended");
            }
        }

        public Filter_Parameters Parse_Filter_Parameters_ToModel(List<string> searchParams)
        {
            Filter_Parameters result = new Filter_Parameters();

            try
            {
                for (int i = 0; i < searchParams.Count; i++)
                {
                    //If the parameter is over 1 digit long (all); the wildcard search in the SQL statement will be triggered with an empty string
                    searchParams[i] = searchParams[i].Length > 1 ? string.Empty : searchParams[i];
                }

                result.Department = searchParams[0];
                result.Sub_Department = searchParams[1];
                result.Section = searchParams[2];
                result.Range = searchParams[3];
                result.Sub_Range = searchParams[4];
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
            }

            return result;
        }

        public Dictionary<string, DataTable> Return_DrillDownDetail_ToDictionary(string packId)
        {
            string[] activeDrillDowns = ConfigurationManager.AppSettings["activeDrillDownQueries"].Split(',');

            Dictionary<string, DataTable> result = new Dictionary<string, DataTable>();

            foreach (string drilldown in activeDrillDowns)
            {
                DataTable _dt = dataHandler.Return_dtDrillDownObject_ToModel(packId, drilldown);
                if(_dt.IsInitialized)
                    result.Add(drilldown, _dt);
            }
            
            return result;
        }

        public IEnumerable<Filter_Data> Return_FilterData_ToModel()
        {
            return dataHandler.Return_FilterData_ToModel();
        }

        public DataTable Return_AllSizeRanges_ToDataTable()
        {
            try
            {
                IEnumerable<Size_Ranges> sizeRanges = dataHandler.Return_AllSizeRanges_ToModel();

                DataTable result = dataHandler.Return_SizeRanges_ToDataTable(sizeRanges);

                return result;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
                return null;
            }

            
        }

        public DataTable Return_SizesBySizeRange_ToDataTable(string sizeRange)
        {
            try
            {
                IEnumerable<Size_Details> sizeDetails = dataHandler.Return_SizesBySizeRange_ToModel(sizeRange);

                DataTable result = dataHandler.Return_SizesBySizeRange_ToDataTable(sizeDetails);

                return result;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
                return null;
            }
        }

        public bool Validate_SizeRatioRow_DoesNotContainDuplicateValue(string sizeCode, DataGridView dgvSizeRatios)
        {
            return validationHandler.Validate_SizeRatioRow_DoesNotContainDuplicateValue(sizeCode, dgvSizeRatios);
        }

        public string Return_NextPackID_ToString()
        {
            return dataHandler.Return_NextPackID_ToString();
        }

        public New_Pack Return_NewPack_ToModel(string packID, string packName, DataGridView dgvSizeRatios)
        {
            return objectSerializer.Serialize_PackData_ToNewPack(packID, packName, dgvSizeRatios);  
        }

        public bool Validate_NewPack_IsUnique(New_Pack newPack)
        {
            return validationHandler.Validate_NewPack_IsUnique(newPack);
        }

        public void Insert_NewPack_ToDB(New_Pack newPack)
        {
            dataHandler.Insert_NewPack_ToDB(newPack);
        }
    }
}
