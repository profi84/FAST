using FAST.Buttons;
using FAST.DB_Connecting;
using FAST.Data;
using FAST.MessageBoxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FAST.Forms;

namespace FAST
{
    public class Presenter
    {
        public Presenter(Form1 mainView)
        {
            this.mainView = mainView;
                        
            mainView.CreateNewTab += new EventHandler(CreateNewTab_EventMainView);
            mainView.buttonClick += new EventHandler<ActiveButtonEventArgs>(BasicButtonsMainView_Click);
        }

        #region // Variables        
        private Form1 mainView;
        CreateNewTabForm createNewTabForm;

        private List<string> listOfTabs = new List<string>();
        private List<List<BasicButton>> listOfButtons = new List<List<BasicButton>>();

        #endregion

        #region // Events formsNewTab

        private void CreateNewTab_EventMainView(object sender, EventArgs e)
        {
            CreateNewTab();
        }
        private void CreateNewTab()
        {
            createNewTabForm = new CreateNewTabForm();
            createNewTabForm.CreateNewTabFormOK += new EventHandler(CreateNewTabForm_OK);
            createNewTabForm.CreateNewTabFormCancel += new EventHandler(CreateNewTabForm_Cancel);
            createNewTabForm.ShowDialog();
        }

        private void BasicButtonsMainView_Click(object sender, ActiveButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CreateNewTabForm_OK(object sender, EventArgs e)
        {
            string valueTab = createNewTabForm.GetTabName();

            if (!listOfTabs.Contains(valueTab))
            {
                listOfTabs.Add(valueTab);
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

        #endregion
                
    }
}
