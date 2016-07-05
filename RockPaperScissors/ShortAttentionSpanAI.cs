using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ShortAttentionSpanAI : IPlayer
    {
        //public int save players move
        //Properties
        public int PlayersMove;


        //Methods
        public int NextMove()
        {

            if (PlayersMove == 0)
            {
                return 1;
            }

            if (PlayersMove == 1)
            {
                return 2;
            }

            if (PlayersMove == 2)
            {
                return 0;
            }


            throw new NotImplementedException();
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //save other move into my variable
            PlayersMove = otherMove;

        }
    }
}
