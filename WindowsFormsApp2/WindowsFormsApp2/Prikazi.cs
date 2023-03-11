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
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Prikazi : Form
    {
        int id;
        String link;
        public Prikazi(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void Prikazi_Load(object sender, EventArgs e)
        {
            String podaciOKonekciji = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(podaciOKonekciji);
            SqlCommand cmd = new SqlCommand("select * from dbo.informacije("+id+")", veza);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            label1.Text = dt.Rows[0]["sifra"].ToString();
            textBox1.Text = dt.Rows[0]["opis"].ToString();
            link = dt.Rows[0]["pdf"].ToString();
            textBox2.Text = dt.Rows[0]["kolicina"].ToString();
            label4.Text = (dt.Rows[0]["package"].ToString()+dt.Rows[0]["brojPinova"].ToString());
            try
            {
                pictureBox1.Image = Image.FromFile(Path.GetFullPath("C:\\Program Files\\ChipStorage\\slike\\" + label1.Text + ".png"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                pictureBox1.Image = null;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(link);
            Process.Start(sInfo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kol = int.Parse(textBox2.Text)+1;
            textBox2.Text = kol.ToString();
            updateKol(kol);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kol = int.Parse(textBox2.Text) - 1;
            if (kol < 0)
            {
                kol = 0;
            }
            else
            {
                textBox2.Text = kol.ToString();
                updateKol(kol);
            }
        }

        private void updateKol(int kol)
        {
            String podaciOKonekciji = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(podaciOKonekciji);
            SqlCommand cmd = new SqlCommand("update cipovi set kolicina = "+kol+" where id = "+id, veza);
            veza.Open();
            cmd.ExecuteNonQuery();
            veza.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Da li ste sigurni da zelite da obrisete cip " + label1.Text + "?", "Brisanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if (d == DialogResult.OK)
            {
                String podaciOKonekciji = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection veza = new SqlConnection(podaciOKonekciji);
                SqlCommand cmd = new SqlCommand("delete from cipovi where sifra = '" + label1.Text + "'", veza);
                veza.Open();
                cmd.ExecuteNonQuery();
                veza.Close();
                this.Close();
            }
            
        }
    }
}
