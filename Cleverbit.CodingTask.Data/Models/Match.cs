
using System;
using System.Collections.Generic;

namespace Cleverbit.CodingTask.Data.Models
{
    public class Match
    {

        public int Id { get; set; }
        public User Winner { get; set; }
        public DateTime Timestamp { get; set; }
        public List<User> Players { get; set; }

    }
}