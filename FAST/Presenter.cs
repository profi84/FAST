using FAST.Buttons;
using FAST.DB_Connecting;
using FAST.Data;
using FAST.MessageBoxes;
using FAST.ParamsEventArgs;
using FAST.Forms;
using FAST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FAST
{
    public class Presenter
    {
        public Presenter(Form1 mainView)
        {
            this.mainView = mainView;

            CheckConfigFiles();
        }

        #region // Variables    

        private Form1 mainView;
        CreateNewTabForm createNewTabForm;
        CreateNewButtonForm createNewButtonForm;

        private List<string> listOfTabs = new List<string>();
        private List<List<BasicButton>> listOfButtons = new List<List<BasicButton>>();

        #endregion

        #region // Private mothods

        private void CheckConfigFiles()
        {
            AvailabilityOfFolderStructure availabilityOfFolderStructure = new AvailabilityOfFolderStructure();

            if (!availabilityOfFolderStructure.CheckAllSettingsFiles())
            {
                MessageBoxCollection.Instance().ShowInfoMessageBox("Dem Programm fehlen wichtige Einstellungsdateien, kann sich fehlerhaft verhalten!" +
                    " Bitte das Programm schließe und Konfigdateien einfügen! ",
                    "Kofig Datei fehlt!");
            }
            else
            {
                SubscribeEventsFromMainView();
            }
        }

        private void SubscribeEventsFromMainView()
        {            
            mainView.buttonClick += new EventHandler<ActiveButtonEventArgs>(BasicButtonsMainView_Click);
        }
        #endregion

        private void CheckWhichButtonWasClickedMainView(ActiveButtonEventArgs eventParam)
        {     
            if (eventParam.ActiveButtonName.Contains(Dictionaries.ButtonsOfMainView["B__ BasicButton"]) && eventParam.IndexListOne != -1)
            {

            }
            else if (eventParam.ActiveButtonName == Dictionaries.ButtonsOfMainView["ButtonCreateNewTab"])
            {
                CreateNewTab();
            }
            else if (eventParam.ActiveButtonName == Dictionaries.ButtonsOfMainView["ButtonCreateNewButton"])
            {

            }
            else if (eventParam.ActiveButtonName == Dictionaries.ButtonsOfMainView["ButtonRemoveTab"])
            {

            }
            else if (eventParam.ActiveButtonName == Dictionaries.ButtonsOfMainView["ButtonRemoveButton"])
            {

            }
            else if (eventParam.ActiveButtonName == Dictionaries.ButtonsOfMainView["ButtonSortTabs"])
            {

            }
            else if (eventParam.ActiveButtonName == Dictionaries.ButtonsOfMainView["ButtonSortButtons"])
            {

            }            
        }

        private void BasicButtonsMainView_Click(object sender, ActiveButtonEventArgs e)
        {
            CheckWhichButtonWasClickedMainView(e);            
        }

        #region // Events formsNewTab
                
        private void CreateNewTab()
        {
            createNewTabForm = new CreateNewTabForm();
            createNewTabForm.CreateNewTabFormOK += new EventHandler(CreateNewTabForm_OK);
            createNewTabForm.CreateNewTabFormCancel += new EventHandler(CreateNewTabForm_Cancel);
            createNewTabForm.ShowDialog();
        }

        private void CreateNewTabForm_OK(object sender, EventArgs e)
        {
            string valueTab = createNewTabForm.GetTabName();

            if (!listOfTabs.Contains(valueTab))
            {
                listOfTabs.Add(valueTab);
                createNewTabForm.Close();
                new WriteDB().SaveTabs(listOfTabs);
            }
            else
            {
                createNewTabForm.ClearTextBox();
                MessageBoxCollection.Instance().ShowInfoMessageBox("Gewünschte Name existiert schon!!! Bitte neu eingeben.", "Doppelte Name vom Reiter!");
            }
        }

        private void CreateNewTabForm_Cancel(object sender, EventArgs e)
        {
            createNewTabForm.Close();
        }

        #endregion
                
    }
}
