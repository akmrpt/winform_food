using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace desktop_milk
{
    public partial class attribute : Form
    {
        public attribute()
        {
            InitializeComponent();
        }

        private void attribute_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbFoodDataSet_att.tblAttribute' table. You can move, or remove it, as needed.
            //  this.dbFoodDataSet_att.Fill(this.dbFoodDataSet_att.tblAttribute);
           // filldata();
        }

        public void filldata()
        {
           
// ...
// Create a connection object.
            OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["desktop_milk.Properties.Settings.dbFoodConnectionString"].ConnectionString);
  //"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\DBs\\NWIND.MDB");

// Create a data adapter.
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM tblAttribute", connection);

// Create and fill a dataset.
DataSet sourceDataSet = new DataSet();
adapter.Fill(sourceDataSet);

// Specify the data source for the grid control.
gridControl1.DataSource = sourceDataSet.Tables[0];
        }
    }
}
