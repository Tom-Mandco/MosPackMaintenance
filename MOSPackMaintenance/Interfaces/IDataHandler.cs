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
    }
}
