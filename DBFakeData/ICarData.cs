using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBiding.DBFakeData
{
    public interface ICarData
    {
        IEnumerable<Car> GetAll();
        IEnumerable<Car> GetAllByName(string name);
    }
    
}
