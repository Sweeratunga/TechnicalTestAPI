using Microsoft.EntityFrameworkCore;
using TechnicalTestAPI.DataAccessLayer.Context;
using TechnicalTestAPI.DataAccessLayer.Interface;
using TechnicalTestAPI.DataAccessLayer.Models;


namespace TechnicalTestAPI.DataAccessLayer.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly TechnicalTestDbContext _dataContext;

        public PersonRepository(TechnicalTestDbContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<bool> AddPerson(Person person)
        {
            if (_dataContext.People == null)
                return false;

            if (_dataContext.People.Any(x => x.Id == person.Id)) { return false; }

            await _dataContext.People.AddAsync(person);
            await _dataContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePerson(Person Person)
        {
            if (_dataContext.People == null)
                return false;

            if (!_dataContext.People.Any(x => x.Id == Person.Id)) { return false; }

            _dataContext.People.Remove(Person);
            await _dataContext.SaveChangesAsync();
            return true;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dataContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<IList<Person>> GetActivePeople()
        {
            if (_dataContext.People == null)
                return new List<Person>();

            return await _dataContext.People.Where(x => x.Active ?? false).ToListAsync();
        }

        public async Task<IList<Person>> GetPeople()
        {

            if (_dataContext.People == null)
                return new List<Person>();

            return await _dataContext.People.ToListAsync();
        }

        public async Task<Person?> GetPersonById(int id)
        {
            if (_dataContext.People == null)
                return null;

            return await _dataContext.People.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Person?> GetPersonByName(string name)
        {
            if (_dataContext.People == null)
                return null;

            return await _dataContext.People.FirstOrDefaultAsync(x => x.Name == name);
        }


        public async Task<bool> UpdatePerson(Person Person)
        {
            if (_dataContext.People == null)
                return false;

            if (!_dataContext.People.Any(x => x.Id == Person.Id)) { return false; }

            _dataContext.People.Update(Person);
            await _dataContext.SaveChangesAsync();
            return true;
        }
    }
}
