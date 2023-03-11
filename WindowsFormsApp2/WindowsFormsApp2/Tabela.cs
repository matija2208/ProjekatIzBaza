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
    public partial class Tabela : Form
    {
        public Tabela()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                String podaciOKonekciji = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection veza = new SqlConnection(podaciOKonekciji);
                SqlCommand cmd = new SqlCommand("select * from dbo.cipoviPoKategoriji('')", veza);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                kategorijeToolStripMenuItem.DropDownItems.Clear();
                cmd = new SqlCommand("select * from kategorije", veza);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ToolStripMenuItem t = new ToolStripMenuItem();
                    t.Text = dt.Rows[i]["naziv"].ToString();
                    cmd = new SqlCommand("select * from podkategorije where idKategorije = " + dt.Rows[i]["id"].ToString(), veza);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dt2 = new DataTable();
                    adapter.Fill(dt2);
                    t.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
                    if (dt2.Rows.Count > 0)
                    {
                        for (int j = 0; j < dt2.Rows.Count; j++)
                        {
                            ToolStripMenuItem t2 = new ToolStripMenuItem();
                            t2.Text = dt2.Rows[j]["naziv"].ToString();
                            t2.Click += new System.EventHandler(this.PodToolStripMenuItem_Click);

                            t.DropDownItems.Add(t2);
                        }
                    }
                    kategorijeToolStripMenuItem.DropDownItems.Add(t);

                }


                kucisteToolStripMenuItem.DropDownItems.Clear();
                cmd = new SqlCommand("SELECT package from cipovi group by package", veza);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    cmd = new SqlCommand("select brojPinova from cipovi where package = '" + dt.Rows[i]["package"].ToString() + "' group by brojPinova order by brojPinova asc", veza);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dt2 = new DataTable();
                    adapter.Fill(dt2);

                    if (dt2.Rows.Count > 0)
                    {
                        ToolStripMenuItem t = new ToolStripMenuItem();
                        t.Text = dt.Rows[i]["package"].ToString();
                        t.Name = dt.Rows[i]["package"].ToString();
                        t.Click += new System.EventHandler(this.dIPToolStripMenuItem_Click);

                        for (int j = 0; j < dt2.Rows.Count; j++)
                        {
                            ToolStripMenuItem t2 = new ToolStripMenuItem();
                            t2.Text = dt2.Rows[j]["brojPinova"].ToString();
                            t2.Name = dt.Rows[i]["package"].ToString() + "_" + dt2.Rows[j]["brojPinova"].ToString();
                            t2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
                            t.DropDownItems.Add(t2);
                        }
                        kucisteToolStripMenuItem.DropDownItems.Add(t);
                    }
                    else
                    {
                        ToolStripMenuItem t = new ToolStripMenuItem();
                        t.Text = dt.Rows[i]["package"].ToString();
                        t.Name = dt.Rows[i]["package"].ToString();
                        t.Click += new System.EventHandler(this.dIPToolStripMenuItem_Click);
                        kucisteToolStripMenuItem.DropDownItems.Add(t);
                    }


                }
            }
            catch (Exception ex)
            {
                DialogResult d = MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if(d == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
        private void prikaziSveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String podaciOKonekciji = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(podaciOKonekciji);
            SqlCommand cmd = new SqlCommand("select * from dbo.cipoviPoKategoriji('')", veza);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String podaciOKonekciji = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(podaciOKonekciji);
            SqlCommand cmd = new SqlCommand("select * from dbo.cipoviPoKategoriji('"+((ToolStripMenuItem)sender).Text+"')", veza);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        

        private void PodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String podaciOKonekciji = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(podaciOKonekciji);
            SqlCommand cmd = new SqlCommand("select * from dbo.cipoviPoPodkategoriji('"+ ((ToolStripMenuItem)sender).Text + "')", veza);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

       

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var x = (dataGridView1.Rows[e.RowIndex].Cells[0].Value).ToString();
            if (x == "")
            {
                MessageBox.Show("Kliknuli ste na prazno polje!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(x);
                Prikazi t = new Prikazi(id);
                t.FormClosed += new FormClosedEventHandler(dodajClosed);
                t.Show();
            }
            
        }

        private void kategorijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajKategoriju t = new DodajKategoriju();
            t.FormClosed += new FormClosedEventHandler(dodajClosed);
            t.Show();
        }

        private void podkategorijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajPodkategoriju t = new DodajPodkategoriju();
            t.FormClosed += new FormClosedEventHandler(dodajClosed);
            t.Show();
        }

        void dodajClosed(object sender, FormClosedEventArgs e)
        {
            this.Form1_Load(sender, e);
        }

        private void cipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dodaj t = new Dodaj();
            t.FormClosed += new FormClosedEventHandler(dodajClosed);
            t.Show();

        }

        private void dIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String podaciOKonekciji = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(podaciOKonekciji);
            SqlCommand cmd = new SqlCommand("select * from dbo.cipoviPoPakovanju('"+((ToolStripMenuItem)sender).Text+"',NULL)", veza);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            String podaciOKonekciji = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(podaciOKonekciji);
            SqlCommand cmd = new SqlCommand("select * from dbo.cipoviPoPakovanju('"+((ToolStripMenuItem)sender).Name.Split('_')[0] + "',"+((ToolStripMenuItem)sender).Text+")", veza);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            String podaciOKonekciji = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(podaciOKonekciji);
            SqlCommand cmd = new SqlCommand("select * from dbo.google('" + ((ToolStripTextBox)sender).Text+"')", veza);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
