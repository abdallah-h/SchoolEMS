using SchoolEMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolEMS.ViewModels
{
    public class GenderCityViewModel
    {
        public List<Gender> Gender { get; set; }
        public List<City> City { get; set; }
    }
}