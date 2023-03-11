using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class DodajKategoriju : Form
    {
        public DodajKategoriju()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String naziv = textBox1.Text;

            String podaciOKonekciji = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(podaciOKonekciji);
            SqlCommand cmd = new SqlCommand("select * from kategorije where naziv = '"+naziv+"'", veza);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if(dt.Rows.Count == 0)
            {
                cmd = new SqlCommand("insert into kategorije values ('" + naziv + "')", veza);
                veza.Open();
                cmd.ExecuteNonQuery();
                veza.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kategorija vec postoji!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
