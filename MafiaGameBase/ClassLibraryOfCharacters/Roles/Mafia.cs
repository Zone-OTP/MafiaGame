using ClassLibraryOfCharacters.Users;

namespace ClassLibraryOfCharacters.Roles
{
    public  class Mafia : Player
    {
        public static string Ability { get; } = "kill";
        public static char type { get; } = 'B';
        public Mafia(string name) : base(name)
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
