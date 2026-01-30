using lab2.lab2tasks.task3no2;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private int Fibonacci(int n)
        {

            if (n == 0)
                return 0;
            if (n == 1)
                return 1;


            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            int n;

            if (int.TryParse(textBox1.Text, out n) && n >= 0)
            {
                int result = Fibonacci(n);
                label3.Text = $"Fibonacci({n}) = {result}";
            }
            else
            {
                label3.Text = "Please enter a valid non-negative integer.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
