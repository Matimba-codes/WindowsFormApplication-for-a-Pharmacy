namespace Matimba_Kubayi_Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = @"MedicineList.txt";
            checkedListBox1.Items.AddRange(System.IO.File.ReadAllLines(filePath));

            Random number = new Random();
            string[] word = File.ReadAllLines(@"MedicineList.txt");
            label4.Text = $"Special: {number.Next(1, 50)}% discount on {word[new Random().Next(word.Length)]}";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"OrderList.txt");
            writer.WriteLine("Order form:\n",checkedListBox1.CheckedItems);

            MessageBox.Show("Order Saved", "Message", MessageBoxButtons.OK);

            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("That drug already exists in the list", "Error", MessageBoxButtons.OK);
            }
            else if (textBox1.Text=="")
            {
                MessageBox.Show("Please enter a new medicine", "Error", MessageBoxButtons.OK);
            }
            else
            {
                checkedListBox1.Items.Add(textBox1.Text);
            }
        }
    }
}