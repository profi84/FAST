using FAST.Buttons;
using FAST.Data;
using FAST.MessageBoxes;
using System;
using System.Collections.Generic;
using System.IO;
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
            if (path.Contains('"'))
            {
                path = path.Substring(1, path.Length - 2);
            }
            return File.Exists(path);
        }

        private void StartProcess(StartFileWithProgramButton startFileWithProgramButton)
        {

        }
    }
}
