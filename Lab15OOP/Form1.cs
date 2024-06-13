using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Lab15OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ϳ��������� �� FTP �������
        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectToFtp();
        }

        // ������������ �������� FTP
        private void ConnectToFtp()
        {
            try
            {
                tvFtpContent.Nodes.Clear();
                LoadFtpDirectory(tbHost.Text + "/", null, tbUser.Text, tbPass.Text);
                MessageBox.Show("ϳ��������� ������");
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ����������: " + ex.Message);
            }
        }

        // ������������ ����� FTP ��������
        private void LoadFtpDirectory(string url, TreeNode parentNode, string username, string password)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                request.Credentials = new NetworkCredential(username, password);
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                request.UsePassive = true;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] tokens = line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);

                        if (tokens.Length >= 9)
                        {
                            string name = tokens[8];
                            string permissions = tokens[0];

                            TreeNode node = new TreeNode(name);

                            if (permissions[0] == 'd')
                            {
                                node.Nodes.Add(new TreeNode("������������..."));
                            }

                            if (parentNode == null)
                            {
                                tvFtpContent.Nodes.Add(node);
                            }
                            else
                            {
                                parentNode.Nodes.Add(node);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ������������ ��������: " + ex.Message);
            }
        }

        // ����������� ����� � TreeView ��� ������������ ����������
        private void tvFtpContent_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0 && e.Node.Nodes[0].Text == "������������...")
            {
                e.Node.Nodes.Clear();
                LoadFtpDirectory(tbHost.Text + "/" + e.Node.FullPath.Replace("\\", "/"), e.Node, tbUser.Text, tbPass.Text);
            }
        }

        // ������ ��� ����������� ����� FTP ��������
        private void btnListDirectoryDetail_Click(object sender, EventArgs e)
        {
            ConnectToFtp();
        }

        // ������ ��� ������������ ����� �� FTP ������
        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "�� �����|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;
                    string uploadUrl = tbHost.Text + "/" + Path.GetFileName(fileName);

                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uploadUrl);
                    request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.UsePassive = true;

                    byte[] fileContents = File.ReadAllBytes(fileName);
                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(fileContents, 0, fileContents.Length);
                    }

                    MessageBox.Show(Path.GetFileName(fileName) + " �����������");
                }
                else
                {
                    MessageBox.Show("������������ ���������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ������������: " + ex.Message);
            }
        }

        // ������ ��� ��������� ������ �������� �� FTP ������
        private void tbnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + "/" + tbNewDir.Text);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                request.UsePassive = true;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("������� " + tbNewDir.Text + " ��������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ��������� ��������: " + ex.Message);
            }
        }

        // ������ ��� ��������� ����� �� FTP ������
        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + "/" + tbDeleteFile.Text);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.DeleteFile;
                request.UsePassive = true;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("���� " + tbDeleteFile.Text + " ��������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ��������� �����: " + ex.Message);
            }
        }

        // ������ ��� ��������� �������� �� FTP ������
        private void btnDeleteDir_Click(object sender, EventArgs e)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + "/" + tbDeleteDir.Text);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.RemoveDirectory;
                request.UsePassive = true;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("������� " + tbDeleteDir.Text + " ��������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ��������� ��������: " + ex.Message);
            }
        }

        // ������ ��� ������������ ����� � FTP �������
        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + "/" + tbDownloadFile.Text);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.UsePassive = true;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (FileStream fileStream = new FileStream(tbDownloadFile.Text, FileMode.Create))
                {
                    responseStream.CopyTo(fileStream);
                }

                MessageBox.Show("���� " + tbDownloadFile.Text + " �����������");
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ������������ �����: " + ex.Message);
            }
        }

        // ������ ��� �������������� ����� �� FTP ������
        private void btnRename_Click(object sender, EventArgs e)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + "/" + tbOldName.Text);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.Rename;
                request.RenameTo = tbNewName.Text;
                request.UsePassive = true;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("���� " + tbOldName.Text + " ������������� �� " + tbNewName.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ��������������: " + ex.Message);
            }
        }

        // ������ ��� ��������� ���� �������� ����������� ����� �� FTP ������
        private void btnGetModifiedTime_Click(object sender, EventArgs e)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + "/" + tbFileModifiedTime.Text);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.GetDateTimestamp;
                request.UsePassive = true;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("��� �������� ����������� �����: " + response.LastModified);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ��������� ���� �����������: " + ex.Message);
            }
        }

        // ������ ��� ������������ ����� � ��������� ������ �� FTP ������
        private void btnStoreUnique_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "�� �����|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    tbUnikue.Text = openFileDialog1.FileName;

                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + "/" + Path.GetFileName(tbUnikue.Text));
                    request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                    request.Method = WebRequestMethods.Ftp.UploadFileWithUniqueName;
                    request.UsePassive = true;

                    byte[] file = File.ReadAllBytes(tbUnikue.Text);
                    using (Stream strz = request.GetRequestStream())
                    {
                        strz.Write(file, 0, file.Length);
                    }

                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {
                        MessageBox.Show("���� ����������� � ��������� ������: " + response.ResponseUri);
                    }
                }
                else
                {
                    MessageBox.Show("������������ ���������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ������������ �����: " + ex.Message);
            }
        }

        // ������ ��� ������������ ������ ����� �� FTP ������
        private void btnUploadFiles_Click(object sender, EventArgs e)
        {
            UploadFiles();
        }

        // ������������ ������ ����� �� FTP ������
        private void UploadFiles()
        {
            try
            {
                openFileDialog1.Filter = "�� �����|*.*";
                openFileDialog1.Multiselect = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog1.FileNames)
                    {
                        string safeFileName = Path.GetFileName(fileName);
                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + "/" + safeFileName);
                        request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                        request.Method = WebRequestMethods.Ftp.UploadFile;
                        request.UsePassive = true;

                        byte[] fileContents = File.ReadAllBytes(fileName);
                        using (Stream requestStream = request.GetRequestStream())
                        {
                            requestStream.Write(fileContents, 0, fileContents.Length);
                        }
                    }

                    MessageBox.Show("����� �����������");
                }
                else
                {
                    MessageBox.Show("������������ ���������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ������������ �����: " + ex.Message);
            }
        }

        // ������ ��� ������������ �������� �� FTP ������
        private void btnUploadDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderDialog = new FolderBrowserDialog();
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderDialog.SelectedPath;
                    string folderName = Path.GetFileName(folderPath);

                    UploadDirectory(folderPath, tbHost.Text + "/" + folderName);

                    MessageBox.Show("������� �����������");
                }
                else
                {
                    MessageBox.Show("������������ ���������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ������������ ��������: " + ex.Message);
            }
        }

        // ������������ �������� �� FTP ������
        private void UploadDirectory(string sourceDir, string targetDir)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(targetDir);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;
            request.UsePassive = true;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse()) { }
            }
            catch (WebException) { }

            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string safeFileName = Path.GetFileName(file);
                FtpWebRequest fileRequest = (FtpWebRequest)WebRequest.Create(targetDir + "/" + safeFileName);
                fileRequest.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                fileRequest.Method = WebRequestMethods.Ftp.UploadFile;
                fileRequest.UsePassive = true;

                byte[] fileContents = File.ReadAllBytes(file);
                using (Stream requestStream = fileRequest.GetRequestStream())
                {
                    requestStream.Write(fileContents, 0, fileContents.Length);
                }
            }

            foreach (string dir in Directory.GetDirectories(sourceDir))
            {
                string safeDirName = Path.GetFileName(dir);
                UploadDirectory(dir, targetDir + "/" + safeDirName);
            }
        }
    }
}
