using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Customer customer)
        {
            if (customer.FirstName == "Ahmet")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
