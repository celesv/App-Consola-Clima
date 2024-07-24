class Program
{
    static void Main(string[] args)
    {
        WeatherData weatherData = new WeatherData(@"C:\\Users\\playd\\source\\repos\\AppClima\\AppClima\\weatherV1.json");

        // Accede a los datos deserializados
        Console.WriteLine($"Copyright: {weatherData.copyright}");
        Console.WriteLine($"Web: {weatherData.web}");
        Console.WriteLine($"Language: {weatherData.language}");
        Console.WriteLine($"Locality Name: {weatherData.locality.name}");

        // Accede a los datos del día 1
        Console.WriteLine("Day 1:");
        Console.WriteLine($"Date: {weatherData.day1.date}");
        Console.WriteLine($"Max Temperature: {weatherData.day1.temperature_max}");
        Console.WriteLine($"Min Temperature: {weatherData.day1.temperature_min}");

        // Accede a los datos de la hora por hora
        Console.WriteLine("Hourly Data:");
        Console.WriteLine($"Hour 1 Date: {weatherData.hour_hour.hour1.date}");
        Console.WriteLine($"Hour 1 Hour Data: {weatherData.hour_hour.hour1.hour_data}");
    }
}


