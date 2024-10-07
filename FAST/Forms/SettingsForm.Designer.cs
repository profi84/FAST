namespace FAST.Forms
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumDistanceWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NumDistanceHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumButtonWidth = new System.Windows.Forms.NumericUpDown();
            this.NumButtonHeight = new System.Windows.Forms.NumericUpDown();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.CheckBoxMinimizeAfterButtonClick = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumDistanceWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDistanceHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumButtonWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumButtonHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abstand Button rechts/links";
            // 
            // NumDistanceWidth
            // 
            this.NumDistanceWidth.Location = new System.Drawing.Point(15, 69);
            this.NumDistanceWidth.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.NumDistanceWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumDistanceWidth.Name = "NumDistanceWidth";
            this.NumDistanceWidth.Size = new System.Drawing.Size(85, 20);
            this.NumDistanceWidth.TabIndex = 1;
            this.NumDistanceWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(192, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Abstand Button oben/unten";
            // 
            // NumDistanceHeight
            // 
            this.NumDistanceHeight.Location = new System.Drawing.Point(195, 69);
            this.NumDistanceHeight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NumDistanceHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumDistanceHeight.Name = "NumDistanceHeight";
            this.NumDistanceHeight.Size = new System.Drawing.Size(85, 20);
            this.NumDistanceHeight.TabIndex = 1;
            this.NumDistanceHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Button Breite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(192, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Button Höhe";
            // 
            // NumButtonWidth
            // 
            this.NumButtonWidth.Location = new System.Drawing.Point(15, 145);
            this.NumButtonWidth.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.NumButtonWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumButtonWidth.Name = "NumButtonWidth";
            this.NumButtonWidth.Size = new System.Drawing.Size(85, 20);
            this.NumButtonWidth.TabIndex = 1;
            this.NumButtonWidth.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // NumButtonHeight
            // 
            this.NumButtonHeight.Location = new System.Drawing.Point(195, 145);
            this.NumButtonHeight.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.NumButtonHeight.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.NumButtonHeight.Name = "NumButtonHeight";
            this.NumButtonHeight.Size = new System.Drawing.Size(85, 20);
            this.NumButtonHeight.TabIndex = 1;
            this.NumButtonHeight.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // ButtonOK
            // 
            this.ButtonOK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonOK.FlatAppearance.BorderSize = 0;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonOK.Location = new System.Drawing.Point(15, 260);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(140, 45);
            this.ButtonOK.TabIndex = 2;
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
            this.ButtonCancel.Location = new System.Drawing.Point(191, 260);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(140, 45);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Abbrechen";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // CheckBoxMinimizeAfterButtonClick
            // 
            this.CheckBoxMinimizeAfterButtonClick.AutoSize = true;
            this.CheckBoxMinimizeAfterButtonClick.Location = new System.Drawing.Point(15, 205);
            this.CheckBoxMinimizeAfterButtonClick.Name = "CheckBoxMinimizeAfterButtonClick";
            this.CheckBoxMinimizeAfterButtonClick.Size = new System.Drawing.Size(189, 17);
            this.CheckBoxMinimizeAfterButtonClick.TabIndex = 4;
            this.CheckBoxMinimizeAfterButtonClick.Text = "Minimieren, nach dem Button Click";
            this.CheckBoxMinimizeAfterButtonClick.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 329);
            this.Controls.Add(this.CheckBoxMinimizeAfterButtonClick);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.NumButtonHeight);
            this.Controls.Add(this.NumDistanceHeight);
            this.Controls.Add(this.NumButtonWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumDistanceWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumDistanceWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDistanceHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumButtonWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumButtonHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumDistanceWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumDistanceHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumButtonWidth;
        private System.Windows.Forms.NumericUpDown NumButtonHeight;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.CheckBox CheckBoxMinimizeAfterButtonClick;
    }
}