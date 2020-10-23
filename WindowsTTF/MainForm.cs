using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTTF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FolderPath.Text = Environment.SpecialFolder.Desktop.ToString();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TotalTimeFinder.GetMediaDuration(FolderPath.Text, Subdirectories.Checked));
        }

        private void FileChooser_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "Select a Folder";
            fbd.ShowNewFolderButton = false;

            if (fbd.ShowDialog() == DialogResult.OK)
                FolderPath.Text = fbd.SelectedPath;
        }
    }
}
