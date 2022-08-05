
namespace CinemaProject
{

    public partial class Form1 : Form
    {
        public static System.Text.Encoding UTF8 { get; }


        public Form1()
        {
            InitializeComponent();
        }
        Cinema Zal;

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;

            try
            {
                Zal = new Cinema(Convert.ToInt32(comboBox1.Text), Convert.ToInt32(comboBox2.Text));
                label3.Text = "Zal əlavə edildi";

            }
            catch (Exception)
            {
                label3.Text = "Zal nömrəsini daxil edin";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            Zal.Biletsat(radioButton1.Checked == false, radioButton2.Checked == false, radioButton3.Checked == false);

            label3.Text = "Qalan yer sayı:" + Zal.Bosyersayi();


            if (Zal.Bosyersayi() < 0)
            {
                label3.Text = "Bütün biletlər satıldı" + Zal.Bosyersayi();

            }
            Zal.Pulmiqdarsayi(radioButton1.Checked, radioButton2.Checked, radioButton3.Checked);
            if (radioButton1.Checked == true)
            {
                label8.Text = "" + Zal.Axsammiqdar();

            }
            else if (radioButton2.Checked == true)
            {
                label9.Text = "" + Zal.Sehermiqdar();

            }
            else if (radioButton3.Checked == true)
            {
                label10.Text = "" + Zal.Endirimmiqdar();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "Boş yer sayı :" + Zal.Bosyersayi();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zal.Biletinlegvi(radioButton1.Checked, radioButton2.Checked, radioButton3.Checked);
            label3.Text = "Bilet ləğv edildi. Qalan yer sayı :" + Zal.Bosyersayi();

            if (Zal.Bosyersayi() == Convert.ToInt32(comboBox2.Text))
            {
                label3.Text = "Bütün biletlər qaytarıldı";
                button2.Enabled = false;

            }
            else
            {
                button2.Enabled = true;

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Hazırki qalan pul miqdari :" + Zal.Qazancim() + "AZN";
            Zal.Pulmiqdarsayi(radioButton1.Checked, radioButton2.Checked, radioButton3.Checked);

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = radioButton1.Checked;
            button2.Enabled = (radioButton1.Checked);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = radioButton2.Checked;
            button2.Enabled = (radioButton2.Checked);

        }
        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            button1.Enabled = radioButton3.Checked;
            button2.Enabled = (radioButton3.Checked);


        }
    }
}