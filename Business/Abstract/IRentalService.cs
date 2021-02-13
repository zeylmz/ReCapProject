using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

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
