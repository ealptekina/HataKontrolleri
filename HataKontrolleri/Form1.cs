using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataKontrolleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
             * try-catch Yapısı
                try: Hata çıkması muhtemel kodlar bu bloğun içine yazılır. Eğer bir hata oluşursa, kontrol catch bloğuna aktarılır.
                    catch: Hataları yakalar ve bu hataları nasıl işleyeceğinizi belirtir.
             * Sadece kritik hataları yakalayın: Çok geniş kapsamlı catch blokları yazmak, hataların kaynağını bulmayı zorlaştırabilir.
                try-catch bloğu çok geniş kapsamlı olmamalı; sadece hata çıkarabilecek kodları kapsamalıdır.

            try bloğu içinde hata oluşturabilecek kodlar yer alır. Eğer bir hata oluşursa, kontrol catch bloğuna aktarılır. Genel olarak Exception sınıfını kullanarak her tür hatayı yakalayabilirsiniz. Bu yöntem, beklenmeyen hataları yönetmek için kullanışlıdır.
             */
            try
            {
                int sayi1 = Convert.ToInt16(textBox1.Text);
                int sayi2 = Convert.ToInt16(textBox2.Text);

                int toplam = sayi1 + sayi2;

                MessageBox.Show(toplam.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen değerlerinizi kontrol edin!");
            }
        }

        // hata detayını string olarak ekranda gösterir

        /*
         * Exception Özellikleri
             Exception sınıfını yakalamak tüm hataları kapsar ancak, spesifik hata türlerini yakalamak genellikle daha iyidir. Böylece hata türüne göre daha uygun müdahaleler yapabilirsiniz.
         
            Hata yönetiminde Exception sınıfının sağladığı özellikler hata ayıklamayı kolaylaştırır:

            Message: Hatanın nedenini belirtir. Kullanıcıya ya da loglara iletilebilir.
            StackTrace: Hatanın meydana geldiği yerin izini sürmek için kullanılır.
            InnerException: İç içe geçmiş hataları anlamak için kullanılır. Bir hata başka bir hatayı tetikleyebilir.
         */
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int s1, s2, sonuc;
                s1 = Convert.ToInt16(textBox1.Text);
                s2 = Convert.ToInt16(textBox2.Text);
                sonuc = s1 * s2;
                label3.Text = sonuc.ToString();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }

        }

        // Hata yok ise; try ve finally blokları çalışır. Hata var ise catch ve finally bloğu çalışır

        /*finally Bloğu ve Exception
            finally bloğu, hatadan bağımsız olarak her durumda çalışır.Bağlantıları kapatma, 
                dosya işleme ya da kaynakları temizleme gibi işlemleri yaparken kullanılır.
        */
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int s1, s2, sonuc;
                s1 = Convert.ToInt16(textBox1.Text);
                s2 = Convert.ToInt16(textBox2.Text);
                sonuc = s1 * s2;
                label3.Text = sonuc.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata var catch Exception çalıştı");
            }
            finally
            {
                MessageBox.Show("Finally Kodu Çalıştı");
            }
        }
    }
}
