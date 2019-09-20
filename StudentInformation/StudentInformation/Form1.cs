using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class Form1 : Form
    {
        ErrorProvider ep = new ErrorProvider();

        List<string> ids = new List<string>();
        List<string> names = new List<string>();
        List<string> mobs = new List<string>();
        List<string> ages = new List<string>();
        List<string> address = new List<string>();
        List<string> gpas = new List<string>();

        string res = "";
        int er = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            ep.Clear();

            if ((idTextBox.Text.Equals("") || idTextBox.Text.Length != 4))
            {
                er++;
                ep.SetError(idTextBox, "Enter your Id and Id Must be 4 charecter");
                return;

            }

            else if (checkDuplicateID()) ;
            else if (nameTextBox.Text.Equals("") || nameTextBox.Text.Length > 30)
            {
                er++;
                ep.SetError(nameTextBox, "Enter your Name and Name Must be 30 charecter");
                return;


            }

            else if (mobileTextBox.Text.Equals("") || mobileTextBox.Text.Length != 11)
            {
                er++;
                ep.SetError(mobileTextBox, "Mobile Must not be Blank and Must Be 11 Digit");
                return;
            }
            else if (checkDuplicateMobile()) ;

            else if (ageTextBox.Text.Equals("") || ageTextBox.Text.Length > 50)
            {
                er++;
                ep.SetError(ageTextBox, "Enter Your ages");
                return;


            }
            else if (addresTextBox.Text.Equals(""))
            {
                er++;
                ep.SetError(addresTextBox, "Enter Your ages");
                return;


            }

            else if (gpaTextBox.Text.Equals("") || (float.Parse(gpaTextBox.Text) < 0 || float.Parse(gpaTextBox.Text) > 4))
            {
                er++;
                ep.SetError(gpaTextBox, "GPA Must not be Blank and Between 0-4");
                return;
            }


            ids.Add(idTextBox.Text);
            names.Add(nameTextBox.Text);
            mobs.Add(mobileTextBox.Text);
            ages.Add(ageTextBox.Text);
            address.Add(addresTextBox.Text);
            gpas.Add(gpaTextBox.Text);

            showRichTextBox.Text = "ID: " + idTextBox.Text + "\n" + "Name: " + nameTextBox.Text + "\n" + "Mobile: " + mobileTextBox.Text + "\n"
                                  + "Age: " + ageTextBox.Text + "\n" + "Address: " + addresTextBox.Text + "\n" + "GPA: " + gpaTextBox.Text;



            MessageBox.Show("data is added");

            Clear();


        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            String minName = "", maxName = "";
            float min = 10, max = 0, avg = 0, total = 0, gpaText;
            showRichTextBox.Clear();



            for (int i = 0; i < ids.Count(); i++)
            {

                gpaText = float.Parse(gpas[i]);

                total += gpaText;

                if (min > gpaText)
                {
                    min = gpaText;
                    minName = names[i];
                }

                if (max < gpaText)
                {
                    max = gpaText;
                    maxName = names[i];
                }







                res += "ID: " + ids[i] + "\n" + "Name: " + names[i] + "\n" + "Mobile: " + mobs[i] + "\n" + "Age: " + ages[i] + "\n" +
                       "Address: " + address[i] + "\n" + "GPA: " + gpas[i] + "\n" + "\n";

                maxTextBox.Text = max.ToString();
                nameMaxTextBox.Text = maxName;
                mimTextBox.Text = min.ToString();
                mimNameTextBox.Text = minName;
                tatalTextBox.Text = total.ToString();
                averegeTextBox.Text = (total / ids.Count()).ToString();

            }
            //showRichTextBox.Text = "";
            showRichTextBox.Text = res;
        }

        private void Clear()
        {
            nameTextBox.Text = "";
            idTextBox.Text = "";
            mobileTextBox.Text = "";
            ageTextBox.Text = "";
            addresTextBox.Text = "";
            gpaTextBox.Text = "";
            maxTextBox.Text = "";
            mimTextBox.Text = "";
            nameMaxTextBox.Text = "";
            mimNameTextBox.Text = "";
            averegeTextBox.Text = "";
            tatalTextBox.Text = "";

        }
        private Boolean checkDuplicateID()
        {
            for (int j = 0; j < ids.Count(); j++)
            {
                if ((idTextBox.Text).Equals(ids[j]))
                {
                    er++;
                    ep.SetError(idTextBox, "iD MUS BE UNIQUE");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        private Boolean checkDuplicateMobile()
        {
            for (int j = 0; j < ids.Count(); j++)
            {
                if ((mobileTextBox.Text).Equals(mobs[j]))
                {
                    er++;
                    ep.SetError(mobileTextBox, "This Mobile used Before\nUse an Unique ID");
               
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (idRadioButton.Checked == true)
            {
                showRichTextBox.Text="";
                for (int i = 0; i < ids.Count(); i++)
                {
                    if (idTextBox.Text.Equals(ids[i]))
                    {
                        showRichTextBox.Text = "ID: " + ids[i] + "\n" + "Name: " + names[i] + "\n" + "Mobile: " + mobs[i] + "\n" + "Age: " + ages[i] + "\n" +
                       "Address: " + address[i] + "\n" + "GPA: " + gpas[i];

                    }
                    idTextBox.Text="";
                    Clear();
                }
            }

            else if (nameRadioButton.Checked == true)
            {
                showRichTextBox.Text="";
                for (int i = 0; i < names.Count(); i++)
                {
                    if (nameTextBox.Text.Equals(names[i]))
                    {
                        showRichTextBox.Text = "ID: " + ids[i] + "\n" + "Name: " + names[i] + "\n" + "Mobile: " + mobs[i] + "\n" + "Age: " + ages[i] + "\n" +
                      "Address: " + address[i] + "\n" + "GPA: " + gpas[i];
                    }
                    nameTextBox.Text="";
                    Clear();
                }
            }

            else if (mobileRadioButton.Checked == true)
            {
                showRichTextBox.Text="";
                for (int i = 0; i < mobs.Count(); i++)
                {
                    if (mobileTextBox.Text.Equals(mobs[i]))
                    {
                        showRichTextBox.Text = "ID: " + ids[i] + "\n" + "Name: " + names[i] + "\n" + "Mobile: " + mobs[i] + "\n" + "Age: " + ages[i] + "\n" +
                    "Address: " + address[i] + "\n" + "GPA: " + gpas[i];

                    }
                    mobileTextBox.Text="";
                    Clear();
                }
            }
        }
    }
}
