using System;
using System.Collections.Generic;
using System.Text;

namespace OyunTasarım
{
    class PlayerManager:IPlayerService
    {
        public void Register(Player player)
        {
            Console.WriteLine(player.PlayerName +":" + "Oyuncu kaydedildi.");
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
