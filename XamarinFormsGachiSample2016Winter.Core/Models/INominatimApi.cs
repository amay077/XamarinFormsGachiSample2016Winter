using System;
using System.Threading.Tasks;
using Refit;

namespace XamarinFormsGachiSample2016Winter.Models
{
	public interface INominatimApi
	{
	    [Get("/search?format=json&q={query}")]
	    Task<NominatimResponse[]> GetLocations(string query);
	}
}
