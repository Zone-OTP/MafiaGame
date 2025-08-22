using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryOfCharacters.Users;

namespace ClassLibraryOfCharacters.Roles
{
    public class Detective : Player
    {
        public static string Ability { get; } = "deduce";

        public char Type { get; } = 'G';
        public Detective(string name) : base(name)
        {
        }

        public override string UseAbility()
        {
            return Ability;
        }

    }
}
