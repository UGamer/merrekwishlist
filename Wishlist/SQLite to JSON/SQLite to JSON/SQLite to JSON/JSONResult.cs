using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
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

            Regex rgxFix1 = new Regex("'");
            Regex rgxFix2 = new Regex("\"");
            foreach (DataRow row in table.Rows)
            {
                string imageTitle = row["ImageTitle"].ToString();
                string title = row["Title"].ToString();
                string want = row["Want"].ToString();
                string price = row["Price"].ToString();
                string deliveryTime = row["DeliveryTime"].ToString();
                string description = row["Description"].ToString();
                string url = row["URL"].ToString();

                // This section replaces all 's and "s to work in the JSON string

                imageTitle = rgxFix1.Replace(imageTitle, "\\\'");
                imageTitle = rgxFix2.Replace(imageTitle, "\\\'\\\'");

                Console.WriteLine("Replaced stuff in imageTitle");

                    title = rgxFix1.Replace(title, "\\\'");
                    title = rgxFix2.Replace(title, "\\\'\\\'");

                Console.WriteLine("Replaced stuff in title");

                    want = rgxFix1.Replace(want, "\\\'");
                    want = rgxFix2.Replace(want, "\\\'\\\'");

                Console.WriteLine("Replaced stuff in want");

                    price = rgxFix1.Replace(price, "\\\'");
                    price = rgxFix2.Replace(price, "\\\'\\\'");

                Console.WriteLine("Replaced stuff in price");

                    deliveryTime = rgxFix1.Replace(deliveryTime, "\\\'");
                    deliveryTime = rgxFix2.Replace(deliveryTime, "\\\'\\\'");

                Console.WriteLine("Replaced stuff in deliveryTime");

                    description = rgxFix1.Replace(description, "\\\'");
                    description = rgxFix2.Replace(description, "\\\'\\\'");

                Console.WriteLine("Replaced stuff in description");

                    url = rgxFix1.Replace(url, "\\\'");
                    url = rgxFix2.Replace(url, "\\\'\\\'");

                Console.WriteLine("Replaced stuff in url");

                Console.WriteLine("Successfully fixed " + row["Title"].ToString());

                jsonString += "{";

                jsonString += "\"imageTitle\":\"" + imageTitle + "\",";

                jsonString += "\"title\":\"" + title + "\",";

                jsonString += "\"want\":\"" + want + "\",";

                jsonString += "\"price\":\"" + price + "\",";

                jsonString += "\"deliveryTime\":\"" + deliveryTime + "\",";

                jsonString += "\"description\":\"" + description + "\",";

                jsonString += "\"url\":\"" + url + "\"},";
            }

            jsonString = jsonString.Substring(0, jsonString.Length - 1);
            jsonString += "]';";

            InitializeComponent();

            ResultBox.Text = jsonString;
        }
    }
}
