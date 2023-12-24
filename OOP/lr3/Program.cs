namespace lab3
{

    class Program
    {
        public static void play(GameAccount p1, GameAccount p2, Game game)
        {
            Random random = new Random();
            decimal randomNumber = random.Next(0, 2);

            if (game.GameTypeNumber == 1)
            {
                if (randomNumber == 0)
                {
                    p1.WinGame(p2.Username, game);

                    p2.LoseGame(p1.Username, game);

                }
                else
                {
                    p1.LoseGame(p2.Username, game);

                    p2.WinGame(p1.Username, game);
                }
            }

            if (game.GameTypeNumber == 2)
            {
                p1.WinGame_noRating(p2.Username, game);

                p2.LoseGame_noRating(p1.Username, game);
            }

            if (game.GameTypeNumber == 3)
            {
                if (randomNumber == 0)
                {
                    p1.WinGame(p2.Username, game);

                    p2.LoseGame_noRating(p1.Username, game);

                }
                else
                {
                    p1.LoseGame_noRating(p2.Username, game);

                    p2.WinGame(p1.Username, game);
                }
            }
        }
        static void Main(string[] args)
        {
            //GameStats.GlobalId = 2000;            

            fabric fabric = new fabric();
            //Game rank = fabric.MakeGameObject(1);

            IAccountService accountService = new AccountService();
            IGameService gameService = new GameService();


            var account1 = accountService.CreateAccount(1, "Albus", 10, 1);
            var account2 = accountService.CreateAccount(2, "Persival", 10, 2);
            var account3 = accountService.CreateAccount(3, "Wulfric", 10, 3);


            gameService.CreateGame(account1, account2, fabric.MakeGameObject(1));
            gameService.CreateGame(account1, account2, fabric.MakeGameObject(1));
            gameService.CreateGame(account1, account3, fabric.MakeGameObject(1));

            accountService.ReadAccounts();
            gameService.ReadGames();
            accountService.ReadPlayedGamesByPlayer(1);









        }
    }

};
