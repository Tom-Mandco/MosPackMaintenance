using System.Windows.Forms;
using MCO.Data.MosPackMaintenance.Models;

namespace MCO.Applications.MOSPackMaintenance.Interfaces
{
    public interface IValidationHandler
    {
        bool Validate_SizeRatioRow_DoesNotContainDuplicateValue(string sizeCode, DataGridView dgvSizeRatios);
        bool Validate_NewPack_IsUnique(New_Pack newPack);
        string Validate_NewPackSubmission_AllDataPresent(string packName, DataGridView dgvSizeRatios);
    }
}
