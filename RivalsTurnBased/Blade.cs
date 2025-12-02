using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RivalsTurnBased
{
    internal class Blade : Character
    {
        public override string Name { get; set; } = "Blade";
        public override RoleClass Role { get; set; } = RoleClass.Duelist;
        public override float HP { get; set; } = 100;
        public override float MoveSpeed { get; set; } = 7;
        public override float Damage { get; set; } = 18;
        public override int ActionRange { get; set; } = 7;
        public override bool Stunnable { get; set; } = true;
        public override bool IsStunned { get; set; } = false;
        public override bool OutOfPlay { get; set; } = true;
        public override float UltimateCharge { get; set; } = 0;
        public override string ToString()
        {
            return Name;
        }
    }
}
