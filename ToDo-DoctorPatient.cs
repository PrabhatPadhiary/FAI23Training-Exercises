using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Proj1_SampleConApp.Week_3
{
    class ToDo_DoctorPatient
    {
        static readonly string CONNECTIONSTRING = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        const string STRCREATEPATIENT = "CreatePatient";
        const string STRDELETEPATIENT = "DeletePatient";
        const string STRUPDATEPATIENT = "UpdatePatient";
        const string STRCREATEDOCTOR = "CreateDoctor";
        static void Main(string[] args)
        {
            //InsertPatient();
            //InsertDoctor();
            UpdatePatient();
            //DeletePatient();
        }

        private static void DeletePatient()
        {
            int patId = utilities.GetInteger("Enter the patient ID you want to delete");

            SqlParameter pm1 = new SqlParameter("@patId", patId);

            try
            {
                ExecuteNonQuery(CONNECTIONSTRING, STRDELETEPATIENT, pm1);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void UpdatePatient()
        {
            int Id = utilities.GetInteger("Enter the Patient ID");
            
            string name = utilities.GetString("Enter the New Patient Name");
            string address = utilities.GetString("Enter the New Patient Address");
            int BillAmount = utilities.GetInteger("Enter the New Patient Bill Amount");
            int DoctId = utilities.GetInteger("Enter the New Doctor Reference Id");
            
            SqlParameter pm1 = new SqlParameter("@patId", Id);
            SqlParameter pm2 = new SqlParameter("@patName", name);
            SqlParameter pm3 = new SqlParameter("@patAddress", address);
            SqlParameter pm4 = new SqlParameter("@patBillAmount", BillAmount);
            SqlParameter pm5 = new SqlParameter("@docId", DoctId);
            

            try
            {
                ExecuteNonQuery(CONNECTIONSTRING, STRUPDATEPATIENT, pm1, pm2, pm3, pm4, pm4,pm5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ExecuteNonQuery(string connection, string procname, params SqlParameter[] parameters)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(procname, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            foreach(var parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private static void InsertDoctor()
        {
            string DoctName = utilities.GetString("Enter the Doctor Name");
            int genDocId = 0;

            SqlParameter pm1 = new SqlParameter("@docName", DoctName);
            SqlParameter pm2 = new SqlParameter("@docId", genDocId);
            pm2.Direction = System.Data.ParameterDirection.Output;

            try
            {
                ExecuteNonQuery(CONNECTIONSTRING, STRCREATEDOCTOR, pm1, pm2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void InsertPatient()
        {
            int genPatId = 0;

            string name = utilities.GetString("Enter the name of the patient");
            string address = utilities.GetString("Enter the address of the patient");
            int billAmount = utilities.GetInteger("Enter the Bill Amount for the patient");
            int docId = utilities.GetInteger("Enter the Id of the doctor to whom he referred");

            SqlParameter pm1 = new SqlParameter("@patName", name);
            SqlParameter pm2 = new SqlParameter("@patAddress", address);
            SqlParameter pm3 = new SqlParameter("@patBillAmount", billAmount);
            SqlParameter pm4 = new SqlParameter("@docId", docId);
            SqlParameter pm5 = new SqlParameter("@patId", genPatId);
            pm5.Direction = System.Data.ParameterDirection.Output;
            
            try
            {
                ExecuteNonQuery(CONNECTIONSTRING, STRCREATEPATIENT, pm1, pm2, pm3, pm4, pm5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
