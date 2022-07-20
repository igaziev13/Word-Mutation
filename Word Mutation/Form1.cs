namespace Word_Mutation
{
    public partial class Form1 : Form
    {
        public static bool allow_vowels = true;
        public static bool allow_consonants = true;
        public static string vowels = "aeiou";
        public static string consonants = "bcdfghjklmnpqrstvwxyz";
        public static int volatility = 2;
        
        private string vowelsCheck = "aeiou";
        private string consonantsCheck = "bcdfghjklmnpqrstvwxyz";

        public Form1()
        {
            InitializeComponent();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                richTextBox1.Text = text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vowels);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            Random random = new Random();
            char vowelChar, consonantsChar;
            foreach (char c in richTextBox1.Text)
            {
                if (random.Next(1, 10) < volatility)
                {
                    vowelChar = vowels[random.Next(0, vowels.Length)];
                    consonantsChar = consonants[random.Next(0, consonants.Length)];
                    if (vowelsCheck.Contains(c)) richTextBox2.Text += vowelChar;
                    else if (vowelsCheck.ToUpper().Contains(c)) richTextBox2.Text += vowelChar.ToString().ToUpper();
                    else if (consonantsCheck.Contains(c)) richTextBox2.Text += consonantsChar;
                    else if (consonantsCheck.ToUpper().Contains(c)) richTextBox2.Text += consonantsChar.ToString().ToUpper();
                    else richTextBox2.Text += c;
                }
                else richTextBox2.Text += c;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox2.Text);
            }
        }
    }
}