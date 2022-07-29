using ConsoleApp2;
using System.Diagnostics;


Stopwatch swquery = Stopwatch.StartNew();
var donkeys = await DataAccess.GetDonkeysAsync();
swquery.Stop();

Stopwatch swforeach = Stopwatch.StartNew();
foreach (var item in donkeys) Console.WriteLine(item);
swforeach.Stop();

Stopwatch swjoin = Stopwatch.StartNew();
Console.WriteLine(string.Join(Environment.NewLine, donkeys));
swjoin.Stop();

Console.WriteLine($"{donkeys.Count} donkeys found..");
Console.WriteLine($"Query time: {swquery.Elapsed}");
Console.WriteLine($"foreach print time: {swforeach.Elapsed}");
Console.WriteLine($"join print time: {swjoin.Elapsed}");
