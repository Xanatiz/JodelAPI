﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JodelAPI.Objects
{
    public enum VoteMethods
    {
        Up,
        Down
    }

    public class MyVotes
    {
        public string PostId { get; set; }

        public string Message { get; set; }

        public string HexColor { get; set; }

        public int VoteCount { get; set; }

        public string LocationName { get; set; }

        public bool IsOwn { get; set; }
    }
}
