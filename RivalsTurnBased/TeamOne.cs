namespace RivalsTurnBased
{
    internal class TeamOne
    {
        public TeamOne(int?[] teamOnePicks, List<Character> sortedList)
        {
            TeamOnePicks = teamOnePicks;
            SortedList = sortedList;
            Console.WriteLine("Team 1 chose:");
            foreach (var num in teamOnePicks) { Console.WriteLine(num); }
            //foreach (var cha in sortedList) { Console.WriteLine(cha); }
        }

        public int?[] TeamOnePicks { get; }
        public List<Character> SortedList { get; }
        public List<Character> CurrentTeam { get; }

        private void CreateTeam(int?[] teamOnePicks, List<Character> sortedList)
        {
            foreach (var num in teamOnePicks)
            {
                foreach (Character c in sortedList)
                {
                    if (num == c.RosterNumber)
                    {
                        Character firstPlayer = new Character(c);
                    }
                }
            }
        }





    }


}
