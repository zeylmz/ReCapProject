using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=001,BrandId=001,ColorId=001,CarName="Fiat Egea",Description="Beyaz Renk değişensiz", ModelYear=2020, DailyPrice=159.99},
                new Car{Id=002,BrandId=002,ColorId=001,CarName="Audi A3",Description="Beyaz Renk değişensiz", ModelYear=2021, DailyPrice=279.90},
                new Car{Id=003,BrandId=002,ColorId=003,CarName="Audi Q5",Description="Gri Renk değişensiz", ModelYear=2020, DailyPrice=339.90},
                new Car{Id=004,BrandId=001,ColorId=002,CarName="Fiat Egea",Description="Siyah Renk değişensiz", ModelYear=2020, DailyPrice=159.99},
                new Car{Id=005,BrandId=003,ColorId=004,CarName="Ford Focus",Description="Diamond Mavi Renk değişensiz", ModelYear=2021, DailyPrice=225.50},
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.CarName = car.CarName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
