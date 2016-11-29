using System.Threading.Tasks;
using XamarinFormsGachiSample2016Winter.Primitives;

namespace XamarinFormsGachiSample2016Winter.Models
{
    public interface IGeoCoder
    {
        Task<LatLong> Forward(string query);
    }
}