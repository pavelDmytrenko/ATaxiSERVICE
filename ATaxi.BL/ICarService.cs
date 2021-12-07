using ATaxi.DL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ATaxi.BL
{
    public interface ICarService
    {
        Car GetCarByID(int? id);
        List<Car> GetAllCars();
        void AddCar(Car car);
        Car DeleteCar(int id);
    }
}
