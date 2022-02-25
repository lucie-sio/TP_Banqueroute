using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libBanque;

namespace AppWindoBanque
{
    public partial class FrmBanque : Form
    {
        #region INITIALISATION DU PROJET/DONNEES AU LANCEMENT DE L'APPLI

        // Variables gloables au formulaire = Propriétés du formulaire
        private AgenceBancaire MonAgence;

        public FrmBanque()
        {
            InitializeComponent();
            InitialiserLaBanque();
        }

        /// <summary>
        /// Fonction d'initialisation de la banque, appel les fonctions d'affichage de la banque
        /// </summary>
        private void InitialiserLaBanque()
        {
            // Instanciation de l'objet MonAgence, en passant en paramètre le nom de l'agence
            MonAgence = new AgenceBancaire("LUCIE");
            // Modification du titre de l'onglet
            lbl_ac_Titre.Text = "AGENCE de " + MonAgence.NomAgence;

            // Appel d'un sous-programme générant le jeu d'essai, autrement dit créant les comptes de l'agence
            GenererJeuDessai();
        }
 
        /// <summary>
        /// Création d'un jeu d'essai de la banque
        /// </summary>
        private void GenererJeuDessai()
        {
            CompteBancaire cbLucie = new CompteBancaire("0123401234AB", "Mlle. ROULIER Lucie");
            CompteBancaire cbAtika = new CompteBancaire("1234512345DE", "Mlle. KRIM Atika", 9999.99m);
            CompteBancaire cbUgo = new CompteBancaire("9876598765ZY", "M. ZANZI Ugo", 5000.00m);

            MonAgence.AjouterCompte(cbLucie);
            MonAgence.AjouterCompte(cbAtika);
            MonAgence.AjouterCompte(cbUgo);
        }

        #endregion

        #region EVENEMENTS ET FONCTIONS D'ENTREE SUR CHAQUE ONGLETS
        private void tabAccueil_Enter(object sender, EventArgs e) // Remplir la liste des comptes à consulter
        {
            RemplirListeComptes();   
        }

        private void tabConsultation_Enter(object sender, EventArgs e) // Remplir la combobox et effacer les champs
        {
            RemplirComboBox(cbx_co_ChoixCompte);
            NettoyerOnglet(tabConsultation);
        }

        private void tabCreation_Enter(object sender, EventArgs e) // Effacer les champs
        {
            NettoyerOnglet(tabCreation);
        }

        private void tabVersement_Enter(object sender, EventArgs e) // Remplir la combobox et effacer le champs
        {
            RemplirComboBox(cbx_ve_ChoixCompte);
            NettoyerOnglet(tabVersement);
        }

        private void tabRetrait_Enter(object sender, EventArgs e) // Remplir la combobox et effacer le champs
        {
            RemplirComboBox(cbx_re_ChoixCompte);
            NettoyerOnglet(tabRetrait);
        }

        private void tabVirement_Enter(object sender, EventArgs e) // Remplir les combobox et effacer le champs
        {
            RemplirComboBox(cbx_vi_Debiteur);
            RemplirComboBox(cbx_vi_Crediteur);
            NettoyerOnglet(tabVirement);
        }

        /// <summary>
        /// Affichage du jeu d'essai de comptes ajoutés à la banque sur la page Accueil
        /// </summary>
        private void RemplirListeComptes()
        {
            // Force le rafraichissement de la liste des comptes lorsqu'on l'onglet Accueil est ouvert
            dgv_ListeComptes.DataSource = null;
            dgv_ListeComptes.DataSource = MonAgence.LesComptes;
            // On peut adapter la mise en forme en redimensionnant automatiquement les colonnes
            dgv_ListeComptes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Sur la page de consultation, permet de d'afficher le contenu de la combobox lorsque la page est ouverte
        /// </summary>
        private void RemplirComboBox(ComboBox laCombo)
        {
            // Supprime le contenu actuel
            laCombo.Items.Clear();
            // Remplit avec chaque compte grâce à une boucle foreach et ajoute un libéllé pour chaque compte dans la combobox
            foreach (CompteBancaire unCompte in MonAgence.LesComptes)
            {
                laCombo.Items.Add(unCompte.NumCompte + " (" + unCompte.NomTitulaire + ")");
            }
        }

        /// <summary>
        /// Efface tous les champs de saisi/selection lorsqu'un nouvel onglet est ouvert
        /// </summary>
        private void NettoyerOnglet(TabPage unOnglet) 
        { 
            switch (unOnglet.Name)
            // On vide les champs concerné de l'onglet qui vient d'être ouvert, en fonction du nom de cette onglet
            {
                case "tabConsultation":
                    cbx_co_ChoixCompte.Text = "";
                    cbx_co_ChoixCompte.SelectedIndex = -1;
                    tbx_co_Numero.Text = "";
                    tbx_co_Titulaire.Text = "";
                    tbx_co_SoldeActuel.Text = "";

                    break;

                case "tabCreation":
                    lbl_cr_Message.Visible = false;
                    tbx_cr_Numero.Text = "";
                    tbx_cr_Titulaire.Text = "";
                    tbx_cr_SoldeInitial.Text = "";
                    // On décoche la liste checkbox et on efface l'item qui aurait été sélectionné précédemment
                    for (int i = 0; i < clb_cr_Civilite.Items.Count; i++)
                    {
                        clb_cr_Civilite.SetItemChecked(i, false);
                    }
                    clb_cr_Civilite.ClearSelected();

                    break;

                case "tabVersement":
                    lbl_ve_Message.Visible = false;
                    cbx_ve_ChoixCompte.Text = "";
                    cbx_ve_ChoixCompte.SelectedIndex = -1;
                    tbx_ve_MontantACrediter.Text = "";

                    break;

                case "tabRetrait":
                    lbl_re_Message.Visible = false;
                    cbx_re_ChoixCompte.Text = "";
                    cbx_re_ChoixCompte.SelectedIndex = -1;
                    tbx_re_MontantADebiter.Text = "";

                    break;

                case "tabVirement":
                    lbl_vi_Message.Visible = false;
                    cbx_vi_Debiteur.Text = "";
                    cbx_vi_Debiteur.SelectedIndex = -1;
                    cbx_vi_Crediteur.Text = "";
                    cbx_vi_Crediteur.SelectedIndex = -1;
                    tbx_vi_MontantVirement.Text = "";

                    break;
            }
        }

        #endregion

        #region CONSULTATION DES COMPTES

        /// <summary>
        /// Fonction d'affichage des informations du compte saisi dans la fenêtre de consultation
        /// </summary>
        private void cbx_co_ChoixCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Récupération de l'index et instanciation d'un objet compte
            int iCompte = cbx_co_ChoixCompte.SelectedIndex;
            CompteBancaire leCompte;

            if (iCompte >= 0)
            {
                // Récupération du compte sélectionné et ajout de ses propriétés au nouveau objet
                leCompte = MonAgence.LesComptes.ElementAt(iCompte);
                // Affichage des informations sur l'interface
                tbx_co_Numero.Text = leCompte.NumCompte.ToString();
                tbx_co_Titulaire.Text = leCompte.NomTitulaire.ToString();
                tbx_co_SoldeActuel.Text = leCompte.SoldeCompte.ToString();
            }
        }

        #endregion

        #region CREATION D'UN COMPTE

        /// <summary>
        /// Création du compte, en s'assurant que tous les champs saisis sont correctes, puis ajout du compte aux comptes de banques
        /// </summary>
        private void btn_cr_Creer_Click(object sender, EventArgs e)
        {
            // Récupération des valeurs des textbox
            string numero = tbx_cr_Numero.Text;
            string titulaire = tbx_cr_Titulaire.Text;
            string soldeString = tbx_cr_SoldeInitial.Text;
            var civilite = clb_cr_Civilite.SelectedItem;
            decimal soldeDecimal;

            // Gestion des erreurs et ajout du compte si aucune erreur
            if (numero.Length == 12) // Si la longueur du numéro de compte est de 12 caractères
            {
                if (titulaire != "") // Si le nom du titulaire a été saisi
                {
                    if (civilite != null) // Si la civilité a été choisie
                    {
                        // Ajout de la civilité au nom du titulaire en fonction du choix
                        if (civilite.ToString() == "Madame") titulaire = "Mme. " + titulaire;
                        else if (civilite.ToString() == "Mademoiselle") titulaire = "Mlle. " + titulaire;
                        else if (civilite.ToString() == "Monsieur") titulaire = "M. " + titulaire;

                        if (Decimal.TryParse(soldeString, out soldeDecimal)) // Si la conversion est possible
                        {
                            if (soldeDecimal >= 0) // Si le solde est égal ou supérieur à 0
                            {
                                // Création du compte avec les infos saisies & ajout du compte à l'agence
                                CompteBancaire cb = new CompteBancaire(numero, titulaire, soldeDecimal);
                                MonAgence.AjouterCompte(cb);

                                // Affichage du message de confirmation
                                lbl_cr_Message.Text = "Le compte de " + titulaire + " a bien été crée.";
                                lbl_cr_Message.ForeColor = Color.Green;
                                lbl_cr_Message.Visible = true;
                            }
                            else // Message d'erreur valeur solde négatif
                            {
                                lbl_cr_Message.Text = "Veuillez saisir une valeur supérieur ou égale à 0.";
                                lbl_cr_Message.ForeColor = Color.Maroon;
                                lbl_cr_Message.Visible = true;
                            }
                        }
                        else // Message d'erreur valeur solde incorrect
                        {
                            lbl_cr_Message.Text = "Valeur de solde initial incorrect. Les décimales sont séparés par une virgule.";
                            lbl_cr_Message.ForeColor = Color.Maroon;
                            lbl_cr_Message.Visible = true;
                        }
                    }
                    else // Message d'erreur civilité non choisie
                    {
                        lbl_cr_Message.Text = "Veuillez choisir la civilité du titulaire.";
                        lbl_cr_Message.ForeColor = Color.Maroon;
                        lbl_cr_Message.Visible = true;
                    }      
                }
                else // Message d'erreur titulaire compte vide
                {
                    lbl_cr_Message.Text = "Veuillez saisir un titulaire pour le compte.";
                    lbl_cr_Message.ForeColor = Color.Maroon;
                    lbl_cr_Message.Visible = true;
                }
            }
            else // Message d'erreur numéro compte vide ou trop court
            {
                lbl_cr_Message.Text = "Veuillez saisir un numéro de compte de 12 caractères.";
                lbl_cr_Message.ForeColor = Color.Maroon;
                lbl_cr_Message.Visible = true;
            }
        }

        // Efface le contenu des champs
        private void btn_cr_Annuler_Click(object sender, EventArgs e)
        {
            NettoyerOnglet(tabCreation);
        }

        #endregion

        #region VERSEMENT SUR UN COMPTE

        /// <summary>
        /// Enregistrement d'un versement d'un montant sur un compte lorsque l'utilisateur click sur le bouton
        /// </summary>
        private void btn_ve_Enregistrer_Click(object sender, EventArgs e)
        {
            // Récupération de l'index du compte sélectionné (ou non)
            int iCompte = cbx_ve_ChoixCompte.SelectedIndex;
            CompteBancaire leCompte;

            // Récupération du montant, si le montant n'est pas valide il retourne 0
            decimal montant = RecupererMontant(tbx_ve_MontantACrediter);
            if (iCompte >= 0) // Si un compte a bien été selectionné
            {
                if (montant > 0) // Si le montant est supérieur à 0
                {
                    // On récupére le compte correspondant au bon index
                    leCompte = MonAgence.LesComptes.ElementAt(iCompte);

                    if (leCompte.CrediterCompte(montant)) // Si le virement à réussit (retourne false)
                    {
                        lbl_ve_Message.Text = "Versement correctement enregistré.";
                        lbl_ve_Message.ForeColor = Color.Green;
                        lbl_ve_Message.Visible = true;
                    }
                    else
                    {
                        lbl_ve_Message.Text = "Erreur lors du versement, le montant est incorrect.";
                        lbl_ve_Message.ForeColor = Color.Maroon;
                        lbl_ve_Message.Visible = true;
                    }
                }
                else // Message d'erreur si le montant entré n'est pas valide ou négatif ou 0
                {
                    lbl_ve_Message.Text = "Veuillez entrer un montant valide et supérieur à 0.";
                    lbl_ve_Message.ForeColor = Color.Maroon;
                    lbl_ve_Message.Visible = true;
                }
            }
            else // Message d'erreur si aucun compte n'a été sélectionné
            {
                lbl_ve_Message.Text = "Veuillez sélectionner un compte.";
                lbl_ve_Message.ForeColor = Color.Maroon;
                lbl_ve_Message.Visible = true;
            }
        }

        // Efface le contenu des champs
        private void btn_ve_Annuler_Click(object sender, EventArgs e)
        {
            NettoyerOnglet(tabVersement);
        }

        #endregion

        #region RETRAIT SUR UN COMPTE

        /// <summary>
        /// Réalisation d'un retrait sur un compte en fonction du montant saisi
        /// </summary>
        private void btn_re_Enregistrer_Click(object sender, EventArgs e)
        {
            // Récupération de l'index du compte sélectionné (ou non)
            int iCompte = cbx_re_ChoixCompte.SelectedIndex;
            CompteBancaire leCompte;

            // Récupération du montant, si le montant n'est pas valide il retourne 0
            decimal montant = RecupererMontant(tbx_re_MontantADebiter);
            if (iCompte >= 0) // Si un compte a bien été selectionné
            {
                if (montant > 0) // Si le montant est supérieur à 0
                {
                    // On récupére le compte correspondant au bon index
                    leCompte = MonAgence.LesComptes.ElementAt(iCompte);

                    if (leCompte.DebiterCompte(montant)) // Si le virement à réussit (retourne false)
                    {
                        lbl_re_Message.Text = "Retrait correctement enregistré.";
                        lbl_re_Message.ForeColor = Color.Green;
                        lbl_re_Message.Visible = true;
                    }
                    else
                    {
                        lbl_re_Message.Text = "Erreur lors du retrait, le montant est incorrect.";
                        lbl_re_Message.ForeColor = Color.Maroon;
                        lbl_re_Message.Visible = true;
                    }
                }
                else // Message d'erreur si le montant entré n'est pas valide ou négatif ou 0
                {
                    lbl_re_Message.Text = "Veuillez entrer un montant valide et supérieur à 0.";
                    lbl_re_Message.ForeColor = Color.Maroon;
                    lbl_re_Message.Visible = true;
                }
            }
            else // Message d'erreur si aucun compte n'a été sélectionné
            {
                lbl_re_Message.Text = "Veuillez sélectionner un compte.";
                lbl_re_Message.ForeColor = Color.Maroon;
                lbl_re_Message.Visible = true;
            }
        }

        // Efface le contenu des champs
        private void btn_re_Annuler_Click(object sender, EventArgs e)
        {
            NettoyerOnglet(tabRetrait);
        }

        #endregion

        #region VIREMENT ENTRE COMPTES
        private void btn_vi_Enregistrer_Click(object sender, EventArgs e)
        {
            // Récupération de l'index du compte sélectionné (ou non)
            int compteDebiteur = cbx_vi_Debiteur.SelectedIndex;
            int compteCrediteur = cbx_vi_Crediteur.SelectedIndex;
            CompteBancaire leDebiteur;
            CompteBancaire leCrediteur;

            // Récupération du montant, si le montant n'est pas valide il retourne 0
            decimal montant = RecupererMontant(tbx_vi_MontantVirement);
            if ((compteDebiteur >= 0) && (compteCrediteur >= 0)) // Si deux comptes sont bien sélectionnés
            {
                if (compteDebiteur != compteCrediteur) // Si les comptes ne sont pas les mêmes
                {
                    if (montant > 0) // Si le montant est supérieur à 0
                    { 
                        // On récupére les compte correspondant au bon index
                        leDebiteur = MonAgence.LesComptes.ElementAt(compteDebiteur);
                        leCrediteur = MonAgence.LesComptes.ElementAt(compteCrediteur);

                        if ((leDebiteur.DebiterCompte(montant)) && (leCrediteur.CrediterCompte(montant))) // Si le virement à réussit (retourne false)
                        {
                            lbl_vi_Message.Text = "Virement correctement enregistré.";
                            lbl_vi_Message.ForeColor = Color.Green;
                            lbl_vi_Message.Visible = true;
                        }
                        else
                        {
                            lbl_vi_Message.Text = "Erreur lors du virement, le montant est incorrect.";
                            lbl_vi_Message.ForeColor = Color.Maroon;
                            lbl_vi_Message.Visible = true;
                        }
                    }
                    else // Message d'erreur si le montant entré n'est pas valide ou négatif ou 0
                    {
                        lbl_vi_Message.Text = "Veuillez entrer un montant valide et supérieur à 0.";
                        lbl_vi_Message.ForeColor = Color.Maroon;
                        lbl_vi_Message.Visible = true;
                    }
                }
                else // Message d'erreur si les comptes sélectionnés sont les mêmes
                {
                    lbl_vi_Message.Text = "Veuillez choisir deux comptes différents";
                    lbl_vi_Message.ForeColor = Color.Maroon;
                    lbl_vi_Message.Visible = true;
                }
            }
            else // Message d'erreur si aucun ou si qu'un seul compte n'a été sélectionné
            {
                lbl_vi_Message.Text = "Veuillez sélectionner deux comptes";
                lbl_vi_Message.ForeColor = Color.Maroon;
                lbl_vi_Message.Visible = true;
            }
        }

        // Efface le contenu des champs
        private void btn_vi_Annuler_Click(object sender, EventArgs e)
        {
            NettoyerOnglet(tabVirement);
        }

        #endregion

        #region FONCTIONS RELATIVES A L'ENREGISTREMENT D'UNE ACTION

        /// <summary>
        /// Récupération du montant du compte sélectionné
        /// </summary>
        private decimal RecupererMontant(TextBox laTextBox)
        {
            decimal montant;

            try // Essai de la conversion
            {
                montant = decimal.Parse(laTextBox.Text);
            }
            catch // Si le montant entré n'est pas une valeur valide
            {
                montant = -1.0m;
            }
            // On retourne la valeur
            return montant;
        }

        /// <summary>
        /// Sélection d'un préfixe (M. Mme. Mle) et déselection des autres
        /// </summary>
        private void clb_cr_Civilite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clb_cr_Civilite.CheckedIndices.Count > 0) // Si un item est choisis
            {
                // On récupère l'index de l'item sélectionné
                int index = clb_cr_Civilite.SelectedIndex;
                // Récupération de la longueur de la liste, puis on la parcours pour déselectionner les autres items
                for (int i = 0; i < clb_cr_Civilite.Items.Count; i++)
                {
                    if (index != i) clb_cr_Civilite.SetItemChecked(i, false);
                }
            }
            else // Si rien n'est choisi (l'utilisateur à décoché) on efface la liste des items selectionnés 
            {
                clb_cr_Civilite.ClearSelected();
            }
        }

        #endregion


    }
}                                                                                             
                                                                                              