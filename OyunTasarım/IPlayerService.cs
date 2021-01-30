using System;
using System.Collections.Generic;
using System.Text;

namespace OyunTasarım
{
    interface IPlayerService
    {
        void Register(Player player);

        void Update(Player player);

        void Delete(Player player);    
    }
}
