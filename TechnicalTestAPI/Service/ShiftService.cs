using System.Security.Claims;
using TechnicalTestAPI.DataAccessLayer.Interface;
using TechnicalTestAPI.DataAccessLayer.Models;
using TechnicalTestAPI.DataAccessLayer.Models.Dtos;
using TechnicalTestAPI.Service.Interface;

namespace TechnicalTestAPI.Service
{
    public class ShiftService : IShiftService
    {
        IShiftRepository _shiftRepository;
        IPersonRepository _personRepository;

        public ShiftService(IShiftRepository shiftRepository, IPersonRepository personRepository)
        {
            _shiftRepository = shiftRepository;
            _personRepository = personRepository;

        }

        public async Task<int?> GetShiftsCountByPersonName(string name)
        {
            var person = await _personRepository.GetPersonByName(name);
            if (person == null)
            {
                return null;
            }
            return await _shiftRepository.GetShiftCountByPersonId(person.Id);
        }

        public async Task<List<RoleShiftCountDto>?> GetShiftAllocationByRole()
        {
            return await _shiftRepository.GetRoleBasedShiftCount();
        }

        public async Task<List<string?>?> GetDistinctLocations()
        {
            return await _shiftRepository.GetDistinctLocations();
        }

        public async Task<List<PersonDto>?> GetActivePersonShifts(DateTime startDate, DateTime endDate)
        {
            var activePersonalShiftList = new List<PersonDto>();
            var people = await _personRepository.GetActivePeople();
            if (people == null)
            {
                return null;
            }
            foreach (var item in people)
            {
                var person = new PersonDto()
                {
                    Id = item.Id,
                    Name = item.Name,
                    DateOfBirth = item.DateOfBirth,
                    StartDate = item.StartDate,
                    Active = true
                };
                person.Shifts = (await _shiftRepository.GetPersonShiftsForRange(item.Id, startDate, endDate))?.Select(x => new ShiftDto
                {
                    Id = x.Id,
                    Location = x.Location,
                    Role = x.Role,
                    Start = x.Start,
                    End = x.End
                }).ToList();
                activePersonalShiftList.Add(person);
            }
            return activePersonalShiftList;


        }
    }
}
