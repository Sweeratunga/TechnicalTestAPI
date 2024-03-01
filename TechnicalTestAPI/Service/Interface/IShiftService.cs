using TechnicalTestAPI.DataAccessLayer.Models;
using TechnicalTestAPI.DataAccessLayer.Models.Dtos;
namespace TechnicalTestAPI.Service.Interface
{
    public interface IShiftService
    {
        Task<int?> GetShiftsCountByPersonName(string name);
        Task<List<RoleShiftCountDto>?> GetShiftAllocationByRole();
        Task<List<string?>?> GetDistinctLocations();
        Task<List<PersonDto>?> GetActivePersonShifts(DateTime startDate, DateTime endDate);
    }
}
