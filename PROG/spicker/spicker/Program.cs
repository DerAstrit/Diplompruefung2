// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using spicker;
using System.Diagnostics.Metrics;


using (var context = new Context())     //Löschen des DB Inahltes um zu verhindern das DB mit Objekten überflutet wird
{
    // Probanden löschen
    var probanden = context.Probanden.ToList();
    context.Probanden.RemoveRange(probanden);

    // Mütter löschen
    var mutters = context.Mutters.ToList();
    context.Mutters.RemoveRange(mutters);

    context.SaveChanges();

}
using(var context  = new Context()) //Mutter hinzufügen 
{
    Mutter mutter1 = new Mutter()
    {Nachname = "Meier" , Vorname = "Anna", Jahrgang = 1970};
    context.Add(mutter1);
    context.SaveChanges();
}

using (Context context = new Context()) //Proband hinzufügen 
{
    Proband proband1 = new Proband()
    { Jahrgang = 1999, Geschlecht = "Männlich", Vorname = "Hans", Nachname = "Meier", Mutter = context.Mutters.Where(x => x.Vorname.Equals("Anna")).FirstOrDefault() };
     context.Add(proband1);
    context.SaveChanges();
}

using (Context context = new Context()) //Proband hinzufügen 
{
    Proband proband2 = new Proband()
    { Jahrgang = 1996, Geschlecht = "Weiblich", Vorname = "Ursula", Nachname = "Meier", Mutter = context.Mutters.Where(x => x.Vorname.Equals("Anna")).FirstOrDefault() };
    context.Add(proband2);
    context.SaveChanges();
}

using (var context = new Context()) //Probanden Anzeigen
{
    var probanden = context.Probanden.Include(p => p.Mutter).ToList();

    foreach (var proband in probanden)
    {
        Console.WriteLine($"Vorname: {proband.Vorname}");
        Console.WriteLine($"Nachname: {proband.Nachname}");
        Console.WriteLine($"Jahrgang: {proband.Jahrgang}");
        Console.WriteLine($"Geschlecht: {proband.Geschlecht}");
        Console.WriteLine($"Mutter: {proband.Mutter.Vorname} {proband.Mutter.Nachname}");
        Console.WriteLine("----------------------------------");
    }

    Console.ReadKey();
    Console.Clear();
}

using (var context = new Context()) //Probanden Ändern 
{
    var proband = context.Probanden.FirstOrDefault(p => p.Vorname.Equals("Ursula") && p.Nachname.Equals("Meier"));

    if (proband != null)
    {
        proband.Nachname = "Schmidt";
        context.SaveChanges();
        Console.WriteLine("Nachname erfolgreich geändert.");
    }
    else
    {
        Console.WriteLine("Proband nicht gefunden.");
    }
}


using (var context = new Context())// geänderte Probanden anzeigen 
{
    var probanden = context.Probanden.Include(p => p.Mutter).ToList();

    foreach (var proband in probanden)
    {
        Console.WriteLine($"Vorname: {proband.Vorname}");
        Console.WriteLine($"Nachname: {proband.Nachname}");
        Console.WriteLine($"Jahrgang: {proband.Jahrgang}");
        Console.WriteLine($"Geschlecht: {proband.Geschlecht}");
        Console.WriteLine($"Mutter: {proband.Mutter.Vorname} {proband.Mutter.Nachname}");
        Console.WriteLine("----------------------------------");
    }

    Console.ReadKey();
    Console.Clear();
}