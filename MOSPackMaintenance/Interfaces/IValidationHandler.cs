using System.Windows.Forms;

namespace MCO.Applications.MOSPackMaintenance.Interfaces
{
    public interface IDGVRowValidator
    {
        bool Validate_SizeRatioRow_DoesNotContainDuplicateValue(string sizeCode, DataGridView dgvSizeRatios);
    }
}
