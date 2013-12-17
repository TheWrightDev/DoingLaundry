namespace DoingLaundry
{
    partial class FormMain
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
            this.buttonWasher = new System.Windows.Forms.Button();
            this.labelMinutesAgo = new System.Windows.Forms.Label();
            this.buttonDryer = new System.Windows.Forms.Button();
            this.groupBoxWashing = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelWashing = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxDrying = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelDrying = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.groupBoxCycleButtons = new System.Windows.Forms.GroupBox();
            this.numericUpDownMinutesAgo = new System.Windows.Forms.NumericUpDown();
            this.groupBoxWashing.SuspendLayout();
            this.groupBoxDrying.SuspendLayout();
            this.groupBoxCycleButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutesAgo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWasher
            // 
            this.buttonWasher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWasher.Location = new System.Drawing.Point(7, 15);
            this.buttonWasher.Name = "buttonWasher";
            this.buttonWasher.Size = new System.Drawing.Size(105, 41);
            this.buttonWasher.TabIndex = 0;
            this.buttonWasher.Text = "Start Washer";
            this.buttonWasher.UseVisualStyleBackColor = true;
            this.buttonWasher.Click += new System.EventHandler(this.buttonWasher_Click);
            // 
            // labelMinutesAgo
            // 
            this.labelMinutesAgo.AutoSize = true;
            this.labelMinutesAgo.Location = new System.Drawing.Point(8, 108);
            this.labelMinutesAgo.Name = "labelMinutesAgo";
            this.labelMinutesAgo.Size = new System.Drawing.Size(69, 13);
            this.labelMinutesAgo.TabIndex = 1;
            this.labelMinutesAgo.Text = "Minutes Ago:";
            // 
            // buttonDryer
            // 
            this.buttonDryer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDryer.Location = new System.Drawing.Point(7, 60);
            this.buttonDryer.Name = "buttonDryer";
            this.buttonDryer.Size = new System.Drawing.Size(105, 41);
            this.buttonDryer.TabIndex = 0;
            this.buttonDryer.Text = "Start Dryer";
            this.buttonDryer.UseVisualStyleBackColor = true;
            this.buttonDryer.Click += new System.EventHandler(this.buttonDryer_Click);
            // 
            // groupBoxWashing
            // 
            this.groupBoxWashing.Controls.Add(this.flowLayoutPanelWashing);
            this.groupBoxWashing.Location = new System.Drawing.Point(129, 3);
            this.groupBoxWashing.Name = "groupBoxWashing";
            this.groupBoxWashing.Size = new System.Drawing.Size(186, 163);
            this.groupBoxWashing.TabIndex = 3;
            this.groupBoxWashing.TabStop = false;
            this.groupBoxWashing.Text = "Washing";
            // 
            // flowLayoutPanelWashing
            // 
            this.flowLayoutPanelWashing.AutoScroll = true;
            this.flowLayoutPanelWashing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelWashing.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelWashing.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelWashing.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelWashing.Name = "flowLayoutPanelWashing";
            this.flowLayoutPanelWashing.Size = new System.Drawing.Size(180, 144);
            this.flowLayoutPanelWashing.TabIndex = 0;
            this.flowLayoutPanelWashing.WrapContents = false;
            // 
            // groupBoxDrying
            // 
            this.groupBoxDrying.Controls.Add(this.flowLayoutPanelDrying);
            this.groupBoxDrying.Location = new System.Drawing.Point(319, 3);
            this.groupBoxDrying.Name = "groupBoxDrying";
            this.groupBoxDrying.Size = new System.Drawing.Size(186, 163);
            this.groupBoxDrying.TabIndex = 4;
            this.groupBoxDrying.TabStop = false;
            this.groupBoxDrying.Text = "Drying";
            // 
            // flowLayoutPanelDrying
            // 
            this.flowLayoutPanelDrying.AutoScroll = true;
            this.flowLayoutPanelDrying.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDrying.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelDrying.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelDrying.Name = "flowLayoutPanelDrying";
            this.flowLayoutPanelDrying.Size = new System.Drawing.Size(180, 144);
            this.flowLayoutPanelDrying.TabIndex = 0;
            this.flowLayoutPanelDrying.WrapContents = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Font = new System.Drawing.Font("Plantagenet Cherokee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Location = new System.Drawing.Point(26, 140);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "SETTINGS";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // groupBoxCycleButtons
            // 
            this.groupBoxCycleButtons.Controls.Add(this.numericUpDownMinutesAgo);
            this.groupBoxCycleButtons.Controls.Add(this.buttonWasher);
            this.groupBoxCycleButtons.Controls.Add(this.buttonDryer);
            this.groupBoxCycleButtons.Controls.Add(this.labelMinutesAgo);
            this.groupBoxCycleButtons.Location = new System.Drawing.Point(4, 3);
            this.groupBoxCycleButtons.Name = "groupBoxCycleButtons";
            this.groupBoxCycleButtons.Size = new System.Drawing.Size(121, 133);
            this.groupBoxCycleButtons.TabIndex = 6;
            this.groupBoxCycleButtons.TabStop = false;
            this.groupBoxCycleButtons.Text = "Start Cycle";
            // 
            // numericUpDownMinutesAgo
            // 
            this.numericUpDownMinutesAgo.Location = new System.Drawing.Point(76, 105);
            this.numericUpDownMinutesAgo.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownMinutesAgo.Name = "numericUpDownMinutesAgo";
            this.numericUpDownMinutesAgo.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownMinutesAgo.TabIndex = 2;
            this.numericUpDownMinutesAgo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMinutesAgo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericUpDownMinutesAgo_MouseClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 168);
            this.Controls.Add(this.groupBoxCycleButtons);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.groupBoxDrying);
            this.Controls.Add(this.groupBoxWashing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doing The Laundry ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.groupBoxWashing.ResumeLayout(false);
            this.groupBoxDrying.ResumeLayout(false);
            this.groupBoxCycleButtons.ResumeLayout(false);
            this.groupBoxCycleButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutesAgo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWasher;
        private System.Windows.Forms.Label labelMinutesAgo;
        private System.Windows.Forms.Button buttonDryer;
        private System.Windows.Forms.GroupBox groupBoxWashing;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelWashing;
        private System.Windows.Forms.GroupBox groupBoxDrying;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDrying;
        private System.Windows.Forms.GroupBox groupBoxCycleButtons;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutesAgo;
    }
}

