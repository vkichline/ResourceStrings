namespace ResourceStrings
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sep1MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.quitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoneMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sep2MenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.findFirstMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvMain = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colResource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusNoStrings = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSelectedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFindLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFind = new System.Windows.Forms.ToolStripStatusLabel();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.aboutToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(433, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuBar";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveMenuItem,
            this.closeMenuItem,
            this.sep1MenuItem,
            this.quitMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveMenuItem.Text = "Save Text";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(163, 22);
            this.closeMenuItem.Text = "Close";
            this.closeMenuItem.Click += new System.EventHandler(this.closeMenuItem_Click);
            // 
            // sep1MenuItem
            // 
            this.sep1MenuItem.Name = "sep1MenuItem";
            this.sep1MenuItem.Size = new System.Drawing.Size(160, 6);
            // 
            // quitMenuItem
            // 
            this.quitMenuItem.Name = "quitMenuItem";
            this.quitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitMenuItem.Size = new System.Drawing.Size(163, 22);
            this.quitMenuItem.Text = "Quit";
            this.quitMenuItem.Click += new System.EventHandler(this.quitMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllMenuItem,
            this.selectNoneMenuItem,
            this.copyMenuItem,
            this.sep2MenuItem,
            this.findFirstMenuItem,
            this.findNextMenuItem,
            this.findAllMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";
            // 
            // selectAllMenuItem
            // 
            this.selectAllMenuItem.Name = "selectAllMenuItem";
            this.selectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllMenuItem.Text = "Select All";
            this.selectAllMenuItem.Click += new System.EventHandler(this.selectAllMenuItem_Click);
            // 
            // selectNoneMenuItem
            // 
            this.selectNoneMenuItem.Name = "selectNoneMenuItem";
            this.selectNoneMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.selectNoneMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectNoneMenuItem.Text = "Select None";
            this.selectNoneMenuItem.Click += new System.EventHandler(this.selectNoneMenuItem_Click);
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyMenuItem.Text = "Copy";
            this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // sep2MenuItem
            // 
            this.sep2MenuItem.Name = "sep2MenuItem";
            this.sep2MenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // findFirstMenuItem
            // 
            this.findFirstMenuItem.Name = "findFirstMenuItem";
            this.findFirstMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findFirstMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findFirstMenuItem.Text = "Find First";
            this.findFirstMenuItem.Click += new System.EventHandler(this.findFirstMenuItem_Click);
            // 
            // findNextMenuItem
            // 
            this.findNextMenuItem.Name = "findNextMenuItem";
            this.findNextMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.findNextMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findNextMenuItem.Text = "Find Next";
            this.findNextMenuItem.Click += new System.EventHandler(this.findNextMenuItem_Click);
            // 
            // findAllMenuItem
            // 
            this.findAllMenuItem.Name = "findAllMenuItem";
            this.findAllMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.findAllMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findAllMenuItem.Text = "Find All";
            this.findAllMenuItem.Click += new System.EventHandler(this.findAllMenuItem_Click);
            // 
            // lvMain
            // 
            this.lvMain.AllowColumnReorder = true;
            this.lvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMain.CausesValidation = false;
            this.lvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colValue,
            this.colResource});
            this.lvMain.FullRowSelect = true;
            this.lvMain.GridLines = true;
            this.lvMain.LabelWrap = false;
            this.lvMain.Location = new System.Drawing.Point(2, 27);
            this.lvMain.Margin = new System.Windows.Forms.Padding(8, 3, 2, 3);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(431, 297);
            this.lvMain.TabIndex = 2;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            this.lvMain.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvMain_ColumnClick);
            this.lvMain.SelectedIndexChanged += new System.EventHandler(this.lvMain_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "";
            this.colName.Width = 144;
            // 
            // colValue
            // 
            this.colValue.Text = "";
            this.colValue.Width = 144;
            // 
            // colResource
            // 
            this.colResource.Text = "";
            this.colResource.Width = 144;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusNoStrings,
            this.statusCountLabel,
            this.statusCount,
            this.statusSelectedLabel,
            this.statusSelected,
            this.statusFindLabel,
            this.statusFind});
            this.statusBar.Location = new System.Drawing.Point(0, 323);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(433, 22);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "statusBar";
            // 
            // statusNoStrings
            // 
            this.statusNoStrings.BackColor = System.Drawing.Color.Red;
            this.statusNoStrings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.statusNoStrings.ForeColor = System.Drawing.Color.White;
            this.statusNoStrings.Name = "statusNoStrings";
            this.statusNoStrings.Size = new System.Drawing.Size(0, 17);
            this.statusNoStrings.Text = "No String Resources Found in This File";
            // 
            // statusCountLabel
            // 
            this.statusCountLabel.BackColor = System.Drawing.SystemColors.Control;
            this.statusCountLabel.Margin = new System.Windows.Forms.Padding(4, 3, 0, 2);
            this.statusCountLabel.Name = "statusCountLabel";
            this.statusCountLabel.Size = new System.Drawing.Size(46, 17);
            this.statusCountLabel.Text = "Strings:";
            // 
            // statusCount
            // 
            this.statusCount.BackColor = System.Drawing.SystemColors.Control;
            this.statusCount.Name = "statusCount";
            this.statusCount.Size = new System.Drawing.Size(13, 17);
            this.statusCount.Text = "0";
            // 
            // statusSelectedLabel
            // 
            this.statusSelectedLabel.BackColor = System.Drawing.SystemColors.Control;
            this.statusSelectedLabel.Margin = new System.Windows.Forms.Padding(8, 3, 0, 2);
            this.statusSelectedLabel.Name = "statusSelectedLabel";
            this.statusSelectedLabel.Size = new System.Drawing.Size(54, 17);
            this.statusSelectedLabel.Text = "Selected:";
            // 
            // statusSelected
            // 
            this.statusSelected.BackColor = System.Drawing.SystemColors.Control;
            this.statusSelected.Name = "statusSelected";
            this.statusSelected.Size = new System.Drawing.Size(13, 17);
            this.statusSelected.Text = "0";
            // 
            // statusFindLabel
            // 
            this.statusFindLabel.BackColor = System.Drawing.SystemColors.Control;
            this.statusFindLabel.Margin = new System.Windows.Forms.Padding(8, 3, 0, 2);
            this.statusFindLabel.Name = "statusFindLabel";
            this.statusFindLabel.Size = new System.Drawing.Size(33, 17);
            this.statusFindLabel.Text = "Find:";
            // 
            // statusFind
            // 
            this.statusFind.BackColor = System.Drawing.SystemColors.Control;
            this.statusFind.Name = "statusFind";
            this.statusFind.Size = new System.Drawing.Size(0, 17);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(433, 345);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.lvMain);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmMain";
            this.Text = "Resource Strings";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.ToolStripSeparator sep1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem selectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectNoneMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripSeparator sep2MenuItem;
        private System.Windows.Forms.ToolStripMenuItem findFirstMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAllMenuItem;
        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.ColumnHeader colResource;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusCount;
        private System.Windows.Forms.ToolStripStatusLabel statusSelectedLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusSelected;
        private System.Windows.Forms.ToolStripStatusLabel statusFindLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusFind;
        private System.Windows.Forms.ToolStripStatusLabel statusNoStrings;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

