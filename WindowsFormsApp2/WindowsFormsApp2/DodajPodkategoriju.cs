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

namespace WindowsFormsApp2
{
    public partial class DodajPodkategoriju : Form
    {
        public DodajPodkategoriju()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kategorija = comboBox1.Text;
            String podkategorija = textBox2.Text;

            String podaciOKonekciji = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(podaciOKonekciji);
            SqlCommand cmd = new SqlCommand("select * from kategorije where naziv = '" + kategorija + "'", veza);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                int id = int.Parse(dt.Rows[0]["id"].ToString());
                cmd = new SqlCommand("select * from podkategorije where naziv = '" + podkategorija + "' and idKategorije = "+id.ToString(), veza);
                adapter=new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                if(dt.Rows.Count == 0)
                {
                    cmd = new SqlCommand("insert into podkategorije values ('" + podkategorija + "',"+id+")", veza);
                    veza.Open();
                    cmd.ExecuteNonQuery();
                    veza.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Podkategorija vec postoji!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Kategorija ne postoji!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DodajPodkategoriju_Load(object sender, EventArgs e)
        {
            String podaciOKonekciji = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(podaciOKonekciji);

            SqlCommand cmd = new SqlCommand("select * from kategorije", veza);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            ad.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["naziv"].ToString());
            }
        }
    }
}
