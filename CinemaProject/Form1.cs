using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaProject
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Cinema salon;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                salon = new Cinema(textBox1.Text, Convert.ToInt32(textBox2.Text));
              label3.Text="salon olusturuldu.koltuk sayisi "+salon.BosKoltukOgren();
            }
            catch
            {
                label3.Text = "salon olusturulmadi kontrol ediniy lutfen ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salon.BiletSat(checkBox1.Checked);
            label3.Text = "Bilet iptal edildi.Kalan koltuk sayisi" + salon.BosKoltukOgren();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salon.BiletIptal(checkBox1.Checked);
            label3.Text = "Bilet iptal edildi" + salon.BosKoltukOgren();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text="suanki bakizeniy "+salon.BakizeOgren();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "bos koltuk sayisi :" + salon.BosKoltukOgren();
        }
    }

    class Cinema
    {
        int toplamKoltukSayisi;
        int BosKoltukSayisi;
        double bakiye;
        string SalonNo;
        const double TAM = 15;
        const double INDIRIMLI = 10;

        public Cinema(string salonn,int koltuksayi)//korucu metot
        {
            toplamKoltukSayisi = koltuksayi;
            SalonNo= salonn;
            BosKoltukSayisi = toplamKoltukSayisi;
            bakiye = 0;

        }
        //bilet satisi 
        public void BiletSat(bool indirimli)
        {
            BosKoltukSayisi--;
            if (indirimli)
                bakiye += INDIRIMLI;
            else
                bakiye += TAM;
        }
        //bilet iade
        public void BiletIptal(bool indirimli)
        {
            BosKoltukSayisi++;
            if (indirimli)
                bakiye -= INDIRIMLI;
            else
                bakiye -= TAM;
        }
        //bos koltuk sayisi
        public int BosKoltukOgren()
        {
            return BosKoltukSayisi;
        }
        //bakize ogren
        public double BakizeOgren()
        {
            return bakiye;
        }
    }
}
