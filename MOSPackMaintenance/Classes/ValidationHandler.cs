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

        public string Validate_NewPackSubmission_AllDataPresent(string packName, DataGridView dgvSizeRatios)
        {
            string result = "";

            if (packName == "")
            {
                result = "No Pack Name Entered";
            }
            else if (packName.Contains("|"))
            {
                result = "Pack names cannot contain the pipe character";
            }
            else if (packName.Length > 50)
            {
                result = "Pack names cannot exceed 50 characters";
            }

            foreach (DataGridViewRow _row in dgvSizeRatios.Rows)
            {
                string _rowQty = _row.Cells[2].Value.ToString();
                int _rowQtyInt;

                bool _isQtyInt = int.TryParse(_rowQty, out _rowQtyInt);

                if (!_isQtyInt)
                {
                    result = string.Format("All ratio quantaties must be in integer format. Please revise qty for size {0}", _row.Cells[0].Value.ToString());
                }
            }

            return result;
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
