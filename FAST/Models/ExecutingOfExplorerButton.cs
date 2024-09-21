using FAST.Buttons;
using FAST.Data;
using FAST.MessageBoxes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.Models
{
    public class ExecutingOfExplorerButton
    {
        public ExecutingOfExplorerButton(StartExplorerButton startExplorerButton)
        {
            if(ChechParams(startExplorerButton.GetPathFolder))
            {
                StartProcess(startExplorerButton);
            }
            else
            {
                MessageBoxCollection.Instance().ShowInfoMessageBox("Inhalte des Lesezeichens sind nicht korrekt. Bitte überprüfen, oder erneut anlegen!",
                    "Falsche Daten!");
            }
        }

        private bool ChechParams(string path)
        {
            if(path.Contains('"'))
            {
                path = path.Substring(1, path.Length -2);
            }
            return Directory.Exists(path);
        }

        private void StartProcess(StartExplorerButton startExplorerButton)
        {
            Process.Start(startExplorerButton.GetPathFolder);
        }
    }
}
