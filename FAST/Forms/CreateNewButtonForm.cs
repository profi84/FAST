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
using FAST.Properties;
using System.Web;

namespace FAST.Forms
{
    public partial class CreateNewButtonForm : Form
    {
        public CreateNewButtonForm(List<string> listOfTabs)
        {
            InitializeComponent();
            ShowComboBoxTabs(listOfTabs);
            ShowComboBoxKindOfButton();
            this.listOfTabs = listOfTabs;
        }

        private void CreateNewButtonForm_Load(object sender, EventArgs e)
        {
            
        }

        List<string> listOfTabs = new List<string>();   
        public event EventHandler CreateNewButtonFormOK;
        public event EventHandler CreateNewButtonFormCancel;

        #region // Public methods

        public BasicButton GetNewButton()
        {            

            if (ComboBoxKindOfButton.Text == Dictionaries.KindOfButtonsNamesEnGe["StartExplorerButton"])
            {
                return new StartExplorerButton()
                {
                    GetTitle = TextBoxTitle.Text.Trim(),
                    GetDescription = TextBoxDescription.Text.Trim(),
                    GetTabName = ComboBoxTabs.Text.Trim(),
                    GetButtonType = Dictionaries.KindOfButtonsNamemTranslated[ComboBoxKindOfButton.Text.Trim()],
                    GetPathFolder = TextBoxPathExplorer.Text.Trim(),
                };
            }
            else if (ComboBoxKindOfButton.Text == Dictionaries.KindOfButtonsNamesEnGe["StartFileWithProgramButton"])
            {
                return new StartFileWithProgramButton()
                {
                    GetTitle = TextBoxTitle.Text.Trim(),
                    GetDescription = TextBoxDescription.Text.Trim(),
                    GetTabName = ComboBoxTabs.Text.Trim(),
                    GetButtonType = Dictionaries.KindOfButtonsNamemTranslated[ComboBoxKindOfButton.Text.Trim()],
                    GetPathOfFile = TextBoxPathFile.Text.Trim()
                };
            }
            else if (ComboBoxKindOfButton.Text == Dictionaries.KindOfButtonsNamesEnGe["StartWebsiteButton"])
            {
                return new StartWebsiteButton()
                {
                    GetTitle = TextBoxTitle.Text.Trim(),
                    GetDescription = TextBoxDescription.Text.Trim(),
                    GetTabName = ComboBoxTabs.Text.Trim(),
                    GetButtonType = Dictionaries.KindOfButtonsNamemTranslated[ComboBoxKindOfButton.Text.Trim()],
                    GetAddressOfWebsite = TextBoxAddressOfWebsite.Text.Trim(),
                };
            }
            else
            {
                return new BasicButton();
            }
        }

        #endregion

        private void ShowComboBoxTabs(List<string> listOfTabs)
        {
            ComboBoxTabs.Items.Clear();

            foreach (string item in listOfTabs)
                ComboBoxTabs.Items.Add(item);
        }

        private void ShowComboBoxKindOfButton()
        {
            ComboBoxKindOfButton.Items.Clear();

            for (int i = 0; i < Dictionaries.KindOfButtonsNamesGerman.Count; i++)
            {
                ComboBoxKindOfButton.Items.Add(Dictionaries.KindOfButtonsNamesGerman[i]);
            }

            ComboBoxKindOfButton.SelectedIndexChanged += new EventHandler(ComboBoxKindOfButton_Click);
        }

        #region // Form events

        private void ComboBoxKindOfButton_Click(object sender, EventArgs e)
        {
            if(ComboBoxKindOfButton.Text == Dictionaries.KindOfButtonsNamesGerman[0])
            {                
                RemoveAllButtonsView();
                CreateExplorerButtonView();
            }
            else if (ComboBoxKindOfButton.Text == Dictionaries.KindOfButtonsNamesGerman[1])
            {
                RemoveAllButtonsView();
                CreateProgramButtonView();
            }
            else if (ComboBoxKindOfButton.Text == Dictionaries.KindOfButtonsNamesGerman[2])
            {
                RemoveAllButtonsView();
                CreateWebsiteButtonView();
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if(TextBoxTitle.Text != String.Empty && CheckValueOfTabComboBox() && CheckValueOfButtonComboBox())
                if (CreateNewButtonFormOK != null) CreateNewButtonFormOK(this, EventArgs.Empty);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (CreateNewButtonFormCancel != null) CreateNewButtonFormCancel(this, EventArgs.Empty);
        }

        #endregion

        #region // Private methods

        private bool CheckValueOfTabComboBox()
        {
            bool returnValue = false;
            string tempValue = ComboBoxTabs.Text.Trim();

            foreach (string item in listOfTabs)
            {
                if (tempValue == item)
                {
                    returnValue = true;
                    break;
                }
            }

            return returnValue;
        }

        private bool CheckValueOfButtonComboBox()
        {
            bool returnValue = false;
            string tempValue = ComboBoxKindOfButton.Text.Trim();

            for (int i = 0; i < Dictionaries.KindOfButtonsNamesGerman.Count; i++)
            {
                if (tempValue == Dictionaries.KindOfButtonsNamesGerman[i])
                {
                    returnValue = true;
                    break;
                }
            }

            return returnValue;
        }

        #endregion

        #region // Creation of view elements in dependency of kind of buttons

        #region // All elements of flesible buttons

        #region // Form elements of explorer button

        Label labelPathExplorer = new Label();
        TextBox TextBoxPathExplorer = new TextBox();

        #endregion

        #region // Form elements of programm button

        Label labelPathFile = new Label();
        TextBox TextBoxPathFile = new TextBox();

        #endregion

        #region // Form elements of website button

        Label labelAddressOfWebsite = new Label();
        TextBox TextBoxAddressOfWebsite = new TextBox();

        #endregion

        #endregion

        private void CreateExplorerButtonView()
        {            
            labelPathExplorer = new System.Windows.Forms.Label();
            labelPathExplorer.AutoSize = true;
            labelPathExplorer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPathExplorer.Location = new System.Drawing.Point(30, 180);
            labelPathExplorer.Name = "labelPathExplorer";
            labelPathExplorer.Text = "Bitte den Ordnerpfad eingeben.";
            Controls.Add(labelPathExplorer);
                        
            TextBoxPathExplorer = new System.Windows.Forms.TextBox();
            TextBoxPathExplorer.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBoxPathExplorer.Location = new System.Drawing.Point(30, 205);
            TextBoxPathExplorer.Name = "TextBoxPathExplorer";
            TextBoxPathExplorer.Size = new System.Drawing.Size(645, 29);
            this.Controls.Add(TextBoxPathExplorer);
        }

        private void CreateProgramButtonView()
        {
            labelPathFile = new System.Windows.Forms.Label();
            labelPathFile.AutoSize = true;
            labelPathFile.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPathFile.Location = new System.Drawing.Point(30, 180);
            labelPathFile.Name = "labelPathFile";
            labelPathFile.Text = "Bitte den Dateipfad eingeben.";
            Controls.Add(labelPathFile);

            TextBoxPathFile = new System.Windows.Forms.TextBox();
            TextBoxPathFile.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBoxPathFile.Location = new System.Drawing.Point(30, 205);
            TextBoxPathFile.Name = "TextBoxPathFile";
            TextBoxPathFile.Size = new System.Drawing.Size(645, 29);
            this.Controls.Add(TextBoxPathFile);
        }

        private void CreateWebsiteButtonView()
        {
            labelAddressOfWebsite = new System.Windows.Forms.Label();
            labelAddressOfWebsite.AutoSize = true;
            labelAddressOfWebsite.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAddressOfWebsite.Location = new System.Drawing.Point(30, 180);
            labelAddressOfWebsite.Name = "labelAddressOfWebsite";
            labelAddressOfWebsite.Text = "Bitte Internetseite eingeben.";
            Controls.Add(labelAddressOfWebsite);

            TextBoxAddressOfWebsite = new System.Windows.Forms.TextBox();
            TextBoxAddressOfWebsite.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBoxAddressOfWebsite.Location = new System.Drawing.Point(30, 205);
            TextBoxAddressOfWebsite.Name = "TextBoxAddressOfWebsite";
            TextBoxAddressOfWebsite.Size = new System.Drawing.Size(645, 29);
            this.Controls.Add(TextBoxAddressOfWebsite);
        }

        private void RemoveAllButtonsView()
        {
            RemoveExplorerButtonView();
            RemoveProgramButtonView();
            RemoveWebsiteButtonView();
        }

        private void RemoveExplorerButtonView()
        {
            this.Controls.Remove(labelPathExplorer);
            this.Controls.Remove(TextBoxPathExplorer);
        }

        private void RemoveProgramButtonView()
        {
            this.Controls.Remove(labelPathFile);
            this.Controls.Remove(TextBoxPathFile);
        }

        private void RemoveWebsiteButtonView()
        {
            this.Controls.Remove(labelAddressOfWebsite);
            this.Controls.Remove(TextBoxAddressOfWebsite);
        }
        #endregion
    }
}
