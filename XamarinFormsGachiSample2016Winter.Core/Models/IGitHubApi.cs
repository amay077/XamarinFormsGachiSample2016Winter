using System.Threading.Tasks;
using Refit;

namespace XamarinFormsGachiSample2016Winter.Models
{
    public interface IGitHubApi
    {
        [Get("/users/{user}")]
        Task<User> GetUser(string user);
    }
}