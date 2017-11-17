using System;
using System.Data;
using System.Windows.Forms;
using ExmapleNS.Controls;

namespace ExmapleNS
{
    public partial class InputForm : Form
    {
        //данные
        public DataRow Row { get; private set; }

        public InputForm()
        {
            InitializeComponent();
        }

        public void Build(DataRow row)
        {
            Row = row;

            //создаем FieldPanel для каждого поля, отображаем в pnMain
            foreach (DataColumn col in row.Table.Columns)
            {
                var pn = new FieldPanel() {Parent = pnMain, Name = col.ColumnName};
                pn.lbName.Text = col.ColumnName;
                pn.tbField.Text = row[col.ColumnName].ToString();
            }
        }

        //парсинг и проверка на правильность
        private void UpdateValue()
        {
            //перебираем FieldPanel, заносим значения в DataRow
            foreach (DataColumn col in Row.Table.Columns)
            {
                var pn = (FieldPanel) pnMain.Controls[col.ColumnName];
                Row[col.ColumnName] = pn.tbField.Text;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateValue();//парсинг и проверка на правильность
                DialogResult = DialogResult.OK;//выход из формы, если все введено правильно
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//выводим сообщение об ошибке и не закрываем форму
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;//выход из формы
            Close();
        }
    }
}
