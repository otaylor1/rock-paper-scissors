using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubbornAI : IPlayer

    {

        //Properties
        public int FavoriteMove;

        //constructor
        public StubbornAI()
        {
            FavoriteMove = 2;
        }           
        
        //Method
        public int NextMove()
        {
            return FavoriteMove;
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //this method intentionally left blank
        }
    }
}
