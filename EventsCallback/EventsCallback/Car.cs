using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsCallback
{
    class Car
    {
        public event Action OnChange;

        private double speed;

        public double Speed
        {
            get { return speed; }
            set {
                speed = value;
                if (speed >= 60)
                {
                    if (OnChange != null)
                    {
                        OnChange();
                    }

                }
            }
        }

    }
}
