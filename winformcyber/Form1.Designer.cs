namespace CybersecuriteApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // ── Déclaration des contrôles ───────────────────────────────
            this.grpProfil           = new System.Windows.Forms.GroupBox();
            this.lblID_P             = new System.Windows.Forms.Label();
            this.txtIDProfil         = new System.Windows.Forms.TextBox();   // affiché mais en lecture seule (auto)
            this.lblNiveau           = new System.Windows.Forms.Label();
            this.txtNiveau           = new System.Windows.Forms.TextBox();
            this.chkMFA              = new System.Windows.Forms.CheckBox();
            this.btnValiderProfil    = new System.Windows.Forms.Button();

            this.grpUtilisateur      = new System.Windows.Forms.GroupBox();
            this.lblID_U             = new System.Windows.Forms.Label();
            this.txtIDUser           = new System.Windows.Forms.TextBox();   // affiché mais en lecture seule
            this.lblNom              = new System.Windows.Forms.Label();
            this.txtNom              = new System.Windows.Forms.TextBox();
            this.lblEmail            = new System.Windows.Forms.Label();
            this.txtEmail            = new System.Windows.Forms.TextBox();
            this.lblMdp              = new System.Windows.Forms.Label();
            this.txtMdp              = new System.Windows.Forms.TextBox();
            this.lblIDProfil         = new System.Windows.Forms.Label();
            this.cbIDProfil          = new System.Windows.Forms.ComboBox();
            this.btnValiderUser      = new System.Windows.Forms.Button();

            // ListBox TP n°2
            this.lbUtilisateurs      = new System.Windows.Forms.ListBox();

            // ── Form ────────────────────────────────────────────────────
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(760, 480);
            this.Text       = "Cas Cybersécurité";
            this.Font       = new System.Drawing.Font("Segoe UI", 9F);

            // ══════════════════════════════════
            //  GroupBox Profil (gauche)
            // ══════════════════════════════════
            this.grpProfil.Text     = "Profil";
            this.grpProfil.Location = new System.Drawing.Point(20, 20);
            this.grpProfil.Size     = new System.Drawing.Size(260, 200);

            //  ID (auto, readonly)
            this.lblID_P.Text     = "ID";
            this.lblID_P.Location = new System.Drawing.Point(15, 30);
            this.lblID_P.Size     = new System.Drawing.Size(60, 20);

            this.txtIDProfil.Location = new System.Drawing.Point(100, 28);
            this.txtIDProfil.Size     = new System.Drawing.Size(140, 22);
            this.txtIDProfil.ReadOnly = true;
            this.txtIDProfil.Text     = "auto";

            //  Niveau
            this.lblNiveau.Text     = "Niveau";
            this.lblNiveau.Location = new System.Drawing.Point(15, 62);
            this.lblNiveau.Size     = new System.Drawing.Size(60, 20);

            this.txtNiveau.Location = new System.Drawing.Point(100, 60);
            this.txtNiveau.Size     = new System.Drawing.Size(140, 22);

            //  MFA
            this.chkMFA.Text     = "MFA";
            this.chkMFA.Location = new System.Drawing.Point(100, 100);
            this.chkMFA.Size     = new System.Drawing.Size(100, 22);

            //  Bouton Valider
            this.btnValiderProfil.Text     = "Valider";
            this.btnValiderProfil.Location = new System.Drawing.Point(80, 150);
            this.btnValiderProfil.Size     = new System.Drawing.Size(90, 28);
            this.btnValiderProfil.Click   += new System.EventHandler(this.btnValiderProfil_Click);

            this.grpProfil.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblID_P, txtIDProfil, lblNiveau, txtNiveau, chkMFA, btnValiderProfil
            });

            // ══════════════════════════════════
            //  GroupBox Utilisateur (droite)
            // ══════════════════════════════════
            this.grpUtilisateur.Text     = "Utilisateur";
            this.grpUtilisateur.Location = new System.Drawing.Point(320, 20);
            this.grpUtilisateur.Size     = new System.Drawing.Size(400, 280);

            //  ID
            this.lblID_U.Text     = "ID";
            this.lblID_U.Location = new System.Drawing.Point(15, 30);
            this.lblID_U.Size     = new System.Drawing.Size(70, 20);

            this.txtIDUser.Location = new System.Drawing.Point(150, 28);
            this.txtIDUser.Size     = new System.Drawing.Size(180, 22);
            this.txtIDUser.ReadOnly = true;
            this.txtIDUser.Text     = "auto";

            //  Nom
            this.lblNom.Text     = "Nom";
            this.lblNom.Location = new System.Drawing.Point(15, 62);
            this.lblNom.Size     = new System.Drawing.Size(70, 20);

            this.txtNom.Location = new System.Drawing.Point(150, 60);
            this.txtNom.Size     = new System.Drawing.Size(180, 22);

            //  Email
            this.lblEmail.Text     = "email";
            this.lblEmail.Location = new System.Drawing.Point(15, 96);
            this.lblEmail.Size     = new System.Drawing.Size(70, 20);

            this.txtEmail.Location = new System.Drawing.Point(150, 94);
            this.txtEmail.Size     = new System.Drawing.Size(180, 22);

            //  Mdp
            this.lblMdp.Text         = "Mdp";
            this.lblMdp.Location     = new System.Drawing.Point(15, 130);
            this.lblMdp.Size         = new System.Drawing.Size(70, 20);

            this.txtMdp.Location      = new System.Drawing.Point(150, 128);
            this.txtMdp.Size          = new System.Drawing.Size(180, 22);
            this.txtMdp.PasswordChar  = '*';

            //  IDprofil (combobox)
            this.lblIDProfil.Text     = "IDprofil";
            this.lblIDProfil.Location = new System.Drawing.Point(15, 166);
            this.lblIDProfil.Size     = new System.Drawing.Size(70, 20);

            this.cbIDProfil.Location      = new System.Drawing.Point(150, 164);
            this.cbIDProfil.Size          = new System.Drawing.Size(180, 22);
            this.cbIDProfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            //  Bouton Valider
            this.btnValiderUser.Text     = "Valider";
            this.btnValiderUser.Location = new System.Drawing.Point(150, 210);
            this.btnValiderUser.Size     = new System.Drawing.Size(90, 28);
            this.btnValiderUser.Click   += new System.EventHandler(this.btnValiderUtilisateur_Click);

            this.grpUtilisateur.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblID_U, txtIDUser, lblNom, txtNom,
                lblEmail, txtEmail, lblMdp, txtMdp,
                lblIDProfil, cbIDProfil, btnValiderUser
            });

            // ══════════════════════════════════
            //  ListBox TP n°2 — lbUtilisateurs
            // ══════════════════════════════════
            this.lbUtilisateurs.Location       = new System.Drawing.Point(320, 310);
            this.lbUtilisateurs.Size           = new System.Drawing.Size(400, 140);
            this.lbUtilisateurs.HorizontalScrollbar = true;

            // ── Ajout au formulaire ─────────────────────────────────────
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                grpProfil, grpUtilisateur, lbUtilisateurs
            });

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // ── Champs designer ─────────────────────────────────────────────
        private System.Windows.Forms.GroupBox grpProfil;
        private System.Windows.Forms.Label    lblID_P;
        private System.Windows.Forms.TextBox  txtIDProfil;
        private System.Windows.Forms.Label    lblNiveau;
        private System.Windows.Forms.TextBox  txtNiveau;
        private System.Windows.Forms.CheckBox chkMFA;
        private System.Windows.Forms.Button   btnValiderProfil;

        private System.Windows.Forms.GroupBox grpUtilisateur;
        private System.Windows.Forms.Label    lblID_U;
        private System.Windows.Forms.TextBox  txtIDUser;
        private System.Windows.Forms.Label    lblNom;
        private System.Windows.Forms.TextBox  txtNom;
        private System.Windows.Forms.Label    lblEmail;
        private System.Windows.Forms.TextBox  txtEmail;
        private System.Windows.Forms.Label    lblMdp;
        private System.Windows.Forms.TextBox  txtMdp;
        private System.Windows.Forms.Label    lblIDProfil;
        private System.Windows.Forms.ComboBox cbIDProfil;
        private System.Windows.Forms.Button   btnValiderUser;

        private System.Windows.Forms.ListBox  lbUtilisateurs;
    }
}
