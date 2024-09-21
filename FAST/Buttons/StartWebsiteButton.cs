using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.Buttons
{
    public class StartWebsiteButton : BasicButton
    {
        public string GetAddressOfWebsite { get; set; }

        public bool GetIfNotDefaultBrowser { get; set; }

        public string GetPathOfBrowserIfNotDefault { get; set; }
    }
}
