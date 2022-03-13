using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabanovaLab3_WPF
{
    internal class TimeObject: Time
    {
        private double Speed { get; set; }

        public TimeObject(double x1, double y2, double s) : base(x1, y2)
        {
            Speed = s;
        }
        private double Distance()
        {
            return Total() * Speed;
        }
        public new string Print()
        {
            return $"{Distance()} м";
        }
    }
}
