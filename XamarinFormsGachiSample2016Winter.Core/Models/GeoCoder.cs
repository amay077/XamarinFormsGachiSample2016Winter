using System;
using System.Net.Http;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Refit;
using XamarinFormsGachiSample2016Winter.Primitives;

namespace XamarinFormsGachiSample2016Winter.Models
{
    public class GeoCoder : IGeoCoder
    {
        readonly HttpClient _client = new HttpClient();

        public Task<Location> Forward(string query)
        {
            var task = _client.GetStringAsync($"http://nominatim.openstreetmap.org/search?format=json&q={query}")
                .ToObservable()
                .Select(
                    json =>
                    {
                        var list = JsonConvert.DeserializeObject<Location[]>(json);
						return list.Length > 0 ? list[0] : null;

                    }).ToTask<Location>();
            return task;
        }
    }
}