// Alexandra Mugford
// February, 2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgrammingInterviewQuestion
{
    public partial class Form1 : Form
    {
        WebBrowser webBrowser = new WebBrowser();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        OpenFileDialog openFileDialog = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();

            webBrowser.ScriptErrorsSuppressed = true; //suppress script error warnings

            webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
        }

        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            setActionButtonsEnabled(true); //re-enable the buttons
            if (webBrowser.Document != null)
            {
                HtmlElementCollection images = webBrowser.Document.GetElementsByTagName("IMG"); //checks html for the img tag

                foreach (HtmlElement img in images)
                {
                    DisplayBox.Text += img.GetAttribute("src") + "\n"; //adds the image src to the display box
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = ""; //clears the text box for next use
            setActionButtonsEnabled(false); //disable the buttons while parsing
            webBrowser.Navigate(WebsiteInput.Text); //navigates to the website specified
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text Documents (*.txt)|*.txt|All Files (.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, DisplayBox.Text);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text Documents (*.txt)|*.txt|All Files (.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DisplayBox.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
            }
        }

        //function to disable/enable the buttons
        private void setActionButtonsEnabled(Boolean enabled)
        {
            ParseButton.Enabled = enabled;
            SaveButton.Enabled = enabled;
            LoadButton.Enabled = enabled;
        }

    }
}
