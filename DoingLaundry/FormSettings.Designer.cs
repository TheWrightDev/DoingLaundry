namespace DoingLaundry
{
    partial class FormSettings
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
            this.checkBoxEmailNotification = new System.Windows.Forms.CheckBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelWasherTime = new System.Windows.Forms.Label();
            this.labelDryerTime = new System.Windows.Forms.Label();
            this.groupBoxDefaultTimes = new System.Windows.Forms.GroupBox();
            this.numericUpDownDryerTime = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWasherTime = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxSoundNotification = new System.Windows.Forms.CheckBox();
            this.textBoxSoundPath = new System.Windows.Forms.TextBox();
            this.buttonBrowseForSound = new System.Windows.Forms.Button();
            this.groupBoxNotifications = new System.Windows.Forms.GroupBox();
            this.groupBoxDefaultTimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDryerTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWasherTime)).BeginInit();
            this.groupBoxNotifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxEmailNotification
            // 
            this.checkBoxEmailNotification.AutoSize = true;
            this.checkBoxEmailNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEmailNotification.Location = new System.Drawing.Point(10, 57);
            this.checkBoxEmailNotification.Name = "checkBoxEmailNotification";
            this.checkBoxEmailNotification.Size = new System.Drawing.Size(64, 20);
            this.checkBoxEmailNotification.TabIndex = 0;
            this.checkBoxEmailNotification.Text = " Email";
            this.checkBoxEmailNotification.UseVisualStyleBackColor = true;
            this.checkBoxEmailNotification.CheckedChanged += new System.EventHandler(this.checkBoxEmailNotification_CheckedChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(72, 56);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(248, 22);
            this.textBoxEmail.TabIndex = 2;
            // 
            // labelWasherTime
            // 
            this.labelWasherTime.AutoSize = true;
            this.labelWasherTime.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWasherTime.Location = new System.Drawing.Point(20, 58);
            this.labelWasherTime.Name = "labelWasherTime";
            this.labelWasherTime.Size = new System.Drawing.Size(78, 18);
            this.labelWasherTime.TabIndex = 5;
            this.labelWasherTime.Text = "Dryer Time:";
            // 
            // labelDryerTime
            // 
            this.labelDryerTime.AutoSize = true;
            this.labelDryerTime.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDryerTime.Location = new System.Drawing.Point(7, 27);
            this.labelDryerTime.Name = "labelDryerTime";
            this.labelDryerTime.Size = new System.Drawing.Size(91, 18);
            this.labelDryerTime.TabIndex = 6;
            this.labelDryerTime.Text = "Washer Time:";
            // 
            // groupBoxDefaultTimes
            // 
            this.groupBoxDefaultTimes.Controls.Add(this.numericUpDownDryerTime);
            this.groupBoxDefaultTimes.Controls.Add(this.numericUpDownWasherTime);
            this.groupBoxDefaultTimes.Controls.Add(this.labelDryerTime);
            this.groupBoxDefaultTimes.Controls.Add(this.labelWasherTime);
            this.groupBoxDefaultTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDefaultTimes.Location = new System.Drawing.Point(8, 4);
            this.groupBoxDefaultTimes.Name = "groupBoxDefaultTimes";
            this.groupBoxDefaultTimes.Size = new System.Drawing.Size(144, 93);
            this.groupBoxDefaultTimes.TabIndex = 7;
            this.groupBoxDefaultTimes.TabStop = false;
            this.groupBoxDefaultTimes.Text = "Default Cycle Times";
            // 
            // numericUpDownDryerTime
            // 
            this.numericUpDownDryerTime.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDryerTime.Location = new System.Drawing.Point(94, 55);
            this.numericUpDownDryerTime.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownDryerTime.Name = "numericUpDownDryerTime";
            this.numericUpDownDryerTime.Size = new System.Drawing.Size(40, 26);
            this.numericUpDownDryerTime.TabIndex = 7;
            this.numericUpDownDryerTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownDryerTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericUpDown_MouseClick);
            // 
            // numericUpDownWasherTime
            // 
            this.numericUpDownWasherTime.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownWasherTime.Location = new System.Drawing.Point(94, 24);
            this.numericUpDownWasherTime.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownWasherTime.Name = "numericUpDownWasherTime";
            this.numericUpDownWasherTime.Size = new System.Drawing.Size(40, 26);
            this.numericUpDownWasherTime.TabIndex = 7;
            this.numericUpDownWasherTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownWasherTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericUpDown_MouseClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(407, 100);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 25);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(487, 100);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 25);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxSoundNotification
            // 
            this.checkBoxSoundNotification.AutoSize = true;
            this.checkBoxSoundNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSoundNotification.Location = new System.Drawing.Point(10, 26);
            this.checkBoxSoundNotification.Name = "checkBoxSoundNotification";
            this.checkBoxSoundNotification.Size = new System.Drawing.Size(66, 20);
            this.checkBoxSoundNotification.TabIndex = 0;
            this.checkBoxSoundNotification.Text = "Sound";
            this.checkBoxSoundNotification.UseVisualStyleBackColor = true;
            this.checkBoxSoundNotification.CheckedChanged += new System.EventHandler(this.checkBoxSoundNotification_CheckedChanged);
            // 
            // textBoxSoundPath
            // 
            this.textBoxSoundPath.Enabled = false;
            this.textBoxSoundPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoundPath.Location = new System.Drawing.Point(72, 25);
            this.textBoxSoundPath.Name = "textBoxSoundPath";
            this.textBoxSoundPath.Size = new System.Drawing.Size(248, 22);
            this.textBoxSoundPath.TabIndex = 2;
            // 
            // buttonBrowseForSound
            // 
            this.buttonBrowseForSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseForSound.Location = new System.Drawing.Point(323, 23);
            this.buttonBrowseForSound.Name = "buttonBrowseForSound";
            this.buttonBrowseForSound.Size = new System.Drawing.Size(75, 25);
            this.buttonBrowseForSound.TabIndex = 8;
            this.buttonBrowseForSound.Text = "Browse";
            this.buttonBrowseForSound.UseVisualStyleBackColor = true;
            this.buttonBrowseForSound.Click += new System.EventHandler(this.buttonBrowseForSound_Click);
            // 
            // groupBoxNotifications
            // 
            this.groupBoxNotifications.Controls.Add(this.buttonBrowseForSound);
            this.groupBoxNotifications.Controls.Add(this.textBoxEmail);
            this.groupBoxNotifications.Controls.Add(this.textBoxSoundPath);
            this.groupBoxNotifications.Controls.Add(this.checkBoxSoundNotification);
            this.groupBoxNotifications.Controls.Add(this.checkBoxEmailNotification);
            this.groupBoxNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNotifications.Location = new System.Drawing.Point(157, 4);
            this.groupBoxNotifications.Name = "groupBoxNotifications";
            this.groupBoxNotifications.Size = new System.Drawing.Size(405, 93);
            this.groupBoxNotifications.TabIndex = 9;
            this.groupBoxNotifications.TabStop = false;
            this.groupBoxNotifications.Text = "Notifications";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 129);
            this.Controls.Add(this.groupBoxNotifications);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxDefaultTimes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.groupBoxDefaultTimes.ResumeLayout(false);
            this.groupBoxDefaultTimes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDryerTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWasherTime)).EndInit();
            this.groupBoxNotifications.ResumeLayout(false);
            this.groupBoxNotifications.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEmailNotification;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelWasherTime;
        private System.Windows.Forms.Label labelDryerTime;
        private System.Windows.Forms.GroupBox groupBoxDefaultTimes;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownDryerTime;
        private System.Windows.Forms.NumericUpDown numericUpDownWasherTime;
        private System.Windows.Forms.CheckBox checkBoxSoundNotification;
        private System.Windows.Forms.TextBox textBoxSoundPath;
        private System.Windows.Forms.Button buttonBrowseForSound;
        private System.Windows.Forms.GroupBox groupBoxNotifications;
    }
}