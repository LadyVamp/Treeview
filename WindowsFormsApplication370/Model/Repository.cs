using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treeview
{
    static class Repository
    {
        public static DataSet DataSet { get; private set; }

        public static void LoadDataSet()
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                DataSet = new DataSet();
                LoadTable(conn, "TRoot");
                LoadTable(conn, "TCatalog");
                LoadTable(conn, "TSubcatalog");
                LoadTable(conn, "TFile");
            }
        }

        private static void LoadTable(SqlConnection conn, string tableName)
        {
            var sql = string.Format("select * from {0}", tableName);
            var table = DataSet.Tables.Add(tableName);
            new SqlDataAdapter(sql, conn).Fill(table);
        }
    }
}
