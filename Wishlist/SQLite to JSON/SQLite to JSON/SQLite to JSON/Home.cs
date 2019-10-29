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
    public partial class Home : Form
    {
        static string connectionString = "Data Source=items.db;Version=3;";
        static SQLiteConnection con;
        SQLiteCommand tableCmd;
        DataTable tableTable;

        public Home()
        {
            con = new SQLiteConnection(connectionString);
            tableCmd = new SQLiteCommand("SELECT * FROM TableRegistry", con);

            con.Open();

            tableCmd.CommandType = CommandType.Text;
            SQLiteDataAdapter da = new SQLiteDataAdapter(tableCmd);
            tableTable = new DataTable();
            da.Fill(tableTable);

            con.Close();

            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox(tableTable, "Convert");
            dialogBox.Show();
        }

        private void AddItemsButton_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox(tableTable, "AddItems");
            dialogBox.Show();
        }

        private void ManageItems_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox(tableTable, "ManageItems");
            dialogBox.Show();
        }

        private void AddTableButton_Click(object sender, EventArgs e)
        {
            NewTable newTable = new NewTable();
            newTable.Show();
        }
    }
}
