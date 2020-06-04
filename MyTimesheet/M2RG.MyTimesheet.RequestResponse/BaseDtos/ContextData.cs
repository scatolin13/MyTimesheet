using System.Collections.Generic;

namespace M2RG.MyTimesheet.RequestResponse.BaseDtos
{
    public class ContextData
    {
        public List<int> EmpresaIds { get; set; }
        public bool IsAdmin { get; set; }
    }
}
