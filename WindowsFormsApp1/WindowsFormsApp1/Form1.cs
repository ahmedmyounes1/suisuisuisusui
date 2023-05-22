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
        List<bank> banks = new List<bank>();

        public Form1()
        {
            InitializeComponent();

            listBox1.DataSource = banks;
            listBox1.DisplayMember = "Fullinfo";
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {   
            data_access db = new data_access();
            banks = db.GetBank(textBox3.Text);

            listBox1.DataSource = banks;
            listBox1.DisplayMember = "Fullinfo";

        }
    }
}