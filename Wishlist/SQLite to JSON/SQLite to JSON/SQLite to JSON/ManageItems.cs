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
        public ManageItems(string tableString)
        {
            this.tableString = tableString;

            string connectionString = "Data Source=items.db;Version=3;";
            SQLiteConnection con = new SQLiteConnection(connectionString);

            SQLiteCommand selectCmd = new SQLiteCommand("SELECT * FROM " + tableString, con);
            
            con.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter(selectCmd);
            DataTable table = new DataTable();
            da.Fill(table);

            InitializeComponent();

            DGV.DataSource = table;
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
            AddItem editItem = new AddItem(tableString, "Edit", DGV.Rows[rowIndex]);
            editItem.Show();

            this.Close();
        }
    }
}
