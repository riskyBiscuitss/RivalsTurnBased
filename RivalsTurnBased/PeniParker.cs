using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RivalsTurnBased
{
    internal class PeniParker : Character
    {
        public override string Name { get; set; } = "Peni Parker";
        public override RoleClass Role { get; set; } = RoleClass.Vanguard;
        public override float HP { get; set; } = 100;
        public override float MoveSpeed { get; set; } = 3;
        public override float Damage { get; set; } = 10;
        public override int ActionRange { get; set; } = 6;
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
