﻿using System.Collections.Generic;
using MCO.Data.MosPackMaintenance.Models;

namespace MCO.Service.MosPackMaintenance.Interfaces
{
    public interface IPerformLookup
    {
        IEnumerable<Raw_Pack_Data> Lookup_RawPackData(Filter_Parameters filterParams);
        IEnumerable<T> GetDetail<T>(string packId, string drillDownDetail);
        IEnumerable<Filter_Data> GetAllSubRanges();
        IEnumerable<Size_Ranges> GetAllSizeRanges();
        IEnumerable<Size_Details> getSizesBySizeRange(string sizeRange);
        string GetNextPackID();
    }
}
