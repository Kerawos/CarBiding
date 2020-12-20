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
                new Car ()
            };
        }

        public IEnumerable<Car> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
