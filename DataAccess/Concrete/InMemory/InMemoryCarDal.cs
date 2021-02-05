using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{CarId=001,BrandId=001,ColorId=001,CarName="Fiat Egea",Description="Beyaz Renk değişensiz", ModelYear=2020, DailyPrice=159.99},
                new Car{CarId=002,BrandId=002,ColorId=001,CarName="Audi A3",Description="Beyaz Renk değişensiz", ModelYear=2021, DailyPrice=279.90},
                new Car{CarId=003,BrandId=002,ColorId=003,CarName="Audi Q5",Description="Gri Renk değişensiz", ModelYear=2020, DailyPrice=339.90},
                new Car{CarId=004,BrandId=001,ColorId=002,CarName="Fiat Egea",Description="Siyah Renk değişensiz", ModelYear=2020, DailyPrice=159.99},
                new Car{CarId=005,BrandId=003,ColorId=004,CarName="Ford Focus",Description="Diamond Mavi Renk değişensiz", ModelYear=2021, DailyPrice=225.50},
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByColor(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarName = car.CarName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
