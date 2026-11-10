using System;
using databaseCsharp;

class Program
{
    static void Main(string[] args)
    {
        Database db = new Database();
        List<Diak> diakok = db.adatokBetoltese();
        //Console.WriteLine(diakok[0].Name);

        //atlag
        var eredmeny = diakok
        .GroupBy((d) => d.ClassId)
        .Select(csoport => new
        {
            Osztaly = csoport.Key,
            Atlag = csoport.Average(d => d.Avg)
        });

        foreach (var adat in eredmeny)
        {
            System.Console.WriteLine($"{adat.Osztaly}: {adat.Atlag:F2}");
        }
    }
}
