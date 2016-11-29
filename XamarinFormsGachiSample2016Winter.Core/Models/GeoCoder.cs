using System;
using System.Threading.Tasks;
using XamarinFormsGachiSample2016Winter.Primitives;

namespace XamarinFormsGachiSample2016Winter.Models
{
    public class GeoCoder : IGeoCoder
    {
        public Task<LatLong> Forward(string query)
        {
            return Task.Delay(2000).ContinueWith(t =>
            {
                return new LatLong(35d, 134d);
            });
        }
    }
}