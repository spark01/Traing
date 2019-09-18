using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int con = 0;
        ErrorProvider ep = new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
        }

        ListView listView1 = new ListView();
        private void addButton_Click(object sender, EventArgs e)
        {
           
            if (con > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                     
                    string Contact = listView1.Items[i].SubItems[2].Text;
                     
                     
                    if(Contact.Substring(0, 12) == contactTextBox.Text){


                        MessageBox.Show("Number is Dublicate");
                        return;
                    }
                }
            }

            string price ="";
            decimal cold = 100;
            decimal black = 120;
            decimal hot = 90;
            decimal regular = 80;
            int er = 0;

            if (OrderComboBox.Text=="")
            {
                er++;
                ep.SetError(OrderComboBox, "Please Select Order");
                return;
            }
            if (quantityTextBox.Text == "")
            {
                er++;
                ep.SetError(quantityTextBox, "Please Select quantity");
                
            }

            if (OrderComboBox.Text== "Cold")
            {
                price = (cold * Decimal.Parse(quantityTextBox.Text)).ToString();
            }
            else if (OrderComboBox.Text == "Black")
            {
                price =( black * Decimal.Parse(quantityTextBox.Text)).ToString();
            }
            else if (OrderComboBox.Text == "Hot")
            {
                price = (hot * Decimal.Parse(quantityTextBox.Text)).ToString();
            }
            else if (OrderComboBox.Text == "Regular")
            {
                price = (regular * Decimal.Parse(quantityTextBox.Text)).ToString();
            }
            else
            {

            }
           


            ListViewItem item = new ListViewItem();
            item.SubItems.Add("Name : " + nameTextBox.Text);
            item.SubItems.Add("Contact : " + contactTextBox.Text);
            item.SubItems.Add("Addres : " + addresTextBox.Text);
            item.SubItems.Add("ItemName: " + OrderComboBox.Text);
            item.SubItems.Add("Qty : " + quantityTextBox.Text);
            item.SubItems.Add("Price: " + price.ToString());
            listView1.Items.Add(item);
            nameTextBox.Clear();
            contactTextBox.Clear();
            addresTextBox.Clear();
            OrderComboBox.SelectedIndex = -1;
            quantityTextBox.Clear();
             price = "";
            con++;
                       
            MessageBox.Show("Customer Information Add");


        }
        private void Clear()
        {
            nameTextBox.Text = "";
            addresTextBox.Text = "";
            contactTextBox.Text = "";
            quantityTextBox.Text = "";
            OrderComboBox.SelectedIndex = -1;
            showRichTextBox.Text = "";
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string Name = listView1.Items[i].SubItems[1].Text;
                string Contact = listView1.Items[i].SubItems[2].Text;
                string Addres = listView1.Items[i].SubItems[3].Text;
                string ItemName = listView1.Items[i].SubItems[4].Text;
                string Qty = listView1.Items[i].SubItems[5].Text;
                string Price = listView1.Items[i].SubItems[6].Text;               

                showRichTextBox.Text += Name + "\n"+ Contact + "\n" + Addres + "\n" + ItemName + "\n" + Qty + "\n" + Price + "\n"+ "\n";

            }         
        }      

    }
}
