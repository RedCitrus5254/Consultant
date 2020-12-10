using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FilePathControl : UserControl
    {
        public FilePathControl()
        {
            InitializeComponent();
        }

        public string FilePath 
        { 
            get
            {
                return FilePathTextBox.Text;
            }
        }
        private void AddFileButton_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text files(*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FilePathTextBox.Text = ofd.FileName;
                }
            }
        }
    }
}
