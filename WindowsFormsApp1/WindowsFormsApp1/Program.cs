using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class bank
    {
        public int bank_id { get; set; }
        public string bank_name { get; set; }
        public string bank_address { get; set; }
        public List<branch> bank_branches { get; set; }

        public string Fullinfo
        {
            get {
                return $"{bank_name} {bank_address}";
                }
        }
    }
    public class branch
    {
        public int branch_id { get; set; }
        public string branch_number { get; set; }
        public string branch_address { get; set; }
        public int bank_id { get; set; }

    }
    public class costumer
    {
        public string customer_name { get; set; }
        public string customer_address { get; set; }
        public int customer_id { get; set; }
        public int customer_phone { get; set; }
        public string customer_ssn { get; set; }

    }
    public class account
    {
        public int account_id { get; set; }
        public int account_number { get; set; }
        public decimal account_balance { get; set; }
        public int costumer_id { get; set; }
        public string account_type { get; set; }

    }
    public class loan
    {
        public int loan_id { get; set; }
        public decimal loan_amount { get; set; }
        public int branch_id { get; set; }
        public int customer_id { get; set; }
        public string loan_type { get; set; }

    }
}
