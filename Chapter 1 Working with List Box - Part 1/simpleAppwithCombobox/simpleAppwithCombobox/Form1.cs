namespace simpleAppwithCombobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] cuisineGenre = { "Filipino", "Chinese", "German", "Italian" };
            comboBox1.Items.AddRange(cuisineGenre);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            string[] filipinoFood = { "roasted pig", "Philippine sausage", "cured beef", "omelette" };
            string[] chineseFood = { "chow mein", "kung pao chicken", "cantonese cuisine", "Mapo tofu" };
            string[] germanFood = { "Currywurst", "Bratwurst ", "roulade", "pretzels" };
            string[] italianFood = { "Rissoto", "lasagna", "tiramisu", "carbonara" };

            fchcklstbox.Items.Clear();

            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString()!.Contains("Filipino"))
            {
                fchcklstbox.Items.AddRange(filipinoFood);

            }
            else if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString()!.Contains("Chinese"))
            {
                fchcklstbox.Items.AddRange(chineseFood);
            }
            else if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString()!.Contains("German"))
            {
                fchcklstbox.Items.AddRange(germanFood);

            }
            else if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString()!.Contains("Italian"))
            {
                flstbox.Items.AddRange(italianFood);
            }

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            foreach (var item in fchcklstbox.Items)
            {
                bool isSelected = fchcklstbox.GetItemChecked(fchcklstbox.Items.IndexOf(item));
                if (isSelected && !flstbox.Items.Contains(item))
                {
                    flstbox.Items.Add(item);
                }
            }
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            flstbox.Items.Remove(flstbox.SelectedItem);
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            flstbox.Items.Clear();
        }
    }
}
