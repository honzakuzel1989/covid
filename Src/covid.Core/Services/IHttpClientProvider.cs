using System.Net.Http;

namespace covid.Core.Services
{
    public interface IHttpClientProvider
    {
        HttpClient Get();
    }
}