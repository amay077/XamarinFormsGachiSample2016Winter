using System.Threading.Tasks;
using XamarinFormsGachiSample2016Winter.Primitives;

namespace XamarinFormsGachiSample2016Winter.Models
{
    public interface IGeoCoder
    {
        Task<Location> Forward(string query);
    }
}