using FizzBuzz.Model;
using FizzBuzz.Service.Interface;
using System;
using System.Collections.Generic;

namespace FizzBuzz.Service
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public List<FizzBuzzEntity> GetData(int number)
        {
            List<FizzBuzzEntity> lstData = new List<FizzBuzzEntity>();
            for (int i = 1; i <= number; i++)
            {
                FizzBuzzEntity data = new FizzBuzzEntity();
                if (i % 3 == 0 && i % 5 == 0)
                {
                    var day = DateTime.Today.DayOfWeek;
                    if (Convert.ToString(day) == "Wednesday")
                    {
                        data.Name = "WizzWuzz";
                        data.Color = "";
                    }
                    else
                    {
                        data.Name = "FizzBuzz";
                        data.Color = "";
                    }
                }
                else if (i % 3 == 0)
                {
                    data.Name = "Fizz";
                    data.Color = "blue";
                }
                else if (i % 5 == 0)
                {
                    data.Name = "Buzz";
                    data.Color = "green";
                }
                else
                {
                    data.Name = i.ToString();
                }
                lstData.Add(data);
            }
            return lstData;
        }
    }
}
