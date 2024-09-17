using FAST.Settings;
using FAST.MessageBoxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FAST.Models
{
    public class AvailabilityOfFolderStructure
    {
        public AvailabilityOfFolderStructure()
        {
            CreateDataFolderIfNotExist();
        }  

        public bool CheckAllSettingsFiles()
        {
            List<string> values = SettingsValuesPermanent.Instance().AllImportantSettingsFiles();
            bool isAllSettingsToGet = true;

            foreach (string path in values)
            {
                if (!File.Exists(path))
                {
                    isAllSettingsToGet = false;
                    MessageBoxCollection.Instance().ShowInfoMessageBox("Datei " + path + " existiert nicht!", "Fehlende Konfiguration!");
                }
            }

            return isAllSettingsToGet;
        }

        private void CreateDataFolderIfNotExist()
        {            
            if (!(Directory.Exists(SettingsValuesPermanent.Instance().GetDataFolderLocation)))
                Directory.CreateDirectory(SettingsValuesPermanent.Instance().GetDataFolderLocation);
        }
    }
}
