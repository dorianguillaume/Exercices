using System;
using System.Text.RegularExpressions;

namespace Pendu
{


    /// <summary>
    /// Modélise un jeu de pendu en utilisant le moins possible de concepts de POO
    /// (Pas de propriétés, ni constructeur)
    /// </summary>
    public class Jeu
    {
        // Variabes utilisées pour mémoriser les informations
        const int NB_ERREURS_MAX = 10; // Nombre d'erreurs maximum avant que la partie soit perdue
        const char CAR_REMPL = '-'; // Caractère de remplacement pour les lettres pas encore trouvées
        int _nbErreurs; // Compteur d'erreurs
        char[] _motEnCours; // Tableau représentant le mot en cours de construction
                            // avec des caractères de remplacement pour les lettres non trouvées
        EtatsPartie _etatPartie; // Etat de la partie (en cours, perdue ou gagnée)

        /// <summary>
        /// Initialisation du jeu
        /// </summary>
        /// <param name="mot">mot à deviner</param>
        public void InitialiserJeu(string mot)
        {
            // Mémorise le mot à deviner après l'avoir mis en minuscules
            MotADeviner = mot.ToLower();

            // Initialise l'état de la partie comme "en cours"
            EtatPartie = EtatsPartie.EnCours;

            // Initialise le tableau représentant le mot en cours de construction
            _motEnCours = new char[mot.Length];
            // Les lettre sont remplacées par des caractères de remplacement
            for (int i = 0; i < MotADeviner.Length; i++)
            {
                _motEnCours[i] = CAR_REMPL;
            }
        }

        /// <summary>
        /// Renvoie l'état de la partie (en cours, perdue ou gagnée)
        /// </summary>
        /// <returns></returns>
        public EtatsPartie EtatPartie
        {
            get { return _etatPartie; }
            private set { }
        }


        /// <summary>
        /// Renvoie le mot à deviner
        /// </summary>
        /// <returns></returns>
        public string MotADeviner { get; private set; }

        /// <summary>
        /// Renvoie le mot en cours, où chaque lettre non trouvée
        /// est remplacée par un caractère de remplacement
        /// </summary>
        /// <returns></returns>
        public string MotEnCours
        {
            get { return new string(_motEnCours); }    
        }

        /// <summary>
        /// Renvoie un dessin du pendu représentantif du nombre d'erreurs déjà faites
        /// </summary>
        /// <returns>Chaîne représentant le dessin du pendu</returns>
      

        public string DessinPendu
        {
            get
            {
                string res = string.Empty;
                // Définit le dessin à renvoyer en fonction du compteur d'erreur
                switch (_nbErreurs)
                {
                    case 1:
                        res = @"

 
    
   
    
____";
                        break;
                    case 2:
                        res = @"

|
|   
|  
|   
|____";
                        break;
                    case 3:
                        res = @"
____
|
|   
|  
|   
|____";
                        break;
                    case 4:
                        res = @"
____
|/  
|   
|  
|   
|____";
                        break;
                    case 5:
                        res = @"
____
|/  |
|   
|  
|   
|____";
                        break;
                    case 6:
                        res = @"
____
|/  |
|   o
|  
|   
|____";
                        break;
                    case 7:
                        res = @"
____
|/  |
|   o
|   |
|   
|____";
                        break;
                    case 8:
                        res = @"
____
|/  |
|   o
|  /|
|   
|____";
                        break;
                    case 9:
                        res = @"
____
|/  |
|   o
|  /|\
|   
|____";
                        break;
                    case 10:
                        res = @"
____
|/  |
|   o
|  /|\
|  / 
|____";
                        break;
                    case 11:
                        res = @"
____
|/  |
|  ~o~
|  /|\
|  / \
|____";
                        break;
                    default:
                        res = @"

 
    
   
    
";
                        break;
                }
                return res;
            }
        }

        /// <summary>
        /// Vérifie le mot passé en paramètre
        /// Renvoie un message d'erreur le cas échéant
        /// </summary>
        /// <param name="mot"></param>
        public static string VerifierMot(string mot)
        {
            string message = "";

            // Vérifie que le mot n'est pas vide ou constitué d'espaces
            if (mot.Contains(" "))
            {
                throw new FormatException("Veuillez saisir un mot sans espace");
            }
            else
            {
                // Vérifie que le mot a une longueur comprise entre 3 et 25 caractères
                if (mot.Length < 3)
                {
                    throw new FormatException("Veuillez saisir un mot compris entre 3 et 25 caractères");
                }
                else
                {
                    // Vérifier les accents
                    // SANS REGEX  if (mot.Contains("é") || mot.Contains("è") || mot.Contains("à") || mot.Contains("â") || mot.Contains("ù"))
                    if (Regex.IsMatch(mot, "[^a-z]"))
                    {
                        throw new FormatException("Veuillez saisir un mot sans accent");
                    }
                }
            }
            return message;
        }

        /// <summary>
        /// Teste si la lettre passée en paramètre est dans le mot
        /// et met à jour l'état de la partie
        /// </summary>
        /// <param name="l">Lettre à tester</param>
        public void TesterLettre(char l)
        {
            int correspondance = 0;
            bool lettreVide = false;

            // Si la lettre est présente dans le mot à deviner
            // on place cette lettre dans le tableau du mot en cours aux bons endroits
            for (int i = 0; i < MotADeviner.Length; i++)
            {
                if (l == MotADeviner[i])
                {
                    _motEnCours[i] = l;
                    correspondance++;
                }
            }


            // Si la lettre n'est pas dans le mot, on incrémente le compteur d'erreurs
            if (correspondance == 0)
            {
                _nbErreurs++;
            }

            // S'il n'y a plus de caractère de remplacement dans le mot en cours,
            // c'est que la partie est gagnée
            // sinon, si le nombre d'erreurs maxi est dépassé, la partie est perdue
            if (_nbErreurs <= NB_ERREURS_MAX)
            {

                for (int i = 0; i < MotADeviner.Length; i++)
                {
                    if (_motEnCours[i] == CAR_REMPL)
                    {

                        lettreVide = true;
                    }
                }

                if (!lettreVide)
                {
                    _etatPartie = EtatsPartie.Gagner;
                }
            }
            else _etatPartie = EtatsPartie.Perdu;
        }
    }
}

