using System.Windows.Forms;
using MCO.Data.MosPackMaintenance.Models;

namespace MCO.Applications.MOSPackMaintenance.Interfaces
{
    public interface ISerializeObjects
    {
        New_Pack Serialize_PackData_ToNewPack(string packID, string packName, DataGridView dgvSizeRatios);
    }
}
