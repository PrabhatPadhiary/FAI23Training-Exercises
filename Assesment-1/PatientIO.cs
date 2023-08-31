using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_1
{
    internal class PatientIO
    {
        const string MenuName = @"C:\Users\pkumarpadhiary\source\repos\Assesment-1\Menu.txt";
        const string fileName = "PatientDetails.xml";
        private static readonly string MenuFileName = ConfigurationManager.AppSettings["MenuFile"];

        static void Main(string[] args)
        {
            bool condition = true;
            do
            {
                var pat = new Assesment_1.Patient();
                string content = File.ReadAllText(MenuFileName);
                string choice = utilities.GetString(content).ToUpper();
                switch (choice)
                {
                    case "N":
                        pat.patId = utilities.GetInteger("Enter the Patient ID: ");
                        pat.patName = utilities.GetString("Enter the patient Name: ");
                        pat.billAmount = utilities.GetInteger("Enter the Bill Amount: ");
                        pat.dctName = utilities.GetString("Enter the Doctor's Name: ");

                        writePatientRecord(pat);
                        break;

                    case "D":
                        int id = utilities.GetInteger("Enter the patient id you want to delete");
                        deleteRecord(id);
                        break;

                    case "S":
                        serialization();
                        break;

                    case "V":
                        List<Assesment_1.Patient> patients = readAllRecords(fileName);
                        foreach (var rec in patients)
                        {
                            Console.WriteLine($"ID: {rec.patId} with Name: {rec.patName}");
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter a valid key");
                        condition = false;
                        break;
                }
            } while (condition);
        }

        public static void deleteRecord(int id)
        {
            var records = readAllRecords(fileName);
            for (int i = 0; i < records.Count(); i++)
            {
                if (records[i].patId == id)
                {
                    records.RemoveAt(i);
                    break;
                }
            }
            File.Delete(fileName);
            bulkInsert(records);
        }

        private static void bulkInsert(List<Assesment_1.Patient> records)
        {
            foreach (var pat in records)
            {
                writePatientRecord(pat);
            }
        }

        public static List<Assesment_1.Patient> readAllRecords(string fileName)
        {
            //string filepos = "PatientDetails.xml";
            //FileStream fs = new FileStream(filepos, FileMode.Open, FileAccess.Read);
            //BinaryFormatter fn = new BinaryFormatter();
            //PatientData deserilizedData = fn.Deserialize(fs) as PatientData;
            //Console.WriteLine(deserilizedData.patName);

            List<Assesment_1.Patient> PatList = new List<Patient>();
            string[] lines = File.ReadAllLines(fileName);
            foreach (string item in lines)
            {
                string[] words = item.Split(',');
                var pat = new Assesment_1.Patient
                {
                    patId = int.Parse(words[0]),
                    patName = words[1],
                    billAmount = int.Parse(words[2]),
                    dctName = words[3]
                };
                PatList.Add(pat);
            }
            return PatList;
        }

        public static void serialization()
        {
            //PatientData data = createPatientData();
            string filepos = "PatientDetails.xml";
            var data = readAllRecords(fileName);
            FileStream fs = new FileStream(filepos, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter fm = new BinaryFormatter();
            fm.Serialize(fs, data);
            fs.Close();
        }

        private static void writePatientRecord(Assesment_1.Patient pat)
        {
            var line = $"{pat.patId},{pat.patName},{pat.billAmount},{pat.dctName},\n";
            List<object> information = new List<object>();
            information.Add(line);
            File.AppendAllText(fileName,line);
            //Console.WriteLine("Patient Details inserted Successfully");
        }

        private static void readAllLines(string filename)
        {

            var info = File.ReadAllText(filename);
            Console.WriteLine(info);
        }

    }
}
