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
                new Car(2, "Subaru Impreza", DateTime.Now, DateTime.Now.AddDays(3)),
                new Car(3, "Renault Clio", DateTime.Now, DateTime.Now.AddDays(5)),
            };
        }

        public IEnumerable<Car> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
