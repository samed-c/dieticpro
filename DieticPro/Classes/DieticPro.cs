using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data.Isql;
using System.Data;


namespace DieticPro
{
    class DieticPro
    {

        public static string ConnStr()
        {
            return ("ServerType=1; User=DIETICUSER; Password=ID829L29!Sq3Sx; Dialect=3; Database=DAT.FDB");
        }


        public void AddNewCustomer(string TBname, string TBsurname, string TBbirth, string TBcompany, string TBaddress, long TBtelephone, long TBmobile)
        {
            FbConnection connection = new FbConnection(ConnStr());
            connection.Open();
            FbTransaction transaction = connection.BeginTransaction();

            string insertQuery = "INSERT INTO CUSTOMERS (NAME, SURNAME, COMPANY, ADDRESS,";
            if (TBbirth != "") insertQuery += "BIRTH, ";
            insertQuery += "TELEPHONE, MOBILE) VALUES ('" + TBname + "', '" + TBsurname + "', '" + TBcompany + "', '" + TBaddress + "', ";
            if (TBbirth != "") insertQuery +=  "'" + TBbirth + "' ,";
            insertQuery += TBtelephone + ", " + TBmobile + ");";
            string insertQuery2 = "COMMIT;";


            FbCommand command = new FbCommand(insertQuery, connection, transaction);
            FbCommand command2 = new FbCommand(insertQuery2, connection, transaction);

            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            connection.Close();
        }


        public DataTable ShowAllCustomers()
        { // STORED PROCEDURE PROC_SHOWALLCUSTOMERS
            FbDataAdapter da = new FbDataAdapter("SELECT * FROM PROC_SHOWALLCUSTOMERS", ConnStr());
            DataTable dt = new DataTable();
            da.Fill(dt);

            return(dt);
        }


     

        internal void AddNewSeance(string sdate, int cid)
        {
            FbConnection connection = new FbConnection(ConnStr());
            connection.Open();
            FbTransaction transaction = connection.BeginTransaction();

            string insertQuery = "INSERT INTO SEANCES (SDATE, CID) VALUES('" + sdate + "', " + cid + ");";
            string insertQuery2 = "COMMIT;";

            FbCommand command = new FbCommand(insertQuery, connection, transaction);
            FbCommand command2 = new FbCommand(insertQuery2, connection, transaction);

            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            connection.Close();     
        }



        internal void SeanceFulfilled(string sid)
        {
            FbConnection connection = new FbConnection(ConnStr());
            connection.Open();
            FbTransaction transaction = connection.BeginTransaction();

            string insertQuery = "UPDATE SEANCES SET FULFILL=1 WHERE SID=" + sid + ";";
            string insertQuery2 = "COMMIT;";

            FbCommand command = new FbCommand(insertQuery, connection, transaction);
            FbCommand command2 = new FbCommand(insertQuery2, connection, transaction);

            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            connection.Close();
        }



        public DataTable ShowDailySeances(string todaydate)
        { // STORED PROCEDURE PROC_SHOWDAILYSEANCES
            FbDataAdapter da = new FbDataAdapter("SELECT * FROM PROC_SHOWDAILYSEANCES('" + todaydate + "');", ConnStr());
            DataTable dt = new DataTable();
            da.Fill(dt);

            return (dt);     
        }



        public DataTable ShowAllSeances(string cid)
        { // STORED PROCEDURE PROC_SHOWALLSEANCES
            FbDataAdapter da = new FbDataAdapter("SELECT * FROM PROC_SHOWALLSEANCES(" + cid + ");", ConnStr());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return (dt);
        }


        public string outta;          
        public string GetUnaryData(string column, string strsid)
        {
            FbConnection conn = new FbConnection(ConnStr());
            FbCommand cmd = new FbCommand("SELECT " + column + "  FROM SEANCES  WHERE SID=" + strsid + ";", conn);      

            conn.Open();
            using (FbDataReader rdr = cmd.ExecuteReader()) {
                while (rdr.Read()) {
                    outta = rdr.GetString(0); 
                } 
            } 

            return outta;
        }

    

        internal void EditSeanceDetails(string strsid, string strweight, string strheight, string strround, string stranalysis, string strnote)
        {
                        
            FbConnection connection = new FbConnection(ConnStr());
            connection.Open();
            FbTransaction transaction = connection.BeginTransaction();

            string insertQuery = "UPDATE SEANCES SET WEIGHT=" + strweight + " , HEIGHT=" + strheight + " , ROUND=" + strround + " , ANALYSIS='" + stranalysis + "' , NOTE='" + strnote + "' WHERE SID=" + strsid + ";";
            string insertQuery2 = "COMMIT;";

            FbCommand command = new FbCommand(insertQuery, connection, transaction);
            FbCommand command2 = new FbCommand(insertQuery2, connection, transaction);

            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            connection.Close();
        }
    
      
 

    }
}
