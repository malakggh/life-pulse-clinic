namespace life_pulse_clinic
{
    public partial class Form1 : Form
    {
        private string FileName = "C:\\Users\\hala_\\Desktop\\accountsTable.xlsx";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excel excel = new Excel(FileName, 1);
            MessageBox.Show(excel.ReadMyCell(1, 1));
        }
    }
}