using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muster_Dependency_Injektion_mit_Interface
{
    internal class Katze :ITier
    {
       
       public string Name { get; set; }
        public Katze()
        {
            
            setName();
        }
        public override string ToString()
        {
            return $"Katze [ name " + Name + " ]";
        }
        public void setName()
        {
            Console.Write("\nGeben Sie der Name der Katze ein : ");
            Name =Console.ReadLine();

        }

       /* public ITier getTier()
        {
            
            return katze;
        }
       */
    }
}
