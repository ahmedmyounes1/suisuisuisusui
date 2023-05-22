using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace WindowsFormsApp1
{
    public class data_access
    {
        public List<bank> GetBank(string bankname)
        {
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<bank>($"SELECT bank_id, bank_name, bank_address FROM bank WHERE bank_name = '{bankname}'").ToList();

                return output;
            }
        }

       
    }
}
