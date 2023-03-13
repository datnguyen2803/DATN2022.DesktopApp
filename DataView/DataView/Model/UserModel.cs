using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataView.DataModel
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public UserModel()
        {
            Name = string.Empty;
            Password = string.Empty;
        }
    }
}
