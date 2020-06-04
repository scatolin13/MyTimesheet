using System.Collections.Generic;

namespace M2RG.MyTimesheet.RequestResponse.BaseDtos
{
    public class Pagination<T> where T : class
    {
        public Pagination()
        {
        }

        public List<T> Entities { get; set; } = new List<T>();
        public int CurrentPage { get; set; } = 0;
        public int PageSize { get; set; } = 0;
        public int TotalRows { get; set; } = 0;
        public int PageNumber { get; set; } = 0;

    }
}
