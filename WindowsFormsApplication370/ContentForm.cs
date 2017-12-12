using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Treeview
{
    public partial class ContentForm : Form
    {
        public ContentForm()
        {
            InitializeComponent();
        }

        private void ContentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchContent_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(txtSearchContent.Text); 
            MatchCollection match = reg.Matches(rtbFilecontent.Text);

            foreach (Match mat in match)
            {
                rtbFilecontent.Select(mat.Index, mat.Length);
                rtbFilecontent.SelectionBackColor = Color.Red;
            }
        }

        private void btnClearHighlight_Click(object sender, EventArgs e)
        {
            rtbFilecontent.SelectionStart = 0;
            rtbFilecontent.SelectAll();
            rtbFilecontent.SelectionBackColor = Color.White;
        }
    }
}
