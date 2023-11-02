namespace Euklides_NWD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            if(!int.TryParse(textBox1.Text, out a))
            {
                return;
            }
            if(!int.TryParse(textBox2.Text, out b)) 
            { 
                return; 
            }
            if(a <= 0)
            {
                return;
            }
            if(b <= 0)
            {
                return;
            }
        }
        private int NWD(int a, int b)
        {
            while (b > 0)
            {
                a %= b;
                int c = a;
                a = b;
                b = c;
            }
            return a;
        }
    }
}