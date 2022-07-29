using Dapper.FluentMap.Mapping;
using ConsoleApp2;
public class DonkeyMapper : EntityMap<Donkey>
{
    public DonkeyMapper()
    {
        Map(p => p.Date_Registered).ToColumn("Date Registered");
    }
}