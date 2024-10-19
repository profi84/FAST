using FAST.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAST.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void SaveSettings()
        {
            SettingsValuesFlexible.Instance().GetDistanceWidthValue = (int)NumDistanceWidth.Value;
            SettingsValuesFlexible.Instance().GetDiscanceHeightValue = (int)NumDistanceHeight.Value;
            SettingsValuesFlexible.Instance().GetButtonWidthValue = (int)NumButtonWidth.Value;
            SettingsValuesFlexible.Instance().GetButtonHeightValue = (int)NumButtonHeight.Value;

            if(CheckBoxMinimizeAfterButtonClick.Checked == true)
                SettingsValuesFlexible.Instance().GetMinimizeFormAfterButtonClick = true;
            else
                SettingsValuesFlexible.Instance().GetMinimizeFormAfterButtonClick = false;

            if (CheckFlagShowTrayMessage.Checked == true)
                SettingsValuesFlexible.Instance().GetShowTrayMessageFlag = true;
            else
                SettingsValuesFlexible.Instance().GetShowTrayMessageFlag = false;
        }

        public event EventHandler ButtonOKSetting;
        public event EventHandler ButtonCancelSetting;

        private void ShowInfo()
        {
            NumDistanceWidth.Value = SettingsValuesFlexible.Instance().GetDistanceWidthValue;
            NumDistanceHeight.Value = SettingsValuesFlexible.Instance().GetDiscanceHeightValue;
            NumButtonWidth.Value = SettingsValuesFlexible.Instance().GetButtonWidthValue;
            NumButtonHeight.Value = SettingsValuesFlexible.Instance().GetButtonHeightValue;

            if(SettingsValuesFlexible.Instance().GetMinimizeFormAfterButtonClick == true)            
                CheckBoxMinimizeAfterButtonClick.Checked = true;
            else
                CheckBoxMinimizeAfterButtonClick.Checked = false;

            if (SettingsValuesFlexible.Instance().GetShowTrayMessageFlag == true)
                CheckFlagShowTrayMessage.Checked = true;
            else
                CheckFlagShowTrayMessage.Checked = false;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            SaveSettings();
            SettingsValuesFlexible.Instance().WriteJson();
            if (ButtonOKSetting != null) ButtonOKSetting(this, EventArgs.Empty);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (ButtonCancelSetting != null) ButtonCancelSetting(this, EventArgs.Empty);
        }
    }
}
