using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Conscience
{
    public partial class InitialWindow : Form
    {
        string path = Directory.GetCurrentDirectory().Replace(@"\bin\Debug\netcoreapp3.0", "");
        public InitialWindow()
        {
            InitializeComponent();
            addPictures();
        }

        public void addPictures()
        {
            facebookLogo.BackgroundImage = Image.FromFile(path + @"\images\facebook-logo.jpg");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            messageText.Clear();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            bool conscienceFlag = ScanText(messageText.Text);
            if (conscienceFlag)
            {
                TabooDialog();
            }
            else
            {
                var messageStatusDlg = MessageBox.Show("Successfully Posted!", "Message Status", MessageBoxButtons.OK);
                addToFeed(messageText.Text);
            }
        }

        private void addToFeed(string text)
        {
            string timestamp = System.DateTime.Now.ToString("MM-dd-yyyy HH:mm  -  ");
            postFeed.AppendText(timestamp + "User: " + text + "\n");
        }

        private bool ScanText(string text)
        {
            List<string> tabooWords = PullTabooWords();
            CultureInfo culture = new CultureInfo("en-US", false);

            foreach(string phrase in tabooWords)
            {
                if (culture.CompareInfo.IndexOf(text, phrase, CompareOptions.IgnoreCase) >= 0)
                    return true;
            }
            return false;
        }

        public void TabooDialog()
        {
            var tabooDlg = MessageBox.Show("These comments may be seen as harrassment.\n\n" +
                "Engaging in these activities may result in the following:\n" +
                "Negative Psychological Effects\n" +
                "Depression\n" +
                "Public Shaming\n" +
                "Criminal Charges\n\n" +
                "Are you sure you want to post this?", "Warning Message", MessageBoxButtons.YesNo);
            if (tabooDlg == System.Windows.Forms.DialogResult.Yes)
            {
                var messageStatusDlg = MessageBox.Show("Succesfully Posted!","Message Status", MessageBoxButtons.OK);
                addToFeed(messageText.Text);
            }
        }

        private List<string> PullTabooWords()
        {
            List<string> tabooWords = new List<string>();
            string file = System.IO.File.ReadAllText(path + @"\badWords.txt");
            string[] split_file = file.Split("\r\n");
            foreach (string s in split_file)
            {
                tabooWords.Add(s);
            }
            return tabooWords;
        }
    }
}