namespace EV8R
{
    partial class ImportFilesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportFilesForm));
            this.importProgressBar = new System.Windows.Forms.ProgressBar();
            this.importStatusLabel = new System.Windows.Forms.Label();
            this.importBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // importProgressBar
            // 
            this.importProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importProgressBar.Location = new System.Drawing.Point(12, 25);
            this.importProgressBar.MarqueeAnimationSpeed = 25;
            this.importProgressBar.Name = "importProgressBar";
            this.importProgressBar.Size = new System.Drawing.Size(344, 23);
            this.importProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.importProgressBar.TabIndex = 0;
            // 
            // importStatusLabel
            // 
            this.importStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.importStatusLabel.AutoSize = true;
            this.importStatusLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.importStatusLabel.Location = new System.Drawing.Point(12, 9);
            this.importStatusLabel.Name = "importStatusLabel";
            this.importStatusLabel.Size = new System.Drawing.Size(59, 13);
            this.importStatusLabel.TabIndex = 1;
            this.importStatusLabel.Text = "Importing...";
            // 
            // importBackgroundWorker
            // 
            this.importBackgroundWorker.WorkerReportsProgress = true;
            this.importBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.importBackgroundWorker_DoWork);
            this.importBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.importBackgroundWorker_ProgressChanged);
            this.importBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.importBackgroundWorker_RunWorkerCompleted);
            // 
            // ImportFilesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(368, 60);
            this.Controls.Add(this.importStatusLabel);
            this.Controls.Add(this.importProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Importing Files...";
            this.Load += new System.EventHandler(this.ImportFilesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar importProgressBar;
        private System.Windows.Forms.Label importStatusLabel;
        private System.ComponentModel.BackgroundWorker importBackgroundWorker;
    }
}