using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RivalsTurnBased
{
    internal class DrStrange : Character
    {
        public override string Name { get; set; } = "Dr. Strange";
        public override RoleClass Role { get; set; } = RoleClass.Vanguard;
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
