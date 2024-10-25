using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashierApplication.ItemNamespace;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void computePriceBtn_Click(object sender, EventArgs e)
        {
            string Item = item.Text;
            double Price = Convert.ToDouble(this.price.Text);
            int Quantity = Convert.ToInt32(this.quantity.Text);
            double Discount = Convert.ToDouble(this.discount.Text);

            DiscountedItem discountedItem = new DiscountedItem(Item, Price, Quantity, Discount);

            string totalPrice = discountedItem.getTotalPrice().ToString();
            totalAmountOutp.Text = totalPrice;
        }

        private void submitPaymentBtn_Click(object sender, EventArgs e)
        {
            string Item = item.Text;
            double Price = Convert.ToDouble(this.price.Text);
            int Quantity = Convert.ToInt32(this.quantity.Text);
            double Discount = Convert.ToDouble(this.discount.Text);

            DiscountedItem discountedItem = new DiscountedItem(Item, Price, Quantity, Discount);

            double PaymentReceived = Convert.ToDouble(this.paymentReceived.Text);
            discountedItem.setPayment(PaymentReceived);
            string change = discountedItem.getChange().ToString();
            changeOutp.Text = change;
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginAccount frmLoginAccount = new frmLoginAccount();
            frmLoginAccount.Show();
            this.Close();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    //
    namespace ItemNamespace
{
    abstract class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;
        public Item(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_quantity = quantity;
            this.total_price = price;
        }
        public double getTotalPrice()
        {
            return this.total_price;
        }
        public abstract void setPayment(double amount);
    }
    class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;

        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
            this.item_discount = discount;

            this.discounted_price = (item_price - (item_price * (item_discount * 0.01))) * quantity;

        }
        public double getTotalPrice()
        {
            return this.discounted_price;
        }
        public override void setPayment(double amount)
        {
            this.payment_amount = amount;
        }
        public double getChange()
        {
            this.change = this.payment_amount - this.discounted_price;
            return this.change;
        }
    }
}
}
