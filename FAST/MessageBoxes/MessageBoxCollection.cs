using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAST.MessageBoxes
{
    public class MessageBoxCollection
    {
        #region Creation SingleTon Pattern

        static MessageBoxCollection messageBoxList;

        protected MessageBoxCollection()
        { }

        public static MessageBoxCollection Instance()
        {
            if (messageBoxList == null)
                messageBoxList = new MessageBoxCollection();

            return messageBoxList;
        }

        #endregion

        #region Public methods

        public void ShowInfoMessageBox(string text, string title, bool ifInforationIcon = true)
        {
            if (ifInforationIcon)
                MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(text, title);
        }

        public bool ShowQuestionMessageBox(string text, string title)
        {
            bool flag = false;

            DialogResult result = MessageBox.Show(text, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.OK)
                flag = true;

            return flag;
        }

        #endregion
    }
}
