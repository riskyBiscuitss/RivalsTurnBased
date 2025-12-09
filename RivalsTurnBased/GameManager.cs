using System.Reflection;

namespace RivalsTurnBased
{
    internal class GameManager
    {
        private void AssignTeams()
        {
            DisplayRoster();
            int playerNumber = 1;
            Console.WriteLine("Player " + playerNumber + " select your team by the corresponding number and press Enter: ");



        }

        public void DisplayRoster()
        {
            Assembly assem = typeof(Character).Assembly;
            Type[] types = assem.GetTypes();
            var derivedClasses = types.Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(Character)));
            List<Character> list = new List<Character>();

            foreach (Type derivedType in derivedClasses)
            {
                if (Activator.CreateInstance(derivedType) is Character player)
                {
                    list.Add(player);
                }
            }

            List<Character> sortedList = list.OrderBy(t => t.Role).ToList();
            bool displayVanguard = false, displayDuelist = false, displayStrategist = false;
            int rosterNumber = 1;

            foreach (Character player in sortedList)
            {

                if (player.Role == RoleClass.Vanguard && displayVanguard == false)
                {
                    Console.WriteLine("Vanguards: ");
                    displayVanguard = true;
                }
                else if (player.Role == RoleClass.Duelist && displayDuelist == false)
                {
                    Console.WriteLine("\nDuelists: ");
                    displayDuelist = true;
                }
                else if (player.Role == RoleClass.Strategist && displayStrategist == false)
                {
                    Console.WriteLine("\nStrategists: ");
                    displayStrategist = true;
                }
                player.RosterNumber = rosterNumber;

                Console.WriteLine(player.RosterNumber + ". " + player);
                rosterNumber++;

                //TeamOne(teamOnePicks, sortedList); 
                //idk if player.rosternumber will be available in TeamOne or else where
            }
            var (teamOnePicks, teamTwoPicks) = CharacterSelect();
            TeamOne teamOne = new TeamOne(teamOnePicks, sortedList);
        }

        public static (int?[] teamOnePicks, int?[] teamTwoPicks) CharacterSelect()
        {
            int selectedNumber;
            bool isFirstTeam = true;
            int?[] firstArr = new int?[6];
            int?[] secondArr = new int?[6];
            int?[] selectedArr = new int?[6];
            int?[] teamOnePicks = new int?[6];
            int?[] teamTwoPicks = new int?[6];
            Console.WriteLine("Select a character from the corresponding number: ");

            int i = 0;


            while (!selectedArr.All(x => x != null))
            {
                if (isFirstTeam) selectedArr = firstArr;
                else selectedArr = secondArr;
                selectedNumber = int.Parse(Console.ReadLine());

                switch (selectedNumber)
                {
                    case 1:
                        selectedArr[i] = selectedNumber;
                        i++;
                        break;
                    case 2:
                        selectedArr[i] = selectedNumber;
                        i++;
                        break;
                    case 3:
                        selectedArr[i] = selectedNumber;
                        i++;
                        break;
                    case 4:
                        selectedArr[i] = selectedNumber;
                        i++;
                        break;
                    case 5:
                        selectedArr[i] = selectedNumber;
                        i++;
                        break;
                    case 6:
                        selectedArr[i] = selectedNumber;
                        i++;
                        break;
                    default:
                        Console.WriteLine("Invalid selection..");
                        break;

                }
                //switching teams and emptying the selectArray
                if (firstArr.All(x => x != null))
                {
                    isFirstTeam = false;
                    teamOnePicks = firstArr.Select(x => x).ToArray();
                    Array.Clear(selectedArr, 0, selectedArr.Length);
                    i = 0;
                }
            }
            teamTwoPicks = secondArr.Select(x => x).ToArray();
            //foreach (int k in firstArr)
            //{
            //    Console.WriteLine(k);
            //}
            //foreach (int m in secondArr)
            //{
            //    Console.WriteLine(m);
            //}
            //TeamOne(firstArr);
            return (teamOnePicks, teamTwoPicks);
        }


    }
}
