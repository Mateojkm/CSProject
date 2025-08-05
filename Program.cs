class Program
{
    static void Main(string[] args)
    {
        Patient patient = new Patient("Mateo", "Mulet", 75, 180);

        Console.Write("Enter systolic pressure: ");
        int systolic = int.Parse(Console.ReadLine());

        Console.Write("Enter diastolic pressure: ");
        int diastolic = int.Parse(Console.ReadLine());

        Console.WriteLine("\n--- Patient Info ---");
        patient.DisplayPatientInfo(systolic, diastolic);
    }
}
