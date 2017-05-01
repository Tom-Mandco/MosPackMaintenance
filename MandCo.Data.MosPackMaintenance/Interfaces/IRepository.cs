using System.Collections.Generic;
using MCO.Data.MosPackMaintenance.Models;

namespace MCO.Data.MosPackMaintenance.Interfaces
{
    public interface IRepository
    {
        IEnumerable<T> GetFurtherDetail<T>(string packId, string drillDownDetail);
        IEnumerable<Raw_Pack_Data> GetAllPacks(Filter_Parameters filterParams);
        
        IEnumerable<Filter_Data> GetAllSubRanges();
        IEnumerable<Size_Ranges> GetAllSizeRanges();
        IEnumerable<Size_Details> GetSizes_ForSizeRange(string sizeRange);

        string GetNextPackID();

        void Insert_NewPackHeader(New_Pack newPack);
    }
}
