using FAST.Buttons;
using FAST.Data;
using FAST.Forms;
using FAST.MessageBoxes;
using FAST.ParamsEventArgs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeWindow();

            foreach (Button button in Controls.OfType<Button>())
            {
                button.Click += (s, a) =>
                {
                    if (buttonClick != null) buttonClick(this, new ActiveButtonEventArgs(button.Name));
                };
            }

            FormClosing += (s, a) =>
            {
                if (ifNotCloseForm)
                {
                    a.Cancel = true;
                    WindowState = FormWindowState.Minimized;
                }
            };

            this.FormClosed += Form1_FormClosed; // Event to close TokenSource in Presenter. Anoder Task.
            this.FormClosed += (s, a) => cancelTokenSource.Cancel();

            CheckKeyCombination();
        }
                
        #region // Variables

        public event EventHandler<ActiveButtonEventArgs> buttonClick;
        public event EventHandler CancelTokenSource;
        public event EventHandler CreateNewTab;

        private bool ifNotCloseForm = true;
        private bool showTrayMessage = true;

        #endregion

        #region // Public methods
                

        #endregion

        #region // Private methods

        private void SetMaxSizeOfWindow()
        {
            MaximizeWindow();
        }

        private void MaximizeWindow()
        {
            WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region // Resize form event and tray events

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                if (showTrayMessage)
                {
                    NotifyIcon.BalloonTipTitle = "Fast All Start Tool";
                    NotifyIcon.BalloonTipText = "Wurde minimiert, läuft im Hintergrund! Beenden über Kontextmenü! Maximieren über STRG + 0";
                    NotifyIcon.Text = "FAST";
                    NotifyIcon.ShowBalloonTip(50);
                    showTrayMessage = false;
                }
            }            
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ifNotCloseForm = false;
            if (CancelTokenSource != null) CancelTokenSource(this, EventArgs.Empty);
            this.Close();
        }
        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MaximizeWindow();
        }

        #endregion

        #region // Form events

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CancelTokenSource != null) CancelTokenSource(this, EventArgs.Empty);
        }

        private void ButtonCreateNewTab_Click(object sender, EventArgs e)
        {
            if (CreateNewTab != null) CreateNewTab(this, EventArgs.Empty);
        }

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
                        Invoke((Action)(() => { SetMaxSizeOfWindow(); }));
                    }

                    if (ct.IsCancellationRequested)
                        break;

                    await Task.Delay(15);
                }
            }, ct);
        }

        #endregion
    }
}
