using System;
using TechnicalTestAPI.DataAccessLayer.Models;
using TechnicalTestAPI.DataAccessLayer.Models.Dtos;

namespace TechnicalTestAPI.DataAccessLayer.Interface
{
    public interface IShiftRepository:IDisposable
    {
        Task<IList<Shift>> GetShifts();
        Task<Shift?> GetShiftById(int id);
        //Task<bool> AddShift(Shift Shift);
        //Task<bool> DeleteShift(Shift Shift);
        //Task<bool> UpdateShift(Shift Shift);
        Task<List<Shift>?> GetShiftsByPersonId(int id);
        //Write an endpoint which takes a name as input and returns the total number of shifts assigned to that person.
        Task<int?> GetShiftCountByPersonId(int id);
        //Write an endpoint which returns an array of role and the total number of shifts assigned to that role in descending order.
        Task<List<RoleShiftCountDto>?> GetRoleBasedShiftCount();
        //Write an endpoint which returns a list of unique locations.
        Task<List<string?>?> GetDistinctLocations();

        //get shifts by personId and range
        Task<List<Shift>?> GetPersonShiftsForRange(int id, DateTime startDate, DateTime endDate);
    }
}
