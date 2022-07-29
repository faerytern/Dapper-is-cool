using Dapper;
using System.Configuration;
using MySqlConnector;
using Dapper.FluentMap;
namespace ConsoleApp2
{
    public static class DataAccess
    {

        public static async Task<List<Donkey>> GetDonkeysAsync()
        {
            FluentMapper.Initialize(a => a.AddMap(new DonkeyMapper()));
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DonkeyMuleDB"].ConnectionString))
            {
                var donkeys = await connection.QueryAsync<Donkey>("SELECT * FROM donkey WHERE Name <> '' AND `Also Known As` != '' AND `Date Registered` IS NOT NULL");
                var donkey = await connection.QueryFirstAsync<Donkey>("SELECT * FROM donkey WHERE Name <> '' AND `Also Known As` != '' AND `Date Registered` IS NOT NULL");
                Console.WriteLine($"My first Donkey! {Environment.NewLine}{donkey}");
                return donkeys.ToList();
            }
        }
    }
}
