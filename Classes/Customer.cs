﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        // Property
        public int Id { get; set; }
        //private string _firstName;
        //public string FirstName
        //{
        //    get
        //    {
        //        return "Mr." + _firstName;
        //    }
        //    set
        //    {
        //        _firstName = value;
        //    }
        //}
        //public string FirstName
        //{
        //    get => "Mr." + _firstName;
        //    set => _firstName = value;
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
