using System;
using System.Collections.Generic;
using System.Text;

namespace Boites
{
    public enum Couleurs
    {
        Blanc,
        Bleu,
        Vert,
        Jaune,
        Orange,
        Rouge,
        Marron
    }

    public enum Matieres
    {
        Carton,
        Plastique,
        Bois,
        Metal
    }

    class Boite
    {

 
        private int _volume;
        private Etiquette _etiquetteDest;
        private Etiquette _etiquetteFragile;

        public static int Compteur { get; private set; }
        public int Hauteur { get; } = 30;
        public int Largeur { get; } = 30;
        public int Longeur { get; } = 30;

        public Couleurs Couleur { get; set; }

        public Matieres Matiere { get; set; }

        public Etiquette EtiquetteDest
        {
            get
            {
                return _etiquetteDest;
            }
        }

        public Etiquette EtiquetteFrag
        {
            get
            {
                return _etiquetteFragile;
            }
        }

        

        public int Volume
        {
            get
            {
                _volume = Hauteur * Largeur * Longeur;
                return _volume;
            }
        }

        public void Etiqueter(string destinataire)
        {
            _etiquetteDest = new Etiquette(destinataire, Couleurs.Blanc, Formats.L);

        }

        public void Etiqueter(string destinataire, bool fragile) 
        {
            Etiqueter(destinataire);

            if (fragile)
            {
                _etiquetteFragile = new Etiquette("FRAGILE", Couleurs.Rouge, Formats.S);
            }
        }

        public void Etiqueter(Etiquette destinataire, Etiquette fragile)
        {
            _etiquetteDest = destinataire;
            _etiquetteFragile = fragile;

        }

        public Boite(int hauteur, int largeur, int longeur)
        {
            Hauteur = hauteur;
            Largeur = largeur;
            Longeur = longeur;
            Compteur++;
        }

        public Boite(int hauteur, int largeur, int longeur, Matieres matiere) : this(hauteur, largeur, longeur )
        {
            Matiere = matiere;
        }

        public static bool Compare(Boite b1, Boite b2)
        {
            if (b1.Hauteur == b2.Hauteur
                && b1.Largeur == b2.Largeur
                && b1.Longeur == b2.Longeur
                && b1.Matiere == b2.Matiere)
            {
                return true;
            }
            else return false;
        }

        public bool Compare2(Boite b1)
        {
            if (b1.Hauteur == Hauteur
                && b1.Largeur == Largeur
                && b1.Longeur == Longeur
                && b1.Matiere == Matiere)
            {
                return true;
            }
            else return false;
        }
    }
}
