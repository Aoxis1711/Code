using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ShiFouMi
{
    public partial class JeuChiFouMi : Form
    {
        string choix;
        int blocage;

        public JeuChiFouMi()
        {
            InitializeComponent();
        }




        public void Jouer(string choix_joueur) 
        {
            int carte_ordi =0;
            string signe_ordi="";
            Random choix_ordi = new Random();
            
            // Affichage signe joueur
            if(choix_joueur == "pierre")
            {
                CadreJeu1.BackgroundImage = ShiFouMi.Properties.Resources.pierre;
            }
            if (choix_joueur == "ciseau")
            {
                CadreJeu1.BackgroundImage = ShiFouMi.Properties.Resources.ciseau;
            }
            if (choix_joueur == "feuille")
            {
                CadreJeu1.BackgroundImage = ShiFouMi.Properties.Resources.feuille;
            }
            if (choix_joueur == "puit")
            {
                CadreJeu1.BackgroundImage = ShiFouMi.Properties.Resources.puits;
            }


            // Affichage signe Ordi
            CadreJeu1.Refresh();
            Thread.Sleep(1500);


            carte_ordi = choix_ordi.Next(1, 5);

            if (carte_ordi == 1)
            {
                CadreJeuOrdi.BackgroundImage = ShiFouMi.Properties.Resources.pierre;
                signe_ordi = "pierre";
            }
            if (carte_ordi == 2)
            {
                CadreJeuOrdi.BackgroundImage = ShiFouMi.Properties.Resources.ciseau;
                signe_ordi = "ciseau";
            }
            if (carte_ordi == 3)
            {
                CadreJeuOrdi.BackgroundImage = ShiFouMi.Properties.Resources.feuille;
                signe_ordi = "feuille";
            }
            if (carte_ordi == 4)
            {
                CadreJeuOrdi.BackgroundImage = ShiFouMi.Properties.Resources.puits;
                signe_ordi = "puit";
            }


            CalculScore(signe_ordi, this.choix);
        }

        public void CalculScore(string choix_ordi, string choix_joueur)
        {
            int score_ordi;
            int score_joueur;

            if (choix_joueur != choix_ordi)
            {
                
                // PIERRE
                if ((choix_joueur == "pierre") && (choix_ordi == "ciseau"))
                {
                    score_joueur;
                }
                else
                {
                    if ((choix_ordi == "pierre") && (choix_joueur == "ciseau"))
                    {
                        score_ordi++;
                    }
                }

                // CISEAU

                if ((choix_joueur == "ciseau") && (choix_ordi == "feuille"))
                {
                    score_joueur++;
                }
                else
                {
                    if ((choix_ordi == "ciseau") && (choix_joueur == "feuille"))
                    {
                        score_ordi++;
                    }
                }


                // FEUILLE

                if ((choix_joueur == "feuille") && (choix_ordi == "puit"))
                {
                    score_joueur++;
                }
                else
                {
                    if ((choix_ordi == "feuille") && (choix_joueur == "puit"))
                    {
                        score_ordi++;
                    }
                }
                if ((choix_joueur == "feuille") && (choix_ordi == "pierre"))
                {
                    score_joueur++;
                }
                else
                {
                    if ((choix_ordi == "feuille") && (choix_joueur == "pierre"))
                    {
                        score_ordi++;
                    }
                }


                // PUIT

                if ((choix_joueur == "puit") && (choix_ordi == "pierre"))
                {
                    score_joueur++;
                }
                else
                {
                    if ((choix_ordi == "puit") && (choix_joueur == "pierre"))
                    {
                        score_ordi++;
                    }
                }

                if ((choix_joueur == "puit") && (choix_ordi == "ciseau"))
                {
                    score_joueur++;
                }
                else
                {
                    if ((choix_ordi == "puit") && (choix_joueur == "ciseau"))
                    {
                        score_ordi++;
                    }
                }



                // Pause 5s
                CadreJeu1.Refresh();
                CadreJeuOrdi.Refresh();

                Thread.Sleep(4000);

                LblScoreJoueur.Text = Convert.ToString(score_joueur);
                LblScoreOrdi.Text = Convert.ToString(score_ordi);

                CadreJeuOrdi.BackgroundImage = ShiFouMi.Properties.Resources.fond;
                CadreJeu1.BackgroundImage = ShiFouMi.Properties.Resources.fond;

                Pierre.Visible = true;
                Ciseau.Visible = true;
                Feuille.Visible = true;
                Puit.Visible = true;
            }
           
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Pierre.Visible = true;
            Ciseau.Visible = true;
            Feuille.Visible = true;
            Puit.Visible = true;
            this.blocage = 1;
        }

        private void Pierre_Click(object sender, EventArgs e)
        {
            this.choix = "pierre";

            
            Pierre.Visible = false;
            Ciseau.Visible = false;
            Feuille.Visible = false;
            Puit.Visible = false;

            Jouer(this.choix);
        }

        private void Ciseau_Click(object sender, EventArgs e)
        {
            this.choix = "ciseau";

            
            Pierre.Visible = false;
            Ciseau.Visible = false;
            Feuille.Visible = false;
            Puit.Visible = false;

            Jouer(this.choix);
        }

        private void Feuille_Click(object sender, EventArgs e)
        {
            this.choix = "feuille";

            
            Pierre.Visible = false;
            Ciseau.Visible = false;
            Feuille.Visible = false;
            Puit.Visible = false;

            Jouer(this.choix);
        }

        private void Puit_Click(object sender, EventArgs e)
        {
            this.choix = "puit";

            
            Pierre.Visible = false;
            Ciseau.Visible = false;
            Feuille.Visible = false;
            Puit.Visible = false;

            Jouer(this.choix);
        }
    }
}
