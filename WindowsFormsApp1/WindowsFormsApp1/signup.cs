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
    public partial class signup : Form
    {
        List<customer> existing_customers = new List<customer>();

        public signup()
        {
            InitializeComponent();

            this.FormClosed += Signup_FormClosed;
        }

        private void Signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            new login().Show();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            data_access db = new data_access();
            existing_customers = db.GetCustomers();

            customer new_customer = new customer();
            new_customer.name = name_textbox.Text;
            new_customer.ssn = SSN_textbox.Text;
            new_customer.phone = phone_textbox.Text;
            new_customer.address = address_textbox.Text;
            new_customer.password = password_textbox.Text;

            if (!IsValidNewUser(new_customer, confirmpassword_textbox.Text))
                return;

            error_label.Text = "SIGNED UP!!!!";
            error_label.ForeColor = Color.Green;

            db.CreateCustomer(new_customer);
        }

        private bool IsValidNewUser(customer new_customer, string confirmation_password)
        {
            if (new_customer.ssn == "")
            {
                error_label.Text = "Must Enter SSN!";
                error_label.ForeColor = Color.Red;
                return false;
            }
            
            if (new_customer.password == "")
            {
                error_label.Text = "Must Enter password!";
                error_label.ForeColor = Color.Red;
                return false;
            }

            if (new_customer.address == "" || new_customer.name == "" || new_customer.phone == "")
            {
                error_label.Text = "Some Fields are Empty!";
                error_label.ForeColor = Color.Red;
                return false;
            }

            if (new_customer.password != confirmation_password)
            {
                error_label.Text = "Confirmation password is not the same!";
                error_label.ForeColor = Color.Red;
                return false;
            }

            foreach (customer customer in existing_customers)
            {
                if (new_customer.ssn == customer.ssn)
                {
                    error_label.Text = "SSN USED!";
                    error_label.ForeColor = Color.Red;
                    return false;
                }
                else if (new_customer.password == customer.password)
                {
                    error_label.Text = "Password USED!";
                    error_label.ForeColor = Color.Red;
                    return false;
                }
            }

            return true;
        }
    }
}
