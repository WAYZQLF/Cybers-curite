using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybersécurite
{
    public class utilisateur
    {
        private DateTime Date_Creation;
        private string Email;
        private int ID;
        private string Mot_De_Passe;
        private string Nom;
        private int ProfilSecuriteld;

        public utilisateur(DateTime date_Creation, string email, int id, string mot_De_Passe, string nom, int profilSecuriteld)
        {
            Date_Creation = date_Creation;
            Email = email;
            ID = id;
            Mot_De_Passe = mot_De_Passe;
            Nom = nom;
            ProfilSecuriteld = profilSecuriteld;
        }

        public utilisateur() { }
        public int getid()
        {
            return ID;
        }
        public override string ToString()
        {
            return ($"[Utilisateur] ID={ID},Nom={Nom}, Email={Email},mdp={Mot_De_Passe},profil={ProfilSecuriteld},date de creation={Date_Creation}");
        }

    }
}
