using System;
using System.IO;
using System.Text.Json;
using Assignment2.Models;
using Microsoft.AspNetCore.Hosting;

namespace Assignment2.Services
{
	public class JsonFileProductService
	{
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }
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

