using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_1
{
    [Serializable]
    public class Patient
    {
        public int patId { get; set; }
        public string patName { get; set; }
        public int billAmount { get; set; }
        public string dctName { get; set; }
        public Patient() { }
        public Patient(int patId, string patName, int billAmount, string dctName)
        {
            this.patId = patId;
            this.patName = patName;
            this.billAmount = billAmount;
            this.dctName = dctName;
        }

        internal void DeepCopy(Patient pat)
        {
            throw new NotImplementedException();
        }
    }

    class PatientCollection
    {
        private static Patient[] _patList = new Patient[100];
        private Patient deepCopy(Patient pat)
        {
            Patient temp = new Patient();
            temp.patId = pat.patId;
            temp.patName = pat.patName;
            temp.billAmount = pat.billAmount;
            temp.dctName = pat.dctName;
            return temp;
        }
        public static void AddingPatient()
        {
            Console.WriteLine("Enter the Patient details...");
            int id = utilities.GetInteger("Enter Patient ID: ");
            string name = utilities.GetString("Enter Patient Name: ");
            int Amount = utilities.GetInteger("Enter Patient's Bill Amount: ");
            string doctorName = utilities.GetString("Enter Patient's Doctor Name: ");
            Patient pat = new Patient(id, name, Amount, doctorName);
            new PatientCollection().AddNewPatient(pat);
            Console.WriteLine("New Patient Added SuccessFully");
        }
        public void AddNewPatient(Patient pat)
        {
            for (int i = 0; i < 100; i++)
            {
                if (_patList[i] == null)
                {
                    _patList[i] = deepCopy(pat);
                    return;
                }
            }
        }
        public static void FindPatient()
        {
            int id = utilities.GetInteger("Enter the Patient ID to find the Patient");
            for (int i = 0; i < 100; i++)
            {
                if ((_patList[i] != null) && (_patList[i].patId == id))
                {
                    printPatient(id);
                    return;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("No Patient with id is found");
        }
        public static void printPatient(int id)
        {
            Console.WriteLine("The Patient Details Are:");
            for (int i = 0; i < 100; i++)
                if (_patList[i].patId == id)
                {
                    Console.WriteLine("The Patient Id is:" + _patList[i].patId);
                    Console.WriteLine("The Patient Name is:" + _patList[i].patName);
                    Console.WriteLine("The Patient Bill Amount is:" + _patList[i].billAmount);
                    Console.WriteLine("The Patient's Doctor is:" + _patList[i].dctName);
                    break;
                }
        }
        public static void FindAllPatient()
        {
            for (int i = 0; i < 100; i++)
            {
                if (_patList[i] != null)
                {
                    Console.WriteLine("The Patient Id is: " + _patList[i].patId);
                    Console.WriteLine("The Patient Name is: " + _patList[i].patName);
                    Console.WriteLine("The Patient Bill Amount is: " + _patList[i].billAmount);
                    Console.WriteLine("The Patient's Doctor is: " + _patList[i].dctName);
                    Console.WriteLine();
                }
                else continue;
            }
        }
        public static void DeletePatient()
        {
            int id = utilities.GetInteger("Enter the Patient id to delete its record");
            for (int i = 0; i < 100; i++)
                if (_patList[i].patId == id)
                {
                    _patList[i] = null;
                    Console.WriteLine("Patient Information Deleted Successfully");
                    break;
                }
        }
        public static void UpdatePatient()
        {
            int id = utilities.GetInteger("Enter Patient id to update his details");
            if (PatientCollection._patList.Length == 0)
                Console.WriteLine("There is no Patient present");
            else
            {
                for (int i = 0; i < 100; i++)
                {
                    if (_patList[i].patId == id)
                    {
                        int uid = utilities.GetInteger("Enter Id to update");
                        _patList[i].patId = uid;
                        string uname = utilities.GetString("Enter Name to update");
                        _patList[i].patName = uname;
                        int ubillAmount = utilities.GetInteger("Enter Bill Amount to update");
                        _patList[i].billAmount = ubillAmount;
                        string udctName = utilities.GetString("Enter Doctor's Name to update");
                        _patList[i].dctName = udctName;
                    }
                }
            }
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            bool condition = true;
            do
            {
                Console.WriteLine("\tMENU \n************************\nTo add new Patient : Press N\nTo update a Patient : Press U\nTo delete a Patient : Press D\nTo find a Patient : Press F\nTo Print All the Patients: Press A\nPS: Any other key implies to exit");
                string opt = Console.ReadLine().ToUpper();
                switch (opt)
                {
                    case "N":
                        PatientCollection.AddingPatient();
                        break;
                    case "U":
                        PatientCollection.UpdatePatient();
                        break;
                    case "D":
                        PatientCollection.DeletePatient();
                        break;
                    case "F":
                        PatientCollection.FindPatient();
                        break;
                    case "A":
                        PatientCollection.FindAllPatient();
                        break;
                    default:
                        condition = false;
                        break;
                }
            } while (condition);
        }
    }
}
