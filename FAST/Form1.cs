﻿using FAST.Buttons;
using FAST.Data;
using FAST.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAST
{
    public partial class Form1 : Form, IViewMainForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeWindow();

            FormClosing += (s, a) =>
            {
                if (ifNotCloseForm)
                {
                    a.Cancel = true;
                    WindowState = FormWindowState.Minimized;
                }
            };

            this.FormClosed += Form1_FormClosed; // Event to close TokenSource in Presenter. Anoder Task.
        }
                
        #region // Variables

        public event EventHandler CancelTokenSource;

        private bool ifNotCloseForm = true;
        private bool showTrayMessage = true;

        #endregion

        #region // Public methods

        public void SetMaxSizeOfWindow()
        {
            Invoke((Action)(() => { MaximizeWindow(); }));
        }

        #endregion

        #region // Private methods

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
                    NotifyIcon.ShowBalloonTip(100);
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
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CancelTokenSource != null) CancelTokenSource(this, EventArgs.Empty);
        }

    }
}
