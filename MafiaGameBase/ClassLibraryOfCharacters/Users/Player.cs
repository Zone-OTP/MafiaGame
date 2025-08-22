using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryOfCharacters.Roles;

namespace ClassLibraryOfCharacters.Users
{
    public class Player
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int VoteCount { get; set; } = 0;
        public bool Alive { get; set; } = true;
        public bool Protected { get; set; } = false;
        public static int _id = 1;

        public Player(string name) {
            Name = name;
            Id = _id++;
        }

        public virtual string UseAbility() {
            return "NothingHappened";
        }
        public virtual string GetType() {
            return "type";
        }
    }
}
