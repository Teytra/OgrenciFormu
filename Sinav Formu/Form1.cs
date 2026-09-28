namespace Sinav_Formu
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }
        private string[] ogrenciler;
        private string gecti_kaldi;
        private string erkek_kadin;
        private Random rastgele = new Random();
        byte index = 0;
        byte indexel = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            if (indexel > 0)
            {
                MessageBox.Show("Öğrencileri Zaten Listeye Aktardın");
            }
            else
            {
                if (ogrenciler == null)
                {
                    MessageBox.Show("Lütfen Önce Sınıf Mevcudunu Giriniz");
                }
                else if (ogrenciler[ogrenciler.Length - 1] == null)
                {
                    MessageBox.Show("Lütfen Öğrenci İsimlerini Giriniz");
                }
                else
                {
                    foreach (string a in ogrenciler)
                    {
                        listBox1.Items.Add(a);
                    }
                    OgrenciAdi.Text = "Öğrenciler Listeye Aktarıldı";
                    indexel++;
                }
            }

        }

        public void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Lütfen Cinsiyet Belirtiniz");
                }
                else
                {
                    if (index < ogrenciler.Length)
                    {
                        index++;
                        if (index + 1 > ogrenciler.Length)
                        {
                            OgrenciAdi.Text = "Lütfen Öğrencileri Listeye Aktarınız";
                        }
                        else
                        {
                            OgrenciAdi.Text = $"{index + 1}.Öğrenci Adını Giriniz";
                        }
                        int rastgelen = rastgele.Next(0, 100);
                        if (rastgelen >= 50)
                        {
                            gecti_kaldi = "Geçti";
                        }
                        else
                        {
                            gecti_kaldi = "Kaldı";
                        }
                        if (radioButton1.Checked)
                        {
                            erkek_kadin = "Erkek";
                        }
                        else
                        {
                            erkek_kadin = "Kadın";
                        }
                        ogrenciler[index - 1] = $"{textBox1.Text} | {erkek_kadin} --> {rastgelen} --> {gecti_kaldi}";
                        textBox1.Text = string.Empty;
                        gecti_kaldi = string.Empty;
                        erkek_kadin = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Onayla Butonuna Basınız");
                    }
                }
            }

        }

        public void SınıfMevcud_Click(object sender, EventArgs e)
        {

            decimal mevcud = numericUpDown1.Value;
            ogrenciler = new string[Convert.ToInt16(mevcud)];
            OgrenciAdi.Text = "1.Öğrencinin Adını Giriniz";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
