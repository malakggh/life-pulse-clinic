namespace life_pulse_clinic
{
    public partial class Form1 : Form
    {
        //private string FileName = "C:\\Users\\hala_\\Desktop\\accountsTable.xlsx";
        private string FileName = "\\accountsTable.xlsx";
        // hi my name is haya
        private Doctor doctor;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login(ref doctor);
            login.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Excel excel = new Excel(FileName, 1);
            //MessageBox.Show(excel.ReadCell(0, 2));
            string path = AppDomain.CurrentDomain.BaseDirectory;
            MessageBox.Show(path);
        }
    }
}