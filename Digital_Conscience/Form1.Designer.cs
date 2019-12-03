namespace Digital_Conscience
{
    partial class InitialWindow
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
            this.clearButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.messageText = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.facebookLogo = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.createPostTitle = new System.Windows.Forms.TextBox();
            this.postFeed = new System.Windows.Forms.RichTextBox();
            this.feedTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).BeginInit();
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearButton.Location = new System.Drawing.Point(50, 500);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 31);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(452, 496);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(251, 38);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messageText
            // 
            this.messageText.AcceptsTab = true;
            this.messageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageText.Location = new System.Drawing.Point(22, 358);
            this.messageText.Name = "messageText";
            this.messageText.ShowSelectionMargin = true;
            this.messageText.Size = new System.Drawing.Size(691, 132);
            this.messageText.TabIndex = 3;
            this.messageText.Text = "What\'s on your mind?";
            this.messageText.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 48);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // facebookLogo
            // 
            this.facebookLogo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.facebookLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.facebookLogo.ImageLocation = "";
            this.facebookLogo.Location = new System.Drawing.Point(8, 6);
            this.facebookLogo.Name = "facebookLogo";
            this.facebookLogo.Size = new System.Drawing.Size(68, 32);
            this.facebookLogo.TabIndex = 5;
            this.facebookLogo.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(82, 10);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(596, 23);
            this.searchBox.TabIndex = 6;
            this.searchBox.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.searchButton.Location = new System.Drawing.Point(677, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(46, 21);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "🔍";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // createPostTitle
            // 
            this.createPostTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createPostTitle.BackColor = System.Drawing.SystemColors.Control;
            this.createPostTitle.Location = new System.Drawing.Point(22, 336);
            this.createPostTitle.Name = "createPostTitle";
            this.createPostTitle.Size = new System.Drawing.Size(691, 23);
            this.createPostTitle.TabIndex = 8;
            this.createPostTitle.Text = "Create Post";
            // 
            // postFeed
            // 
            this.postFeed.AcceptsTab = true;
            this.postFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postFeed.Location = new System.Drawing.Point(22, 87);
            this.postFeed.Name = "postFeed";
            this.postFeed.ShowSelectionMargin = true;
            this.postFeed.Size = new System.Drawing.Size(691, 226);
            this.postFeed.TabIndex = 3;
            this.postFeed.Text = "";
            this.postFeed.UseWaitCursor = true;
            // 
            // feedTitle
            // 
            this.feedTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feedTitle.BackColor = System.Drawing.SystemColors.Control;
            this.feedTitle.Location = new System.Drawing.Point(22, 64);
            this.feedTitle.Name = "feedTitle";
            this.feedTitle.Size = new System.Drawing.Size(691, 23);
            this.feedTitle.TabIndex = 8;
            this.feedTitle.Text = "Feed";
            // 
            // InitialWindow
            // 
            this.ClientSize = new System.Drawing.Size(735, 547);
            this.Controls.Add(this.createPostTitle);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.facebookLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.postFeed);
            this.Controls.Add(this.feedTitle);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "InitialWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogo)).EndInit();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RichTextBox messageText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox facebookLogo;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox createPostTitle;
        private System.Windows.Forms.RichTextBox postFeed;
        private System.Windows.Forms.TextBox feedTitle;
    }
}

