using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Net.Mail;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        private string filePath = "";
        private string currentlySelectedItemName = "";
        private bool isFile = false;
        private bool copyIsFile = false, isCopied = false;
        private string itemName = "";
        private string copyPath = "";
        DriveInfo[] di = DriveInfo.GetDrives();
        TreeNode curNode;

        //------------------------------------------------------------------------------------------------------------------

        public Form1()
        {
            InitializeComponent();
            treeView1.BeforeSelect += treeView1_BeforeSelect;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            // заполняем дерево 1 поля дисками
            FillDriveNodes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filePathTextBox.Text = filePath;
        }

        //------------------------------------------------------------------------------------------------------------------

        // загрузка поддиректорий перед разверткой узла
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            curNode = e.Node;
            e.Node.Nodes.Clear();
            string[] dirs;
            currentlySelectedItemName = "";
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    //получаем все поддиректории выбранной папки
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            //FillTreeNode(dirNode, dirs[i]);
                            dirNode.Nodes.Add(new TreeNode());
                            e.Node.Nodes.Add(dirNode);
                        }
                        filePath = e.Node.FullPath;
                        isFile = false;
                        loadFilesAndDirectories();
                        filePathTextBox.Text = filePath;
                        removeBackSlash();
                    }
                }

            }
            catch (Exception ex) { }
        }

        //------------------------------------------------------------------------------------------------------------------

        //загрузка поддиректорий перед выделением узла
        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            curNode = e.Node;
            e.Node.Nodes.Clear();
            currentlySelectedItemName = "";
            string[] dirs;

            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            //FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                    filePath = e.Node.FullPath;
                    isFile = false;
                    loadFilesAndDirectories();
                    filePathTextBox.Text = filePath;
                }
            }
            catch (Exception ex) { }
        }

        //------------------------------------------------------------------------------------------------------------------

        //запись дисков в изначальные узлы на форме
        private void FillDriveNodes()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode driveNode = new TreeNode { Text = drive.Name };
                    FillTreeNode(driveNode, drive.Name);
                    treeView1.Nodes.Add(driveNode);
                    curNode = driveNode;
                }
            }
            catch (Exception ex) { }
        }

        //------------------------------------------------------------------------------------------------------------------

        // получаем дочерние узлы для определенного узла
        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception ex) { }
        }

        //------------------------------------------------------------------------------------------------------------------
        //загрузка файлов и папок(директорй)
        public void loadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath = filePath + "\\" + currentlySelectedItemName;
            FileAttributes fileAttr;
            try
            {
                if (isFile)
                {
                    
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    if (!fileDetails.Exists)
                        return;
                    fileNameLabel.Text = fileDetails.Name;
                    fileTypeLabel.Text = fileDetails.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {
                    filePathTextBox.Text = tempFilePath;
                    removeBackSlash();
                    tempFilePath = filePathTextBox.Text;
                    fileAttr = File.GetAttributes(tempFilePath);
                }

                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    
                    fileList = new DirectoryInfo(tempFilePath);
                    FileInfo[] files = fileList.GetFiles(); //загрузка всех файлов
                    DirectoryInfo[] dirs = fileList.GetDirectories(); //загрузка всех директорий
                    string fileExtension = "";
                    listView1.Items.Clear();

                    //обработка изображений различных типов файлов
                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        switch (fileExtension)
                        {
                            case ".GIF":
                                listView1.Items.Add(files[i].Name, 51);
                                break;
                            case ".ISO":
                                listView1.Items.Add(files[i].Name, 1);
                                break;
                            case ".PPT":
                                listView1.Items.Add(files[i].Name, 2);
                                break;
                            case ".PDF":
                                listView1.Items.Add(files[i].Name, 3);
                                break;
                            case ".DOC":
                                listView1.Items.Add(files[i].Name, 4);
                                break;
                            case ".CAD":
                                listView1.Items.Add(files[i].Name, 5);
                                break;
                            case ".PSD":
                                listView1.Items.Add(files[i].Name, 6);
                                break;
                            case ".RTF":
                                listView1.Items.Add(files[i].Name, 7);
                                break;
                            case ".SWF":
                                listView1.Items.Add(files[i].Name, 8);
                                break;
                            case ".HLP":
                                listView1.Items.Add(files[i].Name, 9);
                                break;
                            case ".JAVA":
                                listView1.Items.Add(files[i].Name, 10);
                                break;
                            case ".MOV":
                                listView1.Items.Add(files[i].Name, 11);
                                break;
                            case ".AUT":
                                listView1.Items.Add(files[i].Name, 12);
                                break;
                            case ".BIN":
                                listView1.Items.Add(files[i].Name, 13);
                                break;
                            case ".EXE":
                                listView1.Items.Add(files[i].Name, 14);
                                break;
                            case ".DB":
                                listView1.Items.Add(files[i].Name, 15);
                                break;
                            case ".FLAC":
                                listView1.Items.Add(files[i].Name, 16);
                                break;
                            case ".DWF":
                                listView1.Items.Add(files[i].Name, 17);
                                break;
                            case ".JS":
                                listView1.Items.Add(files[i].Name, 18);
                                break;
                            case ".RSS":
                                listView1.Items.Add(files[i].Name, 19);
                                break;
                            case ".TIFF":
                                listView1.Items.Add(files[i].Name, 20);
                                break;
                            case ".XLSX":
                                listView1.Items.Add(files[i].Name, 21);
                                break;
                            case ".PS":
                                listView1.Items.Add(files[i].Name, 22);
                                break;
                            case ".SYS":
                                listView1.Items.Add(files[i].Name, 23);
                                break;
                            case ".DOCX":
                                listView1.Items.Add(files[i].Name, 24);
                                break;
                            case ".DWG":
                                listView1.Items.Add(files[i].Name, 25);
                                break;
                            case ".MPG":
                                listView1.Items.Add(files[i].Name, 26);
                                break;
                            case ".MP4":
                                listView1.Items.Add(files[i].Name, 27);
                                break;
                            case ".AL":
                                listView1.Items.Add(files[i].Name, 28);
                                break;
                            case ".HTML":
                                listView1.Items.Add(files[i].Name, 29);
                                break;
                            case ".HTM":
                                listView1.Items.Add(files[i].Name, 30);
                                break;
                            case ".AAC":
                                listView1.Items.Add(files[i].Name, 31);
                                break;
                            case ".BMP":
                                listView1.Items.Add(files[i].Name, 32);
                                break;
                            case ".PHP":
                                listView1.Items.Add(files[i].Name, 33);
                                break;
                            case ".MKV":
                                listView1.Items.Add(files[i].Name, 34);
                                break;
                            case ".SVG":
                                listView1.Items.Add(files[i].Name, 35);
                                break;
                            case ".TXT":
                                listView1.Items.Add(files[i].Name, 36);
                                break;
                            case ".ACE":
                                listView1.Items.Add(files[i].Name, 37);
                                break;
                            case ".CSS":
                                listView1.Items.Add(files[i].Name, 38);
                                break;
                            case ".EPS":
                                listView1.Items.Add(files[i].Name, 39);
                                break;
                            case ".DMG":
                                listView1.Items.Add(files[i].Name, 40);
                                break;
                            case ".RAR":
                                listView1.Items.Add(files[i].Name, 41);
                                break;
                            case ".INI":
                                listView1.Items.Add(files[i].Name, 42);
                                break;
                            case ".XLS":
                                listView1.Items.Add(files[i].Name, 43);
                                break;
                            case ".MP3":
                                listView1.Items.Add(files[i].Name, 44);
                                break;
                            case ".ZIP":
                                listView1.Items.Add(files[i].Name, 45);
                                break;
                            case ".AVI":
                                listView1.Items.Add(files[i].Name, 46);
                                break;
                            case ".JPG":
                                listView1.Items.Add(files[i].Name, 47);
                                break;
                            case ".CDR":
                                listView1.Items.Add(files[i].Name, 48);
                                break;
                            case ".PNG":
                                listView1.Items.Add(files[i].Name, 49);
                                break;
                            default:
                                listView1.Items.Add(files[i].Name, 51);
                                break;
                        }

                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 0);
                    }
                }
                else
                {
                    fileNameLabel.Text = this.currentlySelectedItemName;
                }
            }
            catch (Exception ex) { }
        }

        //------------------------------------------------------------------------------------------------------------------

        //переход в новый реестр (диекторию)
        public void loadButtonAction()
        {
            removeBackSlash();
            filePath = filePathTextBox.Text;
            loadFilesAndDirectories();
            isFile = false;
            removeBackSlash();
        }

        //------------------------------------------------------------------------------------------------------------------

        //удаление ненужного слэша в конце строки месторасположения (ели есть)
        public void removeBackSlash()
        {
            string path = filePathTextBox.Text;
            if (path.LastIndexOf("\\") == path.Length - 1)
            {
                filePathTextBox.Text = path.Substring(0, path.Length - 1);
            }
        }

        //------------------------------------------------------------------------------------------------------------------

        //переход к прошлой директории
        public void goBack()
        {
            try
            {
                removeBackSlash();
                string path = filePathTextBox.Text;
                path = path.Substring(0, path.LastIndexOf("\\"));
                filePath = path;
                this.isFile = false;
                filePathTextBox.Text = path;
                currentlySelectedItemName = "";
                loadFilesAndDirectories();
                removeBackSlash();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

        }

        //------------------------------------------------------------------------------------------------------------------

        //выбор файла во втором поле (списке)
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;
            filePath = filePathTextBox.Text;
            FileAttributes fileAttr = File.GetAttributes(filePath + "\\" + currentlySelectedItemName);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
            }
            else
            {
                isFile = true;
            }
            string tempFilePath = "";
            //если это файл, показываем его имя и расширение
            if (isFile)
            {
                tempFilePath = filePath + "\\" + currentlySelectedItemName;
                FileInfo fileDetails = new FileInfo(tempFilePath);
                fileNameLabel.Text = fileDetails.Name;
                fileTypeLabel.Text = fileDetails.Extension;

            }
            else
            {
                fileNameLabel.Text = "--";
                fileTypeLabel.Text = "--";
            }
        }

        //------------------------------------------------------------------------------------------------------------------

        //открытие поддиректорий
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        //------------------------------------------------------------------------------------------------------------------

        //обработка кнопки "назад"
        private void backButton_Click(object sender, EventArgs e)
        {
            goBack();
            loadButtonAction();
        }

        //------------------------------------------------------------------------------------------------------------------

        //обработка кнопки "перемещение"
        private void Move_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Перемещение";
            sfd.FileName = currentlySelectedItemName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (isFile)
                {
                    System.IO.File.Move(filePathTextBox.Text + "\\" + currentlySelectedItemName, sfd.FileName);
                }
                else
                {
                    System.IO.Directory.Move(filePathTextBox.Text + "\\" + currentlySelectedItemName, sfd.FileName);
                }
            }
            Refresh_Files();
        }

 //------------------------------------------------------------------------------------------------------------------

        //обработка кнопки "удаление"
        private void Delete_Click(object sender, EventArgs e)
        {
            string filename = filePathTextBox.Text + "\\" + currentlySelectedItemName;
            if (isFile)
            {
                // Delete a file
                if (System.IO.File.Exists(filename))
                {
                    try
                    {
                        System.IO.File.Delete(filename);
                    }
                    catch (System.IO.IOException exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
            }
            else
            {
                // Delete a directory and all subdirectories
                if (System.IO.Directory.Exists(filename))
                {
                    try
                    {
                        System.IO.Directory.Delete(filename, true);
                    }

                    catch (System.IO.IOException exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
            }
            Refresh_Files();
        }

//------------------------------------------------------------------------------------------------------------------

        //обработка кнопки "переименовать"

        private void Rename_Click(object sender, EventArgs e)
        {
            RenameForm rForm = new RenameForm();
            rForm.ShowDialog();
            string filename = rForm.value;
            if (filename != "")
            {
                if (isFile)
                {
                    System.IO.File.Move(filePathTextBox.Text + "\\" + currentlySelectedItemName, filePathTextBox.Text + "\\" + filename);
                }
                else
                {
                    System.IO.Directory.Move(filePathTextBox.Text + "\\" + currentlySelectedItemName, filePathTextBox.Text + "\\" + filename);
                }
            }
            Refresh_Files();
        }

//------------------------------------------------------------------------------------------------------------------

        //обработка кнопки "копировать"
        private void Copy_Click(object sender, EventArgs e)
        {
            isCopied = true;
            if (isFile)
            {
                copyPath = filePathTextBox.Text;
                itemName = currentlySelectedItemName;
                copyIsFile = true;
            }
            else
            {
                copyPath = filePathTextBox.Text;
                itemName = currentlySelectedItemName;
                copyIsFile = false;
            }
        }

//------------------------------------------------------------------------------------------------------------------

        //обновление информации 
        private void Refresh_Files()
        {
            currentlySelectedItemName = "";
            isFile = false;
            loadFilesAndDirectories();
        }

//------------------------------------------------------------------------------------------------------------------

        //обработка кнопки "добавить"
        private void Add_Click(object sender, EventArgs e)
        {
            string destination = filePathTextBox.Text;
            string subpath = @"New folder";
            DirectoryInfo dirInfo = new DirectoryInfo(destination);
            if (!dirInfo.Exists)
            {
            dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);
            Refresh_Files();
        }

//------------------------------------------------------------------------------------------------------------------

        //обработка кнопки "вставить"
        private void Paste_Click(object sender, EventArgs e)
        {
            string destination = filePathTextBox.Text;
            if (isCopied)
            {
                if (!copyIsFile)
                {
                    DirectoryCopy(copyPath + "\\" + itemName, destination + "\\" + itemName, true);
                }
                else
                {
                    System.IO.File.Copy(copyPath + "\\" + itemName, destination + "\\" + itemName, true);
                }
            }
            Refresh_Files();
        }

//------------------------------------------------------------------------------------------------------------------

        //копирование директорий
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            try
            {
                DirectoryInfo dir = new DirectoryInfo(sourceDirName);

                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException(
                        "Source directory does not exist or could not be found: "
                        + sourceDirName);
                }

                DirectoryInfo[] dirs = dir.GetDirectories();
                // If the destination directory doesn't exist, create it.
                if (!Directory.Exists(destDirName))
                {
                    Directory.CreateDirectory(destDirName);
                }

                // Get the files in the directory and copy them to the new location.
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string temppath = Path.Combine(destDirName, file.Name);
                    file.CopyTo(temppath, false);
                }

                // If copying subdirectories, copy them and their contents to new location.
                if (copySubDirs)
                {
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        string temppath = Path.Combine(destDirName, subdir.Name);
                        DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                    }
                }
            }
            catch (Exception e) 
            {
                    Console.WriteLine(e.Message);
            }
        }

//------------------------------------------------------------------------------------------------------------------

        //обработка кнопки "шифровать"
        private void Crypt_Click(object sender, EventArgs e)
        {
            string catalog = @"C:\";
            string fileName = "CryptApplication.exe";
            string cur = "";
            try
            {
                foreach (string findedFile in Directory.EnumerateFiles(catalog, fileName, SearchOption.AllDirectories))
                {
                    FileInfo FI;//по полному пути к файлу создаём объект класса FileInfo
                    FI = new FileInfo(findedFile);
                    cur = FI.FullName;
                }
            }
            catch
            {
                
            }
            System.Diagnostics.Process.Start(cur);
            Refresh_Files();
        }
    }
}
                
