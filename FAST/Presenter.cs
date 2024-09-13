using FAST.Buttons;
using FAST.DB_Connecting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST
{
    public class Presenter
    {
        public Presenter(IViewMainForm mainView)
        {
            this.mainView = mainView;
        }

        private IViewMainForm mainView;
    }
}
