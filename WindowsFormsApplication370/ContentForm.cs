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

        private void button1_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(textBox1.Text); //textBox1 - поле для ввода искомого текста
            MatchCollection match = reg.Matches(richTextBox1.Text);

            foreach (Match mat in match)
            {
                richTextBox1.Select(mat.Index, mat.Length);
                richTextBox1.SelectionBackColor = Color.Red;
            }
        }

        private void btnClearHighlight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
        }
    }
}
