﻿using System;
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


        //Типа живой поиск (не работает)
        //private void txtSearch_TextChanged(object sender, EventArgs e)
        //{
        //    //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
        //    //    String.Format("Name like '{0}%'", txtSearch.Text);
        //    this.tFileBindingSource.Filter = "(Name LIKE '" + txtSearch.Text + "*')";
        //}

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (dataGridView1.DataSource == tFileBindingSource)
            {
                tFileBindingSource.Filter = "name LIKE'" + txtSearch.Text + "%'";
                //где Исполнитель - название столбца в DatagridView
            }
        }
        //Поиск по ключевым словам (не работает)
        private void btnSearch_Click(object sender, EventArgs e)
        {
            tFileBindingSource.Filter = null;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Selected = false;
                    this.tFileBindingSource.Filter = "(keywords LIKE '" + txtSearch.Text + "*')";
                }
            }

            catch
            {
                MessageBox.Show("Такого названия нет");
            }
        }


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
    }
}