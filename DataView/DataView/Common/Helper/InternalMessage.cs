using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataView.Common.Helper.ConstantHelper;

namespace DataView.Common.Helper
{
    public class InternalMessage
    {
        public INTERNAL_MESSAGE_CODE Code { get; set; }
        public object? Data { get; set; }

        public InternalMessage()
        {
            Code = INTERNAL_MESSAGE_CODE.CODE_INTERNAL_MESSAGE_NONE;
            Data = null;
        }

        public InternalMessage(INTERNAL_MESSAGE_CODE code, object? data = null)
        {
            Code = code;
            Data = data;
        }
    }
}
