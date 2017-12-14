using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Treeview
{
    public partial class EditTFileForm : Form
        //public partial class EditTFileForm : MetroFramework.Forms.MetroForm
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=DESKTOP-O9H5H8N;Initial Catalog=RepositoryDB3;Integrated Security=True";
        string sql = "SELECT * FROM TFile";

        private void EditTFileForm_Load(object sender, EventArgs e)
        {

        }

        public EditTFileForm()
        {
            InitializeComponent();

          
        }


    }
}
