using System.Collections.Generic;

namespace InfluxDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var influxDbClient = new InfluxData.Net.InfluxDb.InfluxDbClient("http://localhost:8086/", "test", "test", InfluxData.Net.Common.Enums.InfluxDbVersion.Latest);


            var pointToWrite = new Point
            {
                Name = "reading", // serie/measurement/table to write into
                Tags = new Dictionary<string, object>
                {
                    { "SensorId", 8 },
                    { "SerialNumber", "00AF123B" }
                },
                Fields = new Dictionary<string, object>
                {
                    { "SensorState", "act" },
                    { "Humidity", 431 },
                    { "Temperature", 22.1 },
                    { "Resistance", 34957 }
                },
                //Timestamp = DateTime.UtcNow // optional (can be set to any DateTime moment)
            };

            var response = influxDbClient.Client.WriteAsync("srtdb", pointToWrite);
            response.Wait();
        }
    }
}
