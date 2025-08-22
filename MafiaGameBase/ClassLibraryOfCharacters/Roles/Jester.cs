using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryOfCharacters.Users;

namespace ClassLibraryOfCharacters.Roles
{
    public class Jester : Player
    {
        
        public static string Ability { get; } = "Win on Village Vote Kill";

        public static char type { get; } = 'U';

        
        public Jester(string name):base(name) 
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
