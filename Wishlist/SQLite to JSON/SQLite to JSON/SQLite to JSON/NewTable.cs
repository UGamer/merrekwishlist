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

        public NewTable()
        {
            con = new SQLiteConnection(connectionString);
            InitializeComponent();
        }

        private void Submit()
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

            highestId++;

            // SQLiteCommand tableCmd = new SQLiteCommand("CREATE TABLE \""+ TableBox.Text + "\" (\"Id\" INTEGER NOT NULL UNIQUE, \"ImageTitle\" TEXT, \"Title\" TEXT NOT NULL, \"Want\" INTEGER NOT NULL, \"Price\" FLOAT NOT NULL, \"DeliveryTime\" INTEGER, \"Description\" TEXT, \"URL\" TEXT, PRIMARY KEY(\"Id\");", con);
            SQLiteCommand tableCmd = new SQLiteCommand("CREATE TABLE " + TableBox.Text + " (Id INTEGER PRIMARY KEY, ImageTitle TEXT, Title TEXT NOT NULL, Want INTEGER NOT NULL, Price FLOAT NOT NULL, DeliveryTime INTEGER, Description TEXT, URL TEXT);", con);
            SQLiteCommand registerCmd = new SQLiteCommand("INSERT INTO TableRegistry ([Id], [Title]) VALUES (@Id, @Title);", con);

            registerCmd.Parameters.AddWithValue("@Id", highestId);
            registerCmd.Parameters.AddWithValue("@Title", TableBox.Text);

            con.Open();
            tableCmd.ExecuteNonQuery();
            registerCmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Table successfully created.", "Success!");

            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void TableBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                Submit();
        }
    }
}
