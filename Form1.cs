using System;
using System.IO;
using System.Windows.Forms;

namespace FileByMaskDeleter
{
    
    public class FileByMaskDeleter
    {
        public string mask { get; set; }
        public string path { get; set; }

        public FileByMaskDeleter()
        {
            mask = path = string.Empty;
        }

        public void Deletion()
        {
            try
            {
                string[] files = Directory.GetFiles(this.path, this.mask);
                foreach (string file in files)
                {
                    File.Delete(file);
                }
                MessageBox.Show(files.Length.ToString() + " file(-s) have been deleted", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(PathTooLongException exception)
            {
                MessageBox.Show(exception.Message, "PathTooLongException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(DirectoryNotFoundException exception)
            {
                MessageBox.Show(exception.Message, "DirectoryNotFoundException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.path = string.Empty;
            }
        }
    }

    public partial class Form1 : Form
    {
        private FileByMaskDeleter _fileByMaskDeleter = new FileByMaskDeleter();

        public Form1()
        {
            InitializeComponent();
        }

        private void StartDeletionButton_Click(object sender, EventArgs e)
        {
                _fileByMaskDeleter.Deletion();
        }

        private void SetPathButton_Click(object sender, EventArgs e)
        {
            using (var d = new System.Windows.Forms.FolderBrowserDialog())
            {
                d.ShowDialog();
                PathTextBox.Text = _fileByMaskDeleter.path = d.SelectedPath;
            }
        }

        private void MaskTextBox_TextChanged(object sender, EventArgs e)
        {
            _fileByMaskDeleter.mask = MaskTextBox.Text;
            StartDeleteionButtonEnabledCheck();
        }

        private void PathTextBox_TextChanged(object sender, EventArgs e)
        {
            _fileByMaskDeleter.path = PathTextBox.Text;
            StartDeleteionButtonEnabledCheck();
        }

        private void StartDeleteionButtonEnabledCheck()
        {
            if (PathTextBox.Text == string.Empty || MaskTextBox.Text == string.Empty)
            {
                StartDeletionButton.Enabled = false;
            }
            else StartDeletionButton.Enabled = true;
        }
    }
}
