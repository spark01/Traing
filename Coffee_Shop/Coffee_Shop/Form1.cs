using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
             
            string item = orderComboBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            double price = 0;

            if(item == "Black")
            {
                price = 120 * quantity;
            }
            else if (item=="Cold")
            {
                price = 100 * quantity;
            }
            else if (item == "Hot")
            {
                price =  90* quantity;
            }
            else if (item == "Regular")
            {
                price = 80 * quantity;
            }
            else
            {
                MessageBox.Show("Select an item");
            }

            
            richTextBoxShow.Text = "Neme :" + nameTextBox.Text + Environment.NewLine  + "Contrac No: " +contactTextBox.Text + Environment.NewLine  +
                                  "Address :" + addressTextBox.Text + Environment.NewLine + "Item : " + item + 
                                  Environment.NewLine + "Total :" + price + Environment.NewLine+"THank You Sir";
        }
        
    }
}
