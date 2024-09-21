using FAST.Buttons;
using FAST.Settings;
using FAST.Data;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.DB_Connecting
{
    public class ReadDB
    {
        public List<string> GetListOfTabs()
        {
             List<string> listOfTabs = new List<string>();

            using (StreamReader file = File.OpenText(SettingsValuesPermanent.Instance().GetTabSaveFile))
            {
                JsonSerializer serializer = new JsonSerializer();
                listOfTabs = (List<string>)serializer.Deserialize(file, typeof(List<string>));
            }

            return listOfTabs;
        }

        public List<List<BasicButton>> GetListOfButtons()
        {
            List<List<BasicButton>> listOfButtons = new List<List<BasicButton>>();

            using (StreamReader reader = File.OpenText(SettingsValuesPermanent.Instance().GetButtonsSaveFile))
            {
                string jsonText = reader.ReadToEnd();
                JArray jsonTextParsed = JArray.Parse(jsonText);

                foreach (var listBasicButtons in jsonTextParsed)
                {
                    List<BasicButton> listOfButtonsOneTab = new List<BasicButton>();

                    foreach (var basicBattonObject in listBasicButtons)
                    {
                        listOfButtonsOneTab.Add(DeserializeObjectFromJsonBasicButton(basicBattonObject));
                    }

                    listOfButtons.Add(listOfButtonsOneTab);
                }
            }

            return listOfButtons;
        }

        private BasicButton DeserializeObjectFromJsonBasicButton(JToken basicBattonObject)
        {
            BasicButton basicButton = null;

            for (int i = 0; i < Dictionaries.KindOfButtonsMain.Count; i++)
            {
                if (basicBattonObject.ToString().Contains(Dictionaries.KindOfButtonsMain[i]))
                {
                    basicButton = GetImportedObject(basicBattonObject, Dictionaries.KindOfButtonsMain[i]);
                    break;
                }
            }

            return basicButton;
        }

        // You have always to enter new if quastions, if you enter new kind of button to your program.
        private BasicButton GetImportedObject(JToken basicBattonObject, string kindOfButton)
        {
            BasicButton basicButton = new BasicButton();

            if (kindOfButton == Dictionaries.KindOfButtonsMain[0])
            {
                basicButton = JsonConvert.DeserializeObject<StartExplorerButton>(basicBattonObject.ToString());
            }
            else if (kindOfButton == Dictionaries.KindOfButtonsMain[1])
            {
                basicButton = JsonConvert.DeserializeObject<StartFileWithProgramButton>(basicBattonObject.ToString());
            }
            else if (kindOfButton == Dictionaries.KindOfButtonsMain[2])
            {
                basicButton = JsonConvert.DeserializeObject<StartWebsiteButton>(basicBattonObject.ToString());
            }            

            return basicButton;
        }

    }
}
