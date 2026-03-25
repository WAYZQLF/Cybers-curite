using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybersécurite
{
    public class ProfilSecurite
    {
        private bool CompteVerrouillage;
        private DateTime? Dateverrouillage;
        private int ID;
        private bool MfaActive;
        private int nbTentatives;
        private int NiveauAcces;
        public ProfilSecurite(bool compteVerrouillage, DateTime? dateverrouillage, int id, bool mfaActive, int nbTentatives, int niveauAcces)
        {
            CompteVerrouillage = compteVerrouillage;
            Dateverrouillage = dateverrouillage;
            ID = id;
            MfaActive = mfaActive;
            this.nbTentatives = nbTentatives;
            NiveauAcces = niveauAcces;
        }
        public ProfilSecurite() { }
        public override string ToString()
        {
            return ($"[ProfilSecurite]ID={ID},Niveau={NiveauAcces},MFA={MfaActive},Verrouillé={CompteVerrouillage}");
        }

    }
     
}
