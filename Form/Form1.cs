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
            // Load medicine names from MedicineList.txt into the checkedListBox
            string filePath = @"MedicineList.txt";
            checkedListBox1.Items.AddRange(System.IO.File.ReadAllLines(filePath));

            // Generate a random discount and display it on label4
            Random random = new Random();
            // Read medicine names only once to avoid multiple file reads
            string[] medicineNames = File.ReadAllLines(@"MedicineList.txt");
            string randomMedicine = medicineNames[random.Next(medicineNames.Length)];
            int randomDiscount = random.Next(1, 50);
            label4.Text = $"Special: {randomDiscount}% discount on {randomMedicine}";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TO-DO: Add code to handle selected medicine changes, if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Save selected medicines to OrderList.txt
            using (StreamWriter writer = new StreamWriter(@"OrderList.txt"))
            {
                writer.WriteLine("Order form:\n");
                foreach (string medicine in checkedListBox1.CheckedItems)
                {
                    writer.WriteLine(medicine);
                }
            }

            MessageBox.Show("Order Saved", "Message", MessageBoxButtons.OK);
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // TODO: Add code to handle text changes in textBox1, if needed
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Add a new medicine to the checkedListBox
            string newMedicine = textBox1.Text.Trim(); // Remove any leading/trailing spaces
            if (checkedListBox1.Items.Contains(newMedicine))
            {
                MessageBox.Show("That drug already exists in the list", "Error", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrEmpty(newMedicine))
            {
                MessageBox.Show("Please enter a new medicine", "Error", MessageBoxButtons.OK);
            }
            else
            {
                checkedListBox1.Items.Add(newMedicine);
            }
        }
    }
}
