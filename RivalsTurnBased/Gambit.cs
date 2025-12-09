namespace RivalsTurnBased
{
    internal class Gambit : Character
    {
        public override string Name { get; set; } = "Gambit";
        public override RoleClass Role { get; set; } = RoleClass.Strategist;
        public override float HP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override float MoveSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override float Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int ActionRange { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool Stunnable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool IsStunned { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool OutOfPlay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override float UltimateCharge { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string ToString()
        {
            return Name;
        }
    }
}
