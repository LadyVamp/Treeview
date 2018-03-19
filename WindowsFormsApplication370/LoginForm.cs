using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Treeview
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //admin; pass
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-O9H5H8N;Initial Catalog=RepositoryDB3;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TUser WHERE Username='" + txtLogin.Text + "' AND Password='" + txtPassword.Text + "' " + "AND Username='admin'", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                MainAP f = new MainAP();
                f.Show();
            }

            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }


    }
}
