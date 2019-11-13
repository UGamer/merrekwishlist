using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLite_to_JSON
{
    public partial class AddItem : Form
    {
        string destTable;
        string type;
        DataGridViewRow row;
        string id;
        ManageItems refer;

        public AddItem(string destTable, string type)
        {
            this.type = type;
            this.destTable = destTable;

            InitializeComponent();
        }

        public AddItem(string destTable, string type, DataGridViewRow row, ManageItems refer)
        {
            this.type = type;
            this.destTable = destTable;
            this.row = row;
            this.refer = refer;

            InitializeComponent();

            id = row.Cells["Id"].Value.ToString();
            ImageTitleBox.Text = row.Cells["ImageTitle"].Value.ToString();
            ImageBox.BackgroundImage = Image.FromFile(@"img\" + ImageTitleBox.Text + ".png");
            TitleBox.Text = row.Cells["Title"].Value.ToString();
            WantBar.Value = Convert.ToInt32(row.Cells["Want"].Value.ToString());
            PriceBox.Text = row.Cells["Price"].Value.ToString();
            DeliveryTimeBox.Text = row.Cells["DeliveryTime"].Value.ToString();
            DescriptionBox.Text = row.Cells["Description"].Value.ToString();
            URLBox.Text = row.Cells["URL"].Value.ToString();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=items.db;Version=3;";
            SQLiteConnection con = new SQLiteConnection(connectionString);

            if (type == "Add")
            {
                SQLiteCommand selectCmd = new SQLiteCommand("SELECT * FROM " + destTable, con);
                SQLiteCommand insertCmd = new SQLiteCommand("INSERT INTO " + destTable + " ([Id], [ImageTitle], [Title], [Want], [Price], [DeliveryTime], [Description], [URL]) VALUES (@Id, @ImageTitle, @Title, @Want, @Price, @DeliveryTime, @Description, @URL);", con);

                con.Open();

                SQLiteDataAdapter da = new SQLiteDataAdapter(selectCmd);
                DataTable table = new DataTable();
                da.Fill(table);

                int highestId = 0;

                for (int index = 0; index < table.Rows.Count; index++)
                    if (highestId < Convert.ToInt32(table.Rows[index]["Id"]))
                        highestId = Convert.ToInt32(table.Rows[index]["Id"]);

                if (highestId == 0)
                    highestId--;

                highestId++;

                insertCmd.Parameters.AddWithValue("@Id", highestId);
                insertCmd.Parameters.AddWithValue("@ImageTitle", ImageTitleBox.Text);
                insertCmd.Parameters.AddWithValue("@Title", TitleBox.Text);
                insertCmd.Parameters.AddWithValue("@Want", WantBar.Value);
                insertCmd.Parameters.AddWithValue("@Price", Convert.ToDouble(PriceBox.Text));
                insertCmd.Parameters.AddWithValue("@DeliveryTime", DeliveryTimeBox.Text);
                insertCmd.Parameters.AddWithValue("@Description", DescriptionBox.Text);
                insertCmd.Parameters.AddWithValue("@URL", URLBox.Text);


                insertCmd.ExecuteNonQuery();
                MessageBox.Show("\"" + TitleBox.Text + "\" successfully added to collection.", "Successful Addition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

                insertCmd.Parameters.RemoveAt("@Id");
                insertCmd.Parameters.RemoveAt("@ImageTitle");
                insertCmd.Parameters.RemoveAt("@Title");
                insertCmd.Parameters.RemoveAt("@Want");
                insertCmd.Parameters.RemoveAt("@Price");
                insertCmd.Parameters.RemoveAt("@DeliveryTime");
                insertCmd.Parameters.RemoveAt("@Description");
                insertCmd.Parameters.RemoveAt("@URL");

                try { ImageBox.BackgroundImage.Save(@"img\" + ImageTitleBox.Text + ".png"); }
                catch { }
            }
            else if (type == "Edit")
            {
                SQLiteCommand updateCmd = new SQLiteCommand("UPDATE " + destTable + " SET ImageTitle = @ImageTitle, Title = @Title, Want = @Want, Price = @Price, DeliveryTime = @DeliveryTime," +
                    " Description = @Description, URL = @URL WHERE Id = " + id + ";", con);
                
                con.Open();

                updateCmd.Parameters.AddWithValue("@ImageTitle", ImageTitleBox.Text);
                updateCmd.Parameters.AddWithValue("@Title", TitleBox.Text);
                updateCmd.Parameters.AddWithValue("@Want", WantBar.Value);
                updateCmd.Parameters.AddWithValue("@Price", Convert.ToDouble(PriceBox.Text));
                updateCmd.Parameters.AddWithValue("@DeliveryTime", DeliveryTimeBox.Text);
                updateCmd.Parameters.AddWithValue("@Description", DescriptionBox.Text);
                updateCmd.Parameters.AddWithValue("@URL", URLBox.Text);


                updateCmd.ExecuteNonQuery();
                MessageBox.Show("\"" + TitleBox.Text + "\" was successfully edited.", "Successful Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

                updateCmd.Parameters.RemoveAt("@ImageTitle");
                updateCmd.Parameters.RemoveAt("@Title");
                updateCmd.Parameters.RemoveAt("@Want");
                updateCmd.Parameters.RemoveAt("@Price");
                updateCmd.Parameters.RemoveAt("@DeliveryTime");
                updateCmd.Parameters.RemoveAt("@Description");
                updateCmd.Parameters.RemoveAt("@URL");

                try
                {
                    string sortByString = refer.DGV.SortedColumn.HeaderText;

                    ListSortDirection sortOrder = ListSortDirection.Ascending;
                    if (refer.DGV.SortOrder == SortOrder.Ascending)
                        sortOrder = ListSortDirection.Ascending;
                    if (refer.DGV.SortOrder == SortOrder.Descending)
                        sortOrder = ListSortDirection.Descending;

                    refer.FillDGV();

                    DataGridViewColumn sortBy = new DataGridViewColumn();
                    for (int index = 0; index < refer.DGV.Columns.Count; index++)
                    {
                        if (refer.DGV.Columns[index].HeaderText == sortByString)
                        {
                            sortBy = refer.DGV.Columns[index];
                            break;
                        }
                    }

                    refer.DGV.Sort(sortBy, sortOrder);
                }
                catch { refer.FillDGV(); }
            }
        }

        private void ImageBox_Click(object sender, EventArgs e)
        {
            Browser browser = new Browser(URLBox.Text);

            DialogResult dialogResult = browser.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                string downloadUrl = browser.downloadUrl;

                /*
                string fileExt = browser.url;
                while (fileExt.IndexOf(".") != -1)
                {
                    fileExt = fileExt.Substring(fileExt.IndexOf(".") + 1);
                }
                */

                WebClient webClient = new WebClient();
                try
                {
                    byte[] imageBytes = webClient.DownloadData(downloadUrl);
                    Console.WriteLine(imageBytes.LongLength);

                    using (var ms = new MemoryStream(imageBytes))
                    {
                        ImageBox.BackgroundImage = Image.FromStream(ms);
                    }
                }
                catch
                {
                    MessageBox.Show("Image download failed.");
                }
            }
        }

        private void WantBar_ValueChanged(object sender, EventArgs e)
        {
            WantLabel.Text = "Want - " + WantBar.Value;
        }
    }
}
