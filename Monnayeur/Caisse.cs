using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monnayeur
{
    class Caisse
    {
        public Affichage Affiche { get; }
        public int Total { get; set; }
        public void Ajouter(Piece piece)
        {
            Total += (int)piece;
            Console.WriteLine((double)piece/100 + "e a été ajouté dans la caisse");
        }
    }
}
