using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reformer
{
    
    public partial class Form1 : Form
    {
        ActionForm actform = new ActionForm();
        public string DiskImageFilename = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Browse_button_Click(object sender, EventArgs e)
        {
            // Opens up the Browse File Dialog
            Browse_openfiledialog.ShowDialog();
            DiskImageFilename = Browse_openfiledialog.FileName.ToString();
            // Sets the path textbox to the same path that the user selected in the Browse_openfiledialog
            Path_textbox.Text = DiskImageFilename;
            // Updates the form
            this.Update();
            // Refreshes the textbox
            Path_textbox.Refresh();
            //Redraws the Form, with updated changes to the path textbox
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Warns the user that the program needs to be in root!
            MessageBox.Show("YOU MUST BE RUNNING THIS IN ROOT! YOU MUST ALSO HAVE HFS+ MOUNTING CAPABILITY!");
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            //Exits program when they click Cancel
            Application.Exit();
        }

        private void ContinueButton_button_Click(object sender, EventArgs e)
        {
            //This will be changed in the near-future, instead of this going here there will be a dialog for making a backup of the ISO, and mounting it as Read-Write
            actform.ShowDialog();

        }
    }
}
