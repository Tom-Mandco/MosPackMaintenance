using System.Collections.Generic;
using MCO.Data.MosPackMaintenance.Models;

namespace MCO.Data.MosPackMaintenance.Interfaces
{
    public interface IRepository
    {
        IEnumerable<Raw_Pack_Data> GetAllPacks(FilterParameters filterParams);
    }
}
