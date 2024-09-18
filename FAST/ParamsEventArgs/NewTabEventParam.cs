using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.ParamsEventArgs
{
    public class NewTabEventParam : EventArgs
    {
        public NewTabEventParam(string newTabName)
        { 
            NewTabName = newTabName;
        }

        public string NewTabName { get; private set; }
    }
}
