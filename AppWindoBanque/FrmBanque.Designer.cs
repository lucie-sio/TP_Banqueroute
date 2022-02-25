
namespace AppWindoBanque
{
    partial class FrmBanque
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanque));
            this.tab_OngletsApplicationa = new System.Windows.Forms.TabControl();
            this.tabAccueil = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_ListeComptes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ac_Titre = new System.Windows.Forms.Label();
            this.tabConsultation = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.tbx_co_SoldeActuel = new System.Windows.Forms.TextBox();
            this.tbx_co_Titulaire = new System.Windows.Forms.TextBox();
            this.tbx_co_Numero = new System.Windows.Forms.TextBox();
            this.cbx_co_ChoixCompte = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCreation = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.clb_cr_Civilite = new System.Windows.Forms.CheckedListBox();
            this.btn_cr_Annuler = new System.Windows.Forms.Button();
            this.btn_cr_Creer = new System.Windows.Forms.Button();
            this.lbl_cr_Message = new System.Windows.Forms.Label();
            this.tbx_cr_SoldeInitial = new System.Windows.Forms.TextBox();
            this.tbx_cr_Titulaire = new System.Windows.Forms.TextBox();
            this.tbx_cr_Numero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabVersement = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.cbx_ve_ChoixCompte = new System.Windows.Forms.ComboBox();
            this.btn_ve_Annuler = new System.Windows.Forms.Button();
            this.btn_ve_Enregistrer = new System.Windows.Forms.Button();
            this.lbl_ve_Message = new System.Windows.Forms.Label();
            this.tbx_ve_MontantACrediter = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabRetrait = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.cbx_re_ChoixCompte = new System.Windows.Forms.ComboBox();
            this.btn_re_Annuler = new System.Windows.Forms.Button();
            this.btn_re_Enregistrer = new System.Windows.Forms.Button();
            this.lbl_re_Message = new System.Windows.Forms.Label();
            this.tbx_re_MontantADebiter = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabVirement = new System.Windows.Forms.TabPage();
            this.cbx_vi_Crediteur = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbx_vi_Debiteur = new System.Windows.Forms.ComboBox();
            this.btn_vi_Annuler = new System.Windows.Forms.Button();
            this.btn_vi_Enregistrer = new System.Windows.Forms.Button();
            this.lbl_vi_Message = new System.Windows.Forms.Label();
            this.tbx_vi_MontantVirement = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tab_OngletsApplicationa.SuspendLayout();
            this.tabAccueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeComptes)).BeginInit();
            this.tabConsultation.SuspendLayout();
            this.tabCreation.SuspendLayout();
            this.tabVersement.SuspendLayout();
            this.tabRetrait.SuspendLayout();
            this.tabVirement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_OngletsApplicationa
            // 
            this.tab_OngletsApplicationa.Controls.Add(this.tabAccueil);
            this.tab_OngletsApplicationa.Controls.Add(this.tabConsultation);
            this.tab_OngletsApplicationa.Controls.Add(this.tabCreation);
            this.tab_OngletsApplicationa.Controls.Add(this.tabVersement);
            this.tab_OngletsApplicationa.Controls.Add(this.tabRetrait);
            this.tab_OngletsApplicationa.Controls.Add(this.tabVirement);
            this.tab_OngletsApplicationa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_OngletsApplicationa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_OngletsApplicationa.Location = new System.Drawing.Point(0, 0);
            this.tab_OngletsApplicationa.Name = "tab_OngletsApplicationa";
            this.tab_OngletsApplicationa.SelectedIndex = 0;
            this.tab_OngletsApplicationa.Size = new System.Drawing.Size(800, 450);
            this.tab_OngletsApplicationa.TabIndex = 0;
            // 
            // tabAccueil
            // 
            this.tabAccueil.BackColor = System.Drawing.Color.Wheat;
            this.tabAccueil.Controls.Add(this.pictureBox1);
            this.tabAccueil.Controls.Add(this.dgv_ListeComptes);
            this.tabAccueil.Controls.Add(this.label2);
            this.tabAccueil.Controls.Add(this.lbl_ac_Titre);
            this.tabAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAccueil.Location = new System.Drawing.Point(4, 29);
            this.tabAccueil.Name = "tabAccueil";
            this.tabAccueil.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccueil.Size = new System.Drawing.Size(792, 417);
            this.tabAccueil.TabIndex = 0;
            this.tabAccueil.Text = "Accueil";
            this.tabAccueil.Enter += new System.EventHandler(this.tabAccueil_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(486, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 254);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_ListeComptes
            // 
            this.dgv_ListeComptes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ListeComptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeComptes.Location = new System.Drawing.Point(45, 163);
            this.dgv_ListeComptes.Name = "dgv_ListeComptes";
            this.dgv_ListeComptes.Size = new System.Drawing.Size(392, 216);
            this.dgv_ListeComptes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liste des comptes de l\'agence";
            // 
            // lbl_ac_Titre
            // 
            this.lbl_ac_Titre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ac_Titre.AutoSize = true;
            this.lbl_ac_Titre.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ac_Titre.Location = new System.Drawing.Point(188, 32);
            this.lbl_ac_Titre.Name = "lbl_ac_Titre";
            this.lbl_ac_Titre.Size = new System.Drawing.Size(415, 57);
            this.lbl_ac_Titre.TabIndex = 0;
            this.lbl_ac_Titre.Text = "AGENCE de LUCIE";
            // 
            // tabConsultation
            // 
            this.tabConsultation.BackColor = System.Drawing.Color.Wheat;
            this.tabConsultation.Controls.Add(this.label17);
            this.tabConsultation.Controls.Add(this.tbx_co_SoldeActuel);
            this.tabConsultation.Controls.Add(this.tbx_co_Titulaire);
            this.tabConsultation.Controls.Add(this.tbx_co_Numero);
            this.tabConsultation.Controls.Add(this.cbx_co_ChoixCompte);
            this.tabConsultation.Controls.Add(this.label6);
            this.tabConsultation.Controls.Add(this.label5);
            this.tabConsultation.Controls.Add(this.label4);
            this.tabConsultation.Controls.Add(this.label3);
            this.tabConsultation.Controls.Add(this.label1);
            this.tabConsultation.Location = new System.Drawing.Point(4, 29);
            this.tabConsultation.Name = "tabConsultation";
            this.tabConsultation.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultation.Size = new System.Drawing.Size(792, 417);
            this.tabConsultation.TabIndex = 1;
            this.tabConsultation.Text = "Consultation";
            this.tabConsultation.Enter += new System.EventHandler(this.tabConsultation_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(546, 283);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 20);
            this.label17.TabIndex = 26;
            this.label17.Text = "€";
            // 
            // tbx_co_SoldeActuel
            // 
            this.tbx_co_SoldeActuel.Location = new System.Drawing.Point(280, 280);
            this.tbx_co_SoldeActuel.Name = "tbx_co_SoldeActuel";
            this.tbx_co_SoldeActuel.Size = new System.Drawing.Size(260, 26);
            this.tbx_co_SoldeActuel.TabIndex = 9;
            // 
            // tbx_co_Titulaire
            // 
            this.tbx_co_Titulaire.Location = new System.Drawing.Point(280, 239);
            this.tbx_co_Titulaire.Name = "tbx_co_Titulaire";
            this.tbx_co_Titulaire.Size = new System.Drawing.Size(260, 26);
            this.tbx_co_Titulaire.TabIndex = 8;
            // 
            // tbx_co_Numero
            // 
            this.tbx_co_Numero.Location = new System.Drawing.Point(280, 196);
            this.tbx_co_Numero.Name = "tbx_co_Numero";
            this.tbx_co_Numero.Size = new System.Drawing.Size(260, 26);
            this.tbx_co_Numero.TabIndex = 7;
            // 
            // cbx_co_ChoixCompte
            // 
            this.cbx_co_ChoixCompte.FormattingEnabled = true;
            this.cbx_co_ChoixCompte.Location = new System.Drawing.Point(280, 129);
            this.cbx_co_ChoixCompte.Name = "cbx_co_ChoixCompte";
            this.cbx_co_ChoixCompte.Size = new System.Drawing.Size(260, 28);
            this.cbx_co_ChoixCompte.TabIndex = 6;
            this.cbx_co_ChoixCompte.SelectedIndexChanged += new System.EventHandler(this.cbx_co_ChoixCompte_SelectedIndexChanged);
            this.cbx_co_ChoixCompte.SelectedValueChanged += new System.EventHandler(this.cbx_co_ChoixCompte_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Solde actuel du compte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Titulaire du compte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numéro de compte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choisir un compte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultation de compte";
            // 
            // tabCreation
            // 
            this.tabCreation.BackColor = System.Drawing.Color.Wheat;
            this.tabCreation.Controls.Add(this.label16);
            this.tabCreation.Controls.Add(this.label12);
            this.tabCreation.Controls.Add(this.clb_cr_Civilite);
            this.tabCreation.Controls.Add(this.btn_cr_Annuler);
            this.tabCreation.Controls.Add(this.btn_cr_Creer);
            this.tabCreation.Controls.Add(this.lbl_cr_Message);
            this.tabCreation.Controls.Add(this.tbx_cr_SoldeInitial);
            this.tabCreation.Controls.Add(this.tbx_cr_Titulaire);
            this.tabCreation.Controls.Add(this.tbx_cr_Numero);
            this.tabCreation.Controls.Add(this.label8);
            this.tabCreation.Controls.Add(this.label9);
            this.tabCreation.Controls.Add(this.label10);
            this.tabCreation.Controls.Add(this.label7);
            this.tabCreation.Location = new System.Drawing.Point(4, 29);
            this.tabCreation.Name = "tabCreation";
            this.tabCreation.Size = new System.Drawing.Size(792, 417);
            this.tabCreation.TabIndex = 2;
            this.tabCreation.Text = "Création de compte";
            this.tabCreation.Enter += new System.EventHandler(this.tabCreation_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(546, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 20);
            this.label16.TabIndex = 26;
            this.label16.Text = "€";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(75, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Civilité";
            // 
            // clb_cr_Civilite
            // 
            this.clb_cr_Civilite.BackColor = System.Drawing.Color.Wheat;
            this.clb_cr_Civilite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_cr_Civilite.CheckOnClick = true;
            this.clb_cr_Civilite.FormattingEnabled = true;
            this.clb_cr_Civilite.Items.AddRange(new object[] {
            "Madame",
            "Mademoiselle",
            "Monsieur"});
            this.clb_cr_Civilite.Location = new System.Drawing.Point(280, 181);
            this.clb_cr_Civilite.Name = "clb_cr_Civilite";
            this.clb_cr_Civilite.Size = new System.Drawing.Size(133, 63);
            this.clb_cr_Civilite.TabIndex = 19;
            this.clb_cr_Civilite.SelectedIndexChanged += new System.EventHandler(this.clb_cr_Civilite_SelectedIndexChanged);
            // 
            // btn_cr_Annuler
            // 
            this.btn_cr_Annuler.BackColor = System.Drawing.Color.Maroon;
            this.btn_cr_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cr_Annuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cr_Annuler.Location = new System.Drawing.Point(440, 288);
            this.btn_cr_Annuler.Name = "btn_cr_Annuler";
            this.btn_cr_Annuler.Size = new System.Drawing.Size(100, 35);
            this.btn_cr_Annuler.TabIndex = 18;
            this.btn_cr_Annuler.Text = "Effacer";
            this.btn_cr_Annuler.UseVisualStyleBackColor = false;
            this.btn_cr_Annuler.Click += new System.EventHandler(this.btn_cr_Annuler_Click);
            // 
            // btn_cr_Creer
            // 
            this.btn_cr_Creer.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_cr_Creer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cr_Creer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cr_Creer.Location = new System.Drawing.Point(280, 288);
            this.btn_cr_Creer.Name = "btn_cr_Creer";
            this.btn_cr_Creer.Size = new System.Drawing.Size(100, 35);
            this.btn_cr_Creer.TabIndex = 17;
            this.btn_cr_Creer.Text = "Créer";
            this.btn_cr_Creer.UseVisualStyleBackColor = false;
            this.btn_cr_Creer.Click += new System.EventHandler(this.btn_cr_Creer_Click);
            // 
            // lbl_cr_Message
            // 
            this.lbl_cr_Message.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_cr_Message.AutoSize = true;
            this.lbl_cr_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cr_Message.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_cr_Message.Location = new System.Drawing.Point(76, 354);
            this.lbl_cr_Message.Name = "lbl_cr_Message";
            this.lbl_cr_Message.Size = new System.Drawing.Size(189, 18);
            this.lbl_cr_Message.TabIndex = 16;
            this.lbl_cr_Message.Text = "Une erreur est survenue";
            this.lbl_cr_Message.Visible = false;
            // 
            // tbx_cr_SoldeInitial
            // 
            this.tbx_cr_SoldeInitial.Location = new System.Drawing.Point(280, 250);
            this.tbx_cr_SoldeInitial.Name = "tbx_cr_SoldeInitial";
            this.tbx_cr_SoldeInitial.Size = new System.Drawing.Size(260, 26);
            this.tbx_cr_SoldeInitial.TabIndex = 15;
            // 
            // tbx_cr_Titulaire
            // 
            this.tbx_cr_Titulaire.Location = new System.Drawing.Point(280, 149);
            this.tbx_cr_Titulaire.Name = "tbx_cr_Titulaire";
            this.tbx_cr_Titulaire.Size = new System.Drawing.Size(260, 26);
            this.tbx_cr_Titulaire.TabIndex = 14;
            // 
            // tbx_cr_Numero
            // 
            this.tbx_cr_Numero.Location = new System.Drawing.Point(280, 117);
            this.tbx_cr_Numero.Name = "tbx_cr_Numero";
            this.tbx_cr_Numero.Size = new System.Drawing.Size(260, 26);
            this.tbx_cr_Numero.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Solde actuel du compte";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Titulaire (Prénom NOM)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(75, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Numéro de compte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 59);
            this.label7.TabIndex = 2;
            this.label7.Text = "Création de compte";
            // 
            // tabVersement
            // 
            this.tabVersement.BackColor = System.Drawing.Color.Wheat;
            this.tabVersement.Controls.Add(this.label13);
            this.tabVersement.Controls.Add(this.cbx_ve_ChoixCompte);
            this.tabVersement.Controls.Add(this.btn_ve_Annuler);
            this.tabVersement.Controls.Add(this.btn_ve_Enregistrer);
            this.tabVersement.Controls.Add(this.lbl_ve_Message);
            this.tabVersement.Controls.Add(this.tbx_ve_MontantACrediter);
            this.tabVersement.Controls.Add(this.label14);
            this.tabVersement.Controls.Add(this.label15);
            this.tabVersement.Controls.Add(this.label11);
            this.tabVersement.Location = new System.Drawing.Point(4, 29);
            this.tabVersement.Name = "tabVersement";
            this.tabVersement.Size = new System.Drawing.Size(792, 417);
            this.tabVersement.TabIndex = 3;
            this.tabVersement.Text = "Versement";
            this.tabVersement.Enter += new System.EventHandler(this.tabVersement_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(546, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "€";
            // 
            // cbx_ve_ChoixCompte
            // 
            this.cbx_ve_ChoixCompte.FormattingEnabled = true;
            this.cbx_ve_ChoixCompte.Location = new System.Drawing.Point(280, 150);
            this.cbx_ve_ChoixCompte.Name = "cbx_ve_ChoixCompte";
            this.cbx_ve_ChoixCompte.Size = new System.Drawing.Size(260, 28);
            this.cbx_ve_ChoixCompte.TabIndex = 24;
            // 
            // btn_ve_Annuler
            // 
            this.btn_ve_Annuler.BackColor = System.Drawing.Color.Maroon;
            this.btn_ve_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ve_Annuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ve_Annuler.Location = new System.Drawing.Point(426, 254);
            this.btn_ve_Annuler.Name = "btn_ve_Annuler";
            this.btn_ve_Annuler.Size = new System.Drawing.Size(114, 35);
            this.btn_ve_Annuler.TabIndex = 23;
            this.btn_ve_Annuler.Text = "Effacer";
            this.btn_ve_Annuler.UseVisualStyleBackColor = false;
            this.btn_ve_Annuler.Click += new System.EventHandler(this.btn_ve_Annuler_Click);
            // 
            // btn_ve_Enregistrer
            // 
            this.btn_ve_Enregistrer.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_ve_Enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ve_Enregistrer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ve_Enregistrer.Location = new System.Drawing.Point(280, 254);
            this.btn_ve_Enregistrer.Name = "btn_ve_Enregistrer";
            this.btn_ve_Enregistrer.Size = new System.Drawing.Size(114, 35);
            this.btn_ve_Enregistrer.TabIndex = 22;
            this.btn_ve_Enregistrer.Text = "Enregistrer";
            this.btn_ve_Enregistrer.UseVisualStyleBackColor = false;
            this.btn_ve_Enregistrer.Click += new System.EventHandler(this.btn_ve_Enregistrer_Click);
            // 
            // lbl_ve_Message
            // 
            this.lbl_ve_Message.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ve_Message.AutoSize = true;
            this.lbl_ve_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ve_Message.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_ve_Message.Location = new System.Drawing.Point(76, 316);
            this.lbl_ve_Message.Name = "lbl_ve_Message";
            this.lbl_ve_Message.Size = new System.Drawing.Size(189, 18);
            this.lbl_ve_Message.TabIndex = 21;
            this.lbl_ve_Message.Text = "Une erreur est survenue";
            this.lbl_ve_Message.Visible = false;
            // 
            // tbx_ve_MontantACrediter
            // 
            this.tbx_ve_MontantACrediter.Location = new System.Drawing.Point(280, 207);
            this.tbx_ve_MontantACrediter.Name = "tbx_ve_MontantACrediter";
            this.tbx_ve_MontantACrediter.Size = new System.Drawing.Size(260, 26);
            this.tbx_ve_MontantACrediter.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(75, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Montant à créditer";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(75, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Compte à créditer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(469, 59);
            this.label11.TabIndex = 2;
            this.label11.Text = "Enregistrer un versement";
            // 
            // tabRetrait
            // 
            this.tabRetrait.BackColor = System.Drawing.Color.Wheat;
            this.tabRetrait.Controls.Add(this.label20);
            this.tabRetrait.Controls.Add(this.cbx_re_ChoixCompte);
            this.tabRetrait.Controls.Add(this.btn_re_Annuler);
            this.tabRetrait.Controls.Add(this.btn_re_Enregistrer);
            this.tabRetrait.Controls.Add(this.lbl_re_Message);
            this.tabRetrait.Controls.Add(this.tbx_re_MontantADebiter);
            this.tabRetrait.Controls.Add(this.label22);
            this.tabRetrait.Controls.Add(this.label23);
            this.tabRetrait.Controls.Add(this.label18);
            this.tabRetrait.Location = new System.Drawing.Point(4, 29);
            this.tabRetrait.Name = "tabRetrait";
            this.tabRetrait.Size = new System.Drawing.Size(792, 417);
            this.tabRetrait.TabIndex = 4;
            this.tabRetrait.Text = "Retrait";
            this.tabRetrait.Enter += new System.EventHandler(this.tabRetrait_Enter);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(546, 210);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 20);
            this.label20.TabIndex = 33;
            this.label20.Text = "€";
            // 
            // cbx_re_ChoixCompte
            // 
            this.cbx_re_ChoixCompte.FormattingEnabled = true;
            this.cbx_re_ChoixCompte.Location = new System.Drawing.Point(280, 150);
            this.cbx_re_ChoixCompte.Name = "cbx_re_ChoixCompte";
            this.cbx_re_ChoixCompte.Size = new System.Drawing.Size(260, 28);
            this.cbx_re_ChoixCompte.TabIndex = 32;
            // 
            // btn_re_Annuler
            // 
            this.btn_re_Annuler.BackColor = System.Drawing.Color.Maroon;
            this.btn_re_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_re_Annuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_re_Annuler.Location = new System.Drawing.Point(426, 254);
            this.btn_re_Annuler.Name = "btn_re_Annuler";
            this.btn_re_Annuler.Size = new System.Drawing.Size(114, 35);
            this.btn_re_Annuler.TabIndex = 31;
            this.btn_re_Annuler.Text = "Effacer";
            this.btn_re_Annuler.UseVisualStyleBackColor = false;
            this.btn_re_Annuler.Click += new System.EventHandler(this.btn_re_Annuler_Click);
            // 
            // btn_re_Enregistrer
            // 
            this.btn_re_Enregistrer.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_re_Enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_re_Enregistrer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_re_Enregistrer.Location = new System.Drawing.Point(280, 254);
            this.btn_re_Enregistrer.Name = "btn_re_Enregistrer";
            this.btn_re_Enregistrer.Size = new System.Drawing.Size(114, 35);
            this.btn_re_Enregistrer.TabIndex = 30;
            this.btn_re_Enregistrer.Text = "Enregistrer";
            this.btn_re_Enregistrer.UseVisualStyleBackColor = false;
            this.btn_re_Enregistrer.Click += new System.EventHandler(this.btn_re_Enregistrer_Click);
            // 
            // lbl_re_Message
            // 
            this.lbl_re_Message.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_re_Message.AutoSize = true;
            this.lbl_re_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_re_Message.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_re_Message.Location = new System.Drawing.Point(76, 316);
            this.lbl_re_Message.Name = "lbl_re_Message";
            this.lbl_re_Message.Size = new System.Drawing.Size(189, 18);
            this.lbl_re_Message.TabIndex = 29;
            this.lbl_re_Message.Text = "Une erreur est survenue";
            this.lbl_re_Message.Visible = false;
            // 
            // tbx_re_MontantADebiter
            // 
            this.tbx_re_MontantADebiter.Location = new System.Drawing.Point(280, 207);
            this.tbx_re_MontantADebiter.Name = "tbx_re_MontantADebiter";
            this.tbx_re_MontantADebiter.Size = new System.Drawing.Size(260, 26);
            this.tbx_re_MontantADebiter.TabIndex = 28;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(75, 210);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(134, 20);
            this.label22.TabIndex = 27;
            this.label22.Text = "Montant à débiter";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(75, 153);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(135, 20);
            this.label23.TabIndex = 26;
            this.label23.Text = "Compte à créditer";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(378, 59);
            this.label18.TabIndex = 3;
            this.label18.Text = "Effectuer un retrait";
            // 
            // tabVirement
            // 
            this.tabVirement.BackColor = System.Drawing.Color.Wheat;
            this.tabVirement.Controls.Add(this.cbx_vi_Crediteur);
            this.tabVirement.Controls.Add(this.label27);
            this.tabVirement.Controls.Add(this.label21);
            this.tabVirement.Controls.Add(this.cbx_vi_Debiteur);
            this.tabVirement.Controls.Add(this.btn_vi_Annuler);
            this.tabVirement.Controls.Add(this.btn_vi_Enregistrer);
            this.tabVirement.Controls.Add(this.lbl_vi_Message);
            this.tabVirement.Controls.Add(this.tbx_vi_MontantVirement);
            this.tabVirement.Controls.Add(this.label25);
            this.tabVirement.Controls.Add(this.label26);
            this.tabVirement.Controls.Add(this.label19);
            this.tabVirement.Location = new System.Drawing.Point(4, 29);
            this.tabVirement.Name = "tabVirement";
            this.tabVirement.Size = new System.Drawing.Size(792, 417);
            this.tabVirement.TabIndex = 5;
            this.tabVirement.Text = "Virement";
            this.tabVirement.Enter += new System.EventHandler(this.tabVirement_Enter);
            // 
            // cbx_vi_Crediteur
            // 
            this.cbx_vi_Crediteur.FormattingEnabled = true;
            this.cbx_vi_Crediteur.Location = new System.Drawing.Point(280, 150);
            this.cbx_vi_Crediteur.Name = "cbx_vi_Crediteur";
            this.cbx_vi_Crediteur.Size = new System.Drawing.Size(260, 28);
            this.cbx_vi_Crediteur.TabIndex = 43;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(75, 153);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(135, 20);
            this.label27.TabIndex = 42;
            this.label27.Text = "Compte à créditer";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(546, 210);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 20);
            this.label21.TabIndex = 41;
            this.label21.Text = "€";
            // 
            // cbx_vi_Debiteur
            // 
            this.cbx_vi_Debiteur.FormattingEnabled = true;
            this.cbx_vi_Debiteur.Location = new System.Drawing.Point(280, 116);
            this.cbx_vi_Debiteur.Name = "cbx_vi_Debiteur";
            this.cbx_vi_Debiteur.Size = new System.Drawing.Size(260, 28);
            this.cbx_vi_Debiteur.TabIndex = 40;
            // 
            // btn_vi_Annuler
            // 
            this.btn_vi_Annuler.BackColor = System.Drawing.Color.Maroon;
            this.btn_vi_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vi_Annuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_vi_Annuler.Location = new System.Drawing.Point(426, 254);
            this.btn_vi_Annuler.Name = "btn_vi_Annuler";
            this.btn_vi_Annuler.Size = new System.Drawing.Size(114, 35);
            this.btn_vi_Annuler.TabIndex = 39;
            this.btn_vi_Annuler.Text = "Effacer";
            this.btn_vi_Annuler.UseVisualStyleBackColor = false;
            this.btn_vi_Annuler.Click += new System.EventHandler(this.btn_vi_Annuler_Click);
            // 
            // btn_vi_Enregistrer
            // 
            this.btn_vi_Enregistrer.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_vi_Enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vi_Enregistrer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_vi_Enregistrer.Location = new System.Drawing.Point(280, 254);
            this.btn_vi_Enregistrer.Name = "btn_vi_Enregistrer";
            this.btn_vi_Enregistrer.Size = new System.Drawing.Size(114, 35);
            this.btn_vi_Enregistrer.TabIndex = 38;
            this.btn_vi_Enregistrer.Text = "Enregistrer";
            this.btn_vi_Enregistrer.UseVisualStyleBackColor = false;
            this.btn_vi_Enregistrer.Click += new System.EventHandler(this.btn_vi_Enregistrer_Click);
            // 
            // lbl_vi_Message
            // 
            this.lbl_vi_Message.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_vi_Message.AutoSize = true;
            this.lbl_vi_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vi_Message.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_vi_Message.Location = new System.Drawing.Point(76, 316);
            this.lbl_vi_Message.Name = "lbl_vi_Message";
            this.lbl_vi_Message.Size = new System.Drawing.Size(189, 18);
            this.lbl_vi_Message.TabIndex = 37;
            this.lbl_vi_Message.Text = "Une erreur est survenue";
            this.lbl_vi_Message.Visible = false;
            // 
            // tbx_vi_MontantVirement
            // 
            this.tbx_vi_MontantVirement.Location = new System.Drawing.Point(280, 207);
            this.tbx_vi_MontantVirement.Name = "tbx_vi_MontantVirement";
            this.tbx_vi_MontantVirement.Size = new System.Drawing.Size(260, 26);
            this.tbx_vi_MontantVirement.TabIndex = 36;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(75, 210);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(154, 20);
            this.label25.TabIndex = 35;
            this.label25.Text = "Montant du virement";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(75, 119);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(131, 20);
            this.label26.TabIndex = 34;
            this.label26.Text = "Compte à débiter";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(-4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(393, 59);
            this.label19.TabIndex = 4;
            this.label19.Text = "Réaliser un virement";
            // 
            // FrmBanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_OngletsApplicationa);
            this.Name = "FrmBanque";
            this.Text = "Application Banqueroute";
            this.tab_OngletsApplicationa.ResumeLayout(false);
            this.tabAccueil.ResumeLayout(false);
            this.tabAccueil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeComptes)).EndInit();
            this.tabConsultation.ResumeLayout(false);
            this.tabConsultation.PerformLayout();
            this.tabCreation.ResumeLayout(false);
            this.tabCreation.PerformLayout();
            this.tabVersement.ResumeLayout(false);
            this.tabVersement.PerformLayout();
            this.tabRetrait.ResumeLayout(false);
            this.tabRetrait.PerformLayout();
            this.tabVirement.ResumeLayout(false);
            this.tabVirement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_OngletsApplicationa;
        private System.Windows.Forms.TabPage tabAccueil;
        private System.Windows.Forms.TabPage tabConsultation;
        private System.Windows.Forms.TabPage tabCreation;
        private System.Windows.Forms.TabPage tabVersement;
        private System.Windows.Forms.TabPage tabRetrait;
        private System.Windows.Forms.TabPage tabVirement;
        private System.Windows.Forms.DataGridView dgv_ListeComptes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ac_Titre;
        private System.Windows.Forms.TextBox tbx_co_SoldeActuel;
        private System.Windows.Forms.TextBox tbx_co_Titulaire;
        private System.Windows.Forms.TextBox tbx_co_Numero;
        private System.Windows.Forms.ComboBox cbx_co_ChoixCompte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_cr_Message;
        private System.Windows.Forms.TextBox tbx_cr_SoldeInitial;
        private System.Windows.Forms.TextBox tbx_cr_Titulaire;
        private System.Windows.Forms.TextBox tbx_cr_Numero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_cr_Annuler;
        private System.Windows.Forms.Button btn_cr_Creer;
        private System.Windows.Forms.CheckedListBox clb_cr_Civilite;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbx_ve_ChoixCompte;
        private System.Windows.Forms.Button btn_ve_Annuler;
        private System.Windows.Forms.Button btn_ve_Enregistrer;
        private System.Windows.Forms.Label lbl_ve_Message;
        private System.Windows.Forms.TextBox tbx_ve_MontantACrediter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbx_re_ChoixCompte;
        private System.Windows.Forms.Button btn_re_Annuler;
        private System.Windows.Forms.Button btn_re_Enregistrer;
        private System.Windows.Forms.Label lbl_re_Message;
        private System.Windows.Forms.TextBox tbx_re_MontantADebiter;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbx_vi_Crediteur;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbx_vi_Debiteur;
        private System.Windows.Forms.Button btn_vi_Annuler;
        private System.Windows.Forms.Button btn_vi_Enregistrer;
        private System.Windows.Forms.Label lbl_vi_Message;
        private System.Windows.Forms.TextBox tbx_vi_MontantVirement;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label19;
    }
}

