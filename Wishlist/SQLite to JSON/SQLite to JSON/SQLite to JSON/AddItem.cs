using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
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

        public AddItem(string destTable, string type)
        {
            this.type = type;
            this.destTable = destTable;

            InitializeComponent();
        }

        public AddItem(string destTable, string type, DataGridViewRow row)
        {
            this.type = type;
            this.destTable = destTable;
            this.row = row;

            InitializeComponent();

            id = row.Cells["Id"].Value.ToString();
            ImageTitleBox.Text = row.Cells["ImageTitle"].Value.ToString();
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
            }
        }
    }
}
