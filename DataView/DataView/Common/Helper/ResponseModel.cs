using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing.IndexedProperties;
using System.Text;
using System.Threading.Tasks;
using static DataView.Common.Helper.ConstantHelper;

namespace DataView.Common.Helper
{
    public class ResponseModel
    {
        public APIResponseCode Code { get; set; }
        public string Message { get; set; }
        public object? Data { get; set; }

        public ResponseModel()
        {
            Code = APIResponseCode.CODE_SUCCESS;
            Message = string.Empty;
            Data = null;
        }
    }
}
