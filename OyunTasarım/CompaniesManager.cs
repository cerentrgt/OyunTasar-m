using System;
using System.Collections.Generic;
using System.Text;

namespace OyunTasarım
{
    class CompaniesManager:ICompaniesService
    {
        public void NewCompanyAdd(Companies companies)
        {
            Console.WriteLine(companies.CompanyName+":"+" kampanyası eklendi.");
        }

        public void OldCompanyDelete(Companies companies)
        {
            Console.WriteLine(companies.CompanyName + ":" + " ismindeki kampanya silindi.");
        }

        public void OldCompanyUpdate(Companies companies)
        {
            Console.WriteLine(companies.CompanyName + ":" + "Kampanyası güncellendi.");
        }
        public void BlackMayCompany( Game game)
        {
            Console.WriteLine(game.GameName+" : " + "siyah mayıs kampanyası uygulandı.");
        }
        public void WeekendCompany( Game game)
        {
            Console.WriteLine(game.GameName + ":"  + "haftasonu  kampanyası uygulandı."); 
        }
    }
}
