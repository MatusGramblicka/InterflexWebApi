using InterflexWebApi.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterflexWebApi.Interfaces
{
    public interface IExchangeLib
    {
        Task<(List<Exchange>, bool)> GetExchangeData(string userName, string password);
    }
}