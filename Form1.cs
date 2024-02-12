namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;

            int number = Convert.ToInt16(textBox1.Text);

            for (i = 1 ; i <= number; i++){

                if (number % i == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
