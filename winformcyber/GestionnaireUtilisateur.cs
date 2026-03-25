using System;
using System.Collections.Generic;

namespace Bibliotheque
{
    /// <summary>
    /// TP n°3 — Classe gestionnaire qui centralise la création
    /// des ProfilSecurite et des Utilisateur.
    /// Le formulaire n'a plus qu'à appeler cette classe.
    /// </summary>
    public class GestionnaireUtilisateur
    {
        // ── Compteurs auto-incrément (simulent une clé primaire) ─────────
        private int prochainIdProfil      = 1;
        private int prochainIdUtilisateur = 1;

        // ── Listes internes ──────────────────────────────────────────────
        private List<ProfilSecurite> profils      = new List<ProfilSecurite>();
        private List<Utilisateur>    utilisateurs = new List<Utilisateur>();

        // ── Méthodes de création ─────────────────────────────────────────

        /// <summary>Crée un ProfilSecurite, l'ajoute à la liste et retourne l'objet.</summary>
        public ProfilSecurite CreerProfilSecurite(int niveauAcces, bool mfaActive)
        {
            ProfilSecurite p = new ProfilSecurite(
                compteVerrouillage:   false,
                dateverrouillage:     null,
                derniereConnexion:    null,
                id:                   prochainIdProfil++,
                mfaActive:            mfaActive,
                nbTentativesEchouees: 0,
                niveauAcces:          niveauAcces
            );
            profils.Add(p);
            return p;
        }

        /// <summary>Crée un Utilisateur, l'ajoute à la liste et retourne l'objet.</summary>
        public Utilisateur CreerUtilisateur(string nom, string email,
            string motDePasse, int profilSecuriteId)
        {
            Utilisateur u = new Utilisateur(
                dateCreation:     DateTime.Now,
                email:            email,
                id:               prochainIdUtilisateur++,
                motDePasseHash:   motDePasse,   // dans un vrai projet : hashage BCrypt
                nom:              nom,
                profilSecuriteId: profilSecuriteId
            );
            utilisateurs.Add(u);
            return u;
        }

        // ── Méthodes de consultation ─────────────────────────────────────

        public List<ProfilSecurite> ObtenirTousLesProfils()      => profils;
        public List<Utilisateur>    ObtenirTousLesUtilisateurs() => utilisateurs;

        public ProfilSecurite ObtenirProfilSecurite(int id)
            => profils.Find(p => p.GetID() == id);

        public Utilisateur ObtenirUtilisateur(int id)
            => utilisateurs.Find(u => u.GetID() == id);
    }
}
