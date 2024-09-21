using FAST.Buttons;
using FAST.Data;
using FAST.MessageBoxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.Models
{
    public class ExecutingOfProgramButton
    {
        public ExecutingOfProgramButton(StartFileWithProgramButton startFileWithProgramButton)
        {
            if (ChechParams(startFileWithProgramButton.GetPathOfFile))
            {
                StartProcess(startFileWithProgramButton);
            }
            else
            {
                MessageBoxCollection.Instance().ShowInfoMessageBox("Inhalte des Lesezeichens sind nicht korrekt. Bitte überprügen, oder erneut anlegen!",
                    "Falsche Daten!");
            }
        }

        private bool ChechParams(string path)
        {
            return true;
        }

        private void StartProcess(StartFileWithProgramButton startFileWithProgramButton)
        {

        }
    }
}
