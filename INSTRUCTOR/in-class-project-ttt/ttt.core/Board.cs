using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttt.core
{
    public class Board
    {
        private Turn turn = Turn.X;

        public Turn Turn
        {
            get { return turn; }
        }
    }
}
