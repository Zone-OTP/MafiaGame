using ClassLibraryOfCharacters.Users;

namespace ClassLibraryOfCharacters.Roles
{
    public class Villager : Player
    {
        public static string Ability { get; } = "sleep";
        public static char type { get; } = 'G';
        public Villager(string name) : base(name)
        {
        }

        public override string UseAbility()
        {
            return Ability;
        }
        public override char GetType()
        {
            return type;
        }

    }
}
