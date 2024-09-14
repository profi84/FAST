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

namespace FAST
{
    public class Presenter
    {
        public Presenter(IViewMainForm mainView)
        {
            this.mainView = mainView;
            mainView.CancelTokenSource += new EventHandler(CancelAnoderTaskTokenSource);
            CheckKeyCombination();
        }

        private IViewMainForm mainView;

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
                        mainView.SetMaxSizeOfWindow();
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
