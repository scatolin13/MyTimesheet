using System.Collections.Generic;

namespace M2RG.MyTimesheet.RequestResponse.BaseDtos
{
    public class Select2AutoComplete<T> where T : class
    {
        public Select2AutoComplete()
        {
        }

        public List<T> Entities { get; set; } = new List<T>();
        public string Query { get; set; } = "";
        public int PageSize { get; set; } = 0;
        public int PageNumber { get; set; } = 0;

    }
}
