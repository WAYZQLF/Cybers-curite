using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Bibliotheque;

namespace CybersecuriteApp
{
    public partial class Form1 : Form
    {
        // ══════════════════════════════════════════════════════════════════
        // TP n°1 & TP n°2  — Listes directement dans le formulaire
        // ══════════════════════════════════════════════════════════════════

        // Liste des profils (alimentée par le bouton « Valider Profil »)
        private List<ProfilSecurite> listeProfils = new List<ProfilSecurite>();

        // Liste des utilisateurs (alimentée par le bouton « Valider Utilisateur »)
        private List<Utilisateur> listeUtilisateurs = new List<Utilisateur>();

        // Compteurs simples pour simuler les IDs (auto-incrément)
        private int nextIdProfil = 1;
        private int nextIdUser   = 1;

        // ══════════════════════════════════════════════════════════════════
        // TP n°3 — Gestionnaire (remplace les deux listes ci-dessus)
        // ══════════════════════════════════════════════════════════════════
        private GestionnaireUtilisateur gestionnaire = new GestionnaireUtilisateur();

        // ──────────────────────────────────────────────────────────────────
        public Form1()
        {
            InitializeComponent();
        }

        // ══════════════════════════════════════════════════════════════════
        //  BOUTON « Valider Profil »  (section gauche du formulaire)
        // ══════════════════════════════════════════════════════════════════
        private void btnValiderProfil_Click(object sender, EventArgs e)
        {
            // 1. Validation des saisies
            if (!int.TryParse(txtNiveau.Text, out int niveau))
            {
                MessageBox.Show("Le niveau doit être un entier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool mfa = chkMFA.Checked;

            // ── TP n°3 : on délègue la création au gestionnaire ──────────
            ProfilSecurite nouveauProfil = gestionnaire.CreerProfilSecurite(niveau, mfa);

            // (TP n°1/2 version directe — conservée pour référence)
            // ProfilSecurite nouveauProfil = new ProfilSecurite(
            //     false, null, null, nextIdProfil++, mfa, 0, niveau);
            // listeProfils.Add(nouveauProfil);

            // 2. Vider puis recharger le combobox IDprofil
            cbIDProfil.Items.Clear();
            foreach (ProfilSecurite p in gestionnaire.ObtenirTousLesProfils())
            {
                cbIDProfil.Items.Add(p.GetID());
            }

            // 3. Afficher confirmation dans la console (ou label si vous en avez un)
            Console.WriteLine(nouveauProfil.ToString());

            // 4. Réinitialiser les champs Profil
            txtNiveau.Clear();
            chkMFA.Checked = false;
        }

        // ══════════════════════════════════════════════════════════════════
        //  BOUTON « Valider Utilisateur »  (section droite du formulaire)
        // ══════════════════════════════════════════════════════════════════
        private void btnValiderUtilisateur_Click(object sender, EventArgs e)
        {
            // 1. Validation des saisies
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtMdp.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs utilisateur.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbIDProfil.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un IDprofil.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Récupérer l'élément sélectionné dans le combobox
            int idProfilSelectionne = (int)cbIDProfil.SelectedItem;

            // 3. Rechercher dans la liste l'élément sélectionné
            ProfilSecurite profilTrouve = gestionnaire.ObtenirProfilSecurite(idProfilSelectionne);

            if (profilTrouve == null)
            {
                MessageBox.Show("Profil introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Créer un nouveau utilisateur via le gestionnaire (TP n°3)
            Utilisateur nouvelUtilisateur = gestionnaire.CreerUtilisateur(
                nom:              txtNom.Text,
                email:            txtEmail.Text,
                motDePasse:       txtMdp.Text,
                profilSecuriteId: profilTrouve.GetID()
            );

            // (TP n°1/2 version directe — conservée pour référence)
            // Utilisateur nouvelUtilisateur = new Utilisateur(
            //     DateTime.Now, txtEmail.Text, nextIdUser++,
            //     txtMdp.Text, txtNom.Text, idProfilSelectionne);
            // listeUtilisateurs.Add(nouvelUtilisateur);

            // 5. Afficher dans la console
            Console.WriteLine(nouvelUtilisateur.ToString());

            // 6. Mettre à jour la ListBox (TP n°2)
            ChargerListBox();

            // 7. Réinitialiser les champs Utilisateur
            txtNom.Clear();
            txtEmail.Clear();
            txtMdp.Clear();
            cbIDProfil.SelectedIndex = -1;
        }

        // ══════════════════════════════════════════════════════════════════
        //  MÉTHODE UTILITAIRE — recharge la ListBox avec tous les utilisateurs
        // ══════════════════════════════════════════════════════════════════
        private void ChargerListBox()
        {
            lbUtilisateurs.Items.Clear();
            foreach (Utilisateur u in gestionnaire.ObtenirTousLesUtilisateurs())
            {
                lbUtilisateurs.Items.Add(u.ToString());
            }
        }
    }
}
