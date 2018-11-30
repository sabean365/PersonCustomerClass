using System;
using System.Windows.Forms;

namespace PersonCustomerClass
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void GetCustData(Customer cust)
        {
            //variables for ints
            int zip, custNum;

            //Get Customer data

            cust.Name = nameTextBox.Text;
            cust.Address = addressTextBox.Text;
            cust.CityState = cityStateTextBox.Text;
            cust.Phone = phoneTextBox.Text;

            //Check for input on zip
            if (int.TryParse(zipTextBox.Text, out zip))
            {
                cust.Zip = zip;

                //Check input on customer number
                if (int.TryParse(custNumInputTextBox.Text, out custNum))
                {
                    cust.CustNum = custNum;
                }
                //Error message
                else
                {
                    MessageBox.Show("Invalid customer number");
                }
            }
            //Error message
            else
            {
                MessageBox.Show("Invalid Zip Code");
            }


            //Check which radio button was checked
            if (yesRadioButton.Checked)
            {
                cust.MailingList = true;
            }
            else
            {
                cust.MailingList = false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
            //Create object
            Customer customer = new Customer();

            //Call method GetCustData
            GetCustData(customer);

            //Display object
            custNameLabel.Text = customer.Name;
            custAddressLabel.Text = customer.Address;
            custCityStateLabel.Text = customer.CityState;
            custZipLabel.Text = customer.Zip.ToString();
            custPhoneLabel.Text = customer.Phone;
            custNumOuputLabel.Text = customer.CustNum.ToString();

            //check mailing list selection
            if (customer.MailingList == true)
            {
                mailListLabel.Text = "Yes";
            }
            else
            {
                mailListLabel.Text = "No";
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
