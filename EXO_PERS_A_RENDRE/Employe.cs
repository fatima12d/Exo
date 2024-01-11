using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_PERS_A_RENDRE
{
    internal class Employe :Personne
    {
        private int id;
        private string departement;
        //CONSTRUCTEUR SANS PARAMETRE
        public Employe() { }
        public Employe(int id,string departement)
        {
            
            this.id = id;
            this.departement = departement;
        }
        public int getId() { return id; }
        public string getDepartement() {  return departement; }
        public int setId(int id) { 
            this.id = id; 
            return id;
        }
        public string setDepartement(string departement) { 
            this.departement= departement; 
            return departement;
        }
        public  Employe ajoutEmploye()
        {
            Employe employe = new Employe();
            Console.WriteLine("donner le numero d'identifiant : ");
            employe.setId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Donner le prenom :");
            employe.setPrenom(Console.ReadLine());
            Console.WriteLine("donner le nom :");
            employe.setNom(Console.ReadLine());
            Console.WriteLine("donner l'age :");
            employe.setAge(int.Parse(Console.ReadLine()));
            Console.WriteLine("donner le departement :");
            employe.setDepartement(Console.ReadLine());

            Console.WriteLine("Employe: " + "Id :" +employe.getId() + " Prenom :" +employe.getPrenom() + " Nom :" +employe.getNom() + " Age :" +employe.getAge() + "ans Departement :" +employe.getDepartement());



            return employe;
        }
      
        public Employe[] RemplirTab(Employe[] tab, int taille)
        {
            tab= new Employe[taille];
           
            int i = 0;
            while (i < tab.Length)
            {
                tab[i] = new Employe();
                //  tab[i].ajoutEmploye();
                Console.WriteLine("donner le numero d'identifiant : ");
                tab[i].setId(int.Parse(Console.ReadLine()));
                Console.WriteLine("Donner le prenom :");
                tab[i].setPrenom(Console.ReadLine());
                Console.WriteLine("donner le nom :");
                tab[i].setNom(Console.ReadLine());
                Console.WriteLine("donner l'age :");
                tab[i].setAge(int.Parse(Console.ReadLine()));
                Console.WriteLine("donner le departement :");
                tab[i].setDepartement(Console.ReadLine());

                i++;
            }
            return tab;
        }

        public  void AffichageTab(Employe[] tab)
        {
           
           
            for (int i=0; i < tab.Length; i++)
            {
               
                Console.WriteLine("Employe: " + "Id :" + tab[i].getId() + " Prenom :" + tab[i].getPrenom() + " Nom :" + tab[i].getNom() + " Age :" + tab[i].getAge() + "ans Departement :" + tab[i].getDepartement());

            }

        }



    }
}
