using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Messaging;
using Azure.Storage.Queues;
using System.Collections;

namespace larry_project3
{
    class Program
    {
        static void Main(string[] args){
    

            ///Synchronous

            /*var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            string fileName = "WeatherForecast.json";
            string jsonString = JsonSerializer.Serialize(weatherForecast);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));*/

            ///Asynchronous

            /*var weatherForecast = new AWeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            string fileName = "WeatherForecast.json";
            using FileStream createStream = File.Create(fileName);
            await JsonSerializer.SerializeAsync(createStream, weatherForecast);
            await createStream.DisposeAsync();

            Console.WriteLine(File.ReadAllText(fileName));
            Console.ReadLine(); */
            var imagePath = @"C:\users\lol4l\downloads\cutemonkey.png";

            string connectionString = "DefaultEndpointsProtocol=https;AccountName=vc0316;AccountKey=EtncGrpA7RkLfhOz5WuaA57bZ7jR4Gx/TgYfmGidUxfJL1qNdiTxnoca6GPK24Qi4NWUmFk5Mib2+AStC/IjOA==;EndpointSuffix=core.windows.net";
            QueueClient queue = new QueueClient(connectionString, "barbie");
            
            for (int i = 0; i < 10; i++)
            {
                queue.SendMessageAsync($"Hi. Today's date and time is {DateTime.Now} - Larry");
                queue.SendMessageAsync(JsonSerializer.SerializeToDocument(imagePath));
            }
        }
        }
    }

