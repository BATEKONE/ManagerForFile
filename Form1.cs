using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Manager
{
    public partial class Form1 : Form
    {
        private string filePath = "C:";
        private bool isFile = false;
        private string currentlySelectedItemName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filePathTextBox.Text = filePath;
            loadFilesAndDirectories();
        }

        public void loadFilesAndDirectories()
        {
            DirectoryInfo filelist;
            string tempFilePath = "";
            FileAttributes fileAttributes;
            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileNameLabel.Text = fileDetails.Name;
                    fileTypeLabel.Text = fileDetails.Extension;
                    fileAttributes = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAttributes = File.GetAttributes(filePath);
                }

                if((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    filelist = new DirectoryInfo(filePath);
                    FileInfo[] files = filelist.GetFiles();                 // Получаем все файлы
                    DirectoryInfo[] dirs = filelist.GetDirectories();       // Получаем все директории
                    string fileExtension = "";
                    listView1.Items.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        switch (fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                listView1.Items.Add(files[i].Name, 1);
                                break;
                            case ".EXE":
                            case ".COM":
                                listView1.Items.Add(files[i].Name, 0);
                                break;
                            case ".TXT":
                                listView1.Items.Add(files[i].Name, 8);
                                break;

                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                listView1.Items.Add(files[i].Name, 3);
                                break;
                            case ".PDF":
                                listView1.Items.Add(files[i].Name, 6);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView1.Items.Add(files[i].Name, 2);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView1.Items.Add(files[i].Name, 5);
                                break;

                            default:
                                listView1.Items.Add(files[i].Name, 8);
                                break;
                        }
                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 4);
                    }
                }
                else
                {
                    fileNameLabel.Text = this.currentlySelectedItemName;
                }
            }
            catch(Exception e)
            {

            }
        }

        public void loadButtonAction()
        {
            removeBackSlash();
            filePath = filePathTextBox.Text;
            loadFilesAndDirectories();
            isFile = false;
        }

        public void removeBackSlash()
        {
            string path = filePathTextBox.Text;
            if(path.LastIndexOf("/") == path.Length - 1)
            {
                filePathTextBox.Text = path.Substring(0, path.Length - 1);
            }
        }

        public void goBack()
        {
            try
            {
                removeBackSlash();
                string path =  filePathTextBox.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                filePathTextBox.Text = path;
                removeBackSlash();
            }
            catch (Exception e)
            {

            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;

            FileAttributes fileAttributes = File.GetAttributes(filePath + "/" + currentlySelectedItemName);
            if((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                filePathTextBox.Text = filePath + "/" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            goBack();
            loadButtonAction();
        }

        private void recurse(string soursepath, string newpath, string mydir)
        {
            string nextpath = newpath + "/" + mydir;
            Directory.CreateDirectory(nextpath);
            DirectoryInfo dir = new DirectoryInfo(soursepath);
            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();
            foreach (DirectoryInfo currdir in dirs)
            {
                recurse(soursepath + "/" + currdir, nextpath, "" + currdir);
            }

            foreach (FileInfo currfile in files)
            {
                File.Copy(soursepath + "/" + currfile, nextpath + "/" + currfile);
            }
        }

        private void fileDeleteButton_Click(object sender, EventArgs e)
        {
            if (Path.GetExtension(filePath) == "")
            {
                Directory.Delete(filePath, true);
                loadFilesAndDirectories();
            }
            else
            {
                File.Delete(filePath);
                loadFilesAndDirectories();
            }
        }

        private void fileCopyButton_Click(object sender, EventArgs e)
        {
            if (Path.GetExtension(filePath) == "")
            {
                recurse(filePath, filePathTextBox2.Text, currentlySelectedItemName);
                loadFilesAndDirectories();
            }
            else
            {
                File.Copy(filePath, filePathTextBox2.Text + "/" + currentlySelectedItemName);
                loadFilesAndDirectories();
            }
        }

        private void fileButtonMoving_Click(object sender, EventArgs e)
        {
            Directory.Move(filePath, filePathTextBox2.Text + "/" + currentlySelectedItemName);
            loadFilesAndDirectories();
        }
    }
}
