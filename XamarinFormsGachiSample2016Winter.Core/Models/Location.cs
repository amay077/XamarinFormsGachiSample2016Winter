using System;
using Newtonsoft.Json;

namespace XamarinFormsGachiSample2016Winter.Models
{
	public class Location
	{
	    [JsonProperty("lat")]
	    public double Latitude { get; set; }

	    [JsonProperty("lon")]
	    public double Longitude { get; set; }

	    [JsonProperty("display_name")]
	    public string DisplayName { get; set; }
	}
}
