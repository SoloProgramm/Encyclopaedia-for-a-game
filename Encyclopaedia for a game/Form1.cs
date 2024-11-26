namespace Encyclopaedia_for_a_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check for dupilcates

            string newEntry = textBox1.Text;

            bool Check = string.IsNullOrEmpty(newEntry);

            if (Check == false)
            {
                listBox1.Items.Add(newEntry);
                textBox1.Text = "";
                textBox1.Focus();
            }
            //keep file upadated
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
