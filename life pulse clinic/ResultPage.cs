using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _Excel = Microsoft.Office.Interop.Excel;


namespace life_pulse_clinic
{
    public partial class ResultPage : Form
    {
        private Form1 form1;
        public ResultPage(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void ResultPage_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            // Declare and construct the ColumnHeader objects.
            ColumnHeader header1, header2;
            header1 = new ColumnHeader();
            header2 = new ColumnHeader();

            // Set the text, alignment and width for each column header.
            header1.Text = "טיפול מומלץ";
            header1.TextAlign = HorizontalAlignment.Center;
            header1.Width = listView1.Width / 2;

            header2.TextAlign = HorizontalAlignment.Center;
            header2.Text = "מחלה / בעיה";
            header2.Width = listView1.Width / 2;

            // Add the headers to the ListView control.
            listView1.Columns.Add(header1);
            listView1.Columns.Add(header2);


            

            addResultsToListView();
        }

        private void addResultsToListView()
        {
            //Form1.patient = new Patient("dsa", "dsa", "2321", 20, "Male", "dsad", "321312", "dsai@dsa.com");
            //Form1.questions = new Questions(false, false, false, false, false);
            ArrayList arr  = Form1.bloodTest.GetDisease();
            if (arr!=null)
            {
                foreach (string item in arr)
                {
                    ListViewItem listItem = new ListViewItem(Functions.GetRecommendation(item));
                    listItem.SubItems.Add(item);
                    listView1.Items.Add(listItem);
                }
            }
        }

        private void ResultPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Show();
            form1.Focus();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                try
                {
                    //create new excel file
                    _Excel.Application excel1 = Excel.MakeNewExcel(path + @"\results.xlsx");
                    excel1.Quit();
                    Marshal.ReleaseComObject(excel1);

                    Excel excel = new Excel(path + @"\results.xlsx", 1);
                    try
                    {
                        excel.WriteCell(0, 0, "First Name");
                        excel.WriteCell(1, 0, Form1.patient.GetFirstName());


                        excel.WriteCell(0, 1, "Last Name");
                        excel.WriteCell(1, 1, Form1.patient.GetLastName());


                        excel.WriteCell(0, 2, "ID");
                        excel.WriteCell(1, 2, Form1.patient.GetId());


                        excel.WriteCell(0, 3, "Age");
                        excel.WriteCell(1, 3, Form1.patient.GetAge().ToString());


                        excel.WriteCell(0, 4, "Gender");
                        excel.WriteCell(1, 4, Form1.patient.GetGender());


                        excel.WriteCell(0, 5, "City");
                        excel.WriteCell(1, 5, Form1.patient.GetCity());


                        excel.WriteCell(0, 6, "Phone");
                        excel.WriteCell(1, 6, Form1.patient.GetPhone());


                        excel.WriteCell(0, 7, "Email");
                        excel.WriteCell(1, 7, Form1.patient.GetEmail());

                        int index = 8;
                        string[] arr = Form1.bloodTest.GetNameValue();
                        for(int i=0; i<arr.Length/2; i++)
                        {
                            excel.WriteCell(0,index, arr[i]);
                            excel.WriteCell(1, index, arr[i + 11]);
                            index++;
                        }

                        excel.WriteCell(0, index, "Diagnosis");
                        excel.WriteCell(0, index+1, "Recommendation");
                        ArrayList arr1 = Form1.bloodTest.GetDisease();
                        if (arr != null)
                        {
                            int row = 1;
                            foreach (string item in arr1)
                            {
                                excel.WriteCell(row, index, item);
                                excel.WriteCell(row,index+1,Functions.GetRecommendation(item));
                                row++;
                            }
                        }
                        excel.SaveWork();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        excel.closeXl();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Form1.patient = null;
            Form1.bloodTest = null;
            Form1.questions = null;
            form1.Show();
            form1.Focus();
            Close();
        }
    }
}
