using FAST.Buttons;
using FAST.Data;
using FAST.Forms;
using FAST.MessageBoxes;
using FAST.ParamsEventArgs;
using FAST.Settings;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            FormClosing += (s, a) =>
            {
                if (ifNotCloseForm)
                {
                    a.Cancel = true;
                    WindowState = FormWindowState.Minimized;
                }
            };
            
            this.FormClosed += (s, a) => cancelTokenSource.Cancel();

            ButtonCreateNewTab.Click += new EventHandler(ButtonCreateNewTab_Click);
            ButtonCreateNewButton.Click += new EventHandler(ButtonCreateNewButton_Click);

            SetMaxSizeOfWindow();
            CheckKeyCombination();
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
        }

        #region // Variables

        public event EventHandler<ActiveButtonEventArgs> buttonClick;
        public event EventHandler CreateNewTab;
        public event EventHandler CreateNewButton;
        public event EventHandler ShowTabControl;
        public event EventHandler ToolStripMenuSettings;
        private bool ifNotCloseForm = true;
        private bool showTrayMessage = true;
        TabControl tabControl = new TabControl();
        List<TabPage> tabPages = new List<TabPage>();

        private int sizeTabContorlWidth;
        private int sizeTabContorlHeight;
        private int aktualyValueWidth = 0;        
        private int linesOfButton = 0;

        #endregion

        #region // Public methods

        public void ShowButtonsOnView(List<List<BasicButton>> listOfButtons, List<string>listOfTabs)
        {
            CreateTabControl();
            RemoveButtonsFromView();

            for (int i = 0; i < listOfButtons.Count; i++)
            {
                aktualyValueWidth = 0;
                linesOfButton = 0;

                tabControl.Controls.Add(CreateTabPage(i, listOfButtons[i], listOfTabs[i]));
            }
        }

        public void MinimizeWindow()
        {
            WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        #endregion

        #region // Private methods

        private void RemoveButtonsFromView()
        {
            foreach (TabPage page in tabPages)
            {
                page.Dispose();
            }
        }

        private void SetMaxSizeOfWindow()
        {
            MaximizeWindow();
        }

        private void MaximizeWindow()
        {
            this.Show();
            WindowState = FormWindowState.Maximized;
            ShowTabControl_View(this, new EventArgs());
        }

        private void ColorActiveTabPage(object sender, DrawItemEventArgs a)
        {
            Font fntTab;
            Brush bshBack;
            Brush bshFore;
            if (a.Index == this.tabControl.SelectedIndex)
            {
                fntTab = new Font(a.Font, FontStyle.Bold);
                bshBack = new System.Drawing.Drawing2D.LinearGradientBrush(a.Bounds, Color.LightSkyBlue, Color.LightGreen, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal);
                bshFore = Brushes.Blue;
            }
            else
            {
                fntTab = a.Font;
                bshBack = new SolidBrush(Color.White);
                bshFore = new SolidBrush(Color.Black);
            }
            string tabName = this.tabControl.TabPages[a.Index].Text;
            StringFormat sftTab = new StringFormat(StringFormatFlags.NoClip);
            sftTab.Alignment = StringAlignment.Center;
            sftTab.LineAlignment = StringAlignment.Center;
            a.Graphics.FillRectangle(bshBack, a.Bounds);
            Rectangle recTab = a.Bounds;
            recTab = new Rectangle(recTab.X, recTab.Y + 4, recTab.Width, recTab.Height - 4);
            a.Graphics.DrawString(tabName, fntTab, bshFore, recTab, sftTab);
        }

        private void CreateTabControl()
        {
            int width = this.Size.Width - 40;
            int height;

            if (WindowState == FormWindowState.Maximized)
                height = this.Size.Height - 220;
            else
                height = this.Size.Height - 175;

            tabControl.Location = new System.Drawing.Point(10, 120);
            tabControl.Size = new System.Drawing.Size(width, height);
            tabControl.Font = new Font("Arial", 14, FontStyle.Bold);
            tabControl.Multiline = true;
            this.Controls.Add(tabControl);

            tabControl.DrawItem += (s, a) =>
            {
                ColorActiveTabPage(s, a);
            };

            sizeTabContorlWidth = tabControl.Size.Width;
            sizeTabContorlHeight = tabControl.Size.Height;
        }

        private TabPage CreateTabPage(int index, List<BasicButton> listOfButtons, string nameOfTab)
        {
            TabPage newTabPage = new TabPage();
            newTabPage.Location = new System.Drawing.Point(0, 0);
            newTabPage.Text = nameOfTab;
            newTabPage.UseVisualStyleBackColor = true;            
            newTabPage.Padding = new System.Windows.Forms.Padding(3);
            newTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            newTabPage.AutoScroll = true;

            for (int i = 0; i < listOfButtons.Count; i++)
            {              
                newTabPage.Controls.Add(CreateButton(index, i, listOfButtons[i]));                
            }

            tabPages.Add(newTabPage);

            return newTabPage;
        }

        // All buttons of tabcontrol have specific format "B__"index List level 1"_"index List level 2"
        private Button CreateButton(int index1, int index2, BasicButton button )
        {
            Button newButton = new Button();
            newButton.Location = new System.Drawing.Point(GetButtonLocationWidth(index2), GetButtonLocationHeigth());
            newButton.Size = new System.Drawing.Size(SettingsValuesFlexible.Instance().GetButtonWidthValue, SettingsValuesFlexible.Instance().GetButtonHeightValue); 
            newButton.Name = Dictionaries.ButtonsOfMainView["B__ BasicButton"] + index1.ToString() + "_"+ index2.ToString();
            newButton.Text = button.GetTitle;
            newButton.Margin = new System.Windows.Forms.Padding(3);
            newButton.TextAlign = ContentAlignment.MiddleCenter;
            newButton.Font = new Font("Arial", 12, FontStyle.Bold);
            newButton.UseVisualStyleBackColor = true;            

            newButton.Click += (s, a) =>
            {
                if (buttonClick != null)
                {
                    buttonClick(this, new ActiveButtonEventArgs(newButton.Name));
                }
            };

            return newButton;
        }

        private int GetButtonLocationWidth(int indexOfButton)
        {
            int constWidth = SettingsValuesFlexible.Instance().GetButtonWidthValue;
            int constDistance = SettingsValuesFlexible.Instance().GetDistanceWidthValue;
            int constStep = 1;

            if (indexOfButton == 0)
            {
                constStep = 0;
            }

            aktualyValueWidth += (constWidth * constStep) + (constDistance);

            if((sizeTabContorlWidth - constDistance) < (aktualyValueWidth + constWidth))
            {
                aktualyValueWidth = constDistance;
                linesOfButton += 1;
            }

            return aktualyValueWidth;
        }

        private int GetButtonLocationHeigth()
        {
            return (SettingsValuesFlexible.Instance().GetButtonHeightValue * linesOfButton) + (SettingsValuesFlexible.Instance().GetDiscanceHeightValue * (linesOfButton + 1));
        }

        #endregion

        #region // Resize form event and tray events

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();

                if (showTrayMessage)
                {
                    NotifyIcon.BalloonTipTitle = "Fast All Start Tool";
                    NotifyIcon.BalloonTipText = "Wurde minimiert, läuft im Hintergrund! Beenden über Kontextmenü! Maximieren über STRG + 0";
                    NotifyIcon.Text = "FAST";
                    NotifyIcon.ShowBalloonTip(50);
                    showTrayMessage = false;
                }
            }
            else
            {
                ShowTabControl_View(this, new EventArgs());
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

        #region // Events form

        private void ShowTabControl_View(object sender, EventArgs e)
        {
            if (ShowTabControl != null) ShowTabControl(this, EventArgs.Empty);
        }

        private void ButtonCreateNewTab_Click(object sender, EventArgs e)
        {
            if (CreateNewTab != null) CreateNewTab(this, EventArgs.Empty);
        }

        private void ButtonCreateNewButton_Click(object sender, EventArgs e)
        {
            if (CreateNewButton != null) CreateNewButton(this, EventArgs.Empty);
        }

        #endregion

        private void beendenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ifNotCloseForm = false;
            this.Close();
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (ToolStripMenuSettings != null) ToolStripMenuSettings(this, EventArgs.Empty);
        }
    }
}
