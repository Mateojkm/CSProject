public class Patient
{
    // Private fields
    private string firstName;
    private string lastName;
    private double weight; // in kg
    private double height; // in cm

    // Public properties
    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public double Weight { get => weight; set => weight = value; }
    public double Height { get => height; set => height = value; }

    // Constructor
    public Patient(string firstName, string lastName, double weight, double height)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.weight = weight;
        this.height = height;
    }

    // Public method for blood pressure
    public string CheckBloodPressure(int systolic, int diastolic)
    {
        if (systolic < 90 || diastolic < 60 || systolic > 180 || diastolic > 120)
            return "Warning: Blood pressure values are out of safe range.";

        if (systolic < 120 && diastolic < 80)
            return "Normal";
        else if (systolic < 130 && diastolic < 80)
            return "Elevated";
        else if (systolic < 140 || diastolic < 90)
            return "Hypertension Stage 1";
        else if (systolic < 180 || diastolic < 120)
            return "Hypertension Stage 2";
        else
            return "Hypertensive Crisis";
    }

    // Private method for BMI
    private double CalculateBMI()
    {
        double heightInMeters = height / 100;
        return weight / (heightInMeters * heightInMeters);
    }

    // Public method to display patient info
    public void DisplayPatientInfo(int systolic, int diastolic)
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Weight: {Weight} kg");
        Console.WriteLine($"Height: {Height} cm");
        Console.WriteLine($"Blood Pressure Status: {CheckBloodPressure(systolic, diastolic)}");
        Console.WriteLine($"BMI: {CalculateBMI():F2}");
    }
}
