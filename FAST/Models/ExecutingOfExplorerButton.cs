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
    public class ExecutingOfExplorerButton
    {
        public ExecutingOfExplorerButton(StartExplorerButton startExplorerButton)
        {
            if(ChechParams(startExplorerButton.PathFolder))
            {
                StartProcess(startExplorerButton);
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

        private void StartProcess(StartExplorerButton startExplorerButton )
        {

        }
    }
}
