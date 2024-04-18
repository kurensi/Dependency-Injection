using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muster_Dependency_Injektion_mit_Interface
{
    internal class Hund : ITier
    {       
       public string Name { get; set; }
       public Hund()
        {
            setName();
        }
       public void setName()
        {
            Console.Write("\nGeben Sie der Name des Hundes ein :");
            Name =Console.ReadLine();
        }
        public override string ToString()
        {
            return $" Hund [ Name :"+Name+" ]";
        }

    }
}
