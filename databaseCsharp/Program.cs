using System;
using databaseCsharp;

class Program
{
    static void Main(string[] args)
    {
        Database db = new Database();
        List<Diak> diakok = db.adatokBetoltese();
        //Console.WriteLine(diakok[0].Name);

        /* //atlag
         var eredmeny = diakok
         .GroupBy((d) => d.ClassId)
         .Select(csoport => new
         {
             Osztaly = csoport.Key,
             Atlag = csoport.Average(d => d.Avg)
         });

         

        //2
        var eredmeny = diakok
        .GroupBy((d) => d.ClassId)
        .Select(csoport => new
        {
            Osztaly = csoport.Key,
            Atlag = csoport.Average(d => d.Avg)
        })
        .OrderByDescending(adat => adat.Atlag);

        foreach (var adat in eredmeny)
        {
            System.Console.WriteLine($"{adat.Osztaly}: {adat.Atlag:F2}");
        }

        var eredmeny = diakok
        .GroupBy(d => d.ClassId)
        .Select(csoport =>
        {
            double legjobbAtlag = csoport.Max(d => d.Avg);
            return csoport
                .Where(d => d.Avg == legjobbAtlag)
                .Select(d => new
                {
                    d.ClassId,
                    d.Name,
                    d.Avg
                });
        });

        foreach (var diak in eredmeny)
        {
            foreach (var adat in diak)
            {
                System.Console.WriteLine($"{adat.ClassId} - {adat.Name}");
            }
        }*/

        var eredmeny = diakok
        .GroupBy(d => d.Age)
        .Select(csoport => new
        {
            Eletkor = csoport.Key,
            Letszam = csoport.Count()
        });

        foreach (var adat in eredmeny)
        {
            System.Console.WriteLine($"{adat.Eletkor} éves: {adat.Letszam}");
        }
    }
}
