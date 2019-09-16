using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Arraw_CoffeeShop
{
    public partial class Form1 : Form
    {
        const int Size = 4;
        string[] customerName = new string[Size];
        string[] customerContract = new string[Size];
        string[] customerAddress = new string[Size];
        string[] Order = new string[Size];
        int[] Quantity = new int[Size];
        double[] totalPrice = new double[Size];
        string Massage;
        int Index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Index < Size)
            {
                    customerName[Index] = nameTextBox.Text;
                    customerContract[Index] = contactTextBox.Text;
                    customerAddress[Index] = addressTextBox.Text;
                    Order[Index] = orderComboBox.Text;
                    Quantity[Index] = Convert.ToInt32(quantityTextBox.Text);
                    totalPrice[Index] = Quantity[Index] * Price(orderComboBox.Text);
                    Print(Index);
                    Index++;
                   }
            else
            {
                MessageBox.Show("Please wait");
            }

        }
        private void Print(int index)
        {
            Massage = "";
            for (int i = 0; i <= index; i++)
            {
                Massage += " No: " + i + Environment.NewLine + " Name: " + customerName[i] + Environment.NewLine + "Contarcrt No: " + customerContract[i] + Environment.NewLine +
                    " Addesess: " + customerAddress[i] + Environment.NewLine + "Item: " + Order[i] + Environment.NewLine + "Quantity: " + Quantity[i] + Environment.NewLine +
                    "Total Price: " + totalPrice[i] + Environment.NewLine + Environment.NewLine;
            }

            saveRichTextBox.Text = "Customer Information: " + Environment.NewLine + Massage + Environment.NewLine;
        }
        private double Price(string order)
        {
            if (order == "Black")
            {
                return 120;
            }
            else if (order == "Cold")
            {
                return 100;
            }
            else if (order == "Hot")
            {
                return 90;
            }
            else if (order == "Regular")
            {
                return 80;
            }
            else
            {
                return 0;
            }
        }


    }       
}
