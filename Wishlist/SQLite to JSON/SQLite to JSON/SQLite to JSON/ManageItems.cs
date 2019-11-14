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
    public partial class ManageItems : Form
    {
        int rowIndex;
        string tableString;

        string connectionString;
        SQLiteConnection con;

        public ManageItems(string tableString)
        {
            this.tableString = tableString;

            connectionString = "Data Source=items.db;Version=3;";
            con = new SQLiteConnection(connectionString);
            
            InitializeComponent();

            FillDGV();
        }

        public void FillDGV()
        {
            string sortByString = "";
            DataGridViewColumn sortBy = new DataGridViewColumn();
            ListSortDirection sortOrder = ListSortDirection.Ascending;
            bool sort = false;
            try
            {
                sortByString = DGV.SortedColumn.HeaderText;

                if (DGV.SortOrder == SortOrder.Ascending)
                    sortOrder = ListSortDirection.Ascending;
                if (DGV.SortOrder == SortOrder.Descending)
                    sortOrder = ListSortDirection.Descending;

                sort = true;
            }
            catch { }

            DGV.DataSource = null;

            SQLiteCommand selectCmd = new SQLiteCommand("SELECT * FROM " + tableString, con);

            con.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter(selectCmd);
            DataTable table = new DataTable();
            da.Fill(table);

            con.Close();

            table.Columns.Add("Image", typeof(Image));
            table.Columns["Image"].SetOrdinal(0);

            string imageTitle;
            for (int index = 0; index < table.Rows.Count; index++)
            {
                imageTitle = table.Rows[index]["ImageTitle"].ToString();
                try { table.Rows[index]["Image"] = Image.FromFile(@"img\" + imageTitle + ".png"); } catch { }
            }

            DGV.DataSource = table;

            DGV.Columns[0].Width = 50;
            ((DataGridViewImageColumn)DGV.Columns[0]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            DGV.Columns["Id"].Visible = false;
            DGV.Columns["ImageTitle"].Visible = false;

            if (sort)
            {
                sortBy = new DataGridViewColumn();
                for (int index = 0; index < DGV.Columns.Count; index++)
                {
                    if (DGV.Columns[index].HeaderText == sortByString)
                    {
                        sortBy = DGV.Columns[index];
                        break;
                    }
                }

                DGV.Sort(sortBy, sortOrder);
            }
        }

        private void DGV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    // this.DGV.Rows[e.RowIndex].Selected = true;

                    this.rowIndex = e.RowIndex;

                    if (DGV.SelectedRows.Count <= 1)
                        DGV.CurrentCell = DGV.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    this.DGVContextMenu.Show(this.DGV, e.Location);
                    DGVContextMenu.Show(Cursor.Position);
                }
            }
            catch { }
        }

        private void EditEntryButton_Click(object sender, EventArgs e)
        {
            AddItem editItem = new AddItem(tableString, "Edit", DGV.Rows[rowIndex], this);
            editItem.Show();
        }

        private void DeleteEntryButton_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 1)
            {
                if (MessageBox.Show("Are you sure you want to delete these items?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int index = 0; index < DGV.SelectedRows.Count; index++)
                    {
                        int id = Convert.ToInt32(DGV.SelectedRows[index].Cells["Id"].Value.ToString());
                        SQLiteCommand deleteCmd = new SQLiteCommand("DELETE FROM " + tableString + " WHERE Id = " + id, con);

                        con.Open();
                        deleteCmd.ExecuteNonQuery();
                        con.Close();
                    }

                    FillDGV();
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete item \"" + DGV.Rows[rowIndex].Cells["Title"].Value.ToString() + "\"", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(DGV.Rows[rowIndex].Cells["Id"].Value.ToString());
                    SQLiteCommand deleteCmd = new SQLiteCommand("DELETE FROM " + tableString + " WHERE Id = " + id, con);

                    con.Open();
                    deleteCmd.ExecuteNonQuery();
                    con.Close();

                    FillDGV();
                }
            }
        }

        private void MoveEntryButton_Click(object sender, EventArgs e)
        {
            con = new SQLiteConnection(connectionString);
            SQLiteCommand tableCmd = new SQLiteCommand("SELECT * FROM TableRegistry", con);
            DataTable tableTable;

            con.Open();

            tableCmd.CommandType = CommandType.Text;
            SQLiteDataAdapter da = new SQLiteDataAdapter(tableCmd);
            tableTable = new DataTable();
            da.Fill(tableTable);

            con.Close();

            DialogBox dialogBox = new DialogBox(tableTable, tableString, DGV.SelectedRows, this);
            dialogBox.Show();
        }

        private void DGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SQLiteCommand updateCmd = new SQLiteCommand("UPDATE " + tableString + " SET ImageTitle = @ImageTitle, Title = @Title, Want = @Want, Price = @Price, DeliveryTime = @DeliveryTime," +
                    " Description = @Description, URL = @URL WHERE Id = " + Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["Id"].Value.ToString()) + ";", con);

            con.Open();

            updateCmd.Parameters.AddWithValue("@ImageTitle", DGV.Rows[e.RowIndex].Cells["ImageTitle"].Value.ToString());
            updateCmd.Parameters.AddWithValue("@Title", DGV.Rows[e.RowIndex].Cells["Title"].Value.ToString());
            updateCmd.Parameters.AddWithValue("@Want", Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["Want"].Value.ToString()));
            updateCmd.Parameters.AddWithValue("@Price", Convert.ToDouble(DGV.Rows[e.RowIndex].Cells["Price"].Value.ToString()));
            updateCmd.Parameters.AddWithValue("@DeliveryTime", DGV.Rows[e.RowIndex].Cells["DeliveryTime"].Value.ToString());
            updateCmd.Parameters.AddWithValue("@Description", DGV.Rows[e.RowIndex].Cells["Description"].Value.ToString());
            updateCmd.Parameters.AddWithValue("@URL", DGV.Rows[e.RowIndex].Cells["URL"].Value.ToString());
            
            updateCmd.ExecuteNonQuery();
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
