namespace MCO.Applications.MOSPackMaintenance.Classes
{
    using System.Windows.Forms;
    using Interfaces;

    public class ValidationHandler : IDGVRowValidator
    {
        public bool Validate_SizeRatioRow_DoesNotContainDuplicateValue(string sizeCode, DataGridView dgvSizeRatios)
        {
            bool result = true;

            foreach(DataGridViewRow row in dgvSizeRatios.Rows)
            {
                if (row.Cells[0].Value.ToString() == sizeCode)
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
