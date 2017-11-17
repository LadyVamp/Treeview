using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Treeview
{
    class TreeNode : IEnumerable<TreeNode>
    {
        public DataRow Row { get; set; }

        public IEnumerator<TreeNode> GetEnumerator()
        {
            if(Row == null)
                //return Repository.DataSet.Tables["Org"].Rows.Cast<DataRow>().Select(r => new TreeNode() { Row = r }).GetEnumerator();
                return Repository.DataSet.Tables["TCatalog"].Rows.Cast<DataRow>().Select(r => new TreeNode() { Row = r }).GetEnumerator();

            switch (Row.Table.TableName)
            {
                //case "Org": return GetEnumerator("Div", "Org_Id");
                //case "Div": return GetEnumerator("Unit", "Div_Id");
                //case "Unit": return GetEnumerator("Cooperator", "Unit_Id");
                //case "Cooperator": return new List<TreeNode>().GetEnumerator();//empty

                ////case "Catalog": return GetEnumerator("Catalog", "ParentId");
                ////case "Catalog": return GetEnumerator("File", "CatalogId");
                //case "TCatalog": return GetEnumerator("TFile", "CatalogId");
                //case "TFile": return new List<TreeNode>().GetEnumerator();//empty

                //case "TCatalog": return GetEnumerator("TCatalog", "ParentId");
                case "TCatalog": return GetEnumerator("TFile", "CatalogId");
                case "TFile": return new List<TreeNode>().GetEnumerator();//empty
            }

            throw new Exception("Hmm...");
        }

        //public IEnumerator<TreeNode> GetEnumerator(string table, string parentIdField)
        //{
        //    var id = (int)Row["Id"];
        //    return Repository.DataSet.Tables[table].Rows.Cast<DataRow>().Where(r => r[parentIdField].Equals(id)).Select(r => new TreeNode() { Row = r }).GetEnumerator();
        //}
        public IEnumerator<TreeNode> GetEnumerator(string table, string parentIdField)
        {
            var id = (int)Row["Id"];
            return Repository.DataSet.Tables[table].Rows.Cast<DataRow>().Where(r => r[parentIdField].Equals(id)).Select(r => new TreeNode() { Row = r }).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            var other = obj as TreeNode;
            if (other == null) return false;
            if (Row == other.Row) return true;
            return Row["Id"] == other.Row["Id"];
        }

        public override int GetHashCode()
        {
            if (Row == null) return 0;
            return (int)Row["Id"];
        }

        public override string ToString()
        {
            return Row == null ? "root" : Row["Name"].ToString();
            //return Row == null ? "root" : Row["Title"].ToString();
        }
    }
}
