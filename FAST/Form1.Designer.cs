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
            this.menuStripMainView = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuMainView.SuspendLayout();
            this.menuStripMainView.SuspendLayout();
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
            this.ButtonCreateNewTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonCreateNewTab.FlatAppearance.BorderSize = 0;
            this.ButtonCreateNewTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateNewTab.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonCreateNewTab.Location = new System.Drawing.Point(10, 35);
            this.ButtonCreateNewTab.Name = "ButtonCreateNewTab";
            this.ButtonCreateNewTab.Size = new System.Drawing.Size(140, 45);
            this.ButtonCreateNewTab.TabIndex = 1;
            this.ButtonCreateNewTab.Text = "Reiter erstellen";
            this.ButtonCreateNewTab.UseVisualStyleBackColor = false;
            // 
            // ButtonCreateNewButton
            // 
            this.ButtonCreateNewButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonCreateNewButton.FlatAppearance.BorderSize = 0;
            this.ButtonCreateNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateNewButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonCreateNewButton.Location = new System.Drawing.Point(160, 35);
            this.ButtonCreateNewButton.Name = "ButtonCreateNewButton";
            this.ButtonCreateNewButton.Size = new System.Drawing.Size(140, 45);
            this.ButtonCreateNewButton.TabIndex = 2;
            this.ButtonCreateNewButton.Text = "Knopf erstellen";
            this.ButtonCreateNewButton.UseVisualStyleBackColor = false;
            // 
            // ButtonRemoveTab
            // 
            this.ButtonRemoveTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonRemoveTab.FlatAppearance.BorderSize = 0;
            this.ButtonRemoveTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveTab.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonRemoveTab.Location = new System.Drawing.Point(310, 35);
            this.ButtonRemoveTab.Name = "ButtonRemoveTab";
            this.ButtonRemoveTab.Size = new System.Drawing.Size(140, 45);
            this.ButtonRemoveTab.TabIndex = 3;
            this.ButtonRemoveTab.Text = "Reiter löschen";
            this.ButtonRemoveTab.UseVisualStyleBackColor = false;
            // 
            // ButtonRemoveButton
            // 
            this.ButtonRemoveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonRemoveButton.FlatAppearance.BorderSize = 0;
            this.ButtonRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonRemoveButton.Location = new System.Drawing.Point(460, 35);
            this.ButtonRemoveButton.Name = "ButtonRemoveButton";
            this.ButtonRemoveButton.Size = new System.Drawing.Size(140, 45);
            this.ButtonRemoveButton.TabIndex = 4;
            this.ButtonRemoveButton.Text = "Knopflöschen";
            this.ButtonRemoveButton.UseVisualStyleBackColor = false;
            // 
            // ButtonSortTabs
            // 
            this.ButtonSortTabs.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonSortTabs.Location = new System.Drawing.Point(610, 35);
            this.ButtonSortTabs.Name = "ButtonSortTabs";
            this.ButtonSortTabs.Size = new System.Drawing.Size(140, 45);
            this.ButtonSortTabs.TabIndex = 5;
            this.ButtonSortTabs.Text = "Reiter einordnen";
            this.ButtonSortTabs.UseVisualStyleBackColor = true;
            // 
            // ButtonSortButtons
            // 
            this.ButtonSortButtons.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonSortButtons.Location = new System.Drawing.Point(760, 35);
            this.ButtonSortButtons.Name = "ButtonSortButtons";
            this.ButtonSortButtons.Size = new System.Drawing.Size(140, 45);
            this.ButtonSortButtons.TabIndex = 6;
            this.ButtonSortButtons.Text = "Knopf einordnen";
            this.ButtonSortButtons.UseVisualStyleBackColor = true;
            // 
            // menuStripMainView
            // 
            this.menuStripMainView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStripMainView.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainView.Name = "menuStripMainView";
            this.menuStripMainView.Size = new System.Drawing.Size(1350, 24);
            this.menuStripMainView.TabIndex = 7;
            this.menuStripMainView.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem,
            this.beendenToolStripMenuItem1});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem1
            // 
            this.beendenToolStripMenuItem1.Name = "beendenToolStripMenuItem1";
            this.beendenToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.beendenToolStripMenuItem1.Text = "Beenden";
            this.beendenToolStripMenuItem1.Click += new System.EventHandler(this.beendenToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 629);
            this.Controls.Add(this.menuStripMainView);
            this.Controls.Add(this.ButtonSortButtons);
            this.Controls.Add(this.ButtonSortTabs);
            this.Controls.Add(this.ButtonRemoveButton);
            this.Controls.Add(this.ButtonRemoveTab);
            this.Controls.Add(this.ButtonCreateNewButton);
            this.Controls.Add(this.ButtonCreateNewTab);
            this.MainMenuStrip = this.menuStripMainView;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FAST - Fast All Start Tool. Maximieren durch \"STRG\" + \"0\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuMainView.ResumeLayout(false);
            this.menuStripMainView.ResumeLayout(false);
            this.menuStripMainView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStripMainView;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem1;
    }
}

