namespace kişilik_testi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            a.Enabled= false;
            b.Enabled= false;
            c.Enabled= false;    
            d.Enabled= false;
            ee.Enabled= false;
        }

        int sayac = 0;
        int puan = 0;
        string a1; string b1; string c1; string d1; string e1;

        


        void sorular()
        {
            if (sayac == 1)
            {
                textBox1.Text = "Sabahları neşeli bir şekilde uyanırım.";
                a.Text = "Hiç tanımlamıyor";
                b.Text = "Biraz tanımlıyor";
                c.Text = "Oldukça iyi tanımlıyor";
                d.Text = "iyi tanımlıyor";
                ee.Text = "Çok iyi tanımlıyor";
                a1 = a.Text;
                b1 = b.Text;
                c1 = c.Text;
                d1 = d.Text;
                e1 = ee.Text;
            }
            else if (sayac == 2)
            {
                textBox1.Text = "Çoğunlukla neşem yerindedir.";
                a.Text = "Hiç tanımlamıyor";
                b.Text = "Biraz tanımlıyor";
                c.Text = "Oldukça iyi tanımlıyor";
                d.Text = "iyi tanımlıyor";
                ee.Text = "Çok iyi tanımlıyor";
                a1 = a.Text;
                b1 = b.Text;
                c1 = c.Text;
                d1 = d.Text;
                e1 = ee.Text;
            }
            else if (sayac == 3)
            {
                textBox1.Text = "Çoğu kimse tarafından sevilirim.";
                a.Text = "Hiç tanımlamıyor";
                b.Text = "Biraz tanımlıyor";
                c.Text = "Oldukça iyi tanımlıyor";
                d.Text = "iyi tanımlıyor";
                ee.Text = "Çok iyi tanımlıyor";
                a1 = a.Text;
                b1 = b.Text;
                c1 = c.Text;
                d1 = d.Text;
                e1 = ee.Text;
            }
            else if (sayac == 4)
            {
                textBox1.Text = "Aynaya baktığım zaman, aynada gördüklerim hoşuma gider.";
                a.Text = "Hiç tanımlamıyor";
                b.Text = "Biraz tanımlıyor";
                c.Text = "Oldukça iyi tanımlıyor";
                d.Text = "iyi tanımlıyor";
                ee.Text = "Çok iyi tanımlıyor";
                a1 = a.Text;
                b1 = b.Text;
                c1 = c.Text;
                d1 = d.Text;
                e1 = ee.Text;
            }
            else if (sayac == 5)
            {
                textBox1.Text = "Eğer karşı cinsten biri olsaydım kendimi çekici bulurdum.";
                a.Text = "Hiç tanımlamıyor";
                b.Text = "Biraz tanımlıyor";
                c.Text = "Oldukça iyi tanımlıyor";
                d.Text = "iyi tanımlıyor";
                ee.Text = "Çok iyi tanımlıyor";
                a1 = a.Text;
                b1 = b.Text;
                c1 = c.Text;
                d1 = d.Text;
                e1 = ee.Text;
            }
            else if (sayac == 6)
            {
                textBox1.Text = "Zeki bir insanım.";
                a.Text = "Hiç tanımlamıyor";
                b.Text = "Biraz tanımlıyor";
                c.Text = "Oldukça iyi tanımlıyor";
                d.Text = "iyi tanımlıyor";
                ee.Text = "Çok iyi tanımlıyor";
                a1 = a.Text;
                b1 = b.Text;
                c1 = c.Text;
                d1 = d.Text;
                e1 = ee.Text;
            }
            else if (sayac == 7)
            {
                textBox1.Text = "İşimden hoşlanırım.";
                a.Text = "Hiç tanımlamıyor";
                b.Text = "Biraz tanımlıyor";
                c.Text = "Oldukça iyi tanımlıyor";
                d.Text = "iyi tanımlıyor";
                ee.Text = "Çok iyi tanımlıyor";
                a1 = a.Text;
                b1 = b.Text;
                c1 = c.Text;
                d1 = d.Text;
                e1 = ee.Text;
            }
            else if (sayac == 8)
            {
                textBox1.Text = "Kendimle ilgili olarak utanılacak pek bir şey göremiyorum.";
                a.Text = "Hiç tanımlamıyor";
                b.Text = "Biraz tanımlıyor";
                c.Text = "Oldukça iyi tanımlıyor";
                d.Text = "iyi tanımlıyor";
                ee.Text = "Çok iyi tanımlıyor";
                a1 = a.Text;
                b1 = b.Text;
                c1 = c.Text;
                d1 = d.Text;
                e1 = ee.Text;
            }
            else if (sayac == 9)
            {
                textBox1.Text = "Hala gelişen ve değişen bir insanım.";
                a.Text = "Hiç tanımlamıyor";
                b.Text = "Biraz tanımlıyor";
                c.Text = "Oldukça iyi tanımlıyor";
                d.Text = "iyi tanımlıyor";
                ee.Text = "Çok iyi tanımlıyor";
                a1 = a.Text;
                b1 = b.Text;
                c1 = c.Text;
                d1 = d.Text;
                e1 = ee.Text;
            }
            else if (sayac == 10)
            {
                textBox1.Text = "Arkadaşlarımın sayısı yönünden içim rahat.";
                a.Text = "Hiç tanımlamıyor";
                b.Text = "Biraz tanımlıyor";
                c.Text = "Oldukça iyi tanımlıyor";
                d.Text = "iyi tanımlıyor";
                ee.Text = "Çok iyi tanımlıyor";
                a1 = a.Text;
                b1 = b.Text;
                c1 = c.Text;
                d1 = d.Text;
                e1 = ee.Text;
            }
            else if (sayac == 11)
            {
                textBox1.Text = "Zeki bir insanım.";
                a.Text = "Hiç tanımlamıyor";
                b.Text = "Biraz tanımlıyor";
                c.Text = "Oldukça iyi tanımlıyor";
                d.Text = "iyi tanımlıyor";
                ee.Text = "Çok iyi tanımlıyor";
                a1 = a.Text;
                b1 = b.Text;
                c1 = c.Text;
                d1 = d.Text;
                e1 = ee.Text;
            }
            else if (sayac == 12)
            {
                textBox1.Text = "Oldukça enerjik bir insanım.";
                a.Text = "Hiç tanımlamıyor";
                b.Text = "Biraz tanımlıyor";
                c.Text = "Oldukça iyi tanımlıyor";
                d.Text = "iyi tanımlıyor";
                ee.Text = "Çok iyi tanımlıyor";
                a1 = a.Text;
                b1 = b.Text;
                c1 = c.Text;
                d1 = d.Text;
                e1 = ee.Text;
            }
            else if (sayac == 13)
            {
                textBox1.Text = "Kendi hatalarıma gülebilirim.";
                a.Text = "Hiç tanımlamıyor";
                b.Text = "Biraz tanımlıyor";
                c.Text = "Oldukça iyi tanımlıyor";
                d.Text = "iyi tanımlıyor";
                ee.Text = "Çok iyi tanımlıyor";
                a1 = a.Text;
                b1 = b.Text;
                c1 = c.Text;
                d1 = d.Text;
                e1 = ee.Text;
            }
            else if (sayac == 14)
            {
                textBox1.Text = "Esas olarak iyimser bir kişiyim.";
                a.Text = "Hiç tanımlamıyor";
                b.Text = "Biraz tanımlıyor";
                c.Text = "Oldukça iyi tanımlıyor";
                d.Text = "iyi tanımlıyor";
                ee.Text = "Çok iyi tanımlıyor";
                a1 = a.Text;
                b1 = b.Text;
                c1 = c.Text;
                d1 = d.Text;
                e1 = ee.Text;
            }
            else if (sayac == 15)
            {
                textBox1.Text = "Ben ilginç bir insanım.";
                a.Text = "Hiç tanımlamıyor";
                b.Text = "Biraz tanımlıyor";
                c.Text = "Oldukça iyi tanımlıyor";
                d.Text = "iyi tanımlıyor";
                ee.Text = "Çok iyi tanımlıyor";
                a1 = a.Text;
                b1 = b.Text;
                c1 = c.Text;
                d1 = d.Text;
                e1 = ee.Text;
            }
            else if (sayac == 16)
            {
                label1.Text = "";
                sorugetir.Enabled = true;
                a.Enabled = true;
                b.Enabled = true;
                c.Enabled = true;
                d.Enabled = true;
                ee.Enabled = true;
                MessageBox.Show("TEST SONA ERDİ!");
                label2.Visible = true;
                textBox2.Visible = true;
                label3.Visible = true;
                a.Visible = false; b.Visible = false; c.Visible = false; d.Visible = false; ee.Visible = false; textBox1.Visible = false;
                label1.Visible = false; sorugetir.Visible = false;
                textBox1.Enabled = true;

            
            }
            if (puan < 16)
            {
                textBox2.Text= "Kendinizi pek seven bir insan değilsiniz.";
                label3.Text="Puanınız: "+puan.ToString();
            }
            if(puan>=16 && puan<=31)
            {
                textBox2.Text = "Kendinizle ilgili karışık duygularınız var.";
                label3.Text = "Puanınız: " + puan.ToString();
            }
            if(puan>=31 && puan<=45)
            {
                textBox2.Text = "Kendini seven ve kendinize kendisiyle barışık yaşayan şanslı insanlardansınız.";
                label3.Text = "Puanınız: " + puan.ToString();
            }
            if(puan>=45 && puan <= 60)
            {
                textBox2.Text = "Kendi hakkında oldukça olumlu düşünen birisiniz.";
                label3.Text = "Puanınız: " + puan.ToString();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sorugetir_Click(object sender, EventArgs e)
        {
            sayac++;
            sorugetir.Text = "SIRADAKİ SORU";
            label1.Text = "SORU" + sayac + ":";
            sorular();
            a.Enabled = true;
            b.Enabled = true;
            c.Enabled = true;
            d.Enabled = true;
            ee.Enabled = true;
            sorugetir.Enabled = false;
        }

        private void cevaplar(object sender, EventArgs e)
        {
            if ((sender as Button).Text == a1)
            {
                puan += 1;
                a.Enabled = false;
                b.Enabled = false;
                c.Enabled = false;
                d.Enabled = false;
                ee.Enabled = false;
                sorugetir.Enabled = true;
            }
            else if ((sender as Button).Text == b1)
            {
                puan += 2;
                a.Enabled = false;
                b.Enabled = false;
                c.Enabled = false;
                d.Enabled = false;
                ee.Enabled = false;
                sorugetir.Enabled = true;
            }
            else if ((sender as Button).Text == c1)
            {
                puan += 3;
                a.Enabled = false;
                b.Enabled = false;
                c.Enabled = false;
                d.Enabled = false;
                ee.Enabled = false;
                sorugetir.Enabled = true;
            }
            else if ((sender as Button).Text == d1)
            {
                puan += 4;
                a.Enabled = false;
                b.Enabled = false;
                c.Enabled = false;
                d.Enabled = false;
                ee.Enabled = false;
                sorugetir.Enabled = true;
            }
            else if ((sender as Button).Text == e1)
            {
                puan += 5;
                a.Enabled = false;
                b.Enabled = false;
                c.Enabled = false;
                d.Enabled = false;
                ee.Enabled = false;
                sorugetir.Enabled = true;
            }
        }
    }
}