namespace Pizzaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "C# dersi basladi";
            label1.Text = "deneme merhaba dünya";
            listBox1.Items.Add("Istanbul");
            listBox1.Items.Add("Bursa");

        }
    }
}