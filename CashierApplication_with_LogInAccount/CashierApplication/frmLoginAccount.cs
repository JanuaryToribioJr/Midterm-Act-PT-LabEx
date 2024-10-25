using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = username.Text;
            string Password = password.Text;
            Cashier cashier = new Cashier("January Toribio Jr.", "BSCS", "CS2", "cutie");



            if (cashier.validateLogin(Username, Password))
            {
                MessageBox.Show($"Welcome {cashier.getFullName()} of {cashier.getDepartment()}");
                frmPurchaseDiscountedItem frmPurchaseDiscountedItem = new frmPurchaseDiscountedItem();
                frmPurchaseDiscountedItem.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Account does not exist.\nPlease try again.");
                username.Clear();
                password.Clear();

            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

                password.PasswordChar = '•';
            
        }
    }
}
//
namespace UserAccountNamespace
{
    abstract class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name, string uName, string password)
        {
            this.full_name = name;
            this.user_name = uName;
            this.user_password = password;
        }
        public abstract bool validateLogin(string uName, string password);
        public string getFullName()
        {
            return this.full_name;
        }
    }
    class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string uName, string password) : base(name, uName, password)
        {
            this.department = department;
        }
        public override bool validateLogin(string uName, string password)
        {
            return this.user_name.Equals(uName) && this.user_password.Equals(password);
        }
        public string getDepartment()
        {
            return this.department;
        }
    }
}