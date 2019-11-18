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
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearButton.Location = new System.Drawing.Point(37, 111);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 25);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(216, 98);
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
            this.messageText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageText.Location = new System.Drawing.Point(22, 15);
            this.messageText.Name = "messageText";
            this.messageText.ShowSelectionMargin = true;
            this.messageText.Size = new System.Drawing.Size(455, 77);
            this.messageText.TabIndex = 3;
            this.messageText.Text = "Enter your message here...";
            this.messageText.UseWaitCursor = true;
            // 
            // InitialWindow
            // 
            this.ClientSize = new System.Drawing.Size(499, 149);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.clearButton);
            this.Name = "InitialWindow";

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RichTextBox messageText;
    }
}

