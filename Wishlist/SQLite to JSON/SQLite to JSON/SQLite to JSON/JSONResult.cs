using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLite_to_JSON
{
    public partial class JSONResult : Form
    {
        public JSONResult(DataTable table)
        {
            string jsonString = "data = '[";

            foreach (DataRow row in table.Rows)
            {
                jsonString += "{";

                jsonString += "\"imageTitle\":\"" + row["ImageTitle"].ToString() + "\",";

                jsonString += "\"title\":\"" + row["Title"].ToString() + "\",";

                jsonString += "\"want\":\"" + row["Want"].ToString() + "\",";

                jsonString += "\"price\":\"" + row["Price"].ToString() + "\",";

                jsonString += "\"deliveryTime\":\"" + row["DeliveryTime"].ToString() + "\",";

                jsonString += "\"description\":\"" + row["Description"].ToString() + "\",";

                jsonString += "\"url\":\"" + row["URL"].ToString() + "\"},";
            }

            jsonString = jsonString.Substring(0, jsonString.Length - 1);
            jsonString += "]';";

            InitializeComponent();

            ResultBox.Text = jsonString;
        }
    }
}
