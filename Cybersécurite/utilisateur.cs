using System;

namespace Bibliotheque
{
    public class Utilisateur
    {
        // ── Propriétés privées ──────────────────────────────────────────
        private DateTime DateCreation;
        private string Email;
        private int ID;
        private string MotDePasseHash;
        private string Nom;
        private int ProfilSecuriteId;   // relation 1,1 UNIDIRECTIONNELLE

        // ── Constructeur ────────────────────────────────────────────────
        public Utilisateur(DateTime dateCreation, string email, int id,
            string motDePasseHash, string nom, int profilSecuriteId)
        {
            DateCreation     = dateCreation;
            Email            = email;
            ID               = id;
            MotDePasseHash   = motDePasseHash;
            Nom              = nom;
            ProfilSecuriteId = profilSecuriteId;
        }

        // ── Accesseurs publics ──────────────────────────────────────────
        public int    GetID()               => ID;
        public string GetNom()              => Nom;
        public string GetEmail()            => Email;
        public int    GetProfilSecuriteId() => ProfilSecuriteId;

        // ── ToString ────────────────────────────────────────────────────
        public override string ToString()
        {
            return $"[Utilisateur] Id={ID}, Nom={Nom}, Email={Email}, mdp={MotDePasseHash}, profil={ProfilSecuriteId}, Date de creation={DateCreation}";
        }
    }
}
