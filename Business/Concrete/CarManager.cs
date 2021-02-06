using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araç Başarıyla Eklendi");                
            }
            else
                Console.WriteLine("Hatalı bir giriş yaptınız. Lütfen tekrar deneyiniz.");

        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
