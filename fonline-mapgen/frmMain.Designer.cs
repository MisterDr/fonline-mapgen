﻿namespace fonline_mapgen
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
            this.components = new System.ComponentModel.Container();
            this.btnLoadMap = new System.Windows.Forms.Button();
            this.pnlViewPort = new System.Windows.Forms.Panel();
            this.cmbMaps = new System.Windows.Forms.ComboBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExportImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMapTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewTiles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewRoofs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewCritters = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewItems = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewScenery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewSceneryWalls = new System.Windows.Forms.ToolStripMenuItem();
            this.openMapDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusHex = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusProto = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new fonline_mapgen.DoubleBufferPanel();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlViewPort.SuspendLayout();
            this.menu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadMap
            // 
            this.btnLoadMap.Location = new System.Drawing.Point(538, 22);
            this.btnLoadMap.Name = "btnLoadMap";
            this.btnLoadMap.Size = new System.Drawing.Size(78, 25);
            this.btnLoadMap.TabIndex = 1;
            this.btnLoadMap.Text = "Load Map";
            this.btnLoadMap.UseVisualStyleBackColor = true;
            this.btnLoadMap.Click += new System.EventHandler(this.btnLoadMap_Click);
            // 
            // pnlViewPort
            // 
            this.pnlViewPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlViewPort.AutoScroll = true;
            this.pnlViewPort.Controls.Add(this.panel1);
            this.pnlViewPort.Location = new System.Drawing.Point(0, 52);
            this.pnlViewPort.Name = "pnlViewPort";
            this.pnlViewPort.Size = new System.Drawing.Size(1028, 561);
            this.pnlViewPort.TabIndex = 7;
            this.pnlViewPort.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlViewPort_Scroll);
            // 
            // cmbMaps
            // 
            this.cmbMaps.DropDownWidth = 600;
            this.cmbMaps.FormattingEnabled = true;
            this.cmbMaps.Location = new System.Drawing.Point(15, 25);
            this.cmbMaps.Name = "cmbMaps";
            this.cmbMaps.Size = new System.Drawing.Size(517, 21);
            this.cmbMaps.TabIndex = 10;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.stuffToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.menuView});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1028, 24);
            this.menu.TabIndex = 11;
            this.menu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpen,
            this.toolStripSeparator1,
            this.menuFileExport,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(146, 22);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // menuFileExport
            // 
            this.menuFileExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileExportImage});
            this.menuFileExport.Name = "menuFileExport";
            this.menuFileExport.Size = new System.Drawing.Size(146, 22);
            this.menuFileExport.Text = "Export...";
            // 
            // menuFileExportImage
            // 
            this.menuFileExportImage.Name = "menuFileExportImage";
            this.menuFileExportImage.Size = new System.Drawing.Size(123, 22);
            this.menuFileExportImage.Text = "As Image";
            this.menuFileExportImage.Click += new System.EventHandler(this.menuFileExportImage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // stuffToolStripMenuItem
            // 
            this.stuffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headerToolStripMenuItem,
            this.viewMapTreeToolStripMenuItem});
            this.stuffToolStripMenuItem.Name = "stuffToolStripMenuItem";
            this.stuffToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.stuffToolStripMenuItem.Text = "Map Data";
            // 
            // headerToolStripMenuItem
            // 
            this.headerToolStripMenuItem.Enabled = false;
            this.headerToolStripMenuItem.Name = "headerToolStripMenuItem";
            this.headerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.headerToolStripMenuItem.Text = "Header";
            this.headerToolStripMenuItem.Click += new System.EventHandler(this.headerToolStripMenuItem_Click);
            // 
            // viewMapTreeToolStripMenuItem
            // 
            this.viewMapTreeToolStripMenuItem.CheckOnClick = true;
            this.viewMapTreeToolStripMenuItem.Enabled = false;
            this.viewMapTreeToolStripMenuItem.Name = "viewMapTreeToolStripMenuItem";
            this.viewMapTreeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewMapTreeToolStripMenuItem.Text = "View Tree";
            this.viewMapTreeToolStripMenuItem.Click += new System.EventHandler(this.viewMapTreeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pathsToolStripMenuItem,
            this.performanceToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // pathsToolStripMenuItem
            // 
            this.pathsToolStripMenuItem.Name = "pathsToolStripMenuItem";
            this.pathsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pathsToolStripMenuItem.Text = "Paths";
            this.pathsToolStripMenuItem.Click += new System.EventHandler(this.pathsToolStripMenuItem_Click);
            // 
            // performanceToolStripMenuItem
            // 
            this.performanceToolStripMenuItem.Name = "performanceToolStripMenuItem";
            this.performanceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.performanceToolStripMenuItem.Text = "Performance";
            this.performanceToolStripMenuItem.Click += new System.EventHandler(this.performanceToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.CheckOnClick = true;
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.debugToolStripMenuItem.Text = "Debug Info";
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewTiles,
            this.menuViewRoofs,
            this.menuViewCritters,
            this.menuViewItems,
            this.menuViewScenery});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "View";
            // 
            // menuViewTiles
            // 
            this.menuViewTiles.CheckOnClick = true;
            this.menuViewTiles.Name = "menuViewTiles";
            this.menuViewTiles.Size = new System.Drawing.Size(115, 22);
            this.menuViewTiles.Text = "Tiles";
            this.menuViewTiles.CheckedChanged += new System.EventHandler(this.menuViewTiles_CheckedChanged);
            // 
            // menuViewRoofs
            // 
            this.menuViewRoofs.CheckOnClick = true;
            this.menuViewRoofs.Name = "menuViewRoofs";
            this.menuViewRoofs.Size = new System.Drawing.Size(115, 22);
            this.menuViewRoofs.Text = "Roofs";
            this.menuViewRoofs.CheckedChanged += new System.EventHandler(this.menuViewRoofs_CheckedChanged);
            // 
            // menuViewCritters
            // 
            this.menuViewCritters.CheckOnClick = true;
            this.menuViewCritters.Name = "menuViewCritters";
            this.menuViewCritters.Size = new System.Drawing.Size(115, 22);
            this.menuViewCritters.Text = "Critters";
            this.menuViewCritters.CheckedChanged += new System.EventHandler(this.menuViewCritters_CheckedChanged);
            // 
            // menuViewItems
            // 
            this.menuViewItems.CheckOnClick = true;
            this.menuViewItems.Name = "menuViewItems";
            this.menuViewItems.Size = new System.Drawing.Size(115, 22);
            this.menuViewItems.Text = "Items";
            this.menuViewItems.CheckedChanged += new System.EventHandler(this.menuViewItems_CheckedChanged);
            // 
            // menuViewScenery
            // 
            this.menuViewScenery.CheckOnClick = true;
            this.menuViewScenery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewSceneryWalls});
            this.menuViewScenery.Name = "menuViewScenery";
            this.menuViewScenery.Size = new System.Drawing.Size(115, 22);
            this.menuViewScenery.Text = "Scenery";
            this.menuViewScenery.CheckedChanged += new System.EventHandler(this.menuViewScenery_CheckedChanged);
            // 
            // menuViewSceneryWalls
            // 
            this.menuViewSceneryWalls.CheckOnClick = true;
            this.menuViewSceneryWalls.Name = "menuViewSceneryWalls";
            this.menuViewSceneryWalls.Size = new System.Drawing.Size(102, 22);
            this.menuViewSceneryWalls.Text = "Walls";
            this.menuViewSceneryWalls.CheckedChanged += new System.EventHandler(this.menuViewSceneryWalls_CheckedChanged);
            // 
            // openMapDialog
            // 
            this.openMapDialog.DefaultExt = "fomap";
            this.openMapDialog.Filter = "FOnline map|*.fomap";
            this.openMapDialog.RestoreDirectory = true;
            this.openMapDialog.ShowReadOnly = true;
            this.openMapDialog.SupportMultiDottedExtensions = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus,
            this.toolStripStatusHex,
            this.toolStripStatusProto});
            this.statusStrip1.Location = new System.Drawing.Point(0, 616);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatus.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusHex
            // 
            this.toolStripStatusHex.Name = "toolStripStatusHex";
            this.toolStripStatusHex.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusHex.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusProto
            // 
            this.toolStripStatusProto.Name = "toolStripStatusProto";
            this.toolStripStatusProto.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusProto.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findMapsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // findMapsToolStripMenuItem
            // 
            this.findMapsToolStripMenuItem.Name = "findMapsToolStripMenuItem";
            this.findMapsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.findMapsToolStripMenuItem.Text = "Find Maps";
            this.findMapsToolStripMenuItem.Click += new System.EventHandler(this.findMapsToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1028, 638);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlViewPort);
            this.Controls.Add(this.cmbMaps);
            this.Controls.Add(this.btnLoadMap);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapper experiment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlViewPort.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadMap;
        private System.Windows.Forms.Panel pnlViewPort;
        private DoubleBufferPanel panel1;
        private System.Windows.Forms.ComboBox cmbMaps;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem stuffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.OpenFileDialog openMapDialog;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuViewTiles;
        private System.Windows.Forms.ToolStripMenuItem menuViewRoofs;
        private System.Windows.Forms.ToolStripMenuItem menuViewCritters;
        private System.Windows.Forms.ToolStripMenuItem menuViewItems;
        private System.Windows.Forms.ToolStripMenuItem menuViewScenery;
        private System.Windows.Forms.ToolStripMenuItem menuViewSceneryWalls;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFileExport;
        private System.Windows.Forms.ToolStripMenuItem menuFileExportImage;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMapTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusHex;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusProto;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findMapsToolStripMenuItem;
    }
}

