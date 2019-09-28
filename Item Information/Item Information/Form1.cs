﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Item_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);


                //string commmandString = @" INSERT INTO Items (Name, Price) VALUES('hot', 90)";
                string commmandString = @" INSERT INTO Items (Name, Price) VALUES('" + nameTextBox.Text + "', " + priceTextBox.Text + ")";

                SqlCommand sqlCommand = new SqlCommand(commmandString, sqlConnection);

                sqlConnection.Open();

                int isExecute = sqlCommand.ExecuteNonQuery();

                if (isExecute > 0)
                {
                    MessageBox.Show("save");

                }
                else
                {
                    MessageBox.Show("not save");
                }

                sqlConnection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
           

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

             
            string commmandString = @"SELECT * FROM Items";

            SqlCommand sqlCommand = new SqlCommand(commmandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                showdataGridView.DataSource = dataTable;
            }
            else
            {
                showdataGridView.DataSource = null;
                MessageBox.Show("data not found");
            }
            sqlConnection.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);


            //string commmandString = @" INSERT INTO Items (Name, Price) VALUES('hot', 90)";
            string commmandString = @"DELETE FROM Items Where Id="+idTextBox.Text+"";

            SqlCommand sqlCommand = new SqlCommand(commmandString, sqlConnection);

            sqlConnection.Open();

            int isExecute = sqlCommand.ExecuteNonQuery();

            if (isExecute > 0)
            {
                MessageBox.Show("Delete");

            }
            else
            {
                MessageBox.Show("not Delete");
            }

            sqlConnection.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);


            //string commmandString = @" INSERT INTO Items (Name, Price) VALUES('hot', 90)";
            string commmandString = @"SELECT * FROM Items Where Id=" + idTextBox.Text + "";

            SqlCommand sqlCommand = new SqlCommand(commmandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                showdataGridView.DataSource = dataTable;
            }
            else
            {
                showdataGridView.DataSource = null;
                MessageBox.Show("data not found");
            }
            sqlConnection.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-K01B49N; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);


            //string commmandString = @" INSERT INTO Items (Name, Price) VALUES('hot', 90)";
            string commmandString = @"UPDATE Items SET Name='"+nameTextBox.Text+"', Price='"+priceTextBox.Text+"' Where Id=" + idTextBox.Text + "";

            SqlCommand sqlCommand = new SqlCommand(commmandString, sqlConnection);

            sqlConnection.Open();

            int isExecute = sqlCommand.ExecuteNonQuery();

            if (isExecute > 0)
            {
                MessageBox.Show("Delete");

            }
            else
            {
                MessageBox.Show("not Delete");
            }

            sqlConnection.Close();
        }
    }
}
