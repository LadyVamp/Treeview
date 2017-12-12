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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dgvTFile.DataSource as DataTable).DefaultView.RowFilter =
        String.Format("filename like '{0}%'", txtSearch.Text);
        }

        // ---Фильтр по формату---
        private void btnType_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            //выбран 1 чекбокс
            if (cbDoc.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            if (cbDocx.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='docx'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            if (cbTxt.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='txt'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            if (cbRtf.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            //выбрано 2 чекбокса
                //doc и docx
            if ((cbDoc.Checked == true) && (cbDocx.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' OR type='docx'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
                //doc и txt
            if ((cbDoc.Checked == true) && (cbTxt.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' OR type='txt'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

                //doc и rtf
            if ((cbDoc.Checked == true) && (cbRtf.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' OR type='rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
                //docx и rtf
            if ((cbDocx.Checked == true) && (cbRtf.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='docx' OR type='rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
                //docx и txt
            if ((cbDocx.Checked == true) && (cbTxt.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='docx' OR type='txt'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
                //rtf и txt
            if ((cbRtf.Checked == true) && (cbTxt.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='rtf' OR type='txt'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            //выбрано 3 чекбокса
                //doc, docx, txt
            if ((cbDoc.Checked == true) && (cbDocx.Checked == true) && (cbTxt.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' OR type='docx' OR type='txt'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
                //doc, docx, rtf
            if ((cbDoc.Checked == true) && (cbDocx.Checked == true) && (cbRtf.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' OR type='docx' OR type='rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
                //docx, txt, rtf
            if ((cbDocx.Checked == true) && (cbTxt.Checked == true) && (cbRtf.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='docx' OR type='txt' OR type='rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
                //doc, txt, rtf
            if ((cbDoc.Checked == true) && (cbTxt.Checked == true) && (cbRtf.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' OR type='txt' OR type='rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            //4 чекбокса
            if ((cbDoc.Checked == true) && (cbDocx.Checked == true) && (cbTxt.Checked == true) && (cbRtf.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='doc' OR type='docx' OR type='txt' OR type='rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
        }


        // ---Фильтр по размеру---
        private void btnSizeFilter_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            if (txtMinSize.Text != "" && txtMaxSize.Text == "") //заполнен только min 
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE size>='" + txtMinSize.Text + "'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            if (txtMinSize.Text != "" && txtMaxSize.Text != "") //оба заполнены 
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE size>='" + txtMinSize.Text + "' AND size<='" + txtMaxSize.Text + "'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            if (txtMaxSize.Text != "" && txtMinSize.Text == "") //заполнен только max 
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE size<='" + txtMaxSize.Text + "'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            if (txtMaxSize.Text == "" && txtMinSize.Text == "")
            {
                MessageBox.Show("Введите минимальный и (или) максимальный размер файла");
            }
        }


        //---Фильтр по дате---
        private void btnDateFilter_Click(object sender, EventArgs e)
        {
            //Select* From TFile Where Date >= '2017-11-29' AND Date <= '2017-12-2'
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(CONNECTION_STRING);

            if ((cbDate1.Checked == true)&& (cbDate2.Checked == false))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE Date>='" + dateTimePicker1.Value.Date + "' ORDER BY Date", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            if ((cbDate2.Checked == true) && (cbDate1.Checked == false))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE Date<='" + dateTimePicker2.Value.Date + "' ORDER BY Date", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            if ((cbDate1.Checked == true) && (cbDate2.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE Date>='" + dateTimePicker1.Value.Date + "' AND date<='" + dateTimePicker2.Value.Date + "' ORDER BY Date", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            if ((cbDate1.Checked == false) && (cbDate2.Checked == false))
            {
                MessageBox.Show("Выберите дату(ы) и поставьте галочку(и)");
            }
        }

        
        //---Типа полнотекстовый поиск---
        /*
            выделит строку, где упоминается слово из текстбокса
            select * from TFile where CONTAINS(Filecontent, 'JS')
        */
        private void btnSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvTFile.RowCount; i++)
            {
                dgvTFile.Rows[i].Selected = false;
                for (int j = 0; j < dgvTFile.ColumnCount; j++)
                    if (dgvTFile.Rows[i].Cells[j].Value != null)
                        if (dgvTFile.Rows[i].Cells[j].Value.ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            dgvTFile.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        //Даблклик по строке dgv открывает форму ContentForm с инфой о статье и текстом
        private void dgvTFile_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ContentForm frm = new ContentForm(); 
            frm.txtID.Text = this.dgvTFile.CurrentRow.Cells[0].Value.ToString();
            frm.txtFilename.Text = this.dgvTFile.CurrentRow.Cells[1].Value.ToString();
            frm.txtType.Text = this.dgvTFile.CurrentRow.Cells[2].Value.ToString();
            frm.txtDate.Text = this.dgvTFile.CurrentRow.Cells[3].Value.ToString();
            frm.txtSize.Text = this.dgvTFile.CurrentRow.Cells[4].Value.ToString();
            frm.txtKeywords.Text = this.dgvTFile.CurrentRow.Cells[5].Value.ToString();
            frm.txtCatID.Text = this.dgvTFile.CurrentRow.Cells[7].Value.ToString();
            frm.rtbFilecontent.Text = this.dgvTFile.CurrentRow.Cells[6].Value.ToString();

            frm.ShowDialog();
        }

        //Вход для администратора
        private void btnCallLogin_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
        }

        // TODO
        // Админка, CRUD для TFile 


    }
}