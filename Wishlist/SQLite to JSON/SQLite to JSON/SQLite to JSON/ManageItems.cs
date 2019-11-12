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
        }

        private void DGV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.DGV.Rows[e.RowIndex].Selected = true;

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

            DialogBox dialogBox = new DialogBox(tableTable, tableString, DGV.Rows[rowIndex], this);
            dialogBox.Show();
        }
    }
}
