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

            //bool firstTeam = true;
            //for(int i = 0; i < 12; i++)
            //if(firstTeam) currentTeam = teamOne
            //else currentTeam  = teamTwo;
            //switch characterSelected
            //case 1: currentTeam(character)
            //teamOne[0] = new DrStrange();
            //cw display team one
            //Team one : teamOne[0] \n etc.
            //if (i >  6) firstTeam = false;

            //new idea
            //int[] teamOnePicks = new int[6];
            //for (int i = 0; i < 7; i++)
            //switch characterSelected:
            //case 1: teamOnePicks[i] = 1;

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

                //CharacterSelect(); change this to return arrays
                //TeamOne(CharacterSelect()); 
                //idk if player.rosternumber will be available in TeamOne or else where
            }
        }

        public void CharacterSelect()
        {
            int selectedNumber;
            bool isFirstTeam = true;
            int?[] firstArr = new int?[6];
            int?[] secondArr = new int?[6];
            int?[] selectedArr = new int?[6];
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
                    Array.Clear(selectedArr, 0, selectedArr.Length);
                    i = 0;
                }
            }
            foreach (int k in firstArr)
            {
                Console.WriteLine(k);
            }
            foreach (int m in secondArr)
            {
                Console.WriteLine(m);
            }
            //TeamOne(firstArr);
        }

        public void TeamOne(int?[] chosenCharacters)
        {
            Character[] teamOne = new Character[6];



        }

        public void TeamTwo()
        {
            Character[] teamTwo = new Character[6];

        }
    }
}
