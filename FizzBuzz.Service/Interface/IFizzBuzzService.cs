using FizzBuzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Service.Interface
{
   public interface IFizzBuzzService
    {
       List<FizzBuzzEntity> GetData(int number);
    }
}
