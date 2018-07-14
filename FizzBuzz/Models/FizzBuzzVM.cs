using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FizzBuzz.Model;

namespace FizzBuzz.Models
{
    public class FizzBuzzVM
    {
        [Required]
        public int EnterNumber { get; set; }

        public List<FizzBuzzEntity> FizzBuzzEntitys { get; set; }
    }
}