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
        public InitialWindow()
        {
            InitializeComponent();
            addPictures();
        }

        public void addPictures()
        {
            //string path = @"C:\Users\Colin Keenan\OneDrive\GitHub\Cjkeenan\Digital_Conscience\Digital_Conscience\images\facebook_logo.png";
            Image logo = Image.FromFile(Directory.GetCurrentDirectory() + @"\images\facebook-logo.png");
            this.facebookLogo.Image = logo;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            messageText.Clear();
            addPictures();
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
                var messageStatusDlg = MessageBox.Show("Message Sent Succesfully", "Message Status", MessageBoxButtons.OK);
                this.Close();
            }
            
        }

        private bool ScanText(string text)
        {
            List<string> tabooWords = PullTabooWords();
            CultureInfo culture = new CultureInfo("en-US", false);

            bool flag = false;         

            foreach(string phrase in tabooWords)
            {
                if (culture.CompareInfo.IndexOf(text, phrase, CompareOptions.IgnoreCase) >= 0)
                    flag = true;
            }
            return flag;
        }

        public void TabooDialog()
        {
            var tabooDlg = MessageBox.Show("Your message contained words that are common with those that are considered hostile or hateful.\nAre you sure you want to post this?", "Warning Message", MessageBoxButtons.YesNo);
            if (tabooDlg == System.Windows.Forms.DialogResult.Yes)
            {
                var messageStatusDlg = MessageBox.Show("Message Sent Succesfully","Message Status", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private List<string> PullTabooWords()
        {
            List<string> tabooWords = new List<string>();
            string file = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + @"\badWords.txt");
            string[] split_file = file.Split('\n');
            foreach (string s in split_file)
            {
                tabooWords.Add(s);
            }
            return tabooWords;
        }
    }
}