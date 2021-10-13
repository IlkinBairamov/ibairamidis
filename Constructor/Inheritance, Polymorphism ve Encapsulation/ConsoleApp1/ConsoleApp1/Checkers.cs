using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Checkers 
    {
        public string Board;
        public string Color;
        public string Figure;

        public int _elo;
        public int Elo
        {
            get
            {
                if (_elo > 2500)
                {
                    return _elo;
                }
                return -1;
               
            }
            set
            {
                if (value > 2500)
                {
                    _elo = value;
                    return;
                }
                Console.WriteLine("incorrect");
                
            }
        }

       
        public  string AllGames()
        {
            return $"{Board} / {Color} / {Figure} / {Elo}";
        }
    }
}
