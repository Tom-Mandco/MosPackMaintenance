using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MCO.Data.MosPackMaintenance.Models;

namespace MCO.Applications.MOSPackMaintenance.Interfaces
{
    public interface IDataHandler
    {
        IEnumerable<Raw_Pack_Data> Return_RawPackData_ToModel(Filter_Parameters filterParams);
        IEnumerable<Cleansed_Pack_Data> Return_CleansedPackData_ToModel(IEnumerable<Raw_Pack_Data> rawPackData);
        DataTable Map_CleansedPackData_InToDataTable(IEnumerable<Cleansed_Pack_Data> cleansedPackData);
        DataTable Return_dtDrillDownObject_ToModel(string packId, string drillDownIdentifier);
        IEnumerable<Filter_Data> Return_FilterData_ToModel();
        IEnumerable<Size_Ranges> Return_AllSizeRanges_ToModel();
        DataTable Return_SizeRanges_ToDataTable(IEnumerable<Size_Ranges> sizeRanges);
        IEnumerable<Size_Details> Return_SizesBySizeRange_ToModel(string sizeRange);
        DataTable Return_SizesBySizeRange_ToDataTable(IEnumerable<Size_Details> sizeDetails);
        string Return_NextPackID_ToString();
        void Insert_NewPack_ToDB(New_Pack newPack);
    }
}
