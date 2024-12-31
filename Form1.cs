using Microsoft.EntityFrameworkCore;

namespace denemeodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnderssec_Click(object sender, EventArgs e)
        {
            using (var ctx = new OkulContext())
            {
                var ogrenci = ctx.Ogrenciler.Include(o => o.OgrenciDersleri).FirstOrDefault(o => o.Numara == tboxNo.Text);

                if (ogrenci != null)
                {
                    
                    var dersSecimForm = new Form2();
                    dersSecimForm.SecilenOgrenciId = ogrenci.OgrenciId; 
                    dersSecimForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("L�tfen �nce ��renci bulun!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new OkulContext())
            {
                cboxsinif.DataSource = context.Siniflar.ToList();
                cboxsinif.DisplayMember = "Adi";
                cboxsinif.ValueMember = "SinifId";
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            using (var ctx = new OkulContext())
            {
                string adi = tboxad.Text.Trim();
                string soyadi = tboxsoyad.Text.Trim();
                string numara = tboxNo.Text.Trim();

                try
                {
                    
                    if (cboxsinif.SelectedValue == null)
                    {
                        MessageBox.Show("L�tfen bir s�n�f se�in.");
                        return;
                    }

                    int sinifId = (int)cboxsinif.SelectedValue;
                    var sinif = ctx.Siniflar.Include(s => s.Ogrenciler).FirstOrDefault(s => s.SinifId == sinifId);

                    if (sinif == null)
                    {
                        MessageBox.Show("Se�ilen s�n�f bulunamad�.");
                        return;
                    }

                    var mevcutOgrenci = ctx.Ogrenciler.FirstOrDefault(o => o.Adi == adi && o.Soyadi == soyadi && o.Numara == numara);
                    if (mevcutOgrenci != null)
                    {
                        MessageBox.Show("Bu ��renci zaten kay�tl�!");
                        return;
                    }

                    
                    if (sinif.Ogrenciler.Count >= sinif.Kapasite)
                    {
                        MessageBox.Show("Se�ilen s�n�f�n kapasitesi dolmu�!");
                        return;
                    }

                    
                    if (string.IsNullOrWhiteSpace(tboxad.Text) || string.IsNullOrWhiteSpace(tboxsoyad.Text) || string.IsNullOrWhiteSpace(tboxNo.Text))
                    {
                        MessageBox.Show("L�tfen t�m alanlar� doldurun.");
                        return;
                    }

                    var yeniOgrenci = new Ogrenci
                    {
                        Adi = tboxad.Text,
                        Soyadi = tboxsoyad.Text,
                        Numara = tboxNo.Text,
                        SinifId = sinifId
                    };

                    ctx.Ogrenciler.Add(yeniOgrenci);
                    ctx.SaveChanges();

                    MessageBox.Show("��renci ba�ar�yla kaydedildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata olu�tu: {ex.Message}");
                }
            }
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            using (var ctx = new OkulContext())
            {
                int numara;
                if (int.TryParse(tboxNo.Text, out numara))
                {
                    var ogrenci = ctx.Ogrenciler.Include(o => o.Sinif).FirstOrDefault(o => o.Numara == tboxNo.Text);

                    if (ogrenci != null)
                    {
                        tboxad.Text = ogrenci.Adi;
                        tboxsoyad.Text = ogrenci.Soyadi;
                        cboxsinif.SelectedValue = ogrenci.SinifId;

                        MessageBox.Show("��renci bilgileri y�klendi.");
                    }
                    else
                    {
                        MessageBox.Show("��renci bulunamad�.");
                    }
                }
                else
                {
                    MessageBox.Show("Ge�erli bir ��renci numaras� girin.");
                }
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            using (var ctx = new OkulContext())
            {
                int numara;
                if (int.TryParse(tboxNo.Text, out numara))
                {
                    var ogrenci = ctx.Ogrenciler.FirstOrDefault(o => o.Numara == tboxNo.Text);

                    if (ogrenci != null)
                    {
                        ogrenci.Adi = tboxad.Text;
                        ogrenci.Soyadi = tboxsoyad.Text;
                        ogrenci.SinifId = (int)cboxsinif.SelectedValue;

                        ctx.SaveChanges();
                        MessageBox.Show("��renci bilgileri ba�ar�yla g�ncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("��renci bulunamad�.");
                    }
                }
                else
                {
                    MessageBox.Show("Ge�erli bir ��renci numaras� girin.");
                }
            }
        }
    }
}
