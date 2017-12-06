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
        //SqlCommand cmd;
        //SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        //заполнить datagridview dgvTFile
        private void FillDgv()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TFile", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "files");
            dgvTFile.DataSource = ds.Tables[0];
            dgvTFile.Columns[0].HeaderText = "ID";
            dgvTFile.Columns[1].HeaderText = "Название";
            dgvTFile.Columns[2].HeaderText = "Формат";
            dgvTFile.Columns[3].HeaderText = "Дата изменения";
            dgvTFile.Columns[4].HeaderText = "Размер, КБ";
            dgvTFile.Columns[5].HeaderText = "Ключевые слова";
            dgvTFile.Columns[6].HeaderText = "Содержание";
            dgvTFile.Columns[7].HeaderText = "IdCatalog";
            dgvTFile.Columns[0].Width = 20;
            dgvTFile.Columns[1].Width = 280;
            dgvTFile.Columns[2].Width = 40;
            dgvTFile.Columns[3].Width = 80;
            dgvTFile.Columns[4].Width = 60;
            dgvTFile.Columns[5].Width = 100;
            dgvTFile.Columns[6].Width = 300;
            dgvTFile.Columns[7].Width = 50;
        }

        private void btnFill_Click(object sender, EventArgs e) //Кнопка Сброс
        {
            FillDgv();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            con.Open(); //подключение открывается только при запуске формы
            FillDgv(); 
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dgvTFile.DataSource as DataTable).DefaultView.RowFilter =
        String.Format("filename like '{0}%'", txtSearch.Text);
        }


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

            for (int i = 0; i < dgvTFile.RowCount; i++)
                if (dgvTFile[1, i].FormattedValue.ToString().
                    Contains(txtSearch.Text.Trim()))
                {
                    dgvTFile.CurrentCell = dgvTFile[0, i];
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


        }

        // ---Фильтр по формату---
        //сокращенная версия для чекбокса
        //private void cbDoc_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (cbDoc.Checked)
        //    {
        //        DataSet ds = new DataSet();
        //        SqlConnection con = new SqlConnection(CONNECTION_STRING);
        //        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='rtf'", con);
        //        da.Fill(ds, "TFile");
        //        dataGridView1.DataSource = ds.Tables["TFile"];
        //    }
        //}

        //  по одному из форматов
        //private void cbDoc_CheckedChanged(object sender, EventArgs e)
        //{
        //    switch (cbDoc.CheckState)
        //    {
        //        case CheckState.Checked:
        //            DataSet ds = new DataSet();
        //            SqlConnection con = new SqlConnection(CONNECTION_STRING);
        //            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc'", con);
        //            da.Fill(ds, "TFile");
        //            dgvTFile.DataSource = ds.Tables["TFile"];
        //            break;
        //        case CheckState.Unchecked:
        //            FillDgv();
        //            break;
        //        case CheckState.Indeterminate:
        //            // Code for indeterminate state.
        //            break;
        //    }
        //}


        //private void cbDoc_Click(object sender, EventArgs e)
        //{
        //    if ((cbDoc.Checked == true) && (cbDocx.Checked == true))
        //    {
        //            DataSet ds = new DataSet();
        //            SqlConnection con = new SqlConnection(CONNECTION_STRING);
        //            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' and type='docx'", con);
        //            da.Fill(ds, "TFile");
        //            dgvTFile.DataSource = ds.Tables["TFile"];
        //    }
        //        //else if (cbTxt.Checked == true) //doc и txt
        //        //{
        //        //    DataSet ds = new DataSet();
        //        //    SqlConnection con = new SqlConnection(CONNECTION_STRING);
        //        //    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' and type='txt'", con);
        //        //    da.Fill(ds, "TFile");
        //        //    dgvTFile.DataSource = ds.Tables["TFile"];
        //        //}
        //        //else if (cbTxt.Checked == true) //doc и rtf
        //        //{
        //        //    DataSet ds = new DataSet();
        //        //    SqlConnection con = new SqlConnection(CONNECTION_STRING);
        //        //    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' and type='rtf'", con);
        //        //    da.Fill(ds, "TFile");
        //        //    dgvTFile.DataSource = ds.Tables["TFile"];
        //        //}

        //    }

        private void btnType_Click(object sender, EventArgs e)
        {
            //выбран 1 чекбокс
            if (cbDoc.Checked == true)
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(CONNECTION_STRING);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            if (cbDocx.Checked == true)
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(CONNECTION_STRING);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='docx'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            if (cbTxt.Checked == true)
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(CONNECTION_STRING);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='txt'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            if (cbRtf.Checked == true)
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(CONNECTION_STRING);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            //выбрано 2 чекбокса
                //doc и docx
            if ((cbDoc.Checked == true) && (cbDocx.Checked == true))
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(CONNECTION_STRING);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' OR type='docx'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
                //doc и txt
            if ((cbDoc.Checked == true) && (cbTxt.Checked == true))
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(CONNECTION_STRING);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' OR type='txt'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

                //doc и rtf
            if ((cbDoc.Checked == true) && (cbRtf.Checked == true))
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(CONNECTION_STRING);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' OR type='rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
                //docx и rtf
            if ((cbDocx.Checked == true) && (cbRtf.Checked == true))
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(CONNECTION_STRING);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='docx' OR type='rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
                //docx и txt
            if ((cbDocx.Checked == true) && (cbTxt.Checked == true))
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(CONNECTION_STRING);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='docx' OR type='txt'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
                //rtf и txt
            if ((cbRtf.Checked == true) && (cbTxt.Checked == true))
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(CONNECTION_STRING);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='rtf' OR type='txt'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            //выбрано 3 чекбокса
                //doc, docx, txt
            if ((cbDoc.Checked == true) && (cbDocx.Checked == true) && (cbTxt.Checked == true))
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(CONNECTION_STRING);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' OR type='docx' OR type='txt'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
                //doc, docx, rtf
            if ((cbDoc.Checked == true) && (cbDocx.Checked == true) && (cbRtf.Checked == true))
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(CONNECTION_STRING);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' OR type='docx' OR type='rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
                //docx, txt, rtf
            if ((cbDocx.Checked == true) && (cbTxt.Checked == true) && (cbRtf.Checked == true))
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(CONNECTION_STRING);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='docx' OR type='txt' OR type='rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
                //doc, txt, rtf
            if ((cbDoc.Checked == true) && (cbTxt.Checked == true) && (cbRtf.Checked == true))
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(CONNECTION_STRING);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' OR type='txt' OR type='rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            //4 чекбокса
            if ((cbDoc.Checked == true) && (cbDocx.Checked == true) && (cbTxt.Checked == true) && (cbRtf.Checked == true))
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(CONNECTION_STRING);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' OR type='docx' OR type='txt' OR type='rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
        }
       




    }
}