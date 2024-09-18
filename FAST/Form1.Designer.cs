namespace FAST
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuMainView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonCreateNewTab = new System.Windows.Forms.Button();
            this.ButtonCreateNewButton = new System.Windows.Forms.Button();
            this.ButtonRemoveTab = new System.Windows.Forms.Button();
            this.ButtonRemoveButton = new System.Windows.Forms.Button();
            this.ButtonSortTabs = new System.Windows.Forms.Button();
            this.ButtonSortButtons = new System.Windows.Forms.Button();
            this.B__2_7 = new System.Windows.Forms.Button();
            this.contextMenuMainView.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.contextMenuMainView;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "NotifyIcon";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // contextMenuMainView
            // 
            this.contextMenuMainView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.contextMenuMainView.Name = "contextMenuMainView";
            this.contextMenuMainView.Size = new System.Drawing.Size(121, 26);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // ButtonCreateNewTab
            // 
            this.ButtonCreateNewTab.Location = new System.Drawing.Point(12, 26);
            this.ButtonCreateNewTab.Name = "ButtonCreateNewTab";
            this.ButtonCreateNewTab.Size = new System.Drawing.Size(132, 46);
            this.ButtonCreateNewTab.TabIndex = 1;
            this.ButtonCreateNewTab.Text = "Reiter erstellen";
            this.ButtonCreateNewTab.UseVisualStyleBackColor = true;
            // 
            // ButtonCreateNewButton
            // 
            this.ButtonCreateNewButton.Location = new System.Drawing.Point(161, 26);
            this.ButtonCreateNewButton.Name = "ButtonCreateNewButton";
            this.ButtonCreateNewButton.Size = new System.Drawing.Size(129, 46);
            this.ButtonCreateNewButton.TabIndex = 2;
            this.ButtonCreateNewButton.Text = "Lesezeichen erstellen";
            this.ButtonCreateNewButton.UseVisualStyleBackColor = true;
            // 
            // ButtonRemoveTab
            // 
            this.ButtonRemoveTab.Location = new System.Drawing.Point(313, 28);
            this.ButtonRemoveTab.Name = "ButtonRemoveTab";
            this.ButtonRemoveTab.Size = new System.Drawing.Size(127, 43);
            this.ButtonRemoveTab.TabIndex = 3;
            this.ButtonRemoveTab.Text = "Reiter löschen";
            this.ButtonRemoveTab.UseVisualStyleBackColor = true;
            // 
            // ButtonRemoveButton
            // 
            this.ButtonRemoveButton.Location = new System.Drawing.Point(454, 31);
            this.ButtonRemoveButton.Name = "ButtonRemoveButton";
            this.ButtonRemoveButton.Size = new System.Drawing.Size(134, 40);
            this.ButtonRemoveButton.TabIndex = 4;
            this.ButtonRemoveButton.Text = "Lesezeichen löschen";
            this.ButtonRemoveButton.UseVisualStyleBackColor = true;
            // 
            // ButtonSortTabs
            // 
            this.ButtonSortTabs.Location = new System.Drawing.Point(602, 31);
            this.ButtonSortTabs.Name = "ButtonSortTabs";
            this.ButtonSortTabs.Size = new System.Drawing.Size(134, 39);
            this.ButtonSortTabs.TabIndex = 5;
            this.ButtonSortTabs.Text = "Reiter einordnen";
            this.ButtonSortTabs.UseVisualStyleBackColor = true;
            // 
            // ButtonSortButtons
            // 
            this.ButtonSortButtons.Location = new System.Drawing.Point(749, 33);
            this.ButtonSortButtons.Name = "ButtonSortButtons";
            this.ButtonSortButtons.Size = new System.Drawing.Size(132, 36);
            this.ButtonSortButtons.TabIndex = 6;
            this.ButtonSortButtons.Text = "Lesezeichen einordnen";
            this.ButtonSortButtons.UseVisualStyleBackColor = true;
            // 
            // B__2_7
            // 
            this.B__2_7.Location = new System.Drawing.Point(12, 138);
            this.B__2_7.Name = "B__2_7";
            this.B__2_7.Size = new System.Drawing.Size(132, 45);
            this.B__2_7.TabIndex = 7;
            this.B__2_7.Text = "button1";
            this.B__2_7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 438);
            this.Controls.Add(this.B__2_7);
            this.Controls.Add(this.ButtonSortButtons);
            this.Controls.Add(this.ButtonSortTabs);
            this.Controls.Add(this.ButtonRemoveButton);
            this.Controls.Add(this.ButtonRemoveTab);
            this.Controls.Add(this.ButtonCreateNewButton);
            this.Controls.Add(this.ButtonCreateNewTab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "FAST - Fast All Start Tool. Maximieren durch \"STRG\" + \"0\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuMainView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuMainView;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Button ButtonCreateNewTab;
        private System.Windows.Forms.Button ButtonCreateNewButton;
        private System.Windows.Forms.Button ButtonRemoveTab;
        private System.Windows.Forms.Button ButtonRemoveButton;
        private System.Windows.Forms.Button ButtonSortTabs;
        private System.Windows.Forms.Button ButtonSortButtons;
        private System.Windows.Forms.Button B__2_7;
    }
}

