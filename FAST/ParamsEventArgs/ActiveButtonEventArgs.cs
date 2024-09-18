using FAST.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.ParamsEventArgs
{
    public class ActiveButtonEventArgs : EventArgs
    {
        public ActiveButtonEventArgs(string nameOfButton)
        {
            ActiveButtonName = nameOfButton;
            IndexListOne = -1;
            IndexListTwo = -1;

            CheckButtonNameForIndex(nameOfButton);
        }

        public string ActiveButtonName { get; private set; }
        public int IndexListOne { get; private set; }
        public int IndexListTwo { get; private set; }


        #region // Private methods
        private void CheckButtonNameForIndex(string nameOfButton)
        {
            int tempValue = Dictionaries.ButtonsOfMainView["B__ BasicButton"].Length;
            string tempName = String.Empty;

            if (nameOfButton.Contains(Dictionaries.ButtonsOfMainView["B__ BasicButton"]))
            {
                tempName = nameOfButton.Substring(tempValue, nameOfButton.Length - tempValue);
                CreateIndexOfLists(tempName);
            }
        }

        private void CreateIndexOfLists(string tempName)
        {
            string indexListOne = String.Empty;
            string indexListTwo = String.Empty;

            int index = tempName.IndexOf("_");

            for (int i = 0; i < index; i++)
            {
                indexListOne += tempName[i];
            }

            for (int i = index + 1; i < tempName.Length; i++)
            {
                indexListTwo += tempName[i];
            }

            SaveIndexesAsVariable( indexListOne,  indexListTwo);
        }

        private void SaveIndexesAsVariable(string indexListOne, string indexListTwo)
        {
            IndexListOne = Int32.Parse(indexListOne);
            IndexListTwo = Int32.Parse(indexListTwo);
        }

        #endregion

    }
}
