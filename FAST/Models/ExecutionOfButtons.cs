using FAST.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.Models
{
    public class ExecutionOfButtons
    {
        public ExecutionOfButtons(BasicButton basicButton)
        {
            if(basicButton is StartExplorerButton)
            {
                StartExplorerButton startExplorerButton = (StartExplorerButton)basicButton;
                ExecutingOfExplorerButton obj = new ExecutingOfExplorerButton(startExplorerButton);
            }
            if (basicButton is StartFileWithProgramButton)
            {
                StartFileWithProgramButton startFileWithProgramButton = (StartFileWithProgramButton)basicButton;
                ExecutingOfProgramButton obj = new ExecutingOfProgramButton(startFileWithProgramButton);
            }
            if (basicButton is StartWebsiteButton)
            {
                StartWebsiteButton startWebsiteButton = (StartWebsiteButton)basicButton;
                ExecutingOfWebsiteButton obj = new ExecutingOfWebsiteButton(startWebsiteButton);
            }
        }
    }
}
