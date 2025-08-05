using System;

namespace CSProjectGroupX
{
    public class Patient
    {
        // Private fields
        private string firstName;
        private string lastName;
        private double weightKg;
        private double heightCm;

        // Public properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public double WeightKg
        {
            get { return weightKg; }
            set { weightKg = value; }
        }

        public double HeightCm
        {
            get { return heightCm; }
            set { heightCm = value; }
        }

        // Constructor
        public Patient(string firstName, string lastName, double weightKg, double heightCm)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.weightKg = weightKg;
            this.heightCm = heightCm;
        }

        // Public method to evaluate blood pressure
        public string EvaluateBloodPressure(int systolic, int diastolic)
        {
            if (systolic < 120 && diastolic < 80)
                return "NORMAL";
            else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
                return "ELEVATED";
            else if ((systolic >= 130 && systolic <= 139) || (diastolic >= 80 && diastolic <= 89))
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
            else if ((systolic >= 140 && systolic <= 180) || (diastolic >= 90 && diastolic <= 120))
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
            else if (systolic > 180 || diastolic > 120)
                return "HYPERTENSIVE CRISIS (consult your doctor immediately)";
            else
                return "Invalid blood pressure values.";
        }

        // Private method to calculate BMI
        private double CalculateBMI()
        {
            double heightMeters = heightCm / 100.0;
            return weightKg / (heightMeters * heightMeters);
        }

        // Public method to print patient info
        public void PrintPatientInfo()
        {
            Console.WriteLine("Patient Information:");
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.WriteLine($"Weight: {weightKg} kg");
            Console.WriteLine($"Height: {heightCm} cm");
            Console.WriteLine($"BMI: {CalculateBMI():F2}");
        }
    }
}
