using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataView.DataModel
{
    public class StationModel
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public StationModel()
        {
            Name = string.Empty;
            Address = string.Empty;
        }
    }
}
