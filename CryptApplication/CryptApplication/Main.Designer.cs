namespace CryptApplication
{
    partial class Crypt
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseFileSrc = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pathToSrc = new System.Windows.Forms.Label();
            this.pathToCrypted = new System.Windows.Forms.Label();
            this.chooseFileCrypted = new System.Windows.Forms.Button();
            this.keyLabel = new System.Windows.Forms.Label();
            this.chooseFileKey = new System.Windows.Forms.Button();
            this.rEncrypt = new System.Windows.Forms.RadioButton();
            this.rDecrypt = new System.Windows.Forms.RadioButton();
            this.genKey = new System.Windows.Forms.Button();
            this.chooseLevel = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.start = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // chooseFileSrc
            // 
            this.chooseFileSrc.Location = new System.Drawing.Point(303, 43);
            this.chooseFileSrc.Name = "chooseFileSrc";
            this.chooseFileSrc.Size = new System.Drawing.Size(177, 26);
            this.chooseFileSrc.TabIndex = 0;
            this.chooseFileSrc.Text = "Обзор";
            this.chooseFileSrc.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pathToSrc
            // 
            this.pathToSrc.Location = new System.Drawing.Point(12, 43);
            this.pathToSrc.Name = "pathToSrc";
            this.pathToSrc.Size = new System.Drawing.Size(285, 26);
            this.pathToSrc.TabIndex = 1;
            this.pathToSrc.Text = "Файл для шифрования";
            // 
            // pathToCrypted
            // 
            this.pathToCrypted.Location = new System.Drawing.Point(12, 83);
            this.pathToCrypted.Name = "pathToCrypted";
            this.pathToCrypted.Size = new System.Drawing.Size(285, 26);
            this.pathToCrypted.TabIndex = 3;
            this.pathToCrypted.Text = "Файл после шифрования";
            // 
            // chooseFileCrypted
            // 
            this.chooseFileCrypted.Location = new System.Drawing.Point(303, 83);
            this.chooseFileCrypted.Name = "chooseFileCrypted";
            this.chooseFileCrypted.Size = new System.Drawing.Size(177, 26);
            this.chooseFileCrypted.TabIndex = 2;
            this.chooseFileCrypted.Text = "Обзор";
            this.chooseFileCrypted.UseVisualStyleBackColor = true;
            this.chooseFileCrypted.Click += new System.EventHandler(this.chooseFileCrypted_Click);
            // 
            // keyLabel
            // 
            this.keyLabel.Location = new System.Drawing.Point(12, 123);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(285, 26);
            this.keyLabel.TabIndex = 5;
            this.keyLabel.Text = "Ключ";
            // 
            // chooseFileKey
            // 
            this.chooseFileKey.Location = new System.Drawing.Point(303, 123);
            this.chooseFileKey.Name = "chooseFileKey";
            this.chooseFileKey.Size = new System.Drawing.Size(75, 26);
            this.chooseFileKey.TabIndex = 4;
            this.chooseFileKey.Text = "Обзор";
            this.chooseFileKey.UseVisualStyleBackColor = true;
            this.chooseFileKey.Click += new System.EventHandler(this.chooseFileKey_Click);
            // 
            // rEncrypt
            // 
            this.rEncrypt.Checked = true;
            this.rEncrypt.Location = new System.Drawing.Point(501, 45);
            this.rEncrypt.Name = "rEncrypt";
            this.rEncrypt.Size = new System.Drawing.Size(287, 24);
            this.rEncrypt.TabIndex = 6;
            this.rEncrypt.TabStop = true;
            this.rEncrypt.Text = "Зашифровать";
            this.rEncrypt.UseVisualStyleBackColor = true;
            this.rEncrypt.CheckedChanged += new System.EventHandler(this.rEncrypt_CheckedChanged);
            // 
            // rDecrypt
            // 
            this.rDecrypt.Location = new System.Drawing.Point(501, 83);
            this.rDecrypt.Name = "rDecrypt";
            this.rDecrypt.Size = new System.Drawing.Size(287, 26);
            this.rDecrypt.TabIndex = 7;
            this.rDecrypt.Text = "Дешифровать";
            this.rDecrypt.UseVisualStyleBackColor = true;
            this.rDecrypt.CheckedChanged += new System.EventHandler(this.rDecrypt_CheckedChanged);
            // 
            // genKey
            // 
            this.genKey.Location = new System.Drawing.Point(384, 123);
            this.genKey.Name = "genKey";
            this.genKey.Size = new System.Drawing.Size(96, 26);
            this.genKey.TabIndex = 8;
            this.genKey.Text = "Сгенерировать";
            this.genKey.UseVisualStyleBackColor = true;
            this.genKey.Click += new System.EventHandler(this.genKey_Click);
            // 
            // chooseLevel
            // 
            this.chooseLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseLevel.FormattingEnabled = true;
            this.chooseLevel.Items.AddRange(new object[] {
            "Простая",
            "Средняя",
            "Сложная"});
            this.chooseLevel.Location = new System.Drawing.Point(501, 123);
            this.chooseLevel.Name = "chooseLevel";
            this.chooseLevel.Size = new System.Drawing.Size(287, 21);
            this.chooseLevel.TabIndex = 9;
            this.chooseLevel.SelectedIndexChanged += new System.EventHandler(this.chooseLevel_SelectedIndexChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 402);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(776, 36);
            this.progressBar.TabIndex = 10;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(185, 212);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(438, 68);
            this.start.TabIndex = 11;
            this.start.Text = "Запуск";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Crypt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = global::CryptApplication.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.chooseLevel);
            this.Controls.Add(this.genKey);
            this.Controls.Add(this.rDecrypt);
            this.Controls.Add(this.rEncrypt);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.chooseFileKey);
            this.Controls.Add(this.pathToCrypted);
            this.Controls.Add(this.chooseFileCrypted);
            this.Controls.Add(this.pathToSrc);
            this.Controls.Add(this.chooseFileSrc);
            this.Name = "Crypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crypt ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chooseFileSrc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label pathToSrc;
        private System.Windows.Forms.Label pathToCrypted;
        private System.Windows.Forms.Button chooseFileCrypted;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Button chooseFileKey;
        private System.Windows.Forms.RadioButton rEncrypt;
        private System.Windows.Forms.RadioButton rDecrypt;
        private System.Windows.Forms.Button genKey;
        private System.Windows.Forms.ComboBox chooseLevel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
    }
}

