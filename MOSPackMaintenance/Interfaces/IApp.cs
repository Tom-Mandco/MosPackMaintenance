namespace MCO.Applications.MOSPackMaintenance.Interfaces
{
    using Data.MosPackMaintenance.Models;
    using System.Data;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public interface IApp
    {
        DataTable Return_CleansedData_ToDataTable(Filter_Parameters filterParams);
        Filter_Parameters Parse_FilterParameters_ToModel(List<string> searchParameters);
    }
}
