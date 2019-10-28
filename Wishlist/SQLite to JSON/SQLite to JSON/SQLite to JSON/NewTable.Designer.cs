namespace SQLite_to_JSON
{
    partial class NewTable
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
            this.Label1 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.TableBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(47, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(199, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "What would you like to name your table?";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(103, 58);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // TableBox
            // 
            this.TableBox.Location = new System.Drawing.Point(13, 31);
            this.TableBox.Name = "TableBox";
            this.TableBox.Size = new System.Drawing.Size(272, 20);
            this.TableBox.TabIndex = 3;
            // 
            // NewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 93);
            this.Controls.Add(this.TableBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.Label1);
            this.Name = "NewTable";
            this.Text = "New Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox TableBox;
    }
}