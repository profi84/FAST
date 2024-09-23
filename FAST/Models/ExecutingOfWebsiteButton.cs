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
    public class ExecutingOfWebsiteButton
    {
        public ExecutingOfWebsiteButton(StartWebsiteButton startWebsiteButton)
        {
            if (startWebsiteButton.GetAddressOfWebsite != null)
            {
                StartProcess(startWebsiteButton);
            }
            else
            {
                MessageBoxCollection.Instance().ShowInfoMessageBox("Inhalte des Lesezeichens sind nicht korrekt. Bitte überprügen, oder erneut anlegen!",
                    "Falsche Daten!");
            }
        }

        private void StartProcess(StartWebsiteButton startWebsiteButton)
        {
            try
            {
                Process.Start(startWebsiteButton.GetAddressOfWebsite);
            }
            catch
            {
                MessageBoxCollection.Instance().ShowInfoMessageBox("Inhalte des Lesezeichens sind nicht korrekt. Bitte überprügen, oder erneut anlegen!",
                   "Falsche Daten!");
            }
        }
    }
}
