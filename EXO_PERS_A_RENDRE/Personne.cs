using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_PERS_A_RENDRE
{
    internal class Personne
    {
        private string prenom;
        private string nom;
        private int age;
        //CONSTRUCTEUR SANS PARAMETRE
        public Personne() { }
        //CONSTRUCTEUR AVEC PARAMETRE
        public Personne(string prenom, string nom, int age) {
            this.prenom = prenom;
            this.nom = nom;
            this.age = age;
        }
        //SETTER ET GETTER
        public string setPrenom(string prenom) {
            this.prenom = prenom;
            return this.prenom;
        }
        public string setNom(string nom)
        {
            this.nom = nom;
            return this.nom;
        }
        public int setAge(int age)
        {
            this.age = age;
            return this.age;
            
        }
        public string getPrenom() { return prenom; }
        public string getNom() { return nom; }
        public int getAge() { return age; }




    }
}  
    
     
 

