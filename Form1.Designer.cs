namespace Manager
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
            this.backButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.fileDeleteButton = new System.Windows.Forms.Button();
            this.fileMovingButton = new System.Windows.Forms.Button();
            this.filePathTextBox2 = new System.Windows.Forms.TextBox();
            this.fileButtonMoving = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(713, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.IconList;
            this.listView1.Location = new System.Drawing.Point(12, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 352);
            this.listView1.SmallImageList = this.IconList;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "chrome.ico");
            this.IconList.Images.SetKeyName(1, "itunes.ico");
            this.IconList.Images.SetKeyName(2, "microsoft-word.ico");
            this.IconList.Images.SetKeyName(3, "utorrent.ico");
            this.IconList.Images.SetKeyName(4, "action.ico");
            this.IconList.Images.SetKeyName(5, "aimp.ico");
            this.IconList.Images.SetKeyName(6, "adobe-portfolio.ico");
            this.IconList.Images.SetKeyName(7, "3d-coat.ico");
            this.IconList.Images.SetKeyName(8, "android-studio.ico");
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(93, 13);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(614, 22);
            this.filePathTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "FileName";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(106, 425);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(15, 16);
            this.fileNameLabel.TabIndex = 5;
            this.fileNameLabel.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "FileType";
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(618, 425);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(15, 16);
            this.fileTypeLabel.TabIndex = 7;
            this.fileTypeLabel.Text = "--";
            // 
            // fileDeleteButton
            // 
            this.fileDeleteButton.Location = new System.Drawing.Point(12, 41);
            this.fileDeleteButton.Name = "fileDeleteButton";
            this.fileDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.fileDeleteButton.TabIndex = 8;
            this.fileDeleteButton.Text = "Delete";
            this.fileDeleteButton.UseVisualStyleBackColor = true;
            this.fileDeleteButton.Click += new System.EventHandler(this.fileDeleteButton_Click);
            // 
            // fileMovingButton
            // 
            this.fileMovingButton.Location = new System.Drawing.Point(713, 41);
            this.fileMovingButton.Name = "fileMovingButton";
            this.fileMovingButton.Size = new System.Drawing.Size(75, 23);
            this.fileMovingButton.TabIndex = 10;
            this.fileMovingButton.Text = "Copy";
            this.fileMovingButton.UseVisualStyleBackColor = true;
            // 
            // filePathTextBox2
            // 
            this.filePathTextBox2.Location = new System.Drawing.Point(174, 41);
            this.filePathTextBox2.Name = "filePathTextBox2";
            this.filePathTextBox2.Size = new System.Drawing.Size(533, 22);
            this.filePathTextBox2.TabIndex = 11;
            // 
            // fileButtonMoving
            // 
            this.fileButtonMoving.Location = new System.Drawing.Point(93, 41);
            this.fileButtonMoving.Name = "fileButtonMoving";
            this.fileButtonMoving.Size = new System.Drawing.Size(75, 23);
            this.fileButtonMoving.TabIndex = 12;
            this.fileButtonMoving.Text = "Moving";
            this.fileButtonMoving.UseVisualStyleBackColor = true;
            this.fileButtonMoving.Click += new System.EventHandler(this.fileButtonMoving_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fileButtonMoving);
            this.Controls.Add(this.filePathTextBox2);
            this.Controls.Add(this.fileMovingButton);
            this.Controls.Add(this.fileDeleteButton);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.backButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.Button fileDeleteButton;
        private System.Windows.Forms.Button fileMovingButton;
        private System.Windows.Forms.TextBox filePathTextBox2;
        private System.Windows.Forms.Button fileButtonMoving;
    }
}

