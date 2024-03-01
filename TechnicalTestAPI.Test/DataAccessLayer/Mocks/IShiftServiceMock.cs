using TechnicalTestAPI.Service;
using TechnicalTestAPI.Service.Interface;

namespace TechnicalTestAPI.Test.DataAccessLayer.Mocks
{
    public class IShiftServiceMock
    {

        public static IShiftService GetMock()
        {
            return new ShiftService(IShiftRepositoryMock.GetMock(), IPersonRepositoryMock.GetMock());
        }
    }
}
