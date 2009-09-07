namespace Reformer
{
    partial class ActionForm
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
            this.components = new System.ComponentModel.Container();
            this.Multi_tabcontrol = new System.Windows.Forms.TabControl();
            this.AddPackages_Tabpage = new System.Windows.Forms.TabPage();
            this.AddPkgExit_button = new System.Windows.Forms.Button();
            this.AddPackages_button = new System.Windows.Forms.Button();
            this.RemovePackages_tabpage = new System.Windows.Forms.TabPage();
            this.CancelDelpkg_button = new System.Windows.Forms.Button();
            this.DelPkg_button = new System.Windows.Forms.Button();
            this.RemPKG_treeview = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsAPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Multi_tabcontrol.SuspendLayout();
            this.AddPackages_Tabpage.SuspendLayout();
            this.RemovePackages_tabpage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Multi_tabcontrol
            // 
            this.Multi_tabcontrol.Controls.Add(this.AddPackages_Tabpage);
            this.Multi_tabcontrol.Controls.Add(this.RemovePackages_tabpage);
            this.Multi_tabcontrol.Location = new System.Drawing.Point(4, 27);
            this.Multi_tabcontrol.Name = "Multi_tabcontrol";
            this.Multi_tabcontrol.SelectedIndex = 0;
            this.Multi_tabcontrol.Size = new System.Drawing.Size(580, 378);
            this.Multi_tabcontrol.TabIndex = 0;
            // 
            // AddPackages_Tabpage
            // 
            this.AddPackages_Tabpage.Controls.Add(this.AddPkgExit_button);
            this.AddPackages_Tabpage.Controls.Add(this.AddPackages_button);
            this.AddPackages_Tabpage.Location = new System.Drawing.Point(4, 22);
            this.AddPackages_Tabpage.Name = "AddPackages_Tabpage";
            this.AddPackages_Tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.AddPackages_Tabpage.Size = new System.Drawing.Size(572, 352);
            this.AddPackages_Tabpage.TabIndex = 0;
            this.AddPackages_Tabpage.Text = "Add Packages";
            this.AddPackages_Tabpage.UseVisualStyleBackColor = true;
            // 
            // AddPkgExit_button
            // 
            this.AddPkgExit_button.Location = new System.Drawing.Point(350, 323);
            this.AddPkgExit_button.Name = "AddPkgExit_button";
            this.AddPkgExit_button.Size = new System.Drawing.Size(105, 23);
            this.AddPkgExit_button.TabIndex = 1;
            this.AddPkgExit_button.Text = "Exit";
            this.AddPkgExit_button.UseVisualStyleBackColor = true;
            // 
            // AddPackages_button
            // 
            this.AddPackages_button.Location = new System.Drawing.Point(461, 323);
            this.AddPackages_button.Name = "AddPackages_button";
            this.AddPackages_button.Size = new System.Drawing.Size(105, 23);
            this.AddPackages_button.TabIndex = 0;
            this.AddPackages_button.Text = "Execute";
            this.AddPackages_button.UseVisualStyleBackColor = true;
            
            // 
            // RemovePackages_tabpage
            // 
            this.RemovePackages_tabpage.Controls.Add(this.CancelDelpkg_button);
            this.RemovePackages_tabpage.Controls.Add(this.DelPkg_button);
            this.RemovePackages_tabpage.Controls.Add(this.RemPKG_treeview);
            this.RemovePackages_tabpage.Location = new System.Drawing.Point(4, 22);
            this.RemovePackages_tabpage.Name = "RemovePackages_tabpage";
            this.RemovePackages_tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.RemovePackages_tabpage.Size = new System.Drawing.Size(572, 352);
            this.RemovePackages_tabpage.TabIndex = 1;
            this.RemovePackages_tabpage.Text = "Remove Packages";
            this.RemovePackages_tabpage.UseVisualStyleBackColor = true;
            // 
            // CancelDelpkg_button
            // 
            this.CancelDelpkg_button.Location = new System.Drawing.Point(338, 323);
            this.CancelDelpkg_button.Name = "CancelDelpkg_button";
            this.CancelDelpkg_button.Size = new System.Drawing.Size(109, 23);
            this.CancelDelpkg_button.TabIndex = 2;
            this.CancelDelpkg_button.Text = "Exit";
            this.CancelDelpkg_button.UseVisualStyleBackColor = true;
            // 
            // DelPkg_button
            // 
            this.DelPkg_button.Location = new System.Drawing.Point(453, 323);
            this.DelPkg_button.Name = "DelPkg_button";
            this.DelPkg_button.Size = new System.Drawing.Size(113, 23);
            this.DelPkg_button.TabIndex = 1;
            this.DelPkg_button.Text = "Delete";
            this.DelPkg_button.UseVisualStyleBackColor = true;
            // 
            // RemPKG_treeview
            // 
            this.RemPKG_treeview.Location = new System.Drawing.Point(6, 6);
            this.RemPKG_treeview.Name = "RemPKG_treeview";
            this.RemPKG_treeview.Size = new System.Drawing.Size(560, 311);
            this.RemPKG_treeview.TabIndex = 0;
            this.RemPKG_treeview.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.RemPKG_treeview_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportABugToolStripMenuItem,
            this.whatsAPackageToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.reportABugToolStripMenuItem.Text = "Report a Bug";
            this.reportABugToolStripMenuItem.Click += new System.EventHandler(this.reportABugToolStripMenuItem_Click);
            // 
            // whatsAPackageToolStripMenuItem
            // 
            this.whatsAPackageToolStripMenuItem.Name = "whatsAPackageToolStripMenuItem";
            this.whatsAPackageToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.whatsAPackageToolStripMenuItem.Text = "What\'s a package?";
            this.whatsAPackageToolStripMenuItem.Click += new System.EventHandler(this.whatsAPackageToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please note that all changes are done in real-time and are not undo-able so BE CA" +
                "REFUL!";
            // 
            // ActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Multi_tabcontrol);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ActionForm";
            this.Text = "Reformer";
            this.Load += new System.EventHandler(this.ActionForm_Load);
            this.Multi_tabcontrol.ResumeLayout(false);
            this.AddPackages_Tabpage.ResumeLayout(false);
            this.RemovePackages_tabpage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Multi_tabcontrol;
        private System.Windows.Forms.TabPage AddPackages_Tabpage;
        private System.Windows.Forms.TabPage RemovePackages_tabpage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsAPackageToolStripMenuItem;
        private System.Windows.Forms.Button AddPkgExit_button;
        private System.Windows.Forms.Button AddPackages_button;
        private System.Windows.Forms.Button CancelDelpkg_button;
        private System.Windows.Forms.Button DelPkg_button;
        private System.Windows.Forms.TreeView RemPKG_treeview;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
    }
}