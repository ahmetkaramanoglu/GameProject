using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Customer customer);
    }
}
