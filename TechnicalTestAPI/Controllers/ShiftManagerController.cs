using Microsoft.AspNetCore.Mvc;
using TechnicalTestAPI.DataAccessLayer.Models.Dtos;
using TechnicalTestAPI.Service.Interface;

namespace TechnicalTestAPI.Controllers
{
    public class ShiftManagerController : Controller
    {
        private readonly IShiftService _shiftService;
        public ShiftManagerController(IShiftService shiftservice)
        {
            _shiftService = shiftservice;
        }
        /// <summary>
        /// name as input and returns the total number of shifts assigned to that person.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetShiftsCountByPersonName([FromQuery] string name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("provided data insufficient"); ;
            }
            var count = await _shiftService.GetShiftsCountByPersonName(name);
            if (count != null)
                return Ok(count);
            else
                return BadRequest("Person not found");
        }
        /// <summary>
        /// returns an array of role and the total number of shifts assigned to that role in descending order.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetShiftAllocationByRole()
        {
            var claims = (await _shiftService.GetShiftAllocationByRole())?.ToArray();
            if (claims != null)
                return Ok(claims);
            else
                return BadRequest("No data found");
        }
        /// <summary>
        /// returns a list of unique locations
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetLocations()
        {
            var locations = await _shiftService.GetDistinctLocations();
            if (locations != null)
                return Ok(locations);
            else
                return BadRequest("No data found");
        }
        /// <summary>
        /// retrieves a list of shifts for active people where the shift starts between two dates.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> GetActivePersonShifts(DateTime startDate, DateTime endDate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Incorrect parameters provided");
            }
           var result= await _shiftService.GetActivePersonShifts(startDate, endDate);
            if (result!=null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("No active shifts found");
            }
        }
    }
}
