using ClassLibrary1;

namespace lab1Task5No2
{
    public partial class Form1 : Form
    {
        int[] array = { 5, 2, 9, 1, 5, 6 };
        public Form1()
        {
            InitializeComponent();
            LoadListBox(array);
        }
        private void LoadListBox(int[] numbers)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Raw sequence:");
            foreach (int num in array)
            {
                listBox1.Items.Add(num);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DescendingSort sorter = new DescendingSort(array);
            sorter.Sort();

            listBox1.Items.Clear();
            listBox1.Items.Add("Sorted sequence:");

            foreach (int num in sorter.GetSortedArray())
            {
                listBox1.Items.Add(num);
            }
        }
    }
}

