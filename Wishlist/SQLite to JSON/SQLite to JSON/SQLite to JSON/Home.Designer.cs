namespace SQLite_to_JSON
{
    partial class Home
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
            this.ConvertButton = new System.Windows.Forms.Button();
            this.AddTableButton = new System.Windows.Forms.Button();
            this.ManageItems = new System.Windows.Forms.Button();
            this.AddItemsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackgroundImage = global::SQLite_to_JSON.Properties.Resources.convert;
            this.ConvertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConvertButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.Location = new System.Drawing.Point(13, 13);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(250, 250);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // AddTableButton
            // 
            this.AddTableButton.BackgroundImage = global::SQLite_to_JSON.Properties.Resources.present;
            this.AddTableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddTableButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.AddTableButton.ForeColor = System.Drawing.Color.White;
            this.AddTableButton.Location = new System.Drawing.Point(13, 269);
            this.AddTableButton.Name = "AddTableButton";
            this.AddTableButton.Size = new System.Drawing.Size(250, 250);
            this.AddTableButton.TabIndex = 1;
            this.AddTableButton.Text = "Add Table/Event";
            this.AddTableButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddTableButton.UseVisualStyleBackColor = true;
            // 
            // ManageItems
            // 
            this.ManageItems.BackgroundImage = global::SQLite_to_JSON.Properties.Resources.pencil;
            this.ManageItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ManageItems.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.ManageItems.Location = new System.Drawing.Point(269, 269);
            this.ManageItems.Name = "ManageItems";
            this.ManageItems.Size = new System.Drawing.Size(250, 250);
            this.ManageItems.TabIndex = 2;
            this.ManageItems.Text = "Manage Items";
            this.ManageItems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ManageItems.UseVisualStyleBackColor = true;
            // 
            // AddItemsButton
            // 
            this.AddItemsButton.BackgroundImage = global::SQLite_to_JSON.Properties.Resources.add;
            this.AddItemsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddItemsButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.AddItemsButton.Location = new System.Drawing.Point(269, 13);
            this.AddItemsButton.Name = "AddItemsButton";
            this.AddItemsButton.Size = new System.Drawing.Size(250, 250);
            this.AddItemsButton.TabIndex = 3;
            this.AddItemsButton.Text = "Add Items";
            this.AddItemsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddItemsButton.UseVisualStyleBackColor = true;
            this.AddItemsButton.Click += new System.EventHandler(this.AddItemsButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 533);
            this.Controls.Add(this.AddItemsButton);
            this.Controls.Add(this.ManageItems);
            this.Controls.Add(this.AddTableButton);
            this.Controls.Add(this.ConvertButton);
            this.Name = "Home";
            this.Text = "SQLite to JSON";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button AddTableButton;
        private System.Windows.Forms.Button ManageItems;
        private System.Windows.Forms.Button AddItemsButton;
    }
}

