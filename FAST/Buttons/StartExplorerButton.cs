using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.Buttons
{
    public class StartExplorerButton : BasicButton
    {
		private string pathFolder;
		public string PathFolder
		{
			get { return pathFolder; }
			set { pathFolder = value; }
		}
	}
}
