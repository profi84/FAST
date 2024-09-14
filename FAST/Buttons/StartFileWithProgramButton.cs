using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.Buttons
{
    public class StartFileWithProgramButton : BasicButton
    {
        public string PathOfFile { get; set; }

        public bool IfNotDefaultProgram { get; set; }

        public string PathProgramIfNotDefault { get; set; }

        public bool IfNoFileChoosed { get; set; }

        public string PathOfFolderIfNoFileChoosed { get; set; }
    }
}
