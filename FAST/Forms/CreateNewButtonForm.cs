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
    public partial class CreateNewButtonForm : Form
    {
        public CreateNewButtonForm()
        {
            InitializeComponent();
        }

        private void CreateNewButtonForm_Load(object sender, EventArgs e)
        {
            
        }

        public event EventHandler CreateNewButtonFormOK;
        public event EventHandler CreateNewButtonFormCancel;

        #region // Public methods

        public BasicButton GetNewButton()
        {
            return new BasicButton();
        }

        #endregion

        #region // Button click

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (CreateNewButtonFormOK != null) CreateNewButtonFormOK(this, EventArgs.Empty);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (CreateNewButtonFormCancel != null) CreateNewButtonFormCancel(this, EventArgs.Empty);
        }

        #endregion

    }
}
