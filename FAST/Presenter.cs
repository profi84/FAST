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

            mainView.CancelTokenSource += new EventHandler(CancelAnoderTaskTokenSource);
            mainView.CreateNewTab += new EventHandler(CreateNewTab_EventMainView);
            
            CheckKeyCombination();
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


        #region // Private methods



        #endregion

        #region // Async Task for checking of key state

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        static CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
        CancellationToken ct = cancelTokenSource.Token;

        private async void CheckKeyCombination()
        {
            await Task.Run(async () =>
            {
                int stateKeyControl;
                int stateKeyNumPad0;
                int stateKeyD0;

                Keys keyToCheckControl = Keys.ControlKey;
                Keys keyToCheckNum = Keys.NumPad0;
                Keys keyToCheckNumTop = Keys.D0;

                while (true)
                {
                    stateKeyControl = Convert.ToInt32(GetAsyncKeyState(keyToCheckControl));
                    stateKeyNumPad0 = Convert.ToInt32(GetAsyncKeyState(keyToCheckNum));
                    stateKeyD0 = Convert.ToInt32(GetAsyncKeyState(keyToCheckNumTop));

                    if (stateKeyControl == -32768 && stateKeyNumPad0 == -32767 || stateKeyControl == -32768 && stateKeyD0 == -32767)
                    {
                        mainView.Invoke((Action)(() => { mainView.SetMaxSizeOfWindow(); }));
                    }

                    if (ct.IsCancellationRequested)
                        break;

                    await Task.Delay(15);
                }
            }, ct);
        }

        private void CancelAnoderTaskTokenSource(object sender, EventArgs e)
        {
            cancelTokenSource.Cancel();
        }

        #endregion
    }
}
