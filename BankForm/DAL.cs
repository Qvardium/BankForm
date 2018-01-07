using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Common;

namespace BankForm
{
    class DAL
    {
        //строка соединения
        string connection_string = @"Data Source=10.1.8.129;Initial Catalog=Bank;uid=sa;pwd=sql;";


        public ArrayList GetAllDebitors()
        {
            ArrayList allDebitors = new ArrayList();
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                SqlCommand com = new SqlCommand("use bank Select * from debitors order by name_1", con);

                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allDebitors.Add(result);
                }
                catch
                {

                }
                
            }


            return allDebitors;
        }

        public ArrayList GetAllCreditsForDebitor(string debitorID)
        {
            ArrayList allCredits = new ArrayList();

            using (SqlConnection con = new SqlConnection(connection_string))
            {
                string query = String.Format("use bank Select * from credits Where debitorID={0} order by opendate",debitorID);
                SqlCommand com = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allCredits.Add(result);
                }
                catch
                {

                }

            }

            return allCredits;
        }

        internal ArrayList GetAllPaymentsForCredit(string creditID)
        {
            ArrayList allPayments = new ArrayList();

            using (SqlConnection con = new SqlConnection(connection_string))
            {
                string query = String.Format("use bank Select * from payments Where creditID={0} order by paydate", creditID);
                SqlCommand com = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allPayments.Add(result);
                }
                catch
                {

                }

            }

            return allPayments;
        }

        public bool saveNewDebitor(string name, string postNumber, string phoneNumber)
        {
            string query = String.Format("use bank INSERT INTO Debitors (name_1,postNumber,phoneNumber) values ('{0}','{1}','{2}')",name,postNumber,phoneNumber);
            

            using (SqlConnection con = new SqlConnection(connection_string))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    if(com.ExecuteNonQuery()==1) return true;
                }
                catch
                {

                }

            }

            return false;
        }

        public bool saveCredit(int id, int amount)
        {
            string query = String.Format("use bank INSERT INTO Credits (debitorID,amount,balance,opendate) values ('{0}','{1}','{1}','{2}')"
                , id, amount, DateTime.Today);
            
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) return true;
                }
                catch
                {

                }

            }


            return false;
        }
    }

    
}
