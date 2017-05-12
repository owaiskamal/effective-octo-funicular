using System;
using System.IO;
using System.Windows.Forms;

namespace Import_Data_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            xGrid.Columns.Add("A", "SID");
            xGrid.Columns.Add("B", "NAME");
            xGrid.Columns.Add("C", "PHONE");
            xGrid.Columns.Add("D", "EMAIL");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            StreamReader xReader = new StreamReader("OurData.txt");
            string[] Arr = new string[4];
            while(!xReader.EndOfStream)
            {
                Arr = xReader.ReadLine().Split('-');
                xGrid.Rows.Add(Arr[0], Arr[1], Arr[2], Arr[3]);
            }
            xReader.Close();
            lblLabel.Text = "Total Records:" + xGrid.Rows.Count;
        }

        private void xGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void xGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string SID = xGrid.CurrentRow.Cells[0].Value.ToString();
            lblName.Text= xGrid.CurrentRow.Cells[1].Value.ToString();
            lblPhone.Text= xGrid.CurrentRow.Cells[2].Value.ToString();
            lblEmail.Text= xGrid.CurrentRow.Cells[3].Value.ToString();
            picbox.Load("images//" + SID + ".png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
