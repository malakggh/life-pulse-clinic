using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace life_pulse_clinic
{
    public partial class ResultPage : Form
    {
        public ResultPage()
        {
            InitializeComponent();
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
            Form1.patient = new Patient("dsa", "dsa", "2321", 20, "Male", "dsad", "321312", "dsai@dsa.com");
            Form1.questions = new Questions(false, false, false, false, false);
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
    }
}
