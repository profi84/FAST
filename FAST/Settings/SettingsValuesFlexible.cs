using FAST.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.Settings
{
    public class SettingsValuesFlexible
    {
        #region Singleton pattern

        static SettingsValuesFlexible settingsValuesFlexible;

        // It will try to read a settings.json file.
        // If not exist than it will to use a default nested class und write the values to settings.json file
        protected SettingsValuesFlexible()
        {
            jsonSettingNested = new JsonSettingNested();

            try
            {
                ReadJson();
            }
            catch (Exception ex)
            {
                WriteJson();
            }            
        }

        public static SettingsValuesFlexible Instance()
        {
            if (settingsValuesFlexible == null)
                settingsValuesFlexible = new SettingsValuesFlexible();

            return settingsValuesFlexible;
        }

        #endregion

        #region // Variables
                
        private string pathSetting = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Settings.json";
        private JsonSettingNested jsonSettingNested;

        #endregion
                
        #region Public Values

        public int GetDistanceWidthValue
        {
            get { return jsonSettingNested.buttonDistanceWidthValue; }
            set { jsonSettingNested.buttonDistanceWidthValue = value; }
        }

        public int GetDiscanceHeightValue
        {
            get { return jsonSettingNested.buttonDiscanceHeightValue; }
            set { jsonSettingNested.buttonDiscanceHeightValue = value; }
        }

        public int GetButtonWidthValue
        {
            get { return jsonSettingNested.buttonWidthValue; }
            set { jsonSettingNested.buttonWidthValue = value; }
        }

        public int GetButtonHeightValue
        {
            get { return jsonSettingNested.buttonHeightValue; }
            set { jsonSettingNested.buttonHeightValue = value; }
        }

        public bool GetMinimizeFormAfterButtonClick
        {
            get { return jsonSettingNested.MinimizeFormAfterButtonClick; }
            set { jsonSettingNested.MinimizeFormAfterButtonClick = value; }
        }

        #endregion

        #region Input Output Settings as Json File

        private void ReadJson()
        {
            using (StreamReader file = File.OpenText(pathSetting))
            {
                JsonSerializer serializer = new JsonSerializer();
                jsonSettingNested = (JsonSettingNested)serializer.Deserialize(file, typeof(JsonSettingNested));
            }
        }

        public void WriteJson()
        {
            using (StreamWriter files = File.CreateText(pathSetting))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(files, jsonSettingNested);
            }
        }

        #endregion

        #region Nested class // Default settings value, if settings.json file not exist.

        class JsonSettingNested
        {
            public int buttonDistanceWidthValue = 10;
            public int buttonDiscanceHeightValue = 10;
            public int buttonWidthValue = 170;
            public int buttonHeightValue = 50;
            public bool MinimizeFormAfterButtonClick = true;
        }

        #endregion
    }
}
