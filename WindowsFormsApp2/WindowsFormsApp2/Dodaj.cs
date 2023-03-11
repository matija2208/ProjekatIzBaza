using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Dodaj : Form
    {
        String path;
        String destiny = "C:\\Program Files\\ChipStorage\\slike";
        public Dodaj()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "This PC";
            openFileDialog1.ShowDialog(this);
            path = openFileDialog1.FileName;
            slika.Text = path;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            String SIFRA = sifra.Text;
            String KATEGORIJA = kategorija.Text;
            String PODKATEGORIJA = podkategorija.Text;
            String OPIS = opis.Text;
            int kol = int.Parse(kolicina.Text);
            String KUCISTE = kuciste.Text;
            int brPin = int.Parse(brPinova.Text);
            String PDF = pdf.Text;

            if(SIFRA == "" || KATEGORIJA == "" || OPIS == "" || PDF == "" || KUCISTE == "" || brPin == null || path == "")
            {
                label10.Text = "POPUNITE SVA POLJA!!!";
                label10.Visible = true;
            }
            else
            {
                String podaciOKonekciji = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection veza = new SqlConnection(podaciOKonekciji);

                SqlCommand cmd = new SqlCommand("select id from kategorije where naziv = '" + KATEGORIJA + "'", veza);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                ad.Fill(dt);

                if(dt.Rows.Count == 0)
                {
                    label10.Text = "NEPOSTOJECA KATEGORIJA!!!";
                    label10.Visible=true;
                }
                else
                {
                    int kategorijaID = int.Parse(dt.Rows[0]["id"].ToString());

                    cmd = new SqlCommand("select id from podkategorije where naziv = '" + PODKATEGORIJA + "'", veza);
                    ad = new SqlDataAdapter(cmd);
                    dt = new DataTable();

                    ad.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        label10.Text = "NEPOSTOJECA PODKATEGORIJA!!!";
                        label10.Visible = true;
                    }
                    else
                    {
                        int podkategorijaID = int.Parse(dt.Rows[0]["id"].ToString());

                        try
                        {
                            cmd = new SqlCommand("select id from cipovi where sifra = '" + SIFRA + "'",veza);
                            ad=new SqlDataAdapter(cmd);
                            dt=new DataTable();
                            ad.Fill(dt);
                            if(dt.Rows.Count==0)
                            {
                                cmd = new SqlCommand("insert into cipovi values('" + SIFRA + "','" + OPIS + "','" + PDF + "'," + kol.ToString() + ",'" + KUCISTE + "'," + brPin + "," + kategorijaID + "," + podkategorijaID + ")", veza);
                                veza.Open();
                                cmd.ExecuteNonQuery();
                                veza.Close();
                                File.Copy(path, destiny + "/" + SIFRA + ".png",true);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Uneta vec postojeca sifra!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void Dodaj_Load(object sender, EventArgs e)
        {
            String podaciOKonekciji = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(podaciOKonekciji);

            SqlCommand cmd = new SqlCommand("select * from kategorije", veza);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            ad.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                kategorija.Items.Add(dr["naziv"].ToString());
            }

            kolicina.Text = "0";
            brPinova.Text = "0";
        }

        private void kategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            String podaciOKonekciji = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(podaciOKonekciji);

            SqlCommand cmd = new SqlCommand("select podkategorije.naziv from podkategorije join kategorije on (kategorije.id = podkategorije.idKategorije) where kategorije.naziv = '"+kategorija.Text+"'", veza);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            ad.Fill(dt);

            if(dt.Rows.Count>0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    podkategorija.Items.Add(dt.Rows[i]["naziv"].ToString());
                }
                podkategorija.Enabled = true;
            }
            else
            {
                podkategorija.Items.Clear();
                podkategorija.Enabled=false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kol = int.Parse(kolicina.Text) + 1;
            kolicina.Text = kol.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kol = int.Parse(kolicina.Text) - 1;
            if (kol < 0)
            {
                kol = 0;
            }
            else
            {
                kolicina.Text = kol.ToString();
            }
        }
    }
}
