using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monnayeur
{
    class Tube
    {
		public Piece Piece { get; set; }
		public int NbPiece { get; set; }
        public int Capacite { get; set; }

		public Tube(Piece piece)
        {
            Piece = piece;
            Capacite = 100;
        }

		public void Ajouter()
        {
            NbPiece++;
        }

    }
}
