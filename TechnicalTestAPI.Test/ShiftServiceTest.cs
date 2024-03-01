using TechnicalTestAPI.DataAccessLayer.Interface;
using TechnicalTestAPI.DataAccessLayer.Models;
using TechnicalTestAPI.DataAccessLayer.Models.Dtos;
using TechnicalTestAPI.Service.Interface;
using TechnicalTestAPI.Test.DataAccessLayer.Mocks;

namespace TechnicalTestAPI.Test
{
    public class ShiftServiceTest
    {
        IShiftService _shiftService;


        [SetUp]
        public void SetUp()
        {

            _shiftService = IShiftServiceMock.GetMock();
  
        }

        [Test]
        [TestCase("John Doe")]
        [TestCase("fail5678900987654321")]
        public async Task GetShiftsCountByPersonName(string id)
        {
            //Arrange


            //Act
            int? count = await _shiftService.GetShiftsCountByPersonName(id);


            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(count, Is.Not.Null);
                Assert.That(count, Is.GreaterThan(0));
            });
        }

        [Test]
      
        public async Task GetShiftAllocationByRole()
        {
            //Arrange
            //string id = "12345678900987654321";

            //Act
            var data = await _shiftService.GetShiftAllocationByRole();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(data, Is.Not.Null);
            Assert.That(data?[1].Role, Is.EqualTo("Doctor"));
            });
        }


        [Test]
        public async Task GetLocations()
        {
            var locations = await _shiftService.GetDistinctLocations();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(locations, Is.Not.Null);
                Assert.That(locations?.Count, Is.GreaterThan(1));
            });
        }

    }
}
