﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    abstract class Customer
    {
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
    }
}
