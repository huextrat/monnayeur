using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monnayeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Validateur valid = new Validateur();

            valid.Inserer(Piece.piece200);
            valid.Payer(50);
            Console.ReadLine();
        }
    }
}
