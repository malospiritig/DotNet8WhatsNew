using System.ComponentModel.DataAnnotations;

namespace Net8DataAnnotations
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        [Range(-20, 50, MinimumIsExclusive =true, MaximumIsExclusive =false)]
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [Length(3, 100)]
        public string? Summary { get; set; }

        [AllowedValues("Red", "Yellow", "Green")]
        [DeniedValues("Black", "White")]
        public string? AlertValue { get; set; }
    }
}
