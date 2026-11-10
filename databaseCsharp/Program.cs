using System;
using databaseCsharp;

class Program
{
    static void Main(string[] args)
    {
        Database db = new Database();
        List<Diak> diakok = db.adatokBetoltese();
        Console.WriteLine(diakok[0].Name);
    }
}
