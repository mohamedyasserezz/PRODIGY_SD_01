namespace PRODIGY_SD_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Conversion Program");

            // Get The Input From user 
            double Temperature = GetTemperatureFromUser();
            char Unit = GetUnitFromUser();

            // Build the UserInterface using the builder pattern
            UserInterface UserInterface = new UserInterface.Builder()
                .SetTemperature(Temperature)
                .SetUnit(Unit)
                .Build();

            // Run the conversion
            UserInterface.StartConversion();
        }

        private static double GetTemperatureFromUser()
        {
            double Temperature;
            do
            {
                Console.Write("Enter the temperature value: ");
            }
            while (!double.TryParse(Console.ReadLine(), out Temperature));
            
            return Temperature;
        }

        private static char GetUnitFromUser()
        {
            char unit;
            do
            {
                Console.Write("Enter the unit (C for Celsius, F for Fahrenheit, K for Kelvin): ");
                unit = char.ToUpper(Console.ReadKey().KeyChar);
            }
            while (unit != 'C' && unit != 'F' && unit != 'K') ;
            return unit;
        }
    }
}
