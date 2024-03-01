using Microsoft.EntityFrameworkCore;
using TechnicalTestAPI.DataAccessLayer.Context;
using TechnicalTestAPI.DataAccessLayer.Interface;
using TechnicalTestAPI.DataAccessLayer.Models;
using TechnicalTestAPI.DataAccessLayer.Models.Dtos;

namespace TechnicalTestAPI.DataAccessLayer.Repository
{
    public class ShiftRepository : IShiftRepository
    {
        private readonly TechnicalTestDbContext _dataContext;

        public ShiftRepository(TechnicalTestDbContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task<IList<Shift>> GetShifts()
        {

            if (_dataContext.Shifts == null)
                return new List<Shift>();

            return await _dataContext.Shifts.ToListAsync();
        }

        public async Task<Shift?> GetShiftById(int id)
        {
            if (_dataContext.Shifts == null)
                return null;

            return await _dataContext.Shifts.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Shift>?> GetShiftsByPersonId(int id)
        {
            if (_dataContext.Shifts == null)
                return null;

            return await _dataContext.Shifts.Where(x => x.PersonId == id).ToListAsync();
        }
        public async Task<List<Shift>?> GetPersonShiftsForRange(int id, DateTime startDate, DateTime endDate)
        {
            if (_dataContext.Shifts == null)
                return null;

            return await _dataContext.Shifts.Where(x => x.PersonId == id && x.Start.HasValue && x.Start <= startDate).ToListAsync();
        }
        public async Task<int?> GetShiftCountByPersonId(int id)
        {
            if (_dataContext.Shifts == null)
                return null;

            return await _dataContext.Shifts.CountAsync(x => x.PersonId == id);
        }

        public async Task<List<RoleShiftCountDto>?> GetRoleBasedShiftCount()
        {
            if (_dataContext.Shifts == null)
                return null;

            return await _dataContext.Shifts.GroupBy(x => x.Role).Select(y => new RoleShiftCountDto { Role = y.Key, Count = y.Count() }).OrderByDescending(z => z.Role).ToListAsync();
        }

        public async Task<List<string?>?> GetDistinctLocations()
        {
            if (_dataContext.Shifts == null)
                return null;

            return await _dataContext.Shifts.Select(x => x.Location).Distinct().ToListAsync();
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
    }
}
