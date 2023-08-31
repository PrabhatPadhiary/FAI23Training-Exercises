using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assesment_1
{
    [Serializable]
    public class PatientData
    {
        public double patId { get; set; }
        public string patName { get; set; }
        public int billAmount { get; set; }
        public string dctName { get; set; }

        public static PatientData createPatientData()
        {
            double patientId = utilities.GetDouble("Enter Patient ID: ");
            string patientName = utilities.GetString("Enter the name of the Patient: ");
            int patBillAmount = utilities.GetInteger("Enter the total Bill Amount: ");
            string doctorName = utilities.GetString("Enter the Doctor name he referred to: ");

            return new PatientData
            {
                patId = patientId,
                patName = patientName,
                billAmount = patBillAmount,
                dctName = doctorName
            };
        }

        public static void serialization()
        {
            PatientData data = createPatientData();
            FileStream fs = new FileStream("PatientDetails.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer fm = new XmlSerializer(typeof(PatientData));
            fm.Serialize(fs, data);
            fs.Close();
        }

        public static void deserialization()
        {
            FileStream fs = new FileStream("PatientDetails.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer fm = new XmlSerializer(typeof(PatientData));
            PatientData extracted = fm.Deserialize(fs) as PatientData;
            Console.WriteLine(extracted.ToString());
        }
        static void Main(string[] args)
        {
            serialization();
            //deserialization();
        }
    }
}
