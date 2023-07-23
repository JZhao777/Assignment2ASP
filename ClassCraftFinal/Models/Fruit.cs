using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ClassCraftFinal.Models
{
	public class Fruit
    {

  // {
  //  "name": "apple",
  //  "color": "red",
  //  "img": "https://images.unsplash.com/photo-1590005354167-6da97870c757?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=881&q=80",
  //  "taste": "sweet",
  //  "origin": "Kazakhstan"
  //}


    public string? Name { get; set; }
        public string? Color { get; set; }

        [JsonPropertyName("img")]
        public string? Image { get; set; }
        public string? Taste { get; set; }
        public string? Origin { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Fruit>(this);

    }
}

