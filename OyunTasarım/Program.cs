using System;

namespace OyunTasarım
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.PlayerName = "Ceren";
            player1.PlayerLastName = "Turgut";
            player1.DateOfBirthYear = 2002;
            player1.NationalIdentity = 12345678921;

            Player player2 = new Player();
            player2.PlayerName = "Celal";
            player2.PlayerLastName = "Turgut";
            player2.DateOfBirthYear = 2001;
            player2.NationalIdentity = 25694322142;

            Player player3 = new Player();
            player3.PlayerName = "Tülay";
            player3.PlayerLastName = "Kılınc";
            player3.DateOfBirthYear = 1978;
            player3.NationalIdentity = 26946848928;

            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Register(player1);
            playerManager.Delete(player2);
            playerManager.Update(player3);

            Game game1 = new Game();
            game1.GameName = "CounterStrike";
            game1.GameStars = 5;
            game1.GameType = "Action";
            game1.GamePrice=26 ;

            Game game2 = new Game();
            game2.GameName = "Araba Yarışı";
            game2.GameStars = 5;
            game2.GameType = "Ralli";
            game2.GamePrice = 26;

            CompaniesManager companiesManager1 = new CompaniesManager();
            companiesManager1.BlackMayCompany(game1);
            companiesManager1.WeekendCompany (game2);

            Companies companies1 = new Companies();
            companies1.CompanyName = "Perfect Friday Company";
            companies1.CompanyPrice = 0.25;

            Companies companies2 = new Companies();
            companies2.CompanyName = "Loves Day Company";
            companies2.CompanyPrice = 0.32;

            Companies companies3 = new Companies();
            companies3.CompanyName = "Nıght Company ";
            companies3.CompanyPrice = 0.56;

            CompaniesManager companiesManager2 = new CompaniesManager();
            companiesManager2.NewCompanyAdd(companies1);
            companiesManager2.OldCompanyUpdate(companies2);
            companiesManager2.OldCompanyDelete(companies3);


            Console.ReadLine();
        }
    }
}
