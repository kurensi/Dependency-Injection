using Muster_Dependency_Injektion_mit_Interface;

var pfleger = new Tierpfleger();
 while(true)
{ 
    try
    {
        Console.Write("\n Mit j/J Eiter und mit n/N Ende  :");
        string str= Console.ReadLine();
        if(str =="n" || str =="N")
        {
            Console.WriteLine("\nCiao Amigo !!");
            break;
        }
        else if(str =="j" || str =="J")
        {
            Console.Clear();
            int wahl = 0;
            Menü(ref wahl);
            switch(wahl)
            {
                case 1:
                    pfleger.setHund();
                    break;
                case 2:
                    pfleger.setKatze();
                    break;
                default:
                    Console.WriteLine("\nFalsche Eingabe !!");
                    break;

            }

        }
        else
        {
            Console.WriteLine("\nFalsche Eingabe !!!");
        }
    }
    catch(Exception ex)
    { Console.WriteLine(ex.ToString()); }


}
Console.Clear();

//Console.WriteLine($"\n----Tierpfleger : {pfleger.Pfleger_name}-----");

pfleger.getTiere();

Console.Write("\nMöchten Sie ein Tier entfernen j/n?? : ");
string jn=Console.ReadLine();
if (jn == "j")
{
    pfleger.tierEntfernen();
}
else if(jn == "n")
{
    Console.WriteLine("\n Ok !!!");
}
else
{
    Console.WriteLine("\nFalsche Eingabe !!!");
}
Console.Clear();
pfleger.getTiere();


Console.ReadKey();

static void Menü(ref int x)
{
    try
    { 
    Console.WriteLine("\n_______ Wählen Sie ein Tier -----");
    Console.WriteLine("\n Hund       (1)");
    Console.Write("\n Katze      (2)   > ");
    x = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception ex)
    { Console.WriteLine(ex.ToString()); }
}