﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core
{
    using System;
    public static class SuiteExtensions
    {

        public static char GetShortName(this Suite suite)
        {
            switch (suite)
            {
                case Suite.Clubs: return 'C';
                case Suite.Diamond: return 'D';
                case Suite.Heart: return 'H';
                case Suite.Spade: return 'S';
                default: throw new InvalidOperationException();
            }
        }
    }
}
