using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.Buttons
{
    public class StartFileWithProgramButton : BasicButton
    {
        public string GetPathOfFile { get; set; }

        public bool GetIfNotDefaultProgram { get; set; }

        public string GetPathProgramIfNotDefault { get; set; }

        public bool GetIfNoFileChoosed { get; set; }

        public string GetPathOfFolderIfNoFileChoosed { get; set; }
    }
}
