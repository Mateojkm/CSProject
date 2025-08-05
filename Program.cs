using System;
using System.IO;

namespace CSProjectGroupX
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("🩺 Welcome to the Patient Health Analyzer");

            // Collect user input
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Weight in KG: ");
            double weightKg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Height in CM: ");
            double heightCm = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter SYSTOLIC mm Hg (upper number): ");
            int systolic = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter DIASTOLIC mm Hg (lower number): ");
            int diastolic = Convert.ToInt32(Console.ReadLine());

            // Create Patient object
            Patient patient = new Patient(firstName, lastName, weightKg, heightCm);

            // Display patient info
            Console.WriteLine("\n--- Patient Summary ---");
            patient.PrintPatientInfo();

            // Evaluate blood pressure
            string bpResult = patient.EvaluateBloodPressure(systolic, diastolic);
            Console.WriteLine($"Blood Pressure Evaluation: {bpResult}");

            // Save to file
            string filePath = "PatientRecords.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("----- Patient Record -----");
                writer.WriteLine($"Name: {firstName} {lastName}");
                writer.WriteLine($"Weight: {weightKg} kg");
                writer.WriteLine($"Height: {heightCm} cm");
                writer.WriteLine($"BMI: {weightKg / Math.Pow(heightCm / 100.0, 2):F2}");
                writer.WriteLine($"Systolic: {systolic} mm Hg");
                writer.WriteLine($"Diastolic: {diastolic} mm Hg");
                writer.WriteLine($"Blood Pressure Evaluation: {bpResult}");
                writer.WriteLine($"Date: {DateTime.Now}");
                writer.WriteLine();
            }

            Console.WriteLine("\n📁 Patient data saved to PatientRecords.txt");
            Console.WriteLine("✅ Analysis Complete. Stay healthy!");
        }
    }
}
