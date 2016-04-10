using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV8R
{
    public partial class ImportFilesForm : Form
    {
        /// <summary>
        /// An array of file names to be loaded.
        /// </summary>
        string[] fileNames;

        /// <summary>
        /// The path to which the processed file should be saved.
        /// </summary>
        string savePath;

        /// <summary>
        /// The importer that translates EV8R files back to their original form.
        /// </summary>
        Importer importer;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public ImportFilesForm(string[] fileNames, string savePath)
        {
            InitializeComponent();

            this.fileNames = fileNames;
            this.savePath = savePath;
            importer = new Importer();
        }

        /// <summary>
        /// Starts importing the given files when the form is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFilesForm_Load(object sender, EventArgs e)
        {
            if (!importBackgroundWorker.IsBusy)
                importBackgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Imports the given files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < fileNames.Length; i++)
            {
                if (importBackgroundWorker.CancellationPending)
                    return;

                importBackgroundWorker.ReportProgress((int)((i + 1) / (float)fileNames.Length * 100.0f),
                    "Importing files " + (i + 1) + " of " + fileNames.Length + "...");

                importer.Load(fileNames[i]);
            }

            importBackgroundWorker.ReportProgress(-1, "Saving processed file...");

            e.Result = importer.Write(savePath) ?
                "File imported and saved successfully!" :
                "Some EV8R files were missing their counterparts.\nCertain files may not have been restored.";
        }
        
        /// <summary>
        /// Updates the status label and progress bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            importStatusLabel.Text = (string)e.UserState;

            if (e.ProgressPercentage < 0)
            {
                importProgressBar.Style = ProgressBarStyle.Marquee;
            }
            else
            {
                importProgressBar.Style = ProgressBarStyle.Continuous;
                importProgressBar.Value = e.ProgressPercentage;
            }
        }

        /// <summary>
        /// Shows a message box displaying the result of the import.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(this, (string)e.Result);
            Close();
        }
    }
}
