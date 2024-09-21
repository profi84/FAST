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
using System.Reflection.Emit;
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
            CreateTabControl();
            foreach (Button button in Controls.OfType<Button>())
            {
                button.Click += (s, a) =>
                {
                    if (buttonClick != null)
                    {
                        buttonClick(this, new ActiveButtonEventArgs(button.Name));
                    }
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
            
            this.FormClosed += (s, a) => cancelTokenSource.Cancel();

            CheckKeyCombination();
        }
                
        #region // Variables

        public event EventHandler<ActiveButtonEventArgs> buttonClick;
        private bool ifNotCloseForm = true;
        private bool showTrayMessage = true;
        TabControl tabControl = new TabControl();
        List<TabPage> tabPages = new List<TabPage>();
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
        private void CreateTabControl()
        {
            int width = this.Size.Width - 40;
            int height = this.Size.Height - 200;
            
            tabControl.Location = new System.Drawing.Point(10, 100);
            //tabControl.Name = "tabControl1";
            tabControl.SelectedIndex = 0; //Eventuell Einstellungen speichern
            tabControl.Size = new System.Drawing.Size(width, height);
            //tabControl.TabIndex = 1;            
            tabControl.Font = new Font("Arial", 12, FontStyle.Bold);            
            tabControl.Controls.Add(CreateTabPage("Web"));
            tabControl.Controls.Add(CreateTabPage("Reiter"));
            this.Controls.Add(tabControl);

            var x = tabControl.Size;
        }

        private TabPage CreateTabPage(string text)
        {
            TabPage newTabPage = new TabPage();
            newTabPage.Location = new System.Drawing.Point(0, 0);
            //newTabPage.Name = name;
            //newTabPage.Padding = new System.Windows.Forms.Padding(0);            
            //newTabPage.Size = new System.Drawing.Size(100, 30);
            newTabPage.TabIndex = 0;
            newTabPage.Text = text;
            newTabPage.UseVisualStyleBackColor = true;
            newTabPage.Controls.Add(CreateButton());

            tabPages.Add(newTabPage);

            return newTabPage;
        }

        private Button CreateButton()
        {
            Button newButton = new Button();
            newButton.Location = new System.Drawing.Point(5, 5);
            newButton.Size = new System.Drawing.Size(105, 35);
            //newButton.TabIndex = 2;
            //newButton.Name = "button3";
            newButton.Text = "text";
            newButton.UseVisualStyleBackColor = true;
            //button.Click += new System.EventHandler(this.button2_Click);

            return newButton;
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
            this.Close();
        }
        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MaximizeWindow();
        }

        #endregion

        #region // Form events


        #endregion

        #region // Async Task for checking of key state // CheckKeyCombination()

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
