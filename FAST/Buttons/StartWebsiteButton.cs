using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.Buttons
{
    public class StartWebsiteButton : BasicButton
    {
        public string AddressOfWebsite { get; set; }

        public bool IfNotDefaultBrowser { get; set; }

        public string PathOfBrowserIfNotDefault { get; set; }
    }
}
