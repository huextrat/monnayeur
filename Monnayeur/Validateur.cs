using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monnayeur
{
    class Validateur
    {
        public Tube[] Tubes { get; set; }
        public double Somme { get; set; }
        public Caisse Caisse { get; }
        public Affichage Affiche { get; }

        public Validateur()
        {
            Tubes = new Tube[6];

            Tubes[0] = new Tube(Piece.piece200);
            Tubes[1] = new Tube(Piece.piece100);
            Tubes[2] = new Tube(Piece.piece50);
            Tubes[3] = new Tube(Piece.piece20);
            Tubes[4] = new Tube(Piece.piece10);
            Tubes[5] = new Tube(Piece.piece5);
   
            for(int i = 0; i < 10; i++) {
                Tubes[0].Ajouter();
                Tubes[1].Ajouter();
                Tubes[2].Ajouter();
                Tubes[3].Ajouter();
                Tubes[4].Ajouter();
                Tubes[5].Ajouter();
            }
           

            Caisse = new Caisse();
            Affiche = new Affichage();
        }

        public void Inserer(Piece piece)
        {
            Tube tube = SelectionTube(piece);
            if (tube.NbPiece < tube.Capacite)
                tube.Ajouter();
            else
                Caisse.Ajouter(piece);
            Somme += (int)piece;
            Affiche.Affiche("Total : " + Somme/100 +"e");
        }

        public void Rembourse(double prix)
        {
            while (prix != 0)
            {
                while (prix >= 200)
                {
                    if (Tubes[0].NbPiece > 0)
                    {
                        Affiche.Affiche("Remboursement de : 2e");
                        Tubes[0].NbPiece -= 1;
                        prix = Math.Abs(200 - prix);
                    }
                    else
                    {
                        break;
                    }
                }

                while (prix >= 100)
                {
                    if (Tubes[1].NbPiece != 0)
                    {
                        Affiche.Affiche("Remboursement de : 1e");
                        Tubes[1].NbPiece -= 1;
                        prix = Math.Abs(100 - prix);
                    }
                    else
                    {
                        break;
                    }
                }

                while (prix >= 50)
                {
                    if (Tubes[2].NbPiece != 0)
                    {
                        Affiche.Affiche("Remboursement de : 0.50e");
                        Tubes[2].NbPiece -= 1;
                        prix = Math.Abs(50 - prix);
                    }
                    else
                    {
                        break;
                    }
                }

                while (prix >= 20)
                {
                    if (Tubes[3].NbPiece != 0)
                    {
                        Affiche.Affiche("Remboursement de : 0.20e");
                        Tubes[3].NbPiece -= 1;
                        prix = Math.Abs(20 - prix);
                    }
                    else
                    {
                        break;
                    }
                }
                while (prix >= 10)
                {
                    if (Tubes[4].NbPiece != 0)
                    {
                        Affiche.Affiche("Remboursement de : 0.10e");
                        Tubes[4].NbPiece -= 1;
                        prix = Math.Abs(10 - prix);
                    }
                    else
                    {
                        break;
                    }
                }

                while (prix >= 5)
                {
                    if (Tubes[5].NbPiece != 0)
                    {
                        Affiche.Affiche("Remboursement de : 0.05e");
                        Tubes[5].NbPiece -= 1;
                        prix = Math.Abs(5 - prix);
                    }
                    else
                    {
                        break;
                    }
                }
                if (prix > 0)
                {
                    Affiche.Affiche("Pas assez d'argent dans les tubes.");
                    break;
                }
            }
            
        }

        public void Payer(double prix)
        {
            Console.WriteLine("Payement de :" + prix/100 + "e");
            if (prix <= Somme)
            {
                prix = Somme - prix;
                Rembourse(prix);
                Affiche.Affiche("Merci.");
            }
            else
            {
                Affiche.Affiche("Veuillez insérer plus d'argent.");
            }
        }

        private Tube SelectionTube(Piece piece)
        {
            foreach (Tube tube in Tubes)
                if (tube.Piece == piece)
                    return tube;
            return null;
        }
    }
}
