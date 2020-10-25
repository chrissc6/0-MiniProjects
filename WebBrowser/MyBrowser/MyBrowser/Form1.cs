using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //searchBar
        private void locationCboxtoolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                webBrowser1.Navigate(locationCboxtoolStripComboBox1.Text);
            }
        }

        //backBtn
        private void backBtntoolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        //forwardBtn
        private void forwardBtntoolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        //goBtn
        private void goBtntoolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(locationCboxtoolStripComboBox1.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //window title bar
            Text = "MyBrowser - " + webBrowser1.Document.Title;
        }
    }
}
