namespace FileExplorer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Delete = new System.Windows.Forms.Button();
            this.Crypt = new System.Windows.Forms.Button();
            this.Rename = new System.Windows.Forms.Button();
            this.Move = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Add);
            this.splitContainer1.Panel2.Controls.Add(this.Delete);
            this.splitContainer1.Panel2.Controls.Add(this.Crypt);
            this.splitContainer1.Panel2.Controls.Add(this.Rename);
            this.splitContainer1.Panel2.Controls.Add(this.Move);
            this.splitContainer1.Panel2.Controls.Add(this.Paste);
            this.splitContainer1.Panel2.Controls.Add(this.Copy);
            this.splitContainer1.Panel2.Controls.Add(this.fileTypeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.fileNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.backButton);
            this.splitContainer1.Panel2.Controls.Add(this.filePathTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(853, 455);
            this.splitContainer1.SplitterDistance = 312;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(312, 455);
            this.treeView1.TabIndex = 1;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "unnamed.png");
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(106, 417);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Crypt
            // 
            this.Crypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Crypt.Location = new System.Drawing.Point(4, 388);
            this.Crypt.Name = "Crypt";
            this.Crypt.Size = new System.Drawing.Size(530, 23);
            this.Crypt.TabIndex = 12;
            this.Crypt.Text = "Crypt";
            this.Crypt.UseVisualStyleBackColor = true;
            this.Crypt.Click += new System.EventHandler(this.Crypt_Click);
            // 
            // Rename
            // 
            this.Rename.Location = new System.Drawing.Point(430, 417);
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(75, 23);
            this.Rename.TabIndex = 12;
            this.Rename.Text = "Rename";
            this.Rename.UseVisualStyleBackColor = true;
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // Move
            // 
            this.Move.Location = new System.Drawing.Point(268, 417);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(75, 23);
            this.Move.TabIndex = 10;
            this.Move.Text = "Move";
            this.Move.UseVisualStyleBackColor = true;
            this.Move.Click += new System.EventHandler(this.Move_Click);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(187, 417);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(75, 23);
            this.Paste.TabIndex = 9;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(25, 417);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(75, 23);
            this.Copy.TabIndex = 8;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileTypeLabel.Location = new System.Drawing.Point(401, 38);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(18, 17);
            this.fileTypeLabel.TabIndex = 7;
            this.fileTypeLabel.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(321, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "File Type";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameLabel.Location = new System.Drawing.Point(106, 38);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(18, 17);
            this.fileNameLabel.TabIndex = 5;
            this.fileNameLabel.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Name";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(84, 5);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(441, 20);
            this.filePathTextBox.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(2, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(534, 317);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "unnamed.png");
            this.iconList.Images.SetKeyName(1, "1485481171-45_78626.png");
            this.iconList.Images.SetKeyName(2, "1485481176-35_78643.png");
            this.iconList.Images.SetKeyName(3, "1485481179-20_78631.png");
            this.iconList.Images.SetKeyName(4, "1485481186-12_78653.png");
            this.iconList.Images.SetKeyName(5, "1485481190-11_78634.png");
            this.iconList.Images.SetKeyName(6, "1485481193-16_78646.png");
            this.iconList.Images.SetKeyName(7, "1485481197-43_78642.png");
            this.iconList.Images.SetKeyName(8, "1485481201-44_78640.png");
            this.iconList.Images.SetKeyName(9, "1485481212-18_78652.png");
            this.iconList.Images.SetKeyName(10, "1485481218-50_78644.png");
            this.iconList.Images.SetKeyName(11, "1485481222-34_78647.png");
            this.iconList.Images.SetKeyName(12, "1485481225-15_78620.png");
            this.iconList.Images.SetKeyName(13, "1485481229-41_78622.png");
            this.iconList.Images.SetKeyName(14, "1485481232-42_78611.png");
            this.iconList.Images.SetKeyName(15, "1485481247-46_78655.png");
            this.iconList.Images.SetKeyName(16, "1485481250-40_78651.png");
            this.iconList.Images.SetKeyName(17, "1485481253-14_78614.png");
            this.iconList.Images.SetKeyName(18, "1485481257-48_78629.png");
            this.iconList.Images.SetKeyName(19, "1485481261-32_78621.png");
            this.iconList.Images.SetKeyName(20, "1485481266-39_78617.png");
            this.iconList.Images.SetKeyName(21, "1485481269-37_78645.png");
            this.iconList.Images.SetKeyName(22, "1485481272-49_78630.png");
            this.iconList.Images.SetKeyName(23, "1485481276-33_78618.png");
            this.iconList.Images.SetKeyName(24, "1485481280-36_78637.png");
            this.iconList.Images.SetKeyName(25, "1485481285-17_78610.png");
            this.iconList.Images.SetKeyName(26, "1485481288-31_78641.png");
            this.iconList.Images.SetKeyName(27, "1485481293-19_78648.png");
            this.iconList.Images.SetKeyName(28, "1485481296-47_78633.png");
            this.iconList.Images.SetKeyName(29, "1485481300-38_78657.png");
            this.iconList.Images.SetKeyName(30, "1485481320-28_78613.png");
            this.iconList.Images.SetKeyName(31, "1485481323-10_78656.png");
            this.iconList.Images.SetKeyName(32, "1485481327-3_78628.png");
            this.iconList.Images.SetKeyName(33, "1485481334-23_78624.png");
            this.iconList.Images.SetKeyName(34, "1485481338-30_78636.png");
            this.iconList.Images.SetKeyName(35, "1485481342-5_78632.png");
            this.iconList.Images.SetKeyName(36, "1485481345-9_78619.png");
            this.iconList.Images.SetKeyName(37, "1485481349-22_78649.png");
            this.iconList.Images.SetKeyName(38, "1485481352-26_78627.png");
            this.iconList.Images.SetKeyName(39, "1485481356-27_78638.png");
            this.iconList.Images.SetKeyName(40, "1485481360-4_78615.png");
            this.iconList.Images.SetKeyName(41, "1485481364-21_78609.png");
            this.iconList.Images.SetKeyName(42, "1485481367-29_78625.png");
            this.iconList.Images.SetKeyName(43, "1485481371-7_78635.png");
            this.iconList.Images.SetKeyName(44, "1485481374-8_78623.png");
            this.iconList.Images.SetKeyName(45, "1485481388-2_78639.png");
            this.iconList.Images.SetKeyName(46, "1485481391-25_78654.png");
            this.iconList.Images.SetKeyName(47, "1485481395-6_78650.png");
            this.iconList.Images.SetKeyName(48, "1485481398-24_78616.png");
            this.iconList.Images.SetKeyName(49, "1485481401-1_78612.png");
            this.iconList.Images.SetKeyName(50, "1485481158-13_78658.png");
            this.iconList.Images.SetKeyName(51, "unknown_103657.png");
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(349, 417);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 14;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 455);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Rename;
        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Crypt;
        private System.Windows.Forms.Button Add;
    }
}

