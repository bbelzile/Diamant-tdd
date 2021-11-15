using System;

namespace TDD
{
    public class Diamant
    {
        public Diamant()
        {

        }

        public string AfficherDiamant(char lettreEnEntree)
        {
            const char A = 'A';
            lettreEnEntree = char.ToUpper(lettreEnEntree);
            int nbEspace = lettreEnEntree - A;

            if (lettreEnEntree == 'A')
            {
                return "A";
            }
            else
            {
                string diamantDeRetour = "";

                for (int i = 0; i < nbEspace * 2 + 1; i++)
                {
                    char lettreCourante = 
                        Convert.ToChar((int)lettreEnEntree - Math.Abs(((int)lettreEnEntree - (int) A) - i));
                    int espaceExterne = Math.Abs(nbEspace - i);
                    int espaceInterne = Math.Abs(i - nbEspace) * 2 - 1 ;

                    if (espaceInterne == -1)
                    {
                        diamantDeRetour += EcrireEspace(espaceExterne) +
                                           lettreCourante +
                                           EcrireEspace(espaceExterne)
                                           + "\n";
                    }
                    else
                    {
                        diamantDeRetour += EcrireEspace(espaceExterne) +
                                           lettreCourante +
                                           EcrireEspace(espaceInterne) +
                                           lettreCourante +
                                           EcrireEspace(espaceExterne)
                                           + "\n";
                    }
                }

                return diamantDeRetour;
            }

            return "Allo";
        }

        public string EcrireEspace(int nbEspace)
        {
            string retourEspace = "";

            for (int i = 0; i < nbEspace; i++)
            {
                retourEspace += " ";
            }

            return retourEspace;
        }
    }
}