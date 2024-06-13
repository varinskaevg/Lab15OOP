namespace Lab15OOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbHost = new TextBox();
            tbUser = new TextBox();
            tbPass = new TextBox();
            btnConnect = new Button();
            groupBox1 = new GroupBox();
            label13 = new Label();
            tbUnikue = new TextBox();
            label12 = new Label();
            tbFileModifiedTime = new TextBox();
            tbNewName = new TextBox();
            label11 = new Label();
            label10 = new Label();
            tbOldName = new TextBox();
            btnStoreUnique = new Button();
            btnListDirectoryDetail = new Button();
            btnListDirectory = new Button();
            btnGetModifiedTime = new Button();
            btnRename = new Button();
            tbDownloadFile = new TextBox();
            tbDeleteFile = new TextBox();
            tbDeleteDir = new TextBox();
            tbNewDir = new TextBox();
            tbUpload = new TextBox();
            label8 = new Label();
            btnDownload = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnDeleteFile = new Button();
            btnDeleteDir = new Button();
            tbnCreate = new Button();
            btnUpload = new Button();
            label9 = new Label();
            textBox9 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            tvFtpContent = new TreeView();
            cbFullView = new CheckBox();
            btnUploadFiles = new Button();
            btnUploadDirectory = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "Хост:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 55);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 1;
            label2.Text = "Ім'я користувача:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 92);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Пароль:";
            // 
            // tbHost
            // 
            tbHost.Location = new Point(165, 16);
            tbHost.Name = "tbHost";
            tbHost.Size = new Size(297, 27);
            tbHost.TabIndex = 3;
            // 
            // tbUser
            // 
            tbUser.Location = new Point(165, 52);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(297, 27);
            tbUser.TabIndex = 4;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(165, 85);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(297, 27);
            tbPass.TabIndex = 5;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(468, 8);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(163, 104);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Підключитися та отримати список файлів та каталогів";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(tbUnikue);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(tbFileModifiedTime);
            groupBox1.Controls.Add(tbNewName);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(tbOldName);
            groupBox1.Controls.Add(btnStoreUnique);
            groupBox1.Controls.Add(btnListDirectoryDetail);
            groupBox1.Controls.Add(btnListDirectory);
            groupBox1.Controls.Add(btnGetModifiedTime);
            groupBox1.Controls.Add(btnRename);
            groupBox1.Controls.Add(tbDownloadFile);
            groupBox1.Controls.Add(tbDeleteFile);
            groupBox1.Controls.Add(tbDeleteDir);
            groupBox1.Controls.Add(tbNewDir);
            groupBox1.Controls.Add(tbUpload);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnDownload);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnDeleteFile);
            groupBox1.Controls.Add(btnDeleteDir);
            groupBox1.Controls.Add(tbnCreate);
            groupBox1.Controls.Add(btnUpload);
            groupBox1.Location = new Point(16, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(615, 402);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Операції з FTP";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(195, 328);
            label13.Name = "label13";
            label13.Size = new Size(48, 20);
            label13.TabIndex = 27;
            label13.Text = "Файл:";
            // 
            // tbUnikue
            // 
            tbUnikue.Location = new Point(279, 325);
            tbUnikue.Name = "tbUnikue";
            tbUnikue.Size = new Size(330, 27);
            tbUnikue.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(195, 288);
            label12.Name = "label12";
            label12.Size = new Size(37, 20);
            label12.TabIndex = 25;
            label12.Text = "Час:";
            // 
            // tbFileModifiedTime
            // 
            tbFileModifiedTime.Location = new Point(279, 285);
            tbFileModifiedTime.Name = "tbFileModifiedTime";
            tbFileModifiedTime.Size = new Size(330, 27);
            tbFileModifiedTime.TabIndex = 24;
            // 
            // tbNewName
            // 
            tbNewName.Location = new Point(413, 245);
            tbNewName.Name = "tbNewName";
            tbNewName.Size = new Size(196, 27);
            tbNewName.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(394, 248);
            label11.Name = "label11";
            label11.Size = new Size(21, 20);
            label11.TabIndex = 22;
            label11.Text = "В:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(195, 248);
            label10.Name = "label10";
            label10.Size = new Size(20, 20);
            label10.TabIndex = 21;
            label10.Text = "З:";
            // 
            // tbOldName
            // 
            tbOldName.Location = new Point(221, 245);
            tbOldName.Name = "tbOldName";
            tbOldName.Size = new Size(167, 27);
            tbOldName.TabIndex = 20;
            // 
            // btnStoreUnique
            // 
            btnStoreUnique.Location = new Point(16, 321);
            btnStoreUnique.Name = "btnStoreUnique";
            btnStoreUnique.Size = new Size(157, 34);
            btnStoreUnique.TabIndex = 19;
            btnStoreUnique.Text = "Унікальне ім'я";
            btnStoreUnique.UseVisualStyleBackColor = true;
            btnStoreUnique.Click += btnStoreUnique_Click;
            // 
            // btnListDirectoryDetail
            // 
            btnListDirectoryDetail.Location = new Point(300, 361);
            btnListDirectoryDetail.Name = "btnListDirectoryDetail";
            btnListDirectoryDetail.Size = new Size(309, 34);
            btnListDirectoryDetail.TabIndex = 18;
            btnListDirectoryDetail.Text = "Список деталей каталогу";
            btnListDirectoryDetail.UseVisualStyleBackColor = true;
            btnListDirectoryDetail.Click += btnListDirectoryDetail_Click;
            // 
            // btnListDirectory
            // 
            btnListDirectory.Location = new Point(0, 361);
            btnListDirectory.Name = "btnListDirectory";
            btnListDirectory.Size = new Size(278, 34);
            btnListDirectory.TabIndex = 17;
            btnListDirectory.Text = "Каталог списку";
            btnListDirectory.UseVisualStyleBackColor = true;
            // 
            // btnGetModifiedTime
            // 
            btnGetModifiedTime.Location = new Point(16, 281);
            btnGetModifiedTime.Name = "btnGetModifiedTime";
            btnGetModifiedTime.Size = new Size(157, 34);
            btnGetModifiedTime.TabIndex = 16;
            btnGetModifiedTime.Text = "Час зміни";
            btnGetModifiedTime.UseVisualStyleBackColor = true;
            btnGetModifiedTime.Click += btnGetModifiedTime_Click;
            // 
            // btnRename
            // 
            btnRename.Location = new Point(16, 241);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(157, 34);
            btnRename.TabIndex = 15;
            btnRename.Text = "Перейменувати";
            btnRename.UseVisualStyleBackColor = true;
            btnRename.Click += btnRename_Click;
            // 
            // tbDownloadFile
            // 
            tbDownloadFile.Location = new Point(279, 201);
            tbDownloadFile.Name = "tbDownloadFile";
            tbDownloadFile.Size = new Size(330, 27);
            tbDownloadFile.TabIndex = 14;
            // 
            // tbDeleteFile
            // 
            tbDeleteFile.Location = new Point(279, 158);
            tbDeleteFile.Name = "tbDeleteFile";
            tbDeleteFile.Size = new Size(330, 27);
            tbDeleteFile.TabIndex = 13;
            // 
            // tbDeleteDir
            // 
            tbDeleteDir.Location = new Point(279, 121);
            tbDeleteDir.Name = "tbDeleteDir";
            tbDeleteDir.Size = new Size(330, 27);
            tbDeleteDir.TabIndex = 12;
            // 
            // tbNewDir
            // 
            tbNewDir.Location = new Point(279, 77);
            tbNewDir.Name = "tbNewDir";
            tbNewDir.Size = new Size(330, 27);
            tbNewDir.TabIndex = 11;
            // 
            // tbUpload
            // 
            tbUpload.Location = new Point(279, 37);
            tbUpload.Name = "tbUpload";
            tbUpload.Size = new Size(330, 27);
            tbUpload.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(195, 201);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 9;
            label8.Text = "Каталог:";
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(16, 194);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(157, 34);
            btnDownload.TabIndex = 8;
            btnDownload.Text = "Завантажити на FTP";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(195, 161);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 7;
            label7.Text = "Файл:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(195, 121);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 6;
            label6.Text = "Каталог:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(195, 80);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 5;
            label5.Text = "Каталог:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 40);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 4;
            label4.Text = "Файл:";
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.Location = new Point(16, 154);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Size = new Size(157, 34);
            btnDeleteFile.TabIndex = 3;
            btnDeleteFile.Text = "Видалити файл";
            btnDeleteFile.UseVisualStyleBackColor = true;
            btnDeleteFile.Click += btnDeleteFile_Click;
            // 
            // btnDeleteDir
            // 
            btnDeleteDir.Location = new Point(16, 114);
            btnDeleteDir.Name = "btnDeleteDir";
            btnDeleteDir.Size = new Size(157, 34);
            btnDeleteDir.TabIndex = 2;
            btnDeleteDir.Text = "Видалити каталог";
            btnDeleteDir.UseVisualStyleBackColor = true;
            btnDeleteDir.Click += btnDeleteDir_Click;
            // 
            // tbnCreate
            // 
            tbnCreate.Location = new Point(16, 73);
            tbnCreate.Name = "tbnCreate";
            tbnCreate.Size = new Size(157, 35);
            tbnCreate.TabIndex = 1;
            tbnCreate.Text = "Створити каталог";
            tbnCreate.UseVisualStyleBackColor = true;
            tbnCreate.Click += tbnCreate_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(16, 33);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(157, 34);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "Розмір файлу";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 552);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 9;
            label9.Text = "Шлях:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(60, 549);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(571, 27);
            textBox9.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tvFtpContent
            // 
            tvFtpContent.Location = new Point(637, 12);
            tvFtpContent.Name = "tvFtpContent";
            tvFtpContent.Size = new Size(381, 397);
            tvFtpContent.TabIndex = 16;
            // 
            // cbFullView
            // 
            cbFullView.AutoSize = true;
            cbFullView.Location = new Point(637, 462);
            cbFullView.Name = "cbFullView";
            cbFullView.Size = new Size(86, 24);
            cbFullView.TabIndex = 17;
            cbFullView.Text = "Повний";
            cbFullView.UseVisualStyleBackColor = true;
            // 
            // btnUploadFiles
            // 
            btnUploadFiles.Location = new Point(637, 415);
            btnUploadFiles.Name = "btnUploadFiles";
            btnUploadFiles.Size = new Size(186, 38);
            btnUploadFiles.TabIndex = 18;
            btnUploadFiles.Text = "Файл";
            btnUploadFiles.UseVisualStyleBackColor = true;
            btnUploadFiles.Click += btnUploadFiles_Click;
            // 
            // btnUploadDirectory
            // 
            btnUploadDirectory.Location = new Point(829, 415);
            btnUploadDirectory.Name = "btnUploadDirectory";
            btnUploadDirectory.Size = new Size(189, 38);
            btnUploadDirectory.TabIndex = 19;
            btnUploadDirectory.Text = "Каталог";
            btnUploadDirectory.UseVisualStyleBackColor = true;
            btnUploadDirectory.Click += btnUploadDirectory_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 578);
            Controls.Add(btnUploadDirectory);
            Controls.Add(btnUploadFiles);
            Controls.Add(cbFullView);
            Controls.Add(tvFtpContent);
            Controls.Add(textBox9);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(btnConnect);
            Controls.Add(tbPass);
            Controls.Add(tbUser);
            Controls.Add(tbHost);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbHost;
        private TextBox tbUser;
        private TextBox tbPass;
        private Button btnConnect;
        private GroupBox groupBox1;
        private Button btnDeleteFile;
        private Button btnDeleteDir;
        private Button tbnCreate;
        private Button btnUpload;
        private Button btnDownload;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tbDownloadFile;
        private TextBox tbDeleteFile;
        private TextBox tbDeleteDir;
        private TextBox tbNewDir;
        private TextBox tbUpload;
        private Label label8;
        private Label label9;
        private TextBox textBox9;
        private OpenFileDialog openFileDialog1;
        private Button btnListDirectoryDetail;
        private Button btnListDirectory;
        private Button btnGetModifiedTime;
        private Button btnRename;
        private Button btnStoreUnique;
        private TextBox tbOldName;
        private TextBox tbNewName;
        private Label label11;
        private Label label10;
        private Label label12;
        private TextBox tbFileModifiedTime;
        private TextBox tbUnikue;
        private Label label13;
        private TreeView tvFtpContent;
        private CheckBox cbFullView;
        private Button btnUploadFiles;
        private Button btnUploadDirectory;
    }
}
