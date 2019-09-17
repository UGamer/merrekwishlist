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

        public DialogBox(DataTable tableTable, string type)
        {
            this.type = type;

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

                JSONResult result = new JSONResult(table);
                result.Show();

                this.Close();
            }
            else if (type == "AddItems")
            {

            }

        }
    }
}
