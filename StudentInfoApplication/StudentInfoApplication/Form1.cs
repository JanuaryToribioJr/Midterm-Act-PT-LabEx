namespace StudentInfoApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class StudentInfo
        {
            private string lastName;
            private string firstName;
            private long StudentID;

            public StudentInfo()
            {
                this.lastName = "";
                this.firstName = "";
                this.StudentID = 0;
            }
            public StudentInfo(string Lname, string Fname, long StudentID)
            {
                this.lastName = Lname;
                this.firstName = Fname;
                this.StudentID = StudentID;
            }
            public string LastNameStudent
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

            public string FirstNameStudent
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
            public long StudentIDNum
            {
                get
                {
                    return this.StudentID;
                }
                set
                {
                    this.StudentID = value;
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LastName = lName.Text;
            string FirstName = fName.Text;
            long StudentID = Convert.ToInt64(studentID.Text);

            StudentInfo student = new StudentInfo(LastName, FirstName, StudentID);

            listBoxLName.Items.Add(student.LastNameStudent);
            listBoxFName.Items.Add(student.FirstNameStudent);
            listBoxStudentID.Items.Add(student.StudentIDNum.ToString());

            lName.Clear();
            fName.Clear();
            studentID.Clear();
        }
    }
}
