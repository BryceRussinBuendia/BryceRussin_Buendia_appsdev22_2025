namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] movies = { "Despicable Me 3", "The Lord of the Rings: The Return of the King", "The Lion King", "Sonic 3"};
            checkedListBox1.Items.AddRange(movies);
            checkedListBox1.CheckOnClick = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var movies in checkedListBox1.Items)
            {
                bool isSelected = checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(movies));
                if (isSelected && !listBox1.Items.Contains(movies))
                {
                    listBox1.Items.Add(movies);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 1)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
