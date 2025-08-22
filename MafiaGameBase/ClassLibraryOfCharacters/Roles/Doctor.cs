using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryOfCharacters.Users;

namespace ClassLibraryOfCharacters.Roles
{
    public class Doctor : Player
    {
        public static string Ability { get; } = "protect";
        public static char type { get; } = 'G';

        public Doctor(string name) : base(name)
        {
        }
        public override string UseAbility()
        {
            return Ability;
        }
        public override string GetType()
        {
            return type.ToString();
        }

    }
}
