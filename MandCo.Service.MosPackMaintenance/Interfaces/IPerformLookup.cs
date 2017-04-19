using System.Collections.Generic;
using MCO.Data.MosPackMaintenance.Models;

namespace MCO.Service.MosPackMaintenance.Interfaces
{
    public interface IPerformLookup
    {
        IEnumerable<Raw_Pack_Data> Lookup_RawPackData(FilterParameters filterParams);
    }
}
