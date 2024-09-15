using FAST.Buttons;
using FAST.Settings;
using Newtonsoft;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.DB_Connecting
{
    public class WriteDB
    {
        public void SaveTabs(List<string> listOfTabs)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(SettingsValuesPermanent.Instance().GetTabSaveFile))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, listOfTabs);
            }
        }

        public void SaveButtons(List<List<BasicButton>> listOfButtons)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(SettingsValuesPermanent.Instance().GetButtonsSaveFile))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, listOfButtons);
            }
        }
    }
}
