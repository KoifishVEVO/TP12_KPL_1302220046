namespace tpmodul12_1302220046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string CariTandaBilangan(int a)
        {
            if (a < 0)
            {
                return "Negatif";
            }
            else if (a > 0)
            {
                return "Positif";
            }
            else
            {
                return "Nol";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (int.TryParse(textBox1.Text, out int input))
            {
                
                string result = CariTandaBilangan(input);

                
                label1.Text = "Hasil: " + result;
            }
            else
            {
                
                MessageBox.Show("Input harus berupa bilangan bulat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

