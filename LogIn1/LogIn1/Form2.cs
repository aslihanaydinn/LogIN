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

namespace LogIn1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string constring = ("Data Source=LAPTOP-H3SEJLE9;Initial Catalog=studentsDB;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);
        public void kayitları_getir()
        {

            baglan.Open();
            SqlDataAdapter veri = new SqlDataAdapter("select * from studentsTable", baglan);
            DataTable table = new DataTable();
            veri.Fill(table);
            dataGridView1.DataSource = table;
            baglan.Close();
        }
        public void kayitlari_temizle()
        {
            txtboxIsim.Text = " ";
            txtboxSoyisim.Text = "";
            txtboxBolum.Text = "";
            cmbboxSehir.Text = "";
            txtboxePosta.Text = "";
            txtboxSifre.Text = "";
            dateTimePicker1.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            kayitları_getir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string mailAdresi = txtboxePosta.Text;
                bool sonuc = IsValidEmail(mailAdresi);
                if (sonuc)
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                        SqlCommand komut = new SqlCommand("insert into studentsTable (isim,soyisim,bölüm,geldiğiŞehir,ePosta,şifre,kayıtTarihi) values (@isim,@soyisim,@bölüm,@geldiğiŞehir,@ePosta,@şifre,@kayıtTarihi)", baglan);
                        komut.Parameters.AddWithValue("@isim", txtboxIsim.Text);
                        komut.Parameters.AddWithValue("@soyisim", txtboxSoyisim.Text);
                        komut.Parameters.AddWithValue("@bölüm", txtboxBolum.Text);
                        komut.Parameters.AddWithValue("@geldiğiŞehir", cmbboxSehir.Text);
                        komut.Parameters.AddWithValue("@ePosta", txtboxePosta.Text);
                        komut.Parameters.AddWithValue("@şifre", txtboxSifre.Text);
                        var sqlParameterKayitTarihi = new SqlParameter("@kayıtTarihi", SqlDbType.DateTime);
                        sqlParameterKayitTarihi.Value = dateTimePicker1.Value;
                        komut.Parameters.Add(sqlParameterKayitTarihi);
                        komut.Connection = baglan;
                        // komut.Parameters.AddWithValue("@kayıtTarihi", dateTimePicker1.Value);
                        komut.ExecuteNonQuery();
                        //kayitları_getir();
                        baglan.Close();
                        kayitları_getir();
                        MessageBox.Show("Yeni öğrenci başarıyla eklendi!");


                    }
                }
                else
                {
                    MessageBox.Show("Lütfen doğru formatta mail adresi giriniz!");
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hatalı İşlem" + hata.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDBDataSet2.studentsTable' table. You can move, or remove it, as needed.
            this.studentsTableTableAdapter.Fill(this.studentsDBDataSet2.studentsTable);
            cmbboxSehir.SelectedIndex = 0;

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            kayitlari_temizle();
            kayitları_getir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();

                SqlCommand veriSil = new SqlCommand("delete from studentsTable where isim=@isim", baglan);
                veriSil.Parameters.AddWithValue("@isim", txtboxIsim.Text);
                veriSil.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Öğrenci Kaydı Silindi!");
                kayitları_getir();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hatalı İşlem Yaptınız!"+hata.Message);
            }

        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand guncelle = new SqlCommand("Update studentsTable set şifre=@şifre, geldiğiŞehir=@geldiğiŞehir,soyisim=@soyisim where isim=@isim", baglan);
            guncelle.Parameters.AddWithValue("@isim", txtboxIsim.Text);
            guncelle.Parameters.AddWithValue("@şifre", txtboxSifre.Text);
            guncelle.Parameters.AddWithValue("@geldiğiŞehir", cmbboxSehir.Text);
            guncelle.Parameters.AddWithValue("@soyisim", txtboxSoyisim.Text);
            guncelle.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Güncellendi!");
            kayitları_getir();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void txtboxIsim_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbboxSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbboxSehir.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbboxSehir.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int temp = dataGridView1.SelectedCells[0].RowIndex;
            txtboxIsim.Text = dataGridView1.Rows[temp].Cells[1].Value.ToString();
            txtboxSoyisim.Text = dataGridView1.Rows[temp].Cells[2].Value.ToString();
            txtboxBolum.Text = dataGridView1.Rows[temp].Cells[3].Value.ToString();
            cmbboxSehir.Text = dataGridView1.Rows[temp].Cells[4].Value.ToString();
            txtboxePosta.Text = dataGridView1.Rows[temp].Cells[5].Value.ToString();
            txtboxSifre.Text = dataGridView1.Rows[temp].Cells[6].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[temp].Cells[7].Value.ToString();
        }
    }
}
