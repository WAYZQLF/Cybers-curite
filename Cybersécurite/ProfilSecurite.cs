using System;

namespace Bibliotheque
{
    public class ProfilSecurite
    {
        // ── Propriétés privées ──────────────────────────────────────────
        private bool CompteVerrouillage;
        private DateTime? Dateverrouillage;
        private DateTime? DerniereConnexion;
        private int ID;
        private bool MfaActive;
        private int NbTentativesEchouees;
        private int NiveauAcces;

        // ── Constructeur ────────────────────────────────────────────────
        public ProfilSecurite(bool compteVerrouillage, DateTime? dateverrouillage,
            DateTime? derniereConnexion, int id, bool mfaActive,
            int nbTentativesEchouees, int niveauAcces)
        {
            CompteVerrouillage   = compteVerrouillage;
            Dateverrouillage     = dateverrouillage;
            DerniereConnexion    = derniereConnexion;
            ID                   = id;
            MfaActive            = mfaActive;
            NbTentativesEchouees = nbTentativesEchouees;
            NiveauAcces          = niveauAcces;
        }

        // ── Accesseurs publics (utiles pour le formulaire) ───────────────
        public int GetID()            => ID;
        public int GetNiveauAcces()   => NiveauAcces;
        public bool GetMfaActive()    => MfaActive;

        // ── ToString ────────────────────────────────────────────────────
        public override string ToString()
        {
            return $"[ProfilSecurite] Id={ID}, Niveau={NiveauAcces}, MFA={MfaActive}, Verrouillé={CompteVerrouillage}";
        }
    }
}
