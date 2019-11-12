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
    public partial class DialogBox : Form
    {
        static string connectionString = "Data Source=items.db;Version=3;";
        static SQLiteConnection con;
        SQLiteCommand tableCmd;
        DataTable table;

        string type;
        DataGridViewRow item;
        ManageItems refer;

        public DialogBox(DataTable tableTable, string type)
        {
            this.type = type;

            InitializeComponent();

            foreach (DataRow row in tableTable.Rows)
                DropDownBox.Items.Add(row["Title"].ToString());
        }

        public DialogBox(DataTable tableTable, string type, DataGridViewRow item, ManageItems refer)
        {
            this.type = type;
            this.item = item;
            this.refer = refer;

            InitializeComponent();

            foreach (DataRow row in tableTable.Rows)
                DropDownBox.Items.Add(row["Title"].ToString());
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (type == "Convert")
            {
                con = new SQLiteConnection(connectionString);
                tableCmd = new SQLiteCommand("SELECT * FROM " + DropDownBox.Text, con);

                con.Open();

                tableCmd.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(tableCmd);
                table = new DataTable();
                da.Fill(table);

                con.Close();

                JSONResult.Convert(table);

                MessageBox.Show("\"data.json\" successfully written.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else if (type == "AddItems")
            {
                AddItem addItem = new AddItem(DropDownBox.Text, "Add");
                addItem.Show();

                this.Close();
            }
            else if (type == "ManageItems")
            {
                ManageItems manageItems = new ManageItems(DropDownBox.Text);
                manageItems.Show();

                this.Close();
            }
            else
            {
                con = new SQLiteConnection(connectionString);

                // Delete from first table (use type)
                int id = Convert.ToInt32(item.Cells["Id"].Value.ToString());
                SQLiteCommand deleteCmd = new SQLiteCommand("DELETE FROM " + type + " WHERE Id = " + id + ";", con);

                // Add to new table (use DropDownBox.Text)
                SQLiteCommand insertCmd = new SQLiteCommand("INSERT INTO " + DropDownBox.Text + " (Id, ImageTitle, Title, Want, Price, DeliveryTime, Description, URL) VALUES (@Id, @ImageTitle, @Title, @Want, @Price, @DeliveryTime, @Description, @URL);", con);

                SQLiteCommand selectCmd = new SQLiteCommand("SELECT * FROM " + type, con);

                con.Open();

                DataTable table;
                selectCmd.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(selectCmd);
                table = new DataTable();
                da.Fill(table);

                con.Close();

                int highestId = 0;
                foreach (DataRow row in table.Rows)
                {
                    int rowId = Convert.ToInt32(row[0].ToString());
                    if (highestId < rowId)
                        highestId = rowId + 1;
                }

                highestId++;

                insertCmd.Parameters.AddWithValue("@Id", highestId);
                insertCmd.Parameters.AddWithValue("@ImageTitle", item.Cells["ImageTitle"].Value.ToString());
                insertCmd.Parameters.AddWithValue("@Title", item.Cells["Title"].Value.ToString());
                insertCmd.Parameters.AddWithValue("@Want", Convert.ToInt32(item.Cells["Want"].Value.ToString()));
                insertCmd.Parameters.AddWithValue("@Price", Convert.ToDouble(item.Cells["Price"].Value.ToString()));
                insertCmd.Parameters.AddWithValue("@DeliveryTime", Convert.ToInt32(item.Cells["DeliveryTime"].Value.ToString()));
                insertCmd.Parameters.AddWithValue("@Description", item.Cells["Description"].Value.ToString());
                insertCmd.Parameters.AddWithValue("@URL", item.Cells["URL"].Value.ToString());

                con.Open();
                insertCmd.ExecuteNonQuery();
                deleteCmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully moved item.", "Success!");

                refer.FillDGV();
            }
        }
    }
}
