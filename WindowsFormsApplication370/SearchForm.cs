using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treeview
{
    public partial class SearchForm : Form
        //public partial class SearchForm : MetroFramework.Forms.MetroForm
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "repositoryDB2TFileWithoutId.TFile". При необходимости она может быть перемещена или удалена.
            this.tFileTableAdapter.Fill(this.repositoryDB2TFileWithoutId.TFile);
            dataGridView1.Columns[0].Width = 240;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 30;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 50;
            dataGridView1.Columns[6].Width = 30;
        }
    }
}
