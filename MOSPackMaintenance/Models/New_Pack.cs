namespace MCO.Applications.MOSPackMaintenance.Models
{
    using System.Collections.Generic;

    public class New_Pack
    {
        public string PackId { get; set; }
        public string PackName { get; set; }

        public IEnumerable<Sizes_In_Pack> SizeList { get; set; }

        public int Return_TotalSizes_ToInt()
        {
            int result = 0;

            foreach (var _size in SizeList)
                result += _size.Qty;

            return result;
        }
    }
}
