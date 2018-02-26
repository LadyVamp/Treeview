using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            dgvTFile.Columns[3].HeaderText = "Дата создания";
            dgvTFile.Columns[4].HeaderText = "Размер, КБ";
            dgvTFile.Columns[5].HeaderText = "Ключевые слова";
            dgvTFile.Columns[6].HeaderText = "Содержание";
            dgvTFile.Columns[7].HeaderText = "IdCatalog";
            dgvTFile.Columns[8].HeaderText = "Дата изменения";
            dgvTFile.Columns[9].HeaderText = "Аннотация";
            dgvTFile.Columns[10].HeaderText = "Автор";
            dgvTFile.Columns[0].Width = 20;
            dgvTFile.Columns[1].Width = 280;
            dgvTFile.Columns[2].Width = 40;
            dgvTFile.Columns[3].Width = 80;
            dgvTFile.Columns[4].Width = 60;
            dgvTFile.Columns[5].Width = 100;
            dgvTFile.Columns[6].Width = 300;
            dgvTFile.Columns[7].Width = 50;
        }

        private void btnReset_Click(object sender, EventArgs e) //Кнопка Сброс
        {
            FillDgv();
            ResetFilters();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            con.Open(); //подключение открывается только при запуске формы
            FillDgv();
            LoadTreeviewKeyword();
        }

        private void ResetFilters() //Сброс фильтров и текстбоксов
        {
            txtSearch.Text = "";
            txtKeywords.Text = "";
            cbDoc.Checked = false;
            cbHtml.Checked = false;
            cbRtf.Checked = false;
            txtMinSize.Text = "";
            txtMaxSize.Text = "";
            cbDate1.Checked = false;
            cbDate2.Checked = false;
        }
      

        //Поле поиска
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='.doc'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            if (cbHtml.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='.html'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            if (cbRtf.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='.rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            //выбрано 2 чекбокса
            //doc и rtf
            if ((cbDoc.Checked == true) && (cbRtf.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='.doc' OR type='.rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            //doc и html
            if ((cbDoc.Checked == true) && (cbHtml.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='.doc' OR type='.html'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            //html и rtf
            if ((cbDoc.Checked == true) && (cbRtf.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='.html' OR type='.rtf'", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
          
            //выбрано 3 чекбокса
            if ((cbDoc.Checked == true) && (cbHtml.Checked == true) && (cbRtf.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='.doc' OR type='.html' OR type='.rtf'", con);
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
            //Select* From TFile Where Date >= '2017-11-29' and DateCreate <= '2017-12-2'
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(CONNECTION_STRING);

            if ((cbDate1.Checked == true) && (cbDate2.Checked == false))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE DateCreate>='" + dateTimePicker1.Value.Date + "' ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            if ((cbDate2.Checked == true) && (cbDate1.Checked == false))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE DateCreate<='" + dateTimePicker2.Value.Date + "' ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            if ((cbDate1.Checked == true) && (cbDate2.Checked == true))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE DateCreate>='" + dateTimePicker1.Value.Date + "' AND DateCreate<='" + dateTimePicker2.Value.Date + "' ORDER BY DateCreate", con);
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
            frm.txtDateCreate.Text = this.dgvTFile.CurrentRow.Cells[3].Value.ToString();
            frm.txtSize.Text = this.dgvTFile.CurrentRow.Cells[4].Value.ToString();
            frm.txtKeywords.Text = this.dgvTFile.CurrentRow.Cells[5].Value.ToString();
            frm.txtCatID.Text = this.dgvTFile.CurrentRow.Cells[7].Value.ToString();
            frm.rtbFilecontent.Text = this.dgvTFile.CurrentRow.Cells[6].Value.ToString();
            frm.txtDateChange.Text = this.dgvTFile.CurrentRow.Cells[8].Value.ToString();
            frm.rtbAnnotation.Text = this.dgvTFile.CurrentRow.Cells[9].Value.ToString();
            frm.txtAuthor.Text = this.dgvTFile.CurrentRow.Cells[10].Value.ToString();

            frm.ShowDialog();
        }

        //Нажатие на элемент treeview вставит значение в поле ключевых слов
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtKeywords.Text = Convert.ToString(treeView1.SelectedNode.Text);
        }

        //Загрузить treeview для TKeyword
        private void LoadTreeviewKeyword()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TKeyword", con);
            da.Fill(dt);
            treeView1.Nodes.Add("Keywords");

            foreach (DataRow dr in dt.Rows)
            {
                TreeNode myTreeNode = new TreeNode
                {
                    Text = dr["Keyword"].ToString(),
                    Name = dr["ID"].ToString(),
                    Tag = dr["ParentKeyId"].ToString()
                };

                // вариант 1: работа с указателем на ноду 
                TreeNode rooTreeNode = treeView1.Nodes.Find(myTreeNode.Tag.ToString(), true).FirstOrDefault();
                // вариант 2: работа с индексом ноды 
                // int rooTreeNode2 = treeView1.Nodes.IndexOfKey(myTreeNode.Tag.ToString()); 
                if (rooTreeNode == null)
                {
                    treeView1.Nodes.Add(myTreeNode);
                }
                else
                {
                    // вариант 1 
                    rooTreeNode.Nodes.Add(myTreeNode);
                    // вариант 2 
                    // treeView1.Nodes[rooTreeNode2].Nodes.Add(myTreeNode); 
                }
            }
        }




        //Поиск по ключевым словам 
        private void btnSearchKeywords_Click(object sender, EventArgs e)
        {
            (dgvTFile.DataSource as DataTable).DefaultView.RowFilter =
            String.Format("keywords like '%{0}%'", txtKeywords.Text);
        }

        // --- Применить Все фильтры ---
        private void btnAllSearch_Click(object sender, EventArgs e)
        {
            //      КОМБО 1  Текстбокс + мин размер + мин дата + ключевое слово
            //select * from TFile where type='.doc' and Date >= '2017-11-29' and size >= 10 and Keywords like '%nodejs%' ORDER BY DateCreate
            //+checked!!!
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            if (
                (cbDoc.Checked == true) //doc
                && ((cbDate1.Checked == true) && (cbDate2.Checked == false))    //minDate
                && (txtMinSize.Text != "" && txtMaxSize.Text == "") //minSize
                && (txtKeywords.Text != "") //Keywords
                )
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='.doc' AND size>=" + txtMinSize.Text + "AND keywords like '%"+ txtKeywords.Text+"%' and DateCreate >= '" + dateTimePicker1.Value.Date + "' ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            //select * from TFile where (type='.rtf') and (Date >= '2015-11-29') and (size >= 10) and (Keywords like '%nodejs%') ORDER BY DateCreate
            //+checked!!!
            else if (
                ((cbRtf.Checked == true) //rtf
                && ((cbDate1.Checked == true) && (cbDate2.Checked == false))    //minDate
                && (txtMinSize.Text != "" && txtMaxSize.Text == "") //minSize
                && (txtKeywords.Text != "") //Keywords
                ))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE (type='.rtf') AND (size>=" + txtMinSize.Text + ") AND (keywords like '%" + txtKeywords.Text + "%') and (DateCreate >= '" + dateTimePicker1.Value.Date + "') ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            //select * from TFile where (type='.html') and (Date >= '2015-11-29') and (size >= 10) and (Keywords like '%nodejs%') ORDER BY DateCreate
            //+checked!!!
            else if (
                ((cbHtml.Checked == true) //html
                && ((cbDate1.Checked == true) && (cbDate2.Checked == false))    //minDate
                && (txtMinSize.Text != "" && txtMaxSize.Text == "") //minSize
                && (txtKeywords.Text != "") //Keywords
                ))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE (type='.html') AND (size>=" + txtMinSize.Text + ") AND (keywords like '%" + txtKeywords.Text + "%') and (Date >= '" + dateTimePicker1.Value.Date + "') ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            //select * from TFile where (type='.html') and (Date >= '2015-11-29') and (size >= 10) ORDER BY DateCreate
            //+checked!!!
            else if (
                ((cbHtml.Checked == true) //html
                && ((cbDate1.Checked == true) && (cbDate2.Checked == false))    //minDate
                && (txtMinSize.Text != "" && txtMaxSize.Text == "") //minSize
                ))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE (type='.html') AND (size>=" + txtMinSize.Text + ") and (DateCreate >= '" + dateTimePicker1.Value.Date + "') ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            //select * from TFile where (type='.html') and (Date >= '2015-11-29') and (size >= 10) ORDER BY DateCreate
            //+checked!!!
            else if (
                ((cbHtml.Checked == true) //html
                && ((cbDate1.Checked == true) && (cbDate2.Checked == false))    //minDate
                && (txtMinSize.Text != "" && txtMaxSize.Text != "") //minSize & maxSize
                ))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE (type='.html') AND (size>=" + txtMinSize.Text + ") AND (size<=" + txtMaxSize.Text + ") and (DateCreate >= '" + dateTimePicker1.Value.Date + "') ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            //select * from TFile where (type='.html') and (Date >= '2015-11-29') and (size >= 10) ORDER BY DateCreate
            // +checked!!!
            else if (
                ((cbHtml.Checked == true) //html
                && ((cbDate1.Checked == true) && (cbDate2.Checked == true))    //minDate & maxDate
                && (txtMinSize.Text != "" && txtMaxSize.Text != "") //minSize & maxSize
                ))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE (type='.html') AND (size>=" + txtMinSize.Text + ") AND (size<=" + txtMaxSize.Text + ") and (DateCreate >= '" + dateTimePicker1.Value.Date + "') and (DateCreate <= '" + dateTimePicker2.Value.Date + "') ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }


            //select * from TFile where (type='.doc' or type='.html') and (Date >= '2015-11-29') and (size >= 10) and (Keywords like '%nodejs%') ORDER BY DateCreate
            // +checked!!!
            else if (
               ((cbDoc.Checked == true) //doc
               || (cbHtml.Checked == true))//html
               && ((cbDate1.Checked == true) && (cbDate2.Checked == false))    //minDate
               && (txtMinSize.Text != "" && txtMaxSize.Text == "") //minSize
               && (txtKeywords.Text != "") //Keywords
               )
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE (type='.doc' or type='docx' or type='.html') AND size>=" + txtMinSize.Text + "AND keywords like '%" + txtKeywords.Text + "%' and Date >= '" + dateTimePicker1.Value.Date + "' ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            //select * from TFile where (type='.doc'or type='.html' or type='.rtf') and (Date >= '2015-11-29') and (size >= 10) and (Keywords like '%nodejs%') ORDER BY DateCreate
            // +checked!!!
            else if (
               ((cbDoc.Checked == true) //doc
               || (cbHtml.Checked == true)//html
               || (cbRtf.Checked == true))//rtf
               && ((cbDate1.Checked == true) && (cbDate2.Checked == false))    //minDate
               && (txtMinSize.Text != "" && txtMaxSize.Text == "") //minSize
               && (txtKeywords.Text != "") //Keywords
               )
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE (type='.doc' or type='docx' or type='.html' or type='.rtf') AND size>=" + txtMinSize.Text + "AND keywords like '%" + txtKeywords.Text + "%' and Date >= '" + dateTimePicker1.Value.Date + "' ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            // end КОМБО 1


            // КОМБО 2: вариации с чекбоксами + макс размер + мин дата
            //select * from TFile where (type='.doc') and (Date >= '2015-11-29') and (size <= 50) and (Keywords like '%javascript%') ORDER BY DateCreate
            // +checked!!!
            else if (
                    (cbDoc.Checked == true) //doc
                   && (cbHtml.Checked == false) //!html
                   && (cbRtf.Checked == false) //!rtf
                    && ((cbDate1.Checked == true) && (cbDate2.Checked == false))    //minDate
                    && (txtMaxSize.Text != "" && txtMinSize.Text == "") //maxSize
                    && (txtKeywords.Text != "") //Keywords
                )
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='.doc' AND size<=" + txtMaxSize.Text + "AND keywords like '%" + txtKeywords.Text + "%' and Date >= '" + dateTimePicker1.Value.Date + "' ORDER BY DateCreate", con);
                    da.Fill(ds, "TFile");
                    dgvTFile.DataSource = ds.Tables["TFile"];
                }

            //  select * from TFile where (type='.doc' or type='.html') and (Date >= '2015-11-29') and (size <= 30) and (Keywords like '%nodejs%') ORDER BY DateCreate
            // +checked!!!
            else if (
                   ((cbDoc.Checked == true) //doc
                   || (cbHtml.Checked == true))//html
                   && ((cbDate1.Checked == true) && (cbDate2.Checked == false))    //minDate
                   && (txtMaxSize.Text != "" && txtMinSize.Text == "") //maxSize
                   && (txtKeywords.Text != "") //Keywords
                   )
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE (type='.doc' or type='docx' or type='.html') AND size<=" + txtMaxSize.Text + "AND keywords like '%" + txtKeywords.Text + "%' and DateCreate >= '" + dateTimePicker1.Value.Date + "' ORDER BY DateCreate", con);
                    da.Fill(ds, "TFile");
                    dgvTFile.DataSource = ds.Tables["TFile"];
                }
            // end КОМБО 2


            // КОМБО 1 БЕЗ ключевых слов
            //  select * from TFile where (type='.doc') and (Date >= '2017-11-29') and (size >= 10) ORDER BY DateCreate
            // +checked!!!
            else if (
                  (cbDoc.Checked == true) //doc
                  && ((cbDate1.Checked == true) && (cbDate2.Checked == false))    //minDate
                  && (txtMinSize.Text != "" && txtMaxSize.Text == "") //minSize
                  && (txtKeywords.Text == "") //Keywords
                  )
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE (type='.doc') AND (size>=" + txtMinSize.Text + ") and (DateCreate >= '" + dateTimePicker1.Value.Date + "') ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            //  select * from TFile where (Type = 'html') and(Date >= '2015-11-29') and(size >= 20) ORDER BY DateCreate
            // +checked!!!
            else if (
                (cbHtml.Checked == true) //html
                &&
                ((cbDate1.Checked == true) && (cbDate2.Checked == false))    //minDate
                && (txtMinSize.Text != "" && txtMaxSize.Text == "") //minSize
                && (txtKeywords.Text == "") //Keywords
                )
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='docx' AND size>=" + txtMinSize.Text + " and DateCreate >= '" + dateTimePicker1.Value.Date + "' ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            //  select * from TFile where (type='.doc' and type='.html') and (Date >= '2015-11-29') and (size >= 20) ORDER BY DateCreate
            // не все результаты показывает
            else if (
               ((cbDoc.Checked == true) //doc
               && (cbHtml.Checked == true))//html
               && ((cbDate1.Checked == true) && (cbDate2.Checked == false))    //minDate
               && (txtMinSize.Text != "" && txtMaxSize.Text == "") //minSize
               && (txtKeywords.Text == "") //Keywords
               )
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE (type='.doc' AND type='.html') AND size>=" + txtMinSize.Text + " and Date >= '" + dateTimePicker1.Value.Date + "' ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            //  select * from TFile where (Type='docx' or type='.html' or type='.rtf') and (Date >= '2015-11-29') and (size >= 20) ORDER BY DateCreate
            // только html показывает
            else if (
               ( 
               (cbHtml.Checked == true)//html
               && (cbRtf.Checked == true))//rtf
               && ((cbDate1.Checked == true) && (cbDate2.Checked == false))    //minDate
               && (txtMinSize.Text != "" && txtMaxSize.Text == "") //minSize
               && (txtKeywords.Text == "") //Keywords
               )
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE (type='.html' and type='.rtf') AND size>=" + txtMinSize.Text + " and DateCreate >= '" + dateTimePicker1.Value.Date + "' ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            // end КОМБО 1 БЕЗ ключевых слов


            // комбо 2: вариации с чекбоксами + макс размер + мин дата БЕЗ ключевых слов
            //  select * from TFile where (type='.doc' or Type='docx') and (Date >= '2015-11-29') and (size <= 30) ORDER BY DateCreate
            // не все результаты показывает
            else if (
                (cbDoc.Checked == true) //doc
                && ((cbDate1.Checked == true) && (cbDate2.Checked == false))    //minDate
                && (txtMaxSize.Text != "" && txtMinSize.Text == "") //maxSize
                && (txtKeywords.Text == "") //Keywords
                )
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE type='.doc' AND size<=" + txtMaxSize.Text + " and DateCreate >= '" + dateTimePicker1.Value.Date + "' ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            // end КОМБО 2 БЕЗ ключевых слов

            // КОМБО 3: вариации с чекбоксами + диапазон размеров + диапазон дат
            //select * from TFile where (type='.doc') and ((Date >= '2016-12-18') and (Date <= '2017-12-18')) and ((size >= 20) and(size <= 50))  and keywords like '%nodejs%' ORDER BY DateCreate
            // +checked!!!
            else if (
                (cbDoc.Checked == true) //doc
                && ((cbDate1.Checked == true) && (cbDate2.Checked == true))    //minDate & maxDate
                && (txtMinSize.Text != "" && txtMaxSize.Text != "") //minSize & maxSize
                && (txtKeywords.Text != "") //Keywords
                )
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE (type='.doc') AND (size>=" + txtMinSize.Text + "and size<=" + txtMaxSize.Text + ") AND keywords like '%" + txtKeywords.Text + "%' and DateCreate >= '" + dateTimePicker1.Value.Date + "' and DateCreate <= '" + dateTimePicker2.Value.Date + "' ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            //select * from TFile where (type='.doc' or Type='docx' or type='.html') and ((Date >= '2016-10-29') and (Date <= '2017-11-29')) and ((size >= 20) and (size <= 50)) and (Keywords like '%sql%') ORDER BY DateCreate 
            // +checked!!!
            else if (
               (
               (cbHtml.Checked == true))//html
               && ((cbDate1.Checked == true) && (cbDate2.Checked == true))    //minDate & maxDate
               && (txtMinSize.Text != "" && txtMaxSize.Text != "") //minSize & maxSize
               && (txtKeywords.Text != "") //Keywords
               )
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE (type='.doc' or type='docx' or type='.html') AND (size>=" + txtMinSize.Text + "and size<=" + txtMaxSize.Text + ") AND keywords like '%" + txtKeywords.Text + "%' and DateCreate >= '" + dateTimePicker1.Value.Date + "' and DateCreate <= '" + dateTimePicker2.Value.Date + "' ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }

            //  select * from TFile where (type='.doc' or Type='docx' or type='.html' or type='.rtf') and ((Date >= '2016-10-29') and (Date <= '2017-11-29')) and ((size >= 20) and (size <= 50)) and (Keywords like '%nodejs%') ORDER BY DateCreate
            //только html 
            else if (
               ((cbDoc.Checked == true) //doc
               || (cbHtml.Checked == true)//txt
               || (cbRtf.Checked == true))//rtf
               && ((cbDate1.Checked == true) && (cbDate2.Checked == true))    //minDate & maxDate
               && (txtMinSize.Text != "" && txtMaxSize.Text != "") //minSize & maxSize
               && (txtKeywords.Text != "") //Keywords
               )
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TFile WHERE (type='.doc' or type='docx' or type='.html' or type='.rtf') AND (size>=" + txtMinSize.Text + "and size<=" + txtMaxSize.Text + ") AND keywords like '%" + txtKeywords.Text + "%' and DateCreate >= '" + dateTimePicker1.Value.Date + "' and DateCreate <= '" + dateTimePicker2.Value.Date + "' ORDER BY DateCreate", con);
                da.Fill(ds, "TFile");
                dgvTFile.DataSource = ds.Tables["TFile"];
            }
            // end КОМБО 3
            


        }



    }// end SearchForm
} //end namespace Treeview