using System;
using System.Collections.Generic;
using System.Text;

namespace Boites
{
    public enum Formats
    {
        XS,
        S,
        M,
        L,
        XL
    }

    class Etiquette
    {
        public string Texte { get; set; }

        public Couleurs Couleur { get; set; }

        public Formats Format { get; set; }

        public Etiquette() { }
        public Etiquette(string destinataire, Couleurs couleur, Formats format)
        {
            Texte = destinataire;
            Couleur = couleur;
            Format = format;
        }

        public override string ToString()
        {
            return "Voici mon message : "+Texte+" avec la couleur "+Couleur+" au format "+Format;
        }
    }
}
