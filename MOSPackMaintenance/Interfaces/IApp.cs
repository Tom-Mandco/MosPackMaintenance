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
        IEnumerable<Filter_Data> Return_FilterData_ToModel();
        DataTable Return_AllSizeRanges_ToDataTable();
        DataTable Return_SizesBySizeRange_ToDataTable(string sizeRangeID);
        bool Validate_SizeRatioRow_DoesNotContainDuplicateValue(string sizeCode, DataGridView dgvSizeRatios);
        string Return_NextPackID_ToString();
    }
}
