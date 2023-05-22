using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        List<customer> customers = new List<customer>();
        public login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            data_access db = new data_access();
            customers = db.GetCustomers();

            var ssn = SSN_textbox.Text;
            var password = password_textbox.Text;
            foreach (customer customer in customers)
            {
                if (customer.ssn == ssn && customer.password == password)
                {
                    error_label.Text = "Correct!";
                    error_label.ForeColor = Color.Green;
                    break;
                }
                else
                {
                    error_label.Text = "Wrong!";
                    error_label.ForeColor = Color.Red;
                }
            }
        }
    }
}
