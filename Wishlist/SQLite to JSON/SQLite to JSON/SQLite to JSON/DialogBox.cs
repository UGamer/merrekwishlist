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
        DataGridViewSelectedRowCollection items;
        ManageItems refer;

        public DialogBox(DataTable tableTable, string type)
        {
            this.type = type;

            InitializeComponent();

            foreach (DataRow row in tableTable.Rows)
                DropDownBox.Items.Add(row["Title"].ToString());
        }

        public DialogBox(DataTable tableTable, string type, DataGridViewSelectedRowCollection items, ManageItems refer)
        {
            this.type = type;
            this.items = items;
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

                for (int index = 0; index < items.Count; index++)
                {
                    // Delete from first table (use type)
                    int id = Convert.ToInt32(items[index].Cells["Id"].Value.ToString());
                    SQLiteCommand deleteCmd = new SQLiteCommand("DELETE FROM " + type + " WHERE Id = " + id + ";", con);

                    // Add to new table (use DropDownBox.Text)
                    SQLiteCommand insertCmd = new SQLiteCommand("INSERT INTO " + DropDownBox.Text + " (Id, ImageTitle, Title, Want, Price, DeliveryTime, Description, URL) VALUES (@Id, @ImageTitle, @Title, @Want, @Price, @DeliveryTime, @Description, @URL);", con);

                    SQLiteCommand selectCmd = new SQLiteCommand("SELECT * FROM " + DropDownBox.Text, con);

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
                    insertCmd.Parameters.AddWithValue("@ImageTitle", items[index].Cells["ImageTitle"].Value.ToString());
                    insertCmd.Parameters.AddWithValue("@Title", items[index].Cells["Title"].Value.ToString());
                    insertCmd.Parameters.AddWithValue("@Want", Convert.ToInt32(items[index].Cells["Want"].Value.ToString()));
                    insertCmd.Parameters.AddWithValue("@Price", Convert.ToDouble(items[index].Cells["Price"].Value.ToString()));
                    insertCmd.Parameters.AddWithValue("@DeliveryTime", Convert.ToInt32(items[index].Cells["DeliveryTime"].Value.ToString()));
                    insertCmd.Parameters.AddWithValue("@Description", items[index].Cells["Description"].Value.ToString());
                    insertCmd.Parameters.AddWithValue("@URL", items[index].Cells["URL"].Value.ToString());

                    con.Open();
                    insertCmd.ExecuteNonQuery();
                    deleteCmd.ExecuteNonQuery();
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

                MessageBox.Show("Successfully moved item(s).", "Success!");

                refer.FillDGV();
                this.Close();
            }
        }
    }
}
