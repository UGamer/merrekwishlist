namespace SQLite_to_JSON
{
    partial class AddItem
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
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.ImageTitleBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.WantBar = new System.Windows.Forms.TrackBar();
            this.WantLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeBox = new System.Windows.Forms.TextBox();
            this.URLLabel = new System.Windows.Forms.Label();
            this.URLBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.DollarSignLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WantBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBox
            // 
            this.ImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageBox.Location = new System.Drawing.Point(13, 13);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(228, 221);
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            this.ImageBox.Click += new System.EventHandler(this.ImageBox_Click);
            // 
            // ImageTitleBox
            // 
            this.ImageTitleBox.Location = new System.Drawing.Point(12, 241);
            this.ImageTitleBox.Name = "ImageTitleBox";
            this.ImageTitleBox.Size = new System.Drawing.Size(229, 20);
            this.ImageTitleBox.TabIndex = 1;
            // 
            // TitleBox
            // 
            this.TitleBox.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBox.Location = new System.Drawing.Point(252, 36);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(540, 50);
            this.TitleBox.TabIndex = 2;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(248, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(35, 20);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(248, 241);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(91, 20);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionBox.Location = new System.Drawing.Point(252, 264);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(540, 109);
            this.DescriptionBox.TabIndex = 6;
            // 
            // WantBar
            // 
            this.WantBar.LargeChange = 1;
            this.WantBar.Location = new System.Drawing.Point(248, 112);
            this.WantBar.Minimum = 1;
            this.WantBar.Name = "WantBar";
            this.WantBar.Size = new System.Drawing.Size(539, 45);
            this.WantBar.TabIndex = 3;
            this.WantBar.Value = 5;
            this.WantBar.ValueChanged += new System.EventHandler(this.WantBar_ValueChanged);
            // 
            // WantLabel
            // 
            this.WantLabel.AutoSize = true;
            this.WantLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WantLabel.Location = new System.Drawing.Point(248, 89);
            this.WantLabel.Name = "WantLabel";
            this.WantLabel.Size = new System.Drawing.Size(69, 20);
            this.WantLabel.TabIndex = 7;
            this.WantLabel.Text = "Want - 5";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(248, 150);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(46, 20);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "Price";
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBox.Location = new System.Drawing.Point(283, 173);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(140, 50);
            this.PriceBox.TabIndex = 4;
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.AutoSize = true;
            this.DeliveryTimeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(431, 150);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(104, 20);
            this.DeliveryTimeLabel.TabIndex = 11;
            this.DeliveryTimeLabel.Text = "Delivery Time";
            // 
            // DeliveryTimeBox
            // 
            this.DeliveryTimeBox.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryTimeBox.Location = new System.Drawing.Point(435, 173);
            this.DeliveryTimeBox.Name = "DeliveryTimeBox";
            this.DeliveryTimeBox.Size = new System.Drawing.Size(352, 50);
            this.DeliveryTimeBox.TabIndex = 5;
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLLabel.Location = new System.Drawing.Point(248, 376);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(36, 20);
            this.URLLabel.TabIndex = 13;
            this.URLLabel.Text = "URL";
            // 
            // URLBox
            // 
            this.URLBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLBox.Location = new System.Drawing.Point(252, 399);
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(495, 27);
            this.URLBox.TabIndex = 7;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(13, 356);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(228, 69);
            this.SubmitButton.TabIndex = 14;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // DollarSignLabel
            // 
            this.DollarSignLabel.AutoSize = true;
            this.DollarSignLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DollarSignLabel.Location = new System.Drawing.Point(246, 180);
            this.DollarSignLabel.Name = "DollarSignLabel";
            this.DollarSignLabel.Size = new System.Drawing.Size(31, 36);
            this.DollarSignLabel.TabIndex = 15;
            this.DollarSignLabel.Text = "$";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.DollarSignLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.URLLabel);
            this.Controls.Add(this.URLBox);
            this.Controls.Add(this.DeliveryTimeLabel);
            this.Controls.Add(this.DeliveryTimeBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.WantLabel);
            this.Controls.Add(this.WantBar);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.ImageTitleBox);
            this.Controls.Add(this.ImageBox);
            this.Name = "AddItem";
            this.Text = "AddItem";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WantBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.TextBox ImageTitleBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.TrackBar WantBar;
        private System.Windows.Forms.Label WantLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label DeliveryTimeLabel;
        private System.Windows.Forms.TextBox DeliveryTimeBox;
        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.TextBox URLBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label DollarSignLabel;
    }
}