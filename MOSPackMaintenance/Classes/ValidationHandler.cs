namespace MCO.Applications.MOSPackMaintenance.Classes
{
    using System;
    using System.Windows.Forms;
    using Interfaces;
    using Data.MosPackMaintenance.Models;
    using Service.MosPackMaintenance.Interfaces;

    public class ValidationHandler : IValidationHandler
    {
        private readonly IPerformLookup performLookup;

        public ValidationHandler(IPerformLookup performLookup)
        {
            this.performLookup = performLookup;
        }

        public bool Validate_NewPack_IsUnique(New_Pack newPack)
        {
            return true;
        }

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
