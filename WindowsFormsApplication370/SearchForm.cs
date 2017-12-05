﻿using System;
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
        private void SearchForm_Load(object sender, EventArgs e)
        {
            //заполнить dataGridView при запуске формы
            DataSet ds = new DataSet();
            SqlConnection dataBaseConnection = new SqlConnection(CONNECTION_STRING);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TFile", dataBaseConnection);
            dataAdapter.Fill(ds, "TFile");
            FileGrid.DataSource = ds.Tables["TFile"];
            FileGrid.Columns[0].HeaderText = "ID";
            FileGrid.Columns[1].HeaderText = "Название";
            FileGrid.Columns[2].HeaderText = "Формат";
            FileGrid.Columns[3].HeaderText = "Дата изменения";
            FileGrid.Columns[4].HeaderText = "Размер, КБ";
            FileGrid.Columns[5].HeaderText = "Ключевые слова";
            FileGrid.Columns[6].HeaderText = "Содержание";
            FileGrid.Columns[7].HeaderText = "IdCatalog";
            FileGrid.Columns[0].Width = 20;
            FileGrid.Columns[1].Width = 280;
            FileGrid.Columns[2].Width = 40;
            FileGrid.Columns[3].Width = 80;
            FileGrid.Columns[4].Width = 60;
            FileGrid.Columns[5].Width = 100;
            FileGrid.Columns[6].Width = 300;
            FileGrid.Columns[7].Width = 50;
        }
       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (FileGrid.DataSource == tFileBindingSource)
            {
                tFileBindingSource.Filter = "name LIKE'" + txtSearch.Text + "%'";
            }
        }
        ////Поиск по ключевым словам (не работает)
        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    tFileBindingSource.Filter = null;
        //    try
        //    {
        //        foreach (DataGridViewRow row in FileGrid.Rows)
        //        {
        //            row.Selected = false;
        //            this.tFileBindingSource.Filter = "(keywords LIKE '" + txtSearch.Text + "*')";
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Такого названия нет");
        //    }
        //}
        //Радиокнопки по формату (не работает)
        private void rbDoc_CheckedChanged(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            this.tFileBindingSource.Filter = "(type LIKE 'doc')";
        }
        private void rbDocx_CheckedChanged(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            this.tFileBindingSource.Filter = "(type LIKE 'docx')";
        }
        private void rbTxt_CheckedChanged(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            this.tFileBindingSource.Filter = "(type LIKE 'txt')";
        }
        private void rbRtf_CheckedChanged(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            this.tFileBindingSource.Filter = "(type LIKE 'rtf')";
        }
        private void rbPdf_CheckedChanged(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            this.tFileBindingSource.Filter = "(type LIKE 'rtf')";
        }
        //Фильтр по размеру файла
        private void btnSizeFilter_Click(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            try
            {
                if (txtMinSize.Text != "" && txtMaxSize.Text != "") //оба заполнены
                {
                    tFileBindingSource.Filter = null;
                    this.tFileBindingSource.Filter = "size >= '" + int.Parse(txtMinSize.Text) + "'";
                    this.tFileBindingSource.Filter = "size <= '" + int.Parse(txtMaxSize.Text) + "'";
                }
                else if (txtMinSize.Text == "" && txtMaxSize.Text == "") //оба пустые 
                {
                    MessageBox.Show("Поля min и max размер не заполнены");
                }
                else if (txtMinSize.Text != "" && txtMaxSize.Text == "") //заполнен только min
                {
                    tFileBindingSource.Filter = null;
                    this.tFileBindingSource.Filter = "size >= '" + int.Parse(txtMinSize.Text) + "'";
                }
                else if (txtMaxSize.Text != "" && txtMinSize.Text == "") //заполнен только max
                {
                    tFileBindingSource.Filter = null;
                    this.tFileBindingSource.Filter = "size <= '" + int.Parse(txtMaxSize.Text) + "'";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Фильтр по дате
        private void btnDate_Click(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = string.Format("Date >= #{0:MM.dd.yyyy} 00:00:00# AND Date <= #{1:MM.dd.yyyy} 23:59:59#"
, dateTimePicker1.Value, dateTimePicker2.Value);
        }

        //типа полнотекстовый поиск (не работает)
        //select* from TFile where CONTAINS(Filecontent, 'JS')
        private void btnSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FileGrid.RowCount; i++)
            {
                FileGrid.Rows[i].Selected = false;
                for (int j = 0; j < FileGrid.ColumnCount; j++)
                    if (FileGrid.Rows[i].Cells[j].Value != null)
                        if (FileGrid.Rows[i].Cells[j].Value.ToString().Contains(txtSearch.Text))
                        {
                            FileGrid.Rows[i].Selected = true;
                            break;
                        }
            }


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





            //tFileBindingSource1.Filter = null;
            //try
            //{
            //    foreach (DataGridViewRow row in FileGrid.Rows)
            //    {
            //        row.Selected = false;
            //        this.tFileBindingSource1.Filter = "select * from TFile where CONTAINS (Filecontent, '" + txtSearch.Text + "')";
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Такого названия нет");
            //}

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