using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muster_Dependency_Injektion_mit_Interface
{
    internal class Tierpfleger
    {
        List<ITier> liste = new List<ITier>();
        public string Pfleger_name { get; set; }
        public ITier tier;
        
        public Tierpfleger()
        {
            setname();
            
        }
        public void setHund()
        {
            tier= new Hund();
            liste.Add(tier);
        }
        public void setKatze()
        {
            tier = new Katze();
            liste.Add(tier);
        }
        public void setname()
        {
            Console.Write("\n Geben Sie die Name des Pflegers ein : ");
            Pfleger_name = Console.ReadLine();
            
        }
        public void getTiere()
        {
            int k = 1;
            Console.WriteLine($"\n____Die Tiere des Pflegers {Pfleger_name} ----------- \n");
            foreach(var x in liste)
            {
                Console.WriteLine($" {k++}tes Tier {x.ToString()}\n");
            }
        }
        public void tierEntfernen()
        {
            Console.Write("\n Geben Sie die Name des Tieres ein : ");
            string tier_name = Console.ReadLine();
            for(int i = 0; i < liste.Count; i++)
            {
                if(tier_name.Equals(liste[i].Name))
                {
                    liste.RemoveAt(i);
                    Console.WriteLine("\nDas Tier ist entfernt worden ");
                    Console.ReadKey();
                    break;
                }
                else if(i==liste.Count-1)
                {
                    Console.WriteLine("\nLeider das eingegebenes Tier befindet sich nicht in der Liste !!!");
                    Console.ReadKey();
                }
            }
        }

    }
}
