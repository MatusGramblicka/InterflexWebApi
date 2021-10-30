using InterflexWebApi.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterflexWebApi.Interfaces
{
    public interface IInterflexLib
    {
        Task<List<DayAndTime>> GetInterflexData(string username, string password);
    }
}