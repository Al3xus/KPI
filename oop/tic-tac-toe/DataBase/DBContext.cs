using System.Collections.Generic;
using tic_tac_toe.PackageForPlayers;


namespace tic_tac_toe.DataBase;

public class DbContext
{
    public List<Account> Accounts { get; }

    public DbContext()
    {
        Accounts = new List<Account>();
    }
}