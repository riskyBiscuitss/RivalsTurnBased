namespace RivalsTurnBased
{
    internal class TeamOne
    {
        public TeamOne(int?[] teamOnePicks, List<Character> sortedList)
        {
            TeamOnePicks = teamOnePicks;
            SortedList = sortedList;
            Console.WriteLine(TeamOnePicks);
            Console.WriteLine(SortedList);
        }

        public int?[] TeamOnePicks { get; }
        public List<Character> SortedList { get; }

        public override string ToString()
        {
            return base.ToString();
        }
    }


}
