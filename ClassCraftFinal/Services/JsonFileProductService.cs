using System;
using System.IO;
using System.Text.Json;
using Assignment2.Models;
using Microsoft.AspNetCore.Hosting;

namespace Assignment2.Services
{
	public class JsonFileProductService
	{
        //initializes the JsonFileProductService class with an instance of the IWebHostEnvironment. 
        //This allows the class to access information about the web hosting environment, such as paths, directories, and other related settings.
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        //Declares a read-only property WebHostEnvironment of type IWebHostEnvironment in the JsonFileProductService class,
        //allows the class to access information about the web hosting environment 
        public IWebHostEnvironment WebHostEnvironment { get; }

        //access the json file
        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "fruits.json");

        //this <Fruit> refers to the Fruit.cs under Models
        public IEnumerable<Fruit> GetProducts()
        {
            using var jsonFileReader = File.OpenText(JsonFileName);

            return JsonSerializer.Deserialize<Fruit[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                })!;
        }
        }
}

