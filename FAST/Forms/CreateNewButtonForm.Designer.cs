namespace FAST.Forms
{
    partial class CreateNewButtonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxTabs = new System.Windows.Forms.ComboBox();
            this.ComboBoxKindOfButton = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ButtonOK
            // 
            this.ButtonOK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonOK.FlatAppearance.BorderSize = 0;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOK.Location = new System.Drawing.Point(352, 483);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(148, 45);
            this.ButtonOK.TabIndex = 0;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonCancel.FlatAppearance.BorderSize = 0;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonCancel.Location = new System.Drawing.Point(511, 483);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(164, 45);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Abbrechen";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lesezeichen  Beschriftung";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.TextBoxTitle.Location = new System.Drawing.Point(30, 55);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(200, 29);
            this.TextBoxTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label2.Location = new System.Drawing.Point(27, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beschreibung *";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.TextBoxDescription.Location = new System.Drawing.Point(30, 130);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(645, 29);
            this.TextBoxDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label3.Location = new System.Drawing.Point(250, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reiter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label4.Location = new System.Drawing.Point(470, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Typ Lesezeichen";
            // 
            // ComboBoxTabs
            // 
            this.ComboBoxTabs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxTabs.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Bold);
            this.ComboBoxTabs.FormattingEnabled = true;
            this.ComboBoxTabs.Location = new System.Drawing.Point(255, 55);
            this.ComboBoxTabs.Name = "ComboBoxTabs";
            this.ComboBoxTabs.Size = new System.Drawing.Size(200, 28);
            this.ComboBoxTabs.TabIndex = 4;
            // 
            // ComboBoxKindOfButton
            // 
            this.ComboBoxKindOfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxKindOfButton.Font = new System.Drawing.Font("Arial Narrow", 12.25F, System.Drawing.FontStyle.Bold);
            this.ComboBoxKindOfButton.FormattingEnabled = true;
            this.ComboBoxKindOfButton.Location = new System.Drawing.Point(475, 55);
            this.ComboBoxKindOfButton.Name = "ComboBoxKindOfButton";
            this.ComboBoxKindOfButton.Size = new System.Drawing.Size(200, 28);
            this.ComboBoxKindOfButton.TabIndex = 4;
            // 
            // CreateNewButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 540);
            this.Controls.Add(this.ComboBoxKindOfButton);
            this.Controls.Add(this.ComboBoxTabs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Name = "CreateNewButtonForm";
            this.Text = "Lesezeichen erstellen!";
            this.Load += new System.EventHandler(this.CreateNewButtonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBoxTabs;
        private System.Windows.Forms.ComboBox ComboBoxKindOfButton;
    }
}