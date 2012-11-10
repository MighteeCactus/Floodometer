using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FloodometerDesktop
{
    public partial class Form1 : Form
    {
        MatchCollection chatMatches;
        Dictionary<string, int> totalData = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void outputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputText.Text = "";
            outputList.Items.Clear();
            outputList.Items.Add(String.Format("Nothing to show"));
            totalData.Clear();
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            if (inputText.Text != "")
            {
                parseText();
                populateData();
            }
        }

        public void parseText() {
            MessengerParser parser = new MessengerParser();
            string pattern;

            if (skypeRadio.Checked)
            {
                pattern = MessengerParser.SKYPE_PATTERN;
            }
            else if (qip9095Radio.Checked)
            {
                pattern = MessengerParser.QIP9095_PATTERN;
            }
            else
            {
                pattern = "";
            }

            chatMatches = parser.parseText(inputText.Text, pattern);
            totalData.Clear();

            GroupCollection groups;

            foreach (Match match in chatMatches)
            {
                groups = match.Groups;

                if (!totalData.ContainsKey(groups[3].Value))
                {
                    totalData.Add(groups[3].Value, 0);
                }
                totalData[groups[3].Value]++;
            }
        }

        public void populateData() {
            outputList.Items.Clear();

            if (totalData.Count > 0)
            {
                outputList.Items.Add(String.Format("People in chat: {0}, Total messages: {1}", totalData.Count, chatMatches.Count));

                foreach (KeyValuePair<string, int> kvp in totalData.OrderBy(key => key.Key))
                {
                    outputList.Items.Add(String.Format("Name: {0}, posts: {1}", kvp.Key, kvp.Value));
                }
            }
            else {
                outputList.Items.Add(String.Format("Nothing to show"));
            }
        }

        private void skypeRadio_CheckedChanged(object sender, EventArgs e)
        {
            parseText();
            populateData();
        }

        private void qip9095Radio_CheckedChanged(object sender, EventArgs e)
        {
            parseText();
            populateData();
        }
    }

    
}
