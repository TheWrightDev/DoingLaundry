namespace DoingLaundry
{
    partial class LaundryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelTimeRemaing = new System.Windows.Forms.Label();
            this.labelDivider = new System.Windows.Forms.Label();
            this.contextMenuStripLaundryControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripLaundryControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStart
            // 
            this.labelStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelStart.Font = new System.Drawing.Font("Miramonte", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.Location = new System.Drawing.Point(0, 0);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(160, 20);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Start Time: 12:59 PM";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimeRemaing
            // 
            this.labelTimeRemaing.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTimeRemaing.Font = new System.Drawing.Font("Miramonte", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeRemaing.Location = new System.Drawing.Point(0, 20);
            this.labelTimeRemaing.Name = "labelTimeRemaing";
            this.labelTimeRemaing.Size = new System.Drawing.Size(160, 19);
            this.labelTimeRemaing.TabIndex = 1;
            this.labelTimeRemaing.Text = "Time Remaining:20m";
            this.labelTimeRemaing.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelDivider
            // 
            this.labelDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDivider.Location = new System.Drawing.Point(2, 40);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(156, 2);
            this.labelDivider.TabIndex = 2;
            // 
            // contextMenuStripLaundryControl
            // 
            this.contextMenuStripLaundryControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEnd});
            this.contextMenuStripLaundryControl.Name = "contextMenuStripLaundryControl";
            this.contextMenuStripLaundryControl.Size = new System.Drawing.Size(106, 26);
            // 
            // toolStripMenuItemEnd
            // 
            this.toolStripMenuItemEnd.Name = "toolStripMenuItemEnd";
            this.toolStripMenuItemEnd.Size = new System.Drawing.Size(105, 22);
            this.toolStripMenuItemEnd.Text = "Finish";
            this.toolStripMenuItemEnd.Click += new System.EventHandler(this.toolStripMenuItemEnd_Click);
            // 
            // LaundryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.labelTimeRemaing);
            this.Controls.Add(this.labelStart);
            this.Font = new System.Drawing.Font("Miramonte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Name = "LaundryControl";
            this.Size = new System.Drawing.Size(160, 41);
            this.contextMenuStripLaundryControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelTimeRemaing;
        private System.Windows.Forms.Label labelDivider;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLaundryControl;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEnd;
    }
}
