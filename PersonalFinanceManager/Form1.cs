namespace PersonalFinanceManager
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

        private void button1_Click(object sender, EventArgs e)
        {
            incomeControl1.BringToFront();
        }

        private void reportsControl1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            expenseControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportsControl1.BringToFront();
        }
    }
}
