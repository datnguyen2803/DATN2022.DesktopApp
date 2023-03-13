using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataView.DataModel
{
    public class PumpModel
    {
        public string StationName { get; set; }
        public string Position { get; set; }
        public int State { get; set; }

        public PumpModel()
        {
            StationName = string.Empty;
            Position = string.Empty;
            State = 0;
        }
    }
}
