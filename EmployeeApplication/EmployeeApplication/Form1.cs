using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EmployeeApplication.Form1;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("table");
        public Form1()
        {
            InitializeComponent();
        }
        public class Employee
        {
            private string iD;
            private string firstName;
            private string lastName;
            private string position;

            public Employee(string iD, string firstName, string lastName, string position)
            {
                this.iD = iD;
                this.firstName = firstName;
                this.lastName = lastName;
                this.position = position;
            }
            public Employee(string firstName, string lastName, string position)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.position = position;
            }
            public string EmployeeID
            {
                get
                {
                    return this.iD;
                }
                set
                {
                    this.iD = value;
                }
            }
            public string FirstName
            {
                get
                {
                    return this.firstName;
                }
                set
                {
                    this.firstName = value;
                }
            }
            public string LastName
            {
                get
                {
                    return this.lastName;
                }
                set
                {
                    this.lastName = value;
                }
            }
            public string Position
            {
                get
                {
                    return this.position;
                }
                set
                {
                    this.position = value;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Employee ID:", typeof(String));
            table.Columns.Add("First name:", typeof(String));
            table.Columns.Add("Last name:", typeof(String));
            table.Columns.Add("Position:", typeof(String));

            tableGrid.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(iD.Text, fName.Text, lName.Text, position.Text);

            iD.Clear();
            fName.Clear();
            lName.Clear();
            position.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
