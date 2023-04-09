using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p3Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno =0, dogru = 0, yanlis =0;

       

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Yarışmanın Kuralları Aşağıda Belirtilmiştir. Lütfen Kurallara Dikkat Ediniz! \n 1)Cevaplarınızı ilk harfi büyük olacak şekilde veriniz. \n 2)Cevabınızı yazdıktan sonra 'Enter' tuşuna basmanız yeterli olacaktır.\n \t \t" +
               " BAŞARILAR!", "YARIŞMA KURALLARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

       
        private void btnCevapla_Click(object sender, EventArgs e)
        {
            btnCevapla.Text = "SONRAKİ SORU!";
            soruno++;
            this.Text=soruno.ToString();
            textBox1.Text = "";
           
            if (soruno == 1)     
            {
                richTextBox1.Text = "Plaka kodu 03 olan ilimiz hangisidir?";
                button1.BackColor = Color.Yellow;
                button8.Text= "A";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Uludağ hangi ilimizde bulunur?";
                button2.BackColor = Color.Yellow;
                button8.Text= "B";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü haftanın hangi günüdür?";
                button3.BackColor = Color.Yellow;
                button8.Text = "c";

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Deniz kelimesinin eş anlamlısıdır.";
                button4.BackColor = Color.Yellow;
                button8.Text = "D";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Bir sıfat, yeni değil.";
                button5.BackColor = Color.Yellow; 
                button8.Text = "E";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Kuzey Afrikada bir ülke.";
                button6.BackColor = Color.Yellow;
                button8.Text = "F";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Çocuk değil , Yaşlı değil. Çocuk ve yaşlının ortası.";
                button7.BackColor = Color.Yellow;
                button8.Text = "G";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Doktora giden insanlar.";
                button13.BackColor = Color.Yellow;
                button8.Text = "H";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Türkiyenin komşusu bir ülke.";
                button12.BackColor = Color.Yellow;
                button8.Text = "I";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Süt veren, eti yenilen bir çiftlik hayvanı.";
                button11.BackColor = Color.Yellow;
                button8.Text = "İ";
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Uzak Doğu Asya'da bir ülke.";
                button10.BackColor = Color.Yellow;
                button8.Text = "J";
            }
            if (soruno == 12)
            {
                richTextBox1.Text = " İnsanların kitap okuduğu , kitap aldığı yer. Orada insanlar genellikle sessiz olurlar.";
                button9.BackColor = Color.Yellow;
                button8.Text = "K";
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Sarı renkli , ekşi bir meyve.";
                button24.BackColor = Color.Yellow;
                button8.Text = "L";
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Nesli tükenmiş, soğuklarda yaşayan, büyük dişlere sahip bir hayvan.";
                button23.BackColor = Color.Yellow;
                button8.Text = "M";
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "En çok kullanılan soru kelimesi.";
                button22.BackColor = Color.Yellow;
                button8.Text = "N";
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "İki ya da ikiden çok nicelik toplamının, bu niceliklerin sayısına bölünmesinden çıkan (sayı).";
                button21.BackColor = Color.Yellow;
                button8.Text = "O";
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Fransa'nın başkenti.";
                button19.BackColor = Color.Yellow; 
                button8.Text = "P";
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Genellikle insan biçiminde ve metalden vb. yapılan, programlanınca belirli bir işi ya da çeşitli işleri yapabilen, " +
                                    "fabrikalarda tehlikeli işlerde insan yerine kulllanılan, elektrikle çalışan otomatik aygıt.";
                button18.BackColor = Color.Yellow;
                button8.Text = "R";
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Çıkılması ve geçilmesi güç, çok dik, yalçın.";
                button17.BackColor = Color.Yellow;
                button8.Text = "S";
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Bir olayın gününü, ayını ve yılını bildiren söz ya da rakam.";
                button15.BackColor = Color.Yellow;
                button8.Text = "T";
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Belleğinde kalmamış olmak, aklından çıkıp gitmek, aklında kalmamak, anımsamamak.";
                button14.BackColor = Color.Yellow;
                button8.Text = "U";
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Türkiye'nin en büyük gölünün bulunduğu şehir.";
                button25.BackColor = Color.Yellow;
                button8.Text = "V";
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Bir acıyı gösteren davranış.";
                button26.BackColor = Color.Yellow;
                button8.Text = "Y";
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Karşısındaki kişinin gerçek duygu ve düşüncelerini öğrenmek için kasıtlı olarak gerekli sözleri söylemek ve ona zorla gerçeği söyletmek.";
                button27.BackColor = Color.Yellow;
                button8.Text = "Z";
            }
            if(soruno == 25)
            {
                richTextBox1.Text = "";
                MessageBox.Show("Yarışmayı Tamamlamış Bulunmaktasınız!\n Doğru Sayınız:" + dogru + "\n Yanlış Sayınız:" + yanlis, "YARIŞMA TAMAMLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                { 
                    case 1:
                        if (textBox1.Text == "Adıyaman")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "Bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "Cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "Derya")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "Eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "Fas")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "Genç")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "Hasta")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "Irak")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "İnek")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "Japonya")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "Kütüphane")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "Limon")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "Mamut")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "Ne")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "Ortalama")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "Paris")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "Robot")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "Sarp")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "Tarih")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "Unutmak")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "Van")
                        {
                            button25.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button25.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "Yas")
                        {
                            button26.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button26.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text.ToUpper() == "ZARF ATMAK")
                        {
                            button27.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button27.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                }
            }
        }

    }
}
