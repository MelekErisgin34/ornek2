using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictionary_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private var kullanicilar = new Dictionary<int, string>();

        public object Kullanicilar { get => kullanicilar; set => kullanicilar = value; }

        private void button1_Click(object sender, EventArgs e)
        {

            kullanicilar.Add(0, "melek erisgin");
            kullanicilar.Add(1, " ilayda");
            kullanicilar.Add(2, "beyza");
            kullanicilar.Add(3, "asmın");

            foreach (KeyValuePair kullanici in kullanicilar)
            {
                Console.WriteLine("ID =>" + kullanici.Key + "\t" + "Ad Soyad =>" + kullanici.Value);


                string yeniKullanici = "melek erisgin";
                bool varMi = kullanicilar.TryGetValue(0, out yeniKullanici);
                if (varMi)
                {
                    //Böyle bir key mevcut
                    MessageBox.Show("Bu ID de bir kullanici mevcuttur.");
                }
                else
                {
                    //Değil ise ekleme işlemini yapalım
                    kullanicilar.Add(0, yeniKullanici);

                    MessageBox.Show("Ekleme işlemi başarıyla gerçekleşmiştir.");
                }
            }
        }
    }
}
