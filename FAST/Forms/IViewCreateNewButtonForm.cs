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
    public interface IViewCreateNewButtonForm
    {
        event EventHandler CreateNewButtonFormOK;
        event EventHandler CreateNewButtonFormCancel;

        BasicButton GetNewButton();
    }
}
