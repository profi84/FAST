using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.Buttons
{
    public class StartFileWithProgramButton : BasicButton
    {
		private string pathOfFile;
		public string PathOfFile
        {
			get { return pathOfFile; }
			set { pathOfFile = value; }
		}

		private bool ifNotDefaultProgram;
		public bool IfNotDefaultProgram
        {
			get { return ifNotDefaultProgram; }
			set { ifNotDefaultProgram = value; }
		}

		private string pathProgramIfNotDefault;
		public string PathProgramIfNotDefault
        {
			get { return pathProgramIfNotDefault; }
			set { pathProgramIfNotDefault = value; }
		}

		private bool ifNoFileChoosed;
		public bool IfNoFileChoosed
        {
			get { return ifNoFileChoosed; }
			set { ifNoFileChoosed = value; }
		}

		private string pathOfFolderIfNoFileChoosed;
		public string PathOfFolderIfNoFileChoosed
        {
			get { return pathOfFolderIfNoFileChoosed; }
			set { pathOfFolderIfNoFileChoosed = value; }
		}
	}
}
