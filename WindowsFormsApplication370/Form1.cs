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
using System.Configuration;

namespace Treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenSearchForm_Click(object sender, EventArgs e)
        {
            SearchForm f2 = new SearchForm();
            f2.Show();
        }

        private void btnCallLogin_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTreeviewCatalog();
        }


        private const string CONNECTION_STRING =
"Data Source=DESKTOP-O9H5H8N;Initial Catalog=RepositoryDB3;Integrated Security=True";
        SqlConnection con = new SqlConnection(CONNECTION_STRING);
        //SqlCommand cmd;
        //SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        //Загрузить treeview для TCatalog
        private void LoadTreeviewCatalog()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TCatalog", con);
            da.Fill(dt);
            treeView2.Nodes.Add("Catalogs");

            foreach (DataRow dr in dt.Rows)
            {
                TreeNode myTreeNode = new TreeNode
                {
                    Text = dr["Catalog"].ToString(),
                    Name = dr["ID"].ToString(),
                    Tag = dr["SubCatalogId"].ToString()
                };

                // вариант 1: работа с указателем на ноду 
                TreeNode rooTreeNode = treeView2.Nodes.Find(myTreeNode.Tag.ToString(), true).FirstOrDefault();
                // вариант 2: работа с индексом ноды 
                // int rooTreeNode2 = treeView1.Nodes.IndexOfKey(myTreeNode.Tag.ToString()); 
                if (rooTreeNode == null)
                {
                    treeView2.Nodes.Add(myTreeNode);
                }
                else
                {
                    // вариант 1 
                    rooTreeNode.Nodes.Add(myTreeNode);
                    // вариант 2 
                    // treeView1.Nodes[rooTreeNode2].Nodes.Add(myTreeNode); 
                }
            }
        }


    }
}
