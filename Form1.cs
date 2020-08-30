using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading; 

namespace FileLocker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DropField_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private List<string> filePaths = new List<string>();
        private List<string> fileNames = new List<string>();
        private List<string> filePathsWithoutExtension = new List<string>();

        private static int fileCount;
        private string[] droppedFiles = new string[fileCount];

        public void DropField_DragDrop(object sender, DragEventArgs e)
        {
            droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            getnum(nameField.Items.Count);

            foreach (string file in droppedFiles)
            {
                string fileName = getFileName(file);
                nameField.Items.Add(fileName);
                fileNames.Add(fileName);

                string pathName = getPathName(file);
                filePaths.Add(pathName);

                string filePathWithoutExtension = getfilePathWithoutExtension(file);
                filePathsWithoutExtension.Add(filePathWithoutExtension);
            }
        }

        public void getnum(int num)
        {
            fileCount = num;
        }

        private string getFileName(string file)
        {
            return Path.GetFileName(file);
        }

        private string getPathName(string file)
        {
            return Path.GetDirectoryName(file);
        }

        private string getfilePathWithoutExtension(string file)
        {
            return Path.GetFileNameWithoutExtension(file);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int count = nameField.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                nameField.Items.RemoveAt(nameField.Items.IndexOf(nameField.SelectedItem));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EncryptButton_MouseHover(object sender, EventArgs e)
        {
            encryptButton.BackColor = Color.DeepSkyBlue;
        }

        private void EncryptButton_MouseLeave(object sender, EventArgs e)
        {
            encryptButton.BackColor = Color.FromArgb(16, 5, 64, 1);
        }

        private void EncryptButton_MouseEnter(object sender, EventArgs e)
        {
            encryptButton.BackColor = Color.DeepSkyBlue;
        }

        private void EncryptButton_MouseClick(object sender, MouseEventArgs e)
        {
            encryptButton.BackColor = Color.Red;
        }

        private void DecryptButton_MouseClick(object sender, MouseEventArgs e)
        {
            decryptButton.BackColor = Color.Red;
        }

        private void DecryptButton_MouseEnter(object sender, EventArgs e)
        {
            decryptButton.BackColor = Color.DeepSkyBlue;
        }

        private void DecryptButton_MouseHover(object sender, EventArgs e)
        {
            decryptButton.BackColor = Color.DeepSkyBlue;
        }

        private void DecryptButton_MouseLeave(object sender, EventArgs e)
        {
            decryptButton.BackColor = Color.FromArgb(16, 5, 64, 1);
        }

        private void RemoveButton_MouseClick(object sender, MouseEventArgs e)
        {
            removeButton.BackColor = Color.Red;
        }

        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            removeButton.BackColor = Color.DeepSkyBlue;
        }

        private void RemoveButton_MouseHover(object sender, EventArgs e)
        {
            removeButton.BackColor = Color.DeepSkyBlue;
        }

        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            removeButton.BackColor = Color.FromArgb(16, 5, 64, 1);
        }




        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
             if (e.Button == MouseButtons.Left)
                        {
                            ReleaseCapture();
                            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                        }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string[] paths = filePaths.ToArray();
            string[] names = fileNames.ToArray();
            string[] pathsWOExtension = filePathsWithoutExtension.ToArray();

            for (int i = 0; i < names.Length; i++)
            {
                File.Move((paths[i] + "\\" + names[i]),(paths[i] + "\\" + pathsWOExtension[i] + ".frk" ));
            }
            nameField.Items.Clear();
            Array.Clear(paths,0,paths.Length);
            Array.Clear(names,0,names.Length);
            Array.Clear(pathsWOExtension,0,pathsWOExtension.Length);
            Array.Clear(droppedFiles,0,droppedFiles.Length);
            filePaths.Clear();
            fileNames.Clear();
            filePathsWithoutExtension.Clear();

        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string[] paths = filePaths.ToArray();
            string[] names = fileNames.ToArray();
            string[] pathsWOExtension = filePathsWithoutExtension.ToArray();

            for (int i = 0; i < names.Length; i++)
            {
                File.Move((paths[i] + "\\" + names[i]), (paths[i] + "\\" + pathsWOExtension[i] + ".mp4"));
            }
            nameField.Items.Clear();
            Array.Clear(paths, 0, paths.Length);
            Array.Clear(names, 0, names.Length);
            Array.Clear(pathsWOExtension, 0, pathsWOExtension.Length);
            Array.Clear(droppedFiles, 0, droppedFiles.Length);
            filePaths.Clear();
            fileNames.Clear();
            filePathsWithoutExtension.Clear();
        }

        private void TojpgButton_Click(object sender, EventArgs e)
        {
            string[] paths = filePaths.ToArray();
            string[] names = fileNames.ToArray();
            string[] pathsWOExtension = filePathsWithoutExtension.ToArray();

            for (int i = 0; i < names.Length; i++)
            {
                File.Move((paths[i] + "\\" + names[i]), (paths[i] + "\\" + pathsWOExtension[i] + ".jpg"));
            }
            nameField.Items.Clear();
            Array.Clear(paths, 0, paths.Length);
            Array.Clear(names, 0, names.Length);
            Array.Clear(pathsWOExtension, 0, pathsWOExtension.Length);
            Array.Clear(droppedFiles, 0, droppedFiles.Length);
            filePaths.Clear();
            fileNames.Clear();
            filePathsWithoutExtension.Clear();
        }
    }
}