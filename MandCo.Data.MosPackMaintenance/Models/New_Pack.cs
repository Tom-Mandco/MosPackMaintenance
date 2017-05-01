namespace MCO.Data.MosPackMaintenance.Models
{
    using System.Collections.Generic;

    public class New_Pack
    {
        public string PackId { get; set; }
        public string PackName { get; set; }

        public IEnumerable<New_Pack_Sizes> SizeList { get; set; }

        public int Return_TotalUnits_ToInt()
        {
            int result = 0;

            foreach (New_Pack_Sizes _size in SizeList)
                result += _size.Qty;

            return result;
        }

        public int Return_TotalSizes_ToInt()
        {
            int result = 0;

            foreach (New_Pack_Sizes _size in SizeList)
                result++;

            return result;
        }
    }
}
