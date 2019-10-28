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
    public partial class NewTable : Form
    {
        static string connectionString = "Data Source=items.db;Version=3;";
        static SQLiteConnection con;

        string type;

        public NewTable()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            SQLiteCommand selectCmd = new SQLiteCommand("SELECT * FROM TableRegistry", con);

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

            SQLiteCommand tableCmd = new SQLiteCommand("CREATE TABLE \"Christmas2019\" (\"Id\" INTEGER NOT NULL UNIQUE, \"ImageTitle\" TEXT, \"Title\" TEXT NOT NULL, \"Want\" INTEGER NOT NULL, \"Price\" FLOAT NOT NULL, \"DeliveryTime\" INTEGER, \"Description\" TEXT, \"URL\" TEXT, PRIMARY KEY(\"Id\");", con);
            SQLiteCommand registerCmd = new SQLiteCommand("INSERT INTO TableRegistry (Id, Title) VALUES (" + highestId + ", " + TableBox.Text + ");", con);

            con.Open();
            tableCmd.ExecuteNonQuery();
            registerCmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Table successfully created.", "Success!");

            this.Close();
        }
    }
}
