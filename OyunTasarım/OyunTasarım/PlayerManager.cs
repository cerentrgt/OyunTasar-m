using System;
using System.Collections.Generic;
using System.Text;

namespace OyunTasarım
{
    class PlayerManager:IPlayerService
    {
        IUserValidationService _userValidationService;
        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Register(Player player)
        {
            if (_userValidationService.Validate(player)==true)
            {
            Console.WriteLine(player.PlayerName +":" + "Oyuncu kaydedildi.");
        }
            else
            {
                Console.WriteLine(player.PlayerName+":"+ "Oyuncu kaydedilmedi");
            }
            
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.PlayerName + ":"+"Oyuncu bilgileri güncellendi.");
        }


        public void Delete(Player player)
        {
            Console.WriteLine(player.PlayerName + ":" + "Oyuncu silindi.");
        }
    }
}
