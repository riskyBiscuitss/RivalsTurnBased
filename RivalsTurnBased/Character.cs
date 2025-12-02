namespace RivalsTurnBased
{
    internal abstract class Character
    {
        abstract public string Name { get; set; }
        abstract public RoleClass Role { get; set; }
        public int RosterNumber { get; set; }
        abstract public float HP { get; set; }
        abstract public float MoveSpeed { get; set; }
        abstract public float Damage { get; set; }
        abstract public int ActionRange { get; set; }
        abstract public bool Stunnable { get; set; }
        abstract public bool IsStunned { get; set; }
        abstract public bool OutOfPlay { get; set; }
        abstract public float UltimateCharge { get; set; }



    }
}
