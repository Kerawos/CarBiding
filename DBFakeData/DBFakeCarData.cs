using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBiding.DBFakeData
{
    public class DBFakeCarData : ICarData
    {
        List<Car> cars;

        public DBFakeCarData()
        {
            cars = new List<Car>
            {
                new Car (1, "Audi S6", DateTime.Now, DateTime.Now.AddDays(2)),
                new Car(2, "Subaru Impreza", DateTime.Now, DateTime.Now.AddDays(5)),
                new Car(3, "Renault Clio", DateTime.Now, DateTime.Now.AddDays(3)),
            };
        }

        public IEnumerable<Car> GetAll()
        {
            return from c in cars
                   orderby c.TimeAuctionEnd
                   ascending
                   select c;
        }

        public IEnumerable<Car> GetAllByName(string name = null)
        {
            return from c in cars
                   where string.IsNullOrEmpty(name) || c.Title.StartsWith(name)
                   orderby c.Title
                   ascending
                   select c;
        }

        public Car GetByID(int id)
        {
            return cars.SingleOrDefault(c => c.ID == id);
        }
    }
}
