using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_PERS_A_RENDRE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe employe = new Employe();
            employe.ajoutEmploye();

            Console.WriteLine("saisir la taille du tableau :");
            int tailletab = int.Parse(Console.ReadLine());
            Employe[] tableau = null;
            tableau = employe.RemplirTab(tableau, tailletab);
            employe.AffichageTab(tableau);

            Console.ReadKey();

        }
    }
}
