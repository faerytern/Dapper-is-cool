using Dapper.FluentMap.Mapping;
using ConsoleApp2;

// Dapper does technically have it's own custom mapper, but it would be an entire page's worth of code per column to change. The FluentMap extension is super helpful, reducing the required code to just this and registering it before the DB call!
public class DonkeyMapper : EntityMap<Donkey>
{
    public DonkeyMapper()
    {
        Map(p => p.Date_Registered).ToColumn("Date Registered");
    }
}