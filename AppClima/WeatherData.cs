using System.Text.Json;

 class WeatherData
{
    public string copyright { get; set; }
    public string use { get; set; }
    public Information information { get; set; }
    public string web { get; set; }
    public string language { get; set; }
    public Locality locality { get; set; }
    public Day day1 { get; set; }
    public Day day2 { get; set; }
    public HourHour hour_hour { get; set; }

    public WeatherData(string jsonFilePath)
    {
        string jsonString = File.ReadAllText(jsonFilePath);
        JsonDocument document = JsonDocument.Parse(jsonString);
        JsonElement root = document.RootElement;

        // JsonDocument se usa para manejar documentos JSON completos, mientras que JsonElement se usa para acceder y manipular elementos individuales dentro de esos documentos sin tener que deserializar todo el JSON de una vez. 

        foreach (JsonProperty i in root.EnumerateObject())
        {
            if (i.NameEquals("copyright"))
            {
                this.copyright = i.Value.GetString();
            }
            else if (i.NameEquals("use"))
            {
                this.use = i.Value.GetString();
            }
            else if (i.NameEquals("information"))
            {
                this.information = JsonSerializer.Deserialize<Information>(i.Value.GetRawText());
            }
            else if (i.NameEquals("web"))
            {
                this.web = i.Value.GetString();
            }
            else if (i.NameEquals("language"))
            {
                this.language = i.Value.GetString();
            }
            else if (i.NameEquals("locality"))
            {
                this.locality = JsonSerializer.Deserialize<Locality>(i.Value.GetRawText());
            }
            else if (i.NameEquals("day1"))
            {
                this.day1 = JsonSerializer.Deserialize<Day>(i.Value.GetRawText());
            }
            else if (i.NameEquals("day2"))
            {
                this.day2 = JsonSerializer.Deserialize<Day>(i.Value.GetRawText());
            }
            else if (i.NameEquals("hour_hour"))
            {
                this.hour_hour = JsonSerializer.Deserialize<HourHour>(i.Value.GetRawText());
            }
        }
    }
}

public class Information
{
    public string temperature { get; set; }
    public string wind { get; set; }
    public string humidity { get; set; }
    public string pressure { get; set; }
}

public class Locality
{
    public string name { get; set; }
    public string url_weather_forecast_15_days { get; set; }
    public string url_hourly_forecast { get; set; }
    public string country { get; set; }
    public string url_country { get; set; }
}

public class Day
{
    public string date { get; set; }
    public int temperature_max { get; set; }
    public int temperature_min { get; set; }
    public string icon { get; set; }
    public string text { get; set; }
    public int humidity { get; set; }
    public int wind { get; set; }
    public string wind_direction { get; set; }
    public string icon_wind { get; set; }
    public string sunrise { get; set; }
    public string sunset { get; set; }
    public string moonrise { get; set; }
    public string moonset { get; set; }
    public string moon_phases_icon { get; set; }
}

public class HourHour
{
    public HourData hour1 { get; set; }
    public HourData hour2 { get; set; }
}

public class HourData
{
    public string date { get; set; }
    public string hour_data { get; set; }
    public int temperature { get; set; }
    public string text { get; set; }
    public int humidity { get; set; }
    public int pressure { get; set; }
    public string icon { get; set; }
    public int wind { get; set; }
    public string wind_direction { get; set; }
    public string icon_wind { get; set; }
}

