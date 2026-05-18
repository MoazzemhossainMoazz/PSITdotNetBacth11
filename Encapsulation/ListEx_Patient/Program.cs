using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListEx_Patient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Patient> patientlist = new List<Patient>();
            //Patient patient1 = new Patient() { Id = 1, Name = "Sakib", Age = 35, Mobile = "01700000000", Address = "Dhaka" };
            //Patient patient2 = new Patient() { Id = 2, Name = "Tamim", Age = 35, Mobile = "01700000001", Address = "Dhaka" };
            //Patient patient3 = new Patient() { Id = 3, Name = "Mushfiq", Age = 35, Mobile = "01700000002", Address = "Dhaka" };

            Patient patient1 = new Patient() {  Name = "Sakib", Age = 35, Mobile = "01700000000", Address = "Dhaka" };
            Patient patient2 = new Patient() {  Name = "Tamim", Age = 35, Mobile = "01700000001", Address = "Dhaka" };
            Patient patient3 = new Patient() {  Name = "Mushfiq", Age = 35, Mobile = "01700000002", Address = "Dhaka" };

            patientlist.Add(patient1);
            patientlist.Add(patient2);
            patientlist.Add(patient3);
            Console.WriteLine($"ID\t\tName\t\tAge\t\tMobile\t\tAddress");

            foreach (var patient in patientlist)
            {
                Console.WriteLine($"{patient.Id}\t\t{patient.Name}\t\t{patient.Age}\t\t {patient.Mobile}\t\t{patient.Address}");
            }

            patientlist.Remove(patient3);
            Console.WriteLine("Remove Mushfiq from patient list: ");
            Console.WriteLine($"ID\t\tName\t\tAge\t\tMobile\t\tAddress");
            foreach (var patient in patientlist)
            {
                Console.WriteLine(patient.Id + "\t\t" + patient.Name + "\t\t" + patient.Age + "\t\t " + patient.Mobile + "\t\t" + patient.Address);
            }

            Patient patient4 =  new Patient() { Name = "Mushfiq", Age = 35, Mobile = "01700000002", Address = "Dhaka" };
            patientlist.Add(patient4);
            Console.WriteLine($"ID\t\tName\t\tAge\t\tMobile\t\tAddress");

            foreach(var patient in patientlist)
            {
                Console.WriteLine(patient.Id + "\t\t" + patient.Name + "\t\t" + patient.Age + "\t\t " + patient.Mobile + "\t\t" + patient.Address);
            }
        }
    }
}
