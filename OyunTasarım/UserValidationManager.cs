using System;
using System.Collections.Generic;
using System.Text;

namespace OyunTasarım
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if (player.PlayerName=="Ceren" && player.PlayerLastName=="Turgut" && player.DateOfBirthYear==2002 
                && player.NationalIdentity== 12345678921)
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
