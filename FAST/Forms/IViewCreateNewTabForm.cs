using FAST.Data;
using FAST.Buttons;
using FAST.MessageBoxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.Forms
{
    public interface IViewCreateNewTabForm
    {
        event EventHandler CreateNewTabFormOK;
        event EventHandler CreateNewTabFormCancel;

        void ClearTextBox();
        string GetTabName();
    }
}
