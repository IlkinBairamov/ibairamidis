using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Chess : Games
    {
       
        public string Title;
               

        public Chess(string board, string color, string figure,  string title) : base(board, color, figure)
        {
            
            Title = title;
        }
        public override string AllGames()
        {
            return $"{base.AllGames()}  / {Title}";
        }
    }
}
