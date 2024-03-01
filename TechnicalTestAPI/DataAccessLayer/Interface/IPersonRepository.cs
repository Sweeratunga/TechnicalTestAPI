using TechnicalTestAPI.DataAccessLayer.Models;

namespace TechnicalTestAPI.DataAccessLayer.Interface
{
    public interface IPersonRepository:IDisposable
    {
        Task<IList<Person>> GetActivePeople();
        Task<Person?> GetPersonById(int id);
        Task<bool> AddPerson(Person person);
        Task<bool> DeletePerson(Person person);
        Task<bool> UpdatePerson(Person person);
        Task<Person?> GetPersonByName(string id);
    }
}
