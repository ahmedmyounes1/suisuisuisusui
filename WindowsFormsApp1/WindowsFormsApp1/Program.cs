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
            Application.Run(new signup());
        }
    }
    public class bank
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public List<branch> branches { get; set; }

        public string Fullinfo
        {
            get {
                return $"{name} {address}";
                }
        }
    }
    public class branch
    {
        public int id { get; set; }
        public string branch_number { get; set; }
        public string bank_address { get; set; }
        public int bank_id { get; set; }

    }
    public class customer
    {
        public int id { get; set; }
        public string ssn { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string password { get; set; }

    }
    public class account
    {
        public int customer_id { get; set; }
        public int number { get; set; }
        public decimal balance { get; set; }
        public string type { get; set; }

    }
    public class loan
    {
        public int id { get; set; }
        public decimal loanAmount { get; set; }
        public int BranchID { get; set; }
        public int CustomerID { get; set; }
        public string LoanType { get; set; }

    }
}
