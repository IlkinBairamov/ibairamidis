using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Games
    {
        public string Board;
        public string Color;
        public string Figure;

        public Games(string dask, string color, string figure)
        {
            Board = dask;
            Color = color;
            Figure = figure;

        }

        public virtual string AllGames()
        {
            return $"{Board} / {Color} / {Figure}";
        }
    }
}
