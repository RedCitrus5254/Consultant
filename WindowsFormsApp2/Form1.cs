using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private List<FilePathControl> filePathControls;

        FileWorker fileWorker;
        public Form1()
        {
            InitializeComponent();

            InitFilePathControls();
            fileWorker = new FileWorker();
        }

        private void InitFilePathControls()
        {
            filePathControls = new List<FilePathControl>();

            for(int i = 0; i < 5; i++)
            {
                CreateFilePathControl();
            }
        }

        public void CreateFilePathControl()
        {
            FilePathControl filePathControl = new FilePathControl();

            if (filePathControls.Count > 0)
            {
                int left = InputFilesLabel.Location.X;
                int top = InputFilesLabel.Location.Y + InputFilesLabel.Height + filePathControls.Count * filePathControl.Height;
                filePathControl.Location = new Point(left, top);
            }
            else
            {
                filePathControl.Location = new Point(InputFilesLabel.Location.X, InputFilesLabel.Location.Y + InputFilesLabel.Height);
            }
            
            filePathControls.Add(filePathControl);
            this.Controls.Add(filePathControl);
        }

        private void AddFilePathControlButton_Click(object sender, EventArgs e)
        {
            CreateFilePathControl();
        }

        private List<string> GetFilePaths()
        {
            List<string> paths = new List<string>();

            foreach(var control in filePathControls)
            {
                if (!string.IsNullOrWhiteSpace(control.FilePath))
                {
                    paths.Add(control.FilePath);
                }
            }

            return paths;
        }

        private void AddDataButton_Click(object sender, EventArgs e)
        {
            if (CreateOutputDirCheckBox.Checked)
            {
                fileWorker.ProcessingFiles(GetFilePaths(), OutputDirTextBox.Text);
            }
            else
            {
                fileWorker.ProcessingFiles(GetFilePaths());
            }
            
        }

        private void CreateOutputDirCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CreateOutputDirCheckBox.Checked)
            {
                OutputDirTextBox.Enabled = true;
            }
            else
            {
                OutputDirTextBox.Enabled = false;
            }
            

        }
    }
}
