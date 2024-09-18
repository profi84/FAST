using FAST.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.Settings
{
    public class SettingsValuesPermanent
    {
        #region Singleton Pattern mit Protected Constructor der Klasse Setting

        static SettingsValuesPermanent settingsPermanent;
        
        protected SettingsValuesPermanent()
        {
            GetExecutingLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\";
            GetDataFolderLocation = GetExecutingLocation + "Data\\";
            GetSettingsFile = GetExecutingLocation + "Settings.json";
            GetTabSaveFile = GetExecutingLocation + GetDataFolderLocation + "ListOfTabs.json";
            GetButtonsSaveFile = GetExecutingLocation + GetDataFolderLocation + "ListOfButtons.json";
        }

        public static SettingsValuesPermanent Instance()
        {
            if (settingsPermanent == null)
                settingsPermanent = new SettingsValuesPermanent();

            return settingsPermanent;
        }

        #endregion

        #region // Settings value

        public string GetExecutingLocation { get; }
        public string GetDataFolderLocation { get; }
        public string GetSettingsFile { get; }
        public string GetTabSaveFile { get; }
        public string GetButtonsSaveFile { get; }

        #endregion

        // All important params from Settings value region. Always to enter, if new param of settings is created
        public List<string> GetAllImportantSettingsFiles()
        {
            List<string> AllSettings = new List<string>();
                        
            AllSettings.Add(GetSettingsFile);

            return AllSettings;
        }

        // All buttons from Main Form. Always to enter, if new button is created
        public List<string> GetAllNamesOfButtonsFromMainView()
        {
            List<string> allButtonsOfMainView = new List<string>
            {
                "ButtonCreateNewTab",
                "ButtonCreateNewButton",
                "ButtonRemoveTab",
                "ButtonRemoveButton",
                "ButtonSortTabs",
                "ButtonSortButtons"
            };

            return allButtonsOfMainView;
        }
    }
}
