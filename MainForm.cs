using System;
using System.Windows.Forms;
using System.IO.Compression;
using System.Text;

namespace Prosource_Extracting_PDF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSourcePath_Click(object sender, EventArgs e)
        {
            var folderPath = new FolderBrowserDialog() { ShowNewFolderButton = true };
            folderPath.ShowDialog();
            if (!string.IsNullOrWhiteSpace(folderPath.SelectedPath))
            {
                lblSourcePath.Text = folderPath.SelectedPath;
                var files = System.IO.Directory.GetFiles(lblSourcePath.Text, "*.zip", System.IO.SearchOption.AllDirectories);
                listFiles.Items.Clear();
                foreach (var file in files)
                {
                    var filename = System.IO.Path.GetFileName(file);
                    listFiles.Items.Add(filename);
                }
            }
        }

        private void btnDestinationPath_Click(object sender, EventArgs e)
        {
            var folderPath = new FolderBrowserDialog();
            folderPath.ShowDialog();
            if (!string.IsNullOrWhiteSpace(folderPath.SelectedPath))
            {
                lblDestinationPath.Text = folderPath.SelectedPath;
                lblDestinationPath.Tag = new { IsSelected = true };
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var counter = 1;
            if (listFiles.Items.Count == 0)
            {
                MessageBox.Show("There is no zip file to process.");
                return;
            }
            dynamic destinationObj = lblDestinationPath.Tag;
            bool destinationPathIsSelected = destinationObj is null ? false : destinationObj.IsSelected;
            if (!destinationPathIsSelected)
            {
                MessageBox.Show("Please select destination path.");
                return;
            }

            listLog.Items.Clear();
            System.IO.Directory.Delete(lblDestinationPath.Text, true);
            var tempDirectoryAddress = lblDestinationPath.Text + "/Temp";
            var textResult = new StringBuilder();
            foreach (var file in listFiles.Items)
            {
                listLog.Items.Add($"{counter++}.\t{DateTime.Now} Create temp directory.");
                System.IO.Directory.CreateDirectory(tempDirectoryAddress);
                using (ZipArchive archive = ZipFile.Open(lblSourcePath.Text + "/" + file, ZipArchiveMode.Read))
                {
                    archive.ExtractToDirectory(tempDirectoryAddress);
                    listLog.Items.Add($"{counter++}.\t{DateTime.Now} Extract file into temp directory.");
                    var files = System.IO.Directory.GetFiles(tempDirectoryAddress, "*.pdf");
                    listLog.Items.Add($"{counter++}.\t{DateTime.Now} Read only PDF files.");
                    foreach (var _file in files)
                    {
                        var filename = System.IO.Path.GetFileNameWithoutExtension(_file);
                        textResult.AppendLine(filename);
                        listLog.Items.Add($"{counter++}.\t{DateTime.Now} Add the name of the file into the result text.");

                        var filenameMustBeMoved = lblDestinationPath.Text + "/" + System.IO.Path.GetFileName(_file);
                        var fileExists = System.IO.File.Exists(filenameMustBeMoved);
                        if (fileExists)
                            filenameMustBeMoved = lblDestinationPath.Text + "/" + System.IO.Path.GetFileNameWithoutExtension(_file) + "_" + Guid.NewGuid() + System.IO.Path.GetExtension(_file);
                        System.IO.File.Move(_file, filenameMustBeMoved);
                        listLog.Items.Add($"{counter++}.\t{DateTime.Now} Move file to the destination path{(fileExists?" file exists. Renamed to "+System.IO.Path.GetFileName(filenameMustBeMoved) :"")}.");
                    }
                }
                System.IO.Directory.Delete(tempDirectoryAddress, true);
                listLog.Items.Add($"{counter++}.\t{DateTime.Now} Delete temp directory.");
            }
            if (textResult.Length > 0)
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(lblDestinationPath.Text + "/Result.txt"))
                {
                    file.WriteLine(textResult.ToString());
                    listLog.Items.Add($"{counter++}.\t{DateTime.Now} Create result text file.");
                }
        }
    }
}
