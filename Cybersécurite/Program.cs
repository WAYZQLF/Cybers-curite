using System;
using System.Windows.Forms;
using Bibliotheque;

namespace CybersecuriteApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // ── Test TP n°1 : affichage console ─────────────────────────
            ProfilSecurite P1 = new ProfilSecurite(
                compteVerrouillage:   false,
                dateverrouillage:     DateTime.Now,
                derniereConnexion:    null,
                id:                   1,
                mfaActive:            true,
                nbTentativesEchouees: 0,
                niveauAcces:          5
            );
            Console.WriteLine(P1.ToString());
            // → [ProfilSecurite] Id=1, Niveau=5, MFA=True, Verrouillé=False

            Utilisateur u1 = new Utilisateur(DateTime.Now, "toto@libre.fr", 1, "hash123", "Alice", 1);
            Console.WriteLine(u1.ToString());
            // → [Utilisateur] Id=1, Nom=Alice, Email=toto@libre.fr, mdp=hash123, profil=1, Date de creation=...

            // ── Lancement du formulaire ──────────────────────────────────
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
