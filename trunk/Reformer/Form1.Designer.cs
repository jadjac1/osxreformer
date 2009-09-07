namespace Reformer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Path_textbox = new System.Windows.Forms.TextBox();
            this.welcomelabel_label = new System.Windows.Forms.Label();
            this.quickdescription_label = new System.Windows.Forms.Label();
            this.Browse_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContinueButton_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.bug_linklabel = new System.Windows.Forms.LinkLabel();
            this.Browse_openfiledialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Path_textbox
            // 
            this.Path_textbox.Location = new System.Drawing.Point(152, 106);
            this.Path_textbox.Name = "Path_textbox";
            this.Path_textbox.Size = new System.Drawing.Size(283, 20);
            this.Path_textbox.TabIndex = 0;
            // 
            // welcomelabel_label
            // 
            this.welcomelabel_label.AutoSize = true;
            this.welcomelabel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelabel_label.Location = new System.Drawing.Point(247, 3);
            this.welcomelabel_label.Name = "welcomelabel_label";
            this.welcomelabel_label.Size = new System.Drawing.Size(200, 25);
            this.welcomelabel_label.TabIndex = 1;
            this.welcomelabel_label.Text = "Welcome to Reformer";
            // 
            // quickdescription_label
            // 
            this.quickdescription_label.AutoSize = true;
            this.quickdescription_label.Location = new System.Drawing.Point(172, 28);
            this.quickdescription_label.Name = "quickdescription_label";
            this.quickdescription_label.Size = new System.Drawing.Size(354, 26);
            this.quickdescription_label.TabIndex = 2;
            this.quickdescription_label.Text = "Reformer is a utility to add and remove software to the Mac OS X Installer.\r\n\r\n";
            // 
            // Browse_button
            // 
            this.Browse_button.Location = new System.Drawing.Point(441, 103);
            this.Browse_button.Name = "Browse_button";
            this.Browse_button.Size = new System.Drawing.Size(75, 23);
            this.Browse_button.TabIndex = 3;
            this.Browse_button.Text = "Browse";
            this.Browse_button.UseVisualStyleBackColor = true;
            this.Browse_button.Click += new System.EventHandler(this.Browse_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 380);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ContinueButton_button
            // 
            this.ContinueButton_button.Location = new System.Drawing.Point(500, 369);
            this.ContinueButton_button.Name = "ContinueButton_button";
            this.ContinueButton_button.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton_button.TabIndex = 5;
            this.ContinueButton_button.Text = "Continue";
            this.ContinueButton_button.UseVisualStyleBackColor = true;
            this.ContinueButton_button.Click += new System.EventHandler(this.ContinueButton_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(419, 369);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 6;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // bug_linklabel
            // 
            this.bug_linklabel.AutoSize = true;
            this.bug_linklabel.Location = new System.Drawing.Point(149, 369);
            this.bug_linklabel.Name = "bug_linklabel";
            this.bug_linklabel.Size = new System.Drawing.Size(69, 13);
            this.bug_linklabel.TabIndex = 7;
            this.bug_linklabel.TabStop = true;
            this.bug_linklabel.Text = "Submit a bug";
            // 
            // Browse_openfiledialog
            // 
            this.Browse_openfiledialog.FileName = "Mac OS X Install Disk";
            this.Browse_openfiledialog.Filter = "Apple Install Disc ISO|*.iso|Apple Install Disc DMG|*.dmg|All Files|*.\"";
            this.Browse_openfiledialog.Title = "Select your Apple Disc Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select your Apple Install Disk Image Below, if you do not have one click";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(488, 87);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(28, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 156);
            this.label2.TabIndex = 10;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bug_linklabel);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.ContinueButton_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Browse_button);
            this.Controls.Add(this.quickdescription_label);
            this.Controls.Add(this.welcomelabel_label);
            this.Controls.Add(this.Path_textbox);
            this.Name = "Form1";
            this.Text = " Reformer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Path_textbox;
        private System.Windows.Forms.Label welcomelabel_label;
        private System.Windows.Forms.Label quickdescription_label;
        private System.Windows.Forms.Button Browse_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ContinueButton_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.LinkLabel bug_linklabel;
        private System.Windows.Forms.OpenFileDialog Browse_openfiledialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
    }
}

