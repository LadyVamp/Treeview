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
    public partial class SearchForm : Form
    {
           public SearchForm()
        {
            InitializeComponent();
        }

        private const string CONNECTION_STRING =
  "Data Source=DESKTOP-O9H5H8N;Initial Catalog=RepositoryDB3;Integrated Security=True";
        SqlConnection con = new SqlConnection(CONNECTION_STRING);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        //заполнить datagridview
        private void btnFill_Click(object sender, EventArgs e) 
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TFile", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "files");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Формат";
            dataGridView1.Columns[3].HeaderText = "Дата изменения";
            dataGridView1.Columns[4].HeaderText = "Размер, КБ";
            dataGridView1.Columns[5].HeaderText = "Ключевые слова";
            dataGridView1.Columns[6].HeaderText = "Содержание";
            dataGridView1.Columns[7].HeaderText = "IdCatalog";
            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[1].Width = 280;
            dataGridView1.Columns[2].Width = 40;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 300;
            dataGridView1.Columns[7].Width = 50;
        }


        private void SearchForm_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TFile", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "files");

            dataGridView1.DataSource = ds.Tables[0];


            //заполнить dataGridView при запуске формы
            //DataSet ds = new DataSet();
            //SqlConnection dataBaseConnection = new SqlConnection(CONNECTION_STRING);
            //SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TFile", dataBaseConnection);
            //dataAdapter.Fill(ds, "TFile");
            //dataGridView1.DataSource = ds.Tables["TFile"];
            //dataGridView1.Columns[0].HeaderText = "ID";
            //dataGridView1.Columns[1].HeaderText = "Название";
            //dataGridView1.Columns[2].HeaderText = "Формат";
            //dataGridView1.Columns[3].HeaderText = "Дата изменения";
            //dataGridView1.Columns[4].HeaderText = "Размер, КБ";
            //dataGridView1.Columns[5].HeaderText = "Ключевые слова";
            //dataGridView1.Columns[6].HeaderText = "Содержание";
            //dataGridView1.Columns[7].HeaderText = "IdCatalog";
            //dataGridView1.Columns[0].Width = 20;
            //dataGridView1.Columns[1].Width = 280;
            //dataGridView1.Columns[2].Width = 40;
            //dataGridView1.Columns[3].Width = 80;
            //dataGridView1.Columns[4].Width = 60;
            //dataGridView1.Columns[5].Width = 100;
            //dataGridView1.Columns[6].Width = 300;
            //dataGridView1.Columns[7].Width = 50;
        }
       

        ////Поиск по ключевым словам (не работает)
        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    tFileBindingSource1.Filter = null;
        //    try
        //    {
        //        foreach (DataGridViewRow row in FileGrid.Rows)
        //        {
        //            row.Selected = false;
        //            this.tFileBindingSource1.Filter = "(keywords LIKE '" + txtSearch.Text + "*')";
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Такого названия нет");
        //    }
        //}
        //Радиокнопки по формату (не работает)
        //private void rbDoc_CheckedChanged(object sender, EventArgs e)
        //{
        //    tFileBindingSource1.Filter = null;
        //    this.tFileBindingSource1.Filter = "(type LIKE 'doc')";

        //    //DataSet ds = new DataSet();
        //    //SqlConnection dataBaseConnection = new SqlConnection(CONNECTION_STRING);
        //    //SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TFile where type='doc'", dataBaseConnection);
        //    //dataAdapter.Fill(ds, "TFile");

        //    //MessageBox.Show("Hello, world.");

        //}
        //private void rbDocx_CheckedChanged(object sender, EventArgs e)
        //{
        //    tFileBindingSource1.Filter = null;
        //    this.tFileBindingSource1.Filter = "(type LIKE 'docx')";
        //}
        //private void rbTxt_CheckedChanged(object sender, EventArgs e)
        //{
        //    tFileBindingSource1.Filter = null;
        //    this.tFileBindingSource1.Filter = "(type LIKE 'txt')";
        //}
        //private void rbRtf_CheckedChanged(object sender, EventArgs e)
        //{
        //    tFileBindingSource1.Filter = null;
        //    this.tFileBindingSource1.Filter = "(type LIKE 'rtf')";
        //}
        //private void rbPdf_CheckedChanged(object sender, EventArgs e)
        //{
        //    tFileBindingSource1.Filter = null;
        //    this.tFileBindingSource1.Filter = "(type LIKE 'pdf')";
        //}

        ////Фильтр по размеру файла
        //private void btnSizeFilter_Click(object sender, EventArgs e)
        //{
        //    tFileBindingSource1.Filter = null;
        //    try
        //    {
        //        if (txtMinSize.Text != "" && txtMaxSize.Text != "") //оба заполнены
        //        {
        //            tFileBindingSource1.Filter = null;
        //            this.tFileBindingSource1.Filter = "size >= '" + int.Parse(txtMinSize.Text) + "'";
        //            this.tFileBindingSource1.Filter = "size <= '" + int.Parse(txtMaxSize.Text) + "'";
        //        }
        //        else if (txtMinSize.Text == "" && txtMaxSize.Text == "") //оба пустые 
        //        {
        //            MessageBox.Show("Поля min и max размер не заполнены");
        //        }
        //        else if (txtMinSize.Text != "" && txtMaxSize.Text == "") //заполнен только min
        //        {
        //            tFileBindingSource1.Filter = null;
        //            this.tFileBindingSource1.Filter = "size >= '" + int.Parse(txtMinSize.Text) + "'";
        //        }
        //        else if (txtMaxSize.Text != "" && txtMinSize.Text == "") //заполнен только max
        //        {
        //            tFileBindingSource1.Filter = null;
        //            this.tFileBindingSource1.Filter = "size <= '" + int.Parse(txtMaxSize.Text) + "'";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
//        //Фильтр по дате
//        private void btnDate_Click(object sender, EventArgs e)
//        {
//            tFileBindingSource1.Filter = string.Format("Date >= #{0:MM.dd.yyyy} 00:00:00# AND Date <= #{1:MM.dd.yyyy} 23:59:59#"
//, dateTimePicker1.Value, dateTimePicker2.Value);
//        }

        //типа полнотекстовый поиск (не работает)
        //select* from TFile where CONTAINS(Filecontent, 'JS')
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //     string selectString =
            //"Filename Like '%" + txtSearch.Text.Trim() + "%'";

            //     DataRowCollection allRows =
            //         ((DataTable)dataGridView1.DataSource).Rows;

            //     DataRow[] searchedRows =
            //         ((DataTable)dataGridView1.DataSource).
            //             Select(selectString);

            //     int rowIndex = allRows.IndexOf(searchedRows[0]);

            //     dataGridView1.CurrentCell =
            //         dataGridView1[0, rowIndex];

            for (int i = 0; i < dataGridView1.RowCount; i++)
                if (dataGridView1[1, i].FormattedValue.ToString().
                    Contains(txtSearch.Text.Trim()))
                {
                    dataGridView1.CurrentCell = dataGridView1[0, i];
                    return;
                }


            //int findrow = 0;
            //for (int col = 0; col < dataGridView1.Columns.Count; col++) //Table0 ака DataGridView
            //{
            //    for (int row = findrow; row < dataGridView1.Rows.Count; row++)
            //        if (dataGridView1[col, row].Value.ToString() == txtSearch.Text)
            //        {
            //            dataGridView1.CurrentCell = dataGridView1[col, row];
            //            findrow = dataGridView1.CurrentRow.Index + 1;
            //            return;
            //        }
            //}



            //for (int i = 0; i < dataGridView1.RowCount; i++)
            //{
            //    dataGridView1.Rows[i].Selected = false;
            //    for (int j = 0; j < dataGridView1.ColumnCount; j++)
            //        if (dataGridView1.Rows[i].Cells[j].Value != null)
            //            if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(txtSearch.Text.ToLower()))
            //            {
            //                dataGridView1.Rows[i].Selected = true;
            //                break;
            //            }
            //}





            //string selectString =
            //        "Filecontent Like '%" + txtSearch.Text.Trim() + "%'";

            //DataRowCollection allRows =
            //    ((DataTable)FileGrid.DataSource).Rows;

            //DataRow[] searchedRows =
            //    ((DataTable)FileGrid.DataSource).
            //        Select(selectString);

            //int rowIndex = allRows.IndexOf(searchedRows[0]);

            //FileGrid.CurrentCell =
            //    FileGrid[0, rowIndex];

            //for (int i = 0; i < FileGrid.RowCount; i++)
            //{
            //    FileGrid.Rows[i].Selected = false;
            //    for (int j = 0; j < FileGrid.ColumnCount; j++)
            //        if (FileGrid.Rows[i].Cells[j].Value != null)
            //            if (FileGrid.Rows[i].Cells[j].Value.ToString().Contains(txtSearch.Text))
            //            {
            //                FileGrid.Rows[i].Selected = true;
            //                break;
            //            }
            //}


            //for (int i = 0; i < FileGrid.RowCount; i++)
            //{
            //    FileGrid.Rows[i].Selected = false;
            //    for (int j = 0; j < FileGrid.ColumnCount; j++)
            //        if (FileGrid.Rows[i].Cells[j].Value != null)
            //            if (FileGrid.Rows[i].Cells[j].Value.ToString().Contains(txtSearch.Text))
            //            {
            //                DataGridViewCell cell = FileGrid.Rows[i].Cells[j];

            //                FileGrid.Rows[i].Selected = true;
            //                FileGrid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            //                FileGrid.CurrentCell = cell;
            //                break;
            //            }
            //}





            //tFileBindingSource11.Filter = null;
            //try
            //{
            //    foreach (DataGridViewRow row in FileGrid.Rows)
            //    {
            //        row.Selected = false;
            //        this.tFileBindingSource11.Filter = "select * from TFile where CONTAINS (Filecontent, '" + txtSearch.Text + "')";
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Такого названия нет");
            //}

        }
        private void FillDataGridView(object sender, EventArgs e)
        {
                SqlDataAdapter da = new SqlDataAdapter("select * from TFile", con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "files");
                dataGridView1.DataSource = ds.Tables[0];
            
        }



        private void cbDocx_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDocx.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from TFile where type = 'docx'", con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "files");
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void cbTxt_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTxt.Checked)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from TFile where type = 'txt'", con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "files");
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        //private void cbRtf_CheckedChanged(object sender, EventArgs e)
        //{
        //    SqlDataAdapter da = new SqlDataAdapter("select * from TFile where type = 'rtf'", con);
        //    SqlCommandBuilder cb = new SqlCommandBuilder(da);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds, "files");
        //    dataGridView1.DataSource = ds.Tables[0];
        //}

        private void cbRtf_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRtf.Checked)
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(CONNECTION_STRING);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='rtf'", con);
                da.Fill(ds, "TFile");
                dataGridView1.DataSource = ds.Tables["TFile"];
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
        String.Format("filename like '{0}%'", txtSearch.Text);
        }





        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        //SqlConnection con = new SqlConnection(CONNECTION_STRING);
        private void cbDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDoc.Checked)
            {
                SqlCommand cmd = new SqlCommand("select * from TFile where type='doc'");
                da.SelectCommand = cmd;
                da.Fill(ds, "TFile");
                
                
                
                
                //tFileBindingSource1.Filter = null;
                //tFileBindingSource1.Filter = "Type like 'doc'";
                //con.Open();

                //SqlDataAdapter da = new SqlDataAdapter("select * from TFile where type = 'doc'", con);
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                //DataSet ds = new DataSet();
                //da.Fill(ds, "files");
                //dataGridView1.DataSource = ds.Tables[0];

                //DataTable MyDataTable = new DataTable("TFile");
                //DataView MyDataView = new DataView(MyDataTable);
                //MyDataView.RowFilter = "Size = 15";

                //DataSet ds = new DataSet();
                //da.Fill(ds, "files");
                //dataGridView1.DataSource = ds.Tables[0];
                //DataView dv = new DataView("TFile".Tables[0]);
                //dataGridView1.DataSource = dv;

                //DataTable MyDataTable = new DataTable("TFile");
                //DataView MyDataView = new DataView(MyDataTable);
                ////dv.RowFilter = " Name  like '%чегото-там%' ";
                //MyDataView.RowFilter = "Type like 'doc' ";

                //DataTable dt = new DataTable("TFile");
                //DataView dv = new DataView(dt);
                //dv.RowFilter = "Size < 50";

                //DataTable table = new DataTable();
                ////Здесь - заполняем нашу таблицу чем нибудь...
                //table.DefaultView.RowFilter = "'Type'='doc'";
                ////Если значение символьное - то в одинарных ковычках.
                //int count = table.DefaultView.Count;
                ////Узнаём сколько строк осталось после наложения фильтра.
                //string value = table.DefaultView[0]["Size"].ToString();
                //Получаем значение ячейки из первой строки.

                //DataTable MyDataTable = new DataTable("TFile");
                //DataView MyDataView = new DataView(MyDataTable);
                ////MyDataView.RowFilter = "Size = 15";
                //MyDataView.RowFilter = "ID >= 10 AND ID <= 60";

                //DataTable table = new DataTable("TFile");
                //DataColumn column = new DataColumn("ID", typeof(System.Int32));
                //table.Columns.Add(column);
                //DataView MyDataView = new DataView(table);
                //MyDataView.RowFilter = "ID >= 2 AND ID <= 5";


            }
        }






        //using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CONNECTION_STRING"].ConnectionString))
        //con.Open();
        //using (var command = new SqlCommand(con))
        //    // select * from TFile where CONTAINS(Filecontent, 'JS')
        //{
        //    command.Parameters.Add("@word", DbType.String).Value = txtSearch.Text;
        //    command.CommandText = "SELECT * FROM TFile WHERE CONTAINS (Filecontent, @word)";
        //    command.ExecuteNonQuery();
        //}


    }
}