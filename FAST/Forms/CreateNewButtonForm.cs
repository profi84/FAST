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
                    GetPathOfFile = TextBoxPathFile.Text.Trim(),
                    GetIfNotDefaultProgram = CheckIfNotDefaultProgram.Checked,
                    GetPathProgramIfNotDefault = TextBoxPathProgramIfNotDefault.Text.Trim(),
                    GetIfNoFileChoosed = CheckIfNoFileChoosed.Checked,
                    GetPathOfFolderIfNoFileChoosed = TextPathOfFolderIfNoFileChoosed.Text.Trim()
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
                    GetIfNotDefaultBrowser = CheckIfNotDefaultBrowser.Checked,
                    GetPathOfBrowserIfNotDefault = TextBoxlabelPathOfBrowserIfNotDefault.Text.Trim()
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
        CheckBox CheckIfNotDefaultProgram = new CheckBox();
        Label labelPathProgramIfNotDefault = new Label();
        TextBox TextBoxPathProgramIfNotDefault = new TextBox();
        CheckBox CheckIfNoFileChoosed = new CheckBox();
        Label labelPathOfFolderIfNoFileChoosed = new Label();
        TextBox TextPathOfFolderIfNoFileChoosed = new TextBox();

        #endregion

        #region // Form elements of website button

        Label labelAddressOfWebsite = new Label();
        TextBox TextBoxAddressOfWebsite = new TextBox();
        CheckBox CheckIfNotDefaultBrowser = new CheckBox();
        Label labelPathOfBrowserIfNotDefault = new Label();
        TextBox TextBoxlabelPathOfBrowserIfNotDefault = new TextBox();

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
            Controls.Add(TextBoxPathExplorer);
        }

        private void CreateProgramButtonView()
        {            
            labelPathFile.AutoSize = true;
            labelPathFile.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPathFile.Location = new System.Drawing.Point(30, 180);
            labelPathFile.Name = "labelPathFile";
            labelPathFile.Text = "Bitte den Dateipfad eingeben. (Start mit default Programm)";
            Controls.Add(labelPathFile);

            TextBoxPathFile.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBoxPathFile.Location = new System.Drawing.Point(30, 205);
            TextBoxPathFile.Name = "TextBoxPathFile";
            TextBoxPathFile.Size = new System.Drawing.Size(645, 29);
            Controls.Add(TextBoxPathFile);

            CheckIfNotDefaultProgram.AutoSize = true;
            CheckIfNotDefaultProgram.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            CheckIfNotDefaultProgram.Location = new System.Drawing.Point(30, 260);
            CheckIfNotDefaultProgram.Name = "CheckIfNotDefaultProgram";
            CheckIfNotDefaultProgram.Text = "Wenn keine default Programm benutzt werden soll.";
            Controls.Add(CheckIfNotDefaultProgram);
            CheckIfNotDefaultProgram.CheckStateChanged += new EventHandler(CheckIfNotDefaultProgram_StateChange);

            labelPathProgramIfNotDefault.AutoSize = true;
            labelPathProgramIfNotDefault.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPathProgramIfNotDefault.Location = new System.Drawing.Point(30, 285);
            labelPathProgramIfNotDefault.Name = "labelPathProgramIfNotDefault";
            labelPathProgramIfNotDefault.Text = "Bitte den Programm Pfad eingeben. (Exe Pfad anstatt default Programm)";
            Controls.Add(labelPathProgramIfNotDefault);

            TextBoxPathProgramIfNotDefault.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBoxPathProgramIfNotDefault.Location = new System.Drawing.Point(30, 310);
            TextBoxPathProgramIfNotDefault.Name = "TextBoxPathProgramIfNotDefault";
            TextBoxPathProgramIfNotDefault.Size = new System.Drawing.Size(645, 29);
            TextBoxPathProgramIfNotDefault.Enabled = false;
            Controls.Add(TextBoxPathProgramIfNotDefault);

            CheckIfNoFileChoosed.AutoSize = true;
            CheckIfNoFileChoosed.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            CheckIfNoFileChoosed.Location = new System.Drawing.Point(30, 365);
            CheckIfNoFileChoosed.Name = "CheckIfNoFileChoosed";
            CheckIfNoFileChoosed.Text = "Wenn kein Datei geöfften werdne soll, sondern Ordner.";
            Controls.Add(CheckIfNoFileChoosed);
            CheckIfNoFileChoosed.CheckStateChanged += new EventHandler(CheckIfNoFileChoosed_StateChange);

            labelPathOfFolderIfNoFileChoosed.AutoSize = true;
            labelPathOfFolderIfNoFileChoosed.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPathOfFolderIfNoFileChoosed.Location = new System.Drawing.Point(30, 390);
            labelPathOfFolderIfNoFileChoosed.Name = "labelPathOfFolderIfNoFileChoosed";
            labelPathOfFolderIfNoFileChoosed.Text = "Bitte Ordner Pfad eingeben, welcher sich dann mit Dialogfenster öffnet.";
            Controls.Add(labelPathOfFolderIfNoFileChoosed);

            TextPathOfFolderIfNoFileChoosed.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextPathOfFolderIfNoFileChoosed.Location = new System.Drawing.Point(30, 415);
            TextPathOfFolderIfNoFileChoosed.Name = "TextPathOfFolderIfNoFileChoosed";
            TextPathOfFolderIfNoFileChoosed.Size = new System.Drawing.Size(645, 29);
            TextPathOfFolderIfNoFileChoosed.Enabled = false;
            Controls.Add(TextPathOfFolderIfNoFileChoosed);
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
            Controls.Add(TextBoxAddressOfWebsite);

            CheckIfNotDefaultBrowser.AutoSize = true;
            CheckIfNotDefaultBrowser.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            CheckIfNotDefaultBrowser.Location = new System.Drawing.Point(30, 260);
            CheckIfNotDefaultBrowser.Name = "CheckIfNotDefaultBrowser";
            CheckIfNotDefaultBrowser.Text = "Wenn kein default Browser benutzt werden soll.";
            Controls.Add(CheckIfNotDefaultBrowser);
            CheckIfNotDefaultBrowser.CheckStateChanged += new EventHandler(CheckIfNotDefaultBrowser_ChangeState);

            labelPathOfBrowserIfNotDefault.AutoSize = true;
            labelPathOfBrowserIfNotDefault.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPathOfBrowserIfNotDefault.Location = new System.Drawing.Point(30, 285);
            labelPathOfBrowserIfNotDefault.Name = "labelPathOfBrowserIfNotDefault";
            labelPathOfBrowserIfNotDefault.Text = "Bitte den Browser Pfad eingeben. (Exe Pfad anstatt default Browser)";
            Controls.Add(labelPathOfBrowserIfNotDefault);

            TextBoxlabelPathOfBrowserIfNotDefault.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBoxlabelPathOfBrowserIfNotDefault.Location = new System.Drawing.Point(30, 310);
            TextBoxlabelPathOfBrowserIfNotDefault.Name = "TextBoxlabelPathOfBrowserIfNotDefault";
            TextBoxlabelPathOfBrowserIfNotDefault.Size = new System.Drawing.Size(645, 29);
            TextBoxlabelPathOfBrowserIfNotDefault.Enabled = false;
            Controls.Add(TextBoxlabelPathOfBrowserIfNotDefault);
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
            this.Controls.Remove(CheckIfNotDefaultProgram);
            this.Controls.Remove(labelPathProgramIfNotDefault);
            this.Controls.Remove(TextBoxPathProgramIfNotDefault);
            this.Controls.Remove(CheckIfNoFileChoosed);
            this.Controls.Remove(labelPathOfFolderIfNoFileChoosed);
            this.Controls.Remove(TextPathOfFolderIfNoFileChoosed);
            CheckIfNoFileChoosed.CheckStateChanged -= new EventHandler(CheckIfNoFileChoosed_StateChange);
            CheckIfNotDefaultProgram.CheckStateChanged -= new EventHandler(CheckIfNotDefaultProgram_StateChange);
        }

        private void RemoveWebsiteButtonView()
        {
            this.Controls.Remove(labelAddressOfWebsite);
            this.Controls.Remove(TextBoxAddressOfWebsite);
            this.Controls.Remove(CheckIfNotDefaultBrowser);
            this.Controls.Remove(labelPathOfBrowserIfNotDefault);
            this.Controls.Remove(TextBoxlabelPathOfBrowserIfNotDefault);
            CheckIfNotDefaultBrowser.CheckStateChanged -= new EventHandler(CheckIfNotDefaultBrowser_ChangeState);
        }

        private void CheckIfNoFileChoosed_StateChange(object sender, EventArgs e)
        {
            if (CheckIfNoFileChoosed.Checked == true)
            {
                TextPathOfFolderIfNoFileChoosed.Enabled = true;
                TextBoxPathFile.Text = String.Empty;
                TextBoxPathFile.Enabled = false;
            }
            else
            {
                TextBoxPathFile.Enabled = true;
                TextPathOfFolderIfNoFileChoosed.Text = String.Empty;
                TextPathOfFolderIfNoFileChoosed.Enabled = false;
            }
        }

        private void CheckIfNotDefaultProgram_StateChange(object sender, EventArgs e)
        {
            if (CheckIfNotDefaultProgram.Checked == true)
            {
                TextBoxPathProgramIfNotDefault.Enabled = true;
            }
            else
            {
                TextBoxPathProgramIfNotDefault.Text = String.Empty;
                TextBoxPathProgramIfNotDefault.Enabled = false;
            }
        }

        private void CheckIfNotDefaultBrowser_ChangeState(object sender, EventArgs e)
        {
            if (CheckIfNotDefaultBrowser.Checked == true)
            {
                TextBoxlabelPathOfBrowserIfNotDefault.Enabled = true;
            }
            else
            {
                TextBoxlabelPathOfBrowserIfNotDefault.Text = string.Empty;
                TextBoxlabelPathOfBrowserIfNotDefault.Enabled = false;
            }
        }

        #endregion
    }
}
