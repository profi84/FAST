using FAST.Buttons;
using FAST.Data;
using FAST.MessageBoxes;
using Microsoft.Win32;
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
                if(startWebsiteButton.GetIfNotDefaultBrowser)                
                    defaultBrowser = startWebsiteButton.GetPathOfBrowserIfNotDefault;                
                else
                    launchBrowser();

                StartProcess(startWebsiteButton);
            }
            else
            {
                MessageBoxCollection.Instance().ShowInfoMessageBox("Inhalte des Lesezeichens sind nicht korrekt. Bitte überprügen, oder erneut anlegen!",
                    "Falsche Daten!");
            }
        }

        string defaultBrowser = String.Empty;

        private void StartProcess(StartWebsiteButton startWebsiteButton)
        {
            try
            {
                Process.Start(defaultBrowser, startWebsiteButton.GetAddressOfWebsite);
            }
            catch
            {
                MessageBoxCollection.Instance().ShowInfoMessageBox("Inhalte des Lesezeichens sind nicht korrekt. Bitte überprügen, oder erneut anlegen!",
                   "Falsche Daten!");
            }
        }

        public void launchBrowser()
        {
            using (RegistryKey userChoiceKey = Registry.LocalMachine.OpenSubKey(@"Software\Clients\StartMenuInternet"))
            {
                var first = userChoiceKey?.GetSubKeyNames().FirstOrDefault();
                if (userChoiceKey == null || first == null) return;
                var reg = userChoiceKey.OpenSubKey(first + @"\shell\open\command");
                var prog = (string)reg?.GetValue(null);
                if (prog == null) return;

                defaultBrowser = prog;
            }
        }
    }
}
