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
using FAST.Settings;

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
        SettingsForm settingsForm;

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
                ImportTabsAndButtons();
            }
        }

        private void SubscribeEventsFromMainView()
        {            
            mainView.buttonClick += new EventHandler<ActiveButtonEventArgs>(BasicButtonsMainView_Click);
            mainView.CreateNewTab += new EventHandler(CreateNewTabMainView_Click);
            mainView.CreateNewButton += new EventHandler(CreateNewButtonMainView_Click);
            mainView.ShowTabControl += new EventHandler(ShowTabControlOnMainView_Event);
            mainView.ToolStripMenuSettings += new EventHandler(CreateNewFormSettings_Event);
        }

        private void CreateNewFormSettings_Event(object sender, EventArgs e)
        {
            settingsForm = new SettingsForm();
            settingsForm.ButtonOKSetting += new EventHandler(SettingsFormOK_Click);
            settingsForm.ButtonCancelSetting += new EventHandler(SettingsFormCancel_Click);
            settingsForm.ShowDialog();
            
        }

        private void SettingsFormCancel_Click(object sender, EventArgs e)
        {            
            settingsForm.Close();
        }

        private void SettingsFormOK_Click(object sender, EventArgs e)
        {
            ShowButtonsOnMainView();
            settingsForm.Close();
        }

        private void ShowTabControlOnMainView_Event(object sender, EventArgs e)
        {
            ShowButtonsOnMainView();
        }

        private void CreateNewButtonMainView_Click(object sender, EventArgs e)
        {
            CreateNewButtonForm();
        }

        private void CreateNewTabMainView_Click(object sender, EventArgs e)
        {
            CreateNewTab();
        }

        private void ImportTabsAndButtons()
        {
            listOfTabs.Clear();
            listOfButtons.Clear();

            try
            {
                listOfTabs = new ReadDB().GetListOfTabs();
                listOfButtons = new ReadDB().GetListOfButtons();
            }
            catch (Exception)
            {}
        }

        #endregion

        private void BasicButtonsMainView_Click(object sender, ActiveButtonEventArgs e)
        {
            CheckWhichButtonWasClickedMainView(e);
        }

        private void CheckWhichButtonWasClickedMainView(ActiveButtonEventArgs eventParam)
        {     
            if (eventParam.ActiveButtonName.Contains(Dictionaries.ButtonsOfMainView["B__ BasicButton"]) && eventParam.IndexListOne != -1)
            {
                new ExecutionOfButtons(listOfButtons[eventParam.IndexListOne][eventParam.IndexListTwo]);

                if(SettingsValuesFlexible.Instance().GetMinimizeFormAfterButtonClick == true)
                    mainView.MinimizeWindow();
            }                 
        }

        private void ShowButtonsOnMainView()
        {
            mainView.ShowButtonsOnView(listOfButtons, listOfTabs);
        }

        #region // Events formsNewTab
                
        private void CreateNewTab()
        {
            createNewTabForm = new CreateNewTabForm();
            createNewTabForm.CreateNewTabFormOK += new EventHandler<NewTabEventParam>(CreateNewTabForm_OK);
            createNewTabForm.CreateNewTabFormCancel += new EventHandler(CreateNewTabForm_Cancel);
            createNewTabForm.ShowDialog();
        }

        private void CreateNewTabForm_OK(object sender, NewTabEventParam paramEventNewTabName)
        {
            if (!listOfTabs.Contains(paramEventNewTabName.NewTabName))
            {
                listOfTabs.Add(paramEventNewTabName.NewTabName);
                listOfButtons.Add(new List<BasicButton>());

                WriteDB writeDB = new WriteDB();
                writeDB.SaveTabs(listOfTabs);
                writeDB.SaveButtons(listOfButtons);

                ShowButtonsOnMainView();

                createNewTabForm.Close();
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

        #endregion // Events formNewButton

        private void CreateNewButtonForm()
        {
            if (listOfTabs.Count > 0)
            {
                createNewButtonForm = new CreateNewButtonForm(listOfTabs);
                createNewButtonForm.CreateNewButtonFormOK += new EventHandler(CreateNewButtonForm_OK);
                createNewButtonForm.CreateNewButtonFormCancel += new EventHandler(CreateNewButtonForm_Cancel);
                createNewButtonForm.ShowDialog();
            }
            else
            {
                MessageBoxCollection.Instance().ShowInfoMessageBox("Reitern nicht vorhanden. Bitte mindestens einen anlegen!", "Reiter fehlen!");
            }
        }

        private void CreateNewButtonForm_OK(object sender, EventArgs e)
        {
            BasicButton basicButton = createNewButtonForm.GetNewButton();

            for (int i = 0;i < listOfTabs.Count; i++)
            {
                if(basicButton.GetTabName == listOfTabs[i])
                {
                    listOfButtons[i].Add(basicButton);
                    break;
                }
            }

            WriteDB writeDB = new WriteDB();
            writeDB.SaveButtons(listOfButtons);

            ShowButtonsOnMainView();

            createNewButtonForm.Close();
        }

        private void CreateNewButtonForm_Cancel(object sender, EventArgs e)
        {
            createNewButtonForm.Close();
        }


        #region

        #endregion

    }
}
