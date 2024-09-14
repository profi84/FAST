using FAST.Data;
using FAST.Buttons;
using FAST.MessageBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAST.Forms
{
    public partial class CreateNewTabForm : Form, IViewCreateNewTabForm
    {
        public CreateNewTabForm()
        {
            InitializeComponent();
        }

        private void CreateNewTabForm_Load(object sender, EventArgs e)
        {
            ButtonOK.Click += new EventHandler(ButtonOK_Click);
            ButtonCancel.Click += new EventHandler(ButtonCancel_Click);
        }

        public event EventHandler CreateNewTabFormOK;
        public event EventHandler CreateNewTabFormCancel;

        #region // Public methods

        public void ClearTextBox()
        {
            TextBoxTabName.Clear();
        }

        public string GetTabName()
        {
            return TextBoxTabName.Text.Trim();
        }

        #endregion

        #region // Buttons click

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if(TextBoxTabName.Text != String.Empty)
                if (CreateNewTabFormOK != null) CreateNewTabFormOK(this, EventArgs.Empty);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (CreateNewTabFormCancel != null) CreateNewTabFormCancel(this, EventArgs.Empty);
        }

        #endregion

    }
}
