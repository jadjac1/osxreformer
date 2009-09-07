using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace Reformer
{
    //Currently this only reads and displays the packages and gets the id and makes an ID for the program to know which item is selected and what to do with it when the user hits the delete button, this part is not finished yet
    public partial class ActionForm : Form
    {

        public FileStream READER = new FileStream("Distribution.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        public XmlDocument doc = new XmlDocument();
        public TreeNode Pkgs = new TreeNode();
        public string ChoiceTitles = null;
        public ArrayList ChoiceArrayList = new ArrayList();
        public Array ChoiceNumbers = null;
        public int ChoiceAmount = 0;
        public string[] pkgidnumber;
        public int SelectedNodeCount = 0;
        public ActionForm()
        {
            InitializeComponent();
            doc.Load(READER);
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exits when they click File>Exit
            Application.Exit();

        }

        private void whatsAPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Simple Explanation of a Mac OS X Package (.pkg)
            MessageBox.Show("A Package is an installer for an Application in Mac OS X, these files are known as .pkg files.  This program cannot add App's, only .pkg files!");
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Opens the Report-A-Bug page on the google code page for Reformer
            System.Diagnostics.Process.Start("firefox http://code.google.com/p/osxreformer/issues/entry");
        }

        private void RemPKG_treeview_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        public void ActionForm_Load(object sender, EventArgs e)
        {
            XmlNodeList choices = doc.GetElementsByTagName("choice");
            
            foreach (XmlNode node in choices)
            {
                if (node.Attributes.Count == 6)
                {
                    // Sets ChoiceTitltes to be the Title of the next item in line
                    ChoiceTitles = node.Attributes["title"].InnerText;
                    // Adds ChoiceTitle (The Title of each item) to ChoiceTitle in order that its in the Distribution File
                    RemPKG_treeview.Nodes.Add(ChoiceTitles);
                    // Increases the choiceamount for later use with finding which choice is selected and that ID, then later it will delete it from the Xmlfile and the package itself
                    ChoiceAmount++;
                    
                   // Selects the pkg-ref subnode of Choice
                    XmlNode pkgrefchoice = doc.SelectSingleNode("installer-gui-script/choice/pkg-ref");
                    // This statement is for declaring the array pkgidnumber, for 
                    foreach (XmlNode Childnode in pkgrefchoice)
                        {
                            pkgidnumber[ChoiceAmount] = pkgrefchoice.Attributes["id"].InnerText; ;

                        }
                    

                }
               
                   
           }
                    

         }


     }
   
}

       
    
