using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.Buttons
{
    public class StartWebsiteButton : BasicButton
    {
		private string addressOfWebsite;
		public string AddressOfWebsite
        {
			get { return addressOfWebsite; }
			set { addressOfWebsite = value; }
		}

		private bool ifNotDefaultBrowser;
		public bool IfNotDefaultBrowser
        {
			get { return ifNotDefaultBrowser; }
			set { ifNotDefaultBrowser = value; }
		}

		private string pathOfBrowserIfNotDefault;
		public string PathOfBrowserIfNotDefault
        {
			get { return pathOfBrowserIfNotDefault; }
			set { pathOfBrowserIfNotDefault = value; }
		}
	}
}
