using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.ParamsEventArgs
{
    public class ActiveButtonEventArgs : EventArgs
    {
        public ActiveButtonEventArgs(string buttonName)
        {
            ActiveButtonName = buttonName;
        }

        public string ActiveButtonName { get; private set; }
    }
}
