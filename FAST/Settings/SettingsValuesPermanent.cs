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
            GetTabSaveFile = GetExecutingLocation + GetDataFolderLocation + "ListOfTabs.json";
            GetButtonsSaveFile = GetExecutingLocation + GetDataFolderLocation + "ListOfButtons.json"; ;
        }

        public static SettingsValuesPermanent Instance()
        {
            if (settingsPermanent == null)
                settingsPermanent = new SettingsValuesPermanent();

            return settingsPermanent;
        }

        #endregion

        #region // Settings values

        public string GetExecutingLocation { get; }
        public string GetDataFolderLocation { get; }
        public string GetTabSaveFile { get; }
        public string GetButtonsSaveFile { get; }

        #endregion

    }
}
