namespace MCO.Applications.MOSPackMaintenance.Interfaces
{
    using Data.MosPackMaintenance.Models;
    using System.Data;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public interface IApp
    {
        New_Pack Return_NewPack_ToModel(string packID, string packName, DataGridView dgvSizeRatios);
        Filter_Parameters Parse_Filter_Parameters_ToModel(List<string> searchParameters);

        IEnumerable<Filter_Data> Return_FilterData_ToModel();
        Dictionary<string, DataTable> Return_DrillDownDetail_ToDictionary(string packId);

        DataTable Return_AllSizeRanges_ToDataTable();
        DataTable Return_SizesBySizeRange_ToDataTable(string sizeRangeID);
        DataTable Return_CleansedData_ToDataTable(Filter_Parameters filterParams);

        bool Validate_SizeRatioRow_DoesNotContainDuplicateValue(string sizeCode, DataGridView dgvSizeRatios);
        bool Validate_NewPack_IsUnique(New_Pack newPack);

        string Return_NextPackID_ToString();
        void Insert_NewPack_ToDB(New_Pack newPack);
    }
}
