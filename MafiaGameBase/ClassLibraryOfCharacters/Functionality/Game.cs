using ClassLibraryOfCharacters.Roles;
using ClassLibraryOfCharacters.Users;

namespace ClassLibraryOfCharacters.Functionality
{
    public class Game
    {
        public static List<Player> Players { get; private set; } = new List<Player>();

        public static List<Player> Initialize(List<string> playerNames, int numDetectives, int numJesters, int numDoctors, int numMafia, int numVillagers)
        {
            int total = numDetectives + numJesters + numDoctors + numMafia + numVillagers;
            if (total > 10 || total != playerNames.Count)
                throw new ArgumentException("Total roles must match player count and not exceed 10.");

            if (new HashSet<string>(playerNames).Count != playerNames.Count)
                throw new ArgumentException("Player names must be unique.");

            Players.Clear();
            var roles = new List<(string Role, int Count)>
            {
                ("Detective", numDetectives),
                ("Jester", numJesters),
                ("Doctor", numDoctors),
                ("Mafia", numMafia),
                ("Villager", numVillagers)
            };

            int nameIndex = 0;
            foreach (var (role, count) in roles)
            {
                for (int i = 0; i < count; i++)
                {
                    switch (role)
                    {
                        case "Detective":
                            Players.Add(new Detective(playerNames[nameIndex++]));
                            break;
                        case "Jester":
                            Players.Add(new Jester(playerNames[nameIndex++]));
                            break;
                        case "Doctor":
                            Players.Add(new Doctor(playerNames[nameIndex++]));
                            break;
                        case "Mafia":
                            Players.Add(new Mafia(playerNames[nameIndex++]));
                            break;
                        case "Villager":
                            Players.Add(new Villager(playerNames[nameIndex++]));
                            break;
                    }
                }
            }
            return Players;

        }
    }
}

