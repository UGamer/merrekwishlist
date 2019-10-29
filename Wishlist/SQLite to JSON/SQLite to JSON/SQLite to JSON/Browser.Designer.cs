﻿namespace SQLite_to_JSON
{
    partial class Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.DownloadButton = new System.Windows.Forms.Button();
            this.AddressBar = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BrowserDock = new System.Windows.Forms.Panel();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BookmarkBar = new System.Windows.Forms.ToolStrip();
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.OpacitySlider = new System.Windows.Forms.TrackBar();
            this.LockButton = new System.Windows.Forms.Button();
            this.FavoriteButton = new System.Windows.Forms.Button();
            this.TabContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CloseTabButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BrowserDock.SuspendLayout();
            this.Tabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacitySlider)).BeginInit();
            this.TabContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(139, 5);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(38, 23);
            this.DownloadButton.TabIndex = 1;
            this.DownloadButton.Text = "V";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // AddressBar
            // 
            this.AddressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressBar.Location = new System.Drawing.Point(183, 7);
            this.AddressBar.Name = "AddressBar";
            this.AddressBar.Size = new System.Drawing.Size(624, 20);
            this.AddressBar.TabIndex = 2;
            this.AddressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressBar_KeyDown);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(807, 6);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(30, 22);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "🔍";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BrowserDock
            // 
            this.BrowserDock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowserDock.Controls.Add(this.Tabs);
            this.BrowserDock.Controls.Add(this.BookmarkBar);
            this.BrowserDock.Location = new System.Drawing.Point(0, 34);
            this.BrowserDock.Name = "BrowserDock";
            this.BrowserDock.Size = new System.Drawing.Size(1021, 488);
            this.BrowserDock.TabIndex = 4;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 25);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1021, 463);
            this.Tabs.TabIndex = 1;
            this.Tabs.SelectedIndexChanged += new System.EventHandler(this.Tabs_SelectedIndexChanged);
            this.Tabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.Tabs_Selected);
            this.Tabs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tabs_MouseUp);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1013, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Loading...";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1013, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "+";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BookmarkBar
            // 
            this.BookmarkBar.Location = new System.Drawing.Point(0, 0);
            this.BookmarkBar.Name = "BookmarkBar";
            this.BookmarkBar.Size = new System.Drawing.Size(1021, 25);
            this.BookmarkBar.TabIndex = 0;
            this.BookmarkBar.Text = "toolStrip1";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 5);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(38, 23);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "<--";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(51, 5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(38, 23);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "-->";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(95, 5);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(38, 23);
            this.RefreshButton.TabIndex = 7;
            this.RefreshButton.Text = "↺";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // OpacitySlider
            // 
            this.OpacitySlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpacitySlider.Location = new System.Drawing.Point(843, 5);
            this.OpacitySlider.Maximum = 100;
            this.OpacitySlider.Minimum = 5;
            this.OpacitySlider.Name = "OpacitySlider";
            this.OpacitySlider.Size = new System.Drawing.Size(104, 45);
            this.OpacitySlider.TabIndex = 8;
            this.OpacitySlider.Value = 100;
            this.OpacitySlider.ValueChanged += new System.EventHandler(this.OpacitySlider_ValueChanged);
            // 
            // LockButton
            // 
            this.LockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LockButton.Location = new System.Drawing.Point(984, 5);
            this.LockButton.Name = "LockButton";
            this.LockButton.Size = new System.Drawing.Size(27, 23);
            this.LockButton.TabIndex = 23;
            this.LockButton.UseVisualStyleBackColor = true;
            // 
            // FavoriteButton
            // 
            this.FavoriteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FavoriteButton.Location = new System.Drawing.Point(954, 5);
            this.FavoriteButton.Name = "FavoriteButton";
            this.FavoriteButton.Size = new System.Drawing.Size(24, 22);
            this.FavoriteButton.TabIndex = 24;
            this.FavoriteButton.Text = "⭐";
            this.FavoriteButton.UseVisualStyleBackColor = true;
            // 
            // TabContextMenu
            // 
            this.TabContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseTabButton});
            this.TabContextMenu.Name = "TabContextMenu";
            this.TabContextMenu.Size = new System.Drawing.Size(126, 26);
            // 
            // CloseTabButton
            // 
            this.CloseTabButton.Name = "CloseTabButton";
            this.CloseTabButton.Size = new System.Drawing.Size(125, 22);
            this.CloseTabButton.Text = "Close Tab";
            this.CloseTabButton.Click += new System.EventHandler(this.CloseTabButton_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 522);
            this.Controls.Add(this.LockButton);
            this.Controls.Add(this.FavoriteButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BrowserDock);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddressBar);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.OpacitySlider);
            this.Name = "Browser";
            this.Text = "Browser";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Browser_FormClosing);
            this.BrowserDock.ResumeLayout(false);
            this.BrowserDock.PerformLayout();
            this.Tabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OpacitySlider)).EndInit();
            this.TabContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.TextBox AddressBar;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel BrowserDock;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TrackBar OpacitySlider;
        private System.Windows.Forms.Button LockButton;
        private System.Windows.Forms.Button FavoriteButton;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip BookmarkBar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ContextMenuStrip TabContextMenu;
        private System.Windows.Forms.ToolStripMenuItem CloseTabButton;
    }
}