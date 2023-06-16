// See https://aka.ms/new-console-template for more information
using spickerII;


Saeugetier saeugetier1 = new Saeugetier() { Familie = "Hund", Name = "Wolf" , Gefaerdung = true };
Fisch fisch1 = new Fisch() { Name = "Regenbogen Forelle", Familie = "Lachsfische" };
Benutzer benutzer1 = new Benutzer() { Nachname = "Max", Vorname = "Muster" , Benutzername = "Mustermax", Email = "max.muster@gmail.com", Passwort = "12345"};

Console.BackgroundColor = ConsoleColor.DarkBlue;
bool stopp = true;
do
{
    Console.WriteLine("Neues Objekt erstellen (y/n)");
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    if (keyInfo.KeyChar == 'n')
    {
        stopp = false;
    } else if ((keyInfo.KeyChar == 'j') || (keyInfo.KeyChar == 'y'))
    {
      
    }
    Console.Clear();

} while (stopp);



List<IAnzeigbar> listIAnzeigbar = new List<IAnzeigbar>();

listIAnzeigbar.Add(saeugetier1);
listIAnzeigbar.Add(fisch1);
listIAnzeigbar.Add(benutzer1 );

foreach (IAnzeigbar anzeigbar in listIAnzeigbar)
{
    anzeigbar.Anzeigen();
}