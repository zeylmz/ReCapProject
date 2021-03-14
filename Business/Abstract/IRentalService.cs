using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetAllByCarId(int id);
        IDataResult<List<Rental>> GetAllByCustomerId(int id);
        IDataResult<Rental> GetById(int rentalId);
        IResult Add(Rental rental);
    }
}
