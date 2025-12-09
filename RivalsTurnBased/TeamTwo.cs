namespace RivalsTurnBased
{
    internal class TeamTwo
    {
        public TeamTwo(int?[] teamTwoPicks, List<Character> sortedList)
        {
            TeamTwoPicks = teamTwoPicks;
            SortedList = sortedList;
            Console.WriteLine("Team 2 chose:");
            foreach (var num in teamTwoPicks) { Console.WriteLine(num); }
            //foreach (var cha in sortedList) { Console.WriteLine(cha); }
        }

        public int?[] TeamTwoPicks { get; }
        public List<Character> SortedList { get; }
    }
}
