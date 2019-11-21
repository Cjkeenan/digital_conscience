using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (messageText.Focused)
                messageText.SelectAll();
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
                var messageStatusDlg = MessageBox.Show("Message Sent Succesfully", "Message Status", MessageBoxButtons.OK);
                this.Close();
            }
            
        }

        private bool ScanText(string text)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '\n', ';'};
            string[] textArray = text.Split(delimiterChars);
            List<string> tabooWords = PullTabooWords();

            bool flag = false;         

            foreach(string taboo in tabooWords)
            {
                foreach(string word in textArray)
                {
                    if (word.Contains(taboo, StringComparison.OrdinalIgnoreCase))
                        flag = true;
                }
            }
            return flag;
        }

        public void TabooDialog()
        {
            var tabooDlg = MessageBox.Show("Your message contained words that are common with those that are considered hostile or hateful.\nAre you sure you want to post this ?", "Warning Message", MessageBoxButtons.YesNo);
            if (tabooDlg == System.Windows.Forms.DialogResult.Yes)
            {
                var messageStatusDlg = MessageBox.Show("Message Sent Succesfully","Message Status", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private List<string> PullTabooWords()
        {
            List<string> tabooWords = new List<string>();
            tabooWords.Add("hello");
            tabooWords.Add("message");
            return tabooWords;
        }
    }
}