namespace MCO.Applications.MOSPackMaintenance.Classes
{
    using System;
    using System.Windows.Forms;
    using Interfaces;
    using Data.MosPackMaintenance.Models;
    using System.Collections.Generic;

    public class ObjectSerializer : ISerializeObjects
    {
        private readonly ILog logger;
        private readonly IValidationHandler validationHandler;

        public ObjectSerializer(ILog logger, IValidationHandler validationHandler)
        {
            this.logger = logger;
            this.validationHandler = validationHandler;
        }

        public New_Pack Serialize_PackData_ToNewPack(string packID, string packName, DataGridView dgvSizeRatios)
        {
            New_Pack result = new New_Pack();
            List<New_Pack_Sizes> packSizes = new List<New_Pack_Sizes>();
            int displaySequence = 1;

            foreach (DataGridViewRow _row in dgvSizeRatios.Rows)
            {
                New_Pack_Sizes packSize = new New_Pack_Sizes()
                {
                    Size_Code = Convert.ToInt32(_row.Cells[0].Value.ToString()),
                    Qty = Convert.ToInt32(_row.Cells[2].Value.ToString()),
                    Display_Sequence = displaySequence
                };
                packSizes.Add(packSize);
                displaySequence++;
            }

            result.PackId = packID;
            result.PackName = packName;
            result.SizeList = packSizes;

            return result;
        }
    }
}
