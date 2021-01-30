using System;
using System.Collections.Generic;
using System.Text;

namespace OyunTasarım
{
    interface IUserValidationService
    {
        bool Validate(Player player);
    }
}
