namespace SQLite_to_JSON
{
    partial class ManageItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.DGVContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditEntryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteEntryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveEntryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DuplicateEntryButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.DGVContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(0, 0);
            this.DGV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 82;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.RowTemplate.Height = 50;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(1600, 865);
            this.DGV.TabIndex = 0;
            this.DGV.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseUp);
            this.DGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellValueChanged);
            // 
            // DGVContextMenu
            // 
            this.DGVContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.DGVContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditEntryButton,
            this.DeleteEntryButton,
            this.DuplicateEntryButton,
            this.MoveEntryButton});
            this.DGVContextMenu.Name = "DGVContextMenu";
            this.DGVContextMenu.Size = new System.Drawing.Size(253, 156);
            // 
            // EditEntryButton
            // 
            this.EditEntryButton.Name = "EditEntryButton";
            this.EditEntryButton.Size = new System.Drawing.Size(252, 38);
            this.EditEntryButton.Text = "Edit Entry";
            this.EditEntryButton.Click += new System.EventHandler(this.EditEntryButton_Click);
            // 
            // DeleteEntryButton
            // 
            this.DeleteEntryButton.Name = "DeleteEntryButton";
            this.DeleteEntryButton.Size = new System.Drawing.Size(252, 38);
            this.DeleteEntryButton.Text = "Delete Entry";
            this.DeleteEntryButton.Click += new System.EventHandler(this.DeleteEntryButton_Click);
            // 
            // MoveEntryButton
            // 
            this.MoveEntryButton.Name = "MoveEntryButton";
            this.MoveEntryButton.Size = new System.Drawing.Size(252, 38);
            this.MoveEntryButton.Text = "Move Entry";
            this.MoveEntryButton.Click += new System.EventHandler(this.MoveEntryButton_Click);
            // 
            // DuplicateEntryButton
            // 
            this.DuplicateEntryButton.Name = "DuplicateEntryButton";
            this.DuplicateEntryButton.Size = new System.Drawing.Size(252, 38);
            this.DuplicateEntryButton.Text = "Duplicate Entry";
            this.DuplicateEntryButton.Click += new System.EventHandler(this.DuplicateEntryButton_Click);
            // 
            // ManageItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.DGV);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ManageItems";
            this.Text = "ManageItems";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.DGVContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip DGVContextMenu;
        private System.Windows.Forms.ToolStripMenuItem EditEntryButton;
        private System.Windows.Forms.ToolStripMenuItem DeleteEntryButton;
        private System.Windows.Forms.ToolStripMenuItem MoveEntryButton;
        public System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.ToolStripMenuItem DuplicateEntryButton;
    }
}