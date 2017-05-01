using MCO.Data.MosPackMaintenance.Models;

namespace MCO.Service.MosPackMaintenance.Interfaces
{
    public interface IPerformInsert
    {
        void Insert_NewPackHeader_ToDB(New_Pack newPack);
        void Insert_NewPackDetail_ToDb(New_Pack newPack);
    }
}
