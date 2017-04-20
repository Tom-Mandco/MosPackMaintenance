namespace MCO.Applications.MOSPackMaintenance.Interfaces
{
    using Data.MosPackMaintenance.Models;
    using System.Data;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public interface IApp
    {
        DataTable Return_CleansedData_ToDataTable(Filter_Parameters filterParams);
        Filter_Parameters Parse_Filter_Parameters_ToModel(List<string> searchParameters);
        Dictionary<string, DataTable> Return_DrillDownDetail_ToDictionary(string packId);
    }
}
