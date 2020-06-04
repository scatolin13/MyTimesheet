using System.Collections.Generic;

namespace M2RG.MyTimesheet.RequestResponse
{
    public interface IResultDefault
    {
        public List<string> Exceptions { get; set; }
    }
}
