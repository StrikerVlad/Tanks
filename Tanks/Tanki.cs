using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    public class Tank
    {
        private string name { get; set; }
        private double ammunitionLevel { get; set; }
        private double armorLevel { get; set; }
        private double manoeuvrability { get; set; }
        private static Random rnd = new Random();


        public Tank(string name)
        {
            this.name = name;
            this.ammunitionLevel = rnd.Next(0, 100);
            this.armorLevel = rnd.Next(0, 100);
            this.manoeuvrability = rnd.Next(0, 100);
        }

        public string getProperties()
        {
            string result = "Имя: " + this.name + "\nБоекомплект: " + this.ammunitionLevel.ToString() + "\nУровень брони:"
                + this.armorLevel.ToString() + "\nУровень маневренности: " + this.manoeuvrability.ToString()
                + "\n**************************";
            return result;
        }

        public static Tank operator *(Tank tank1, Tank tank2)
        {
            if ((tank1.ammunitionLevel > tank2.ammunitionLevel && tank1.armorLevel > tank2.armorLevel)
                || (tank1.ammunitionLevel > tank2.ammunitionLevel && tank1.manoeuvrability > tank2.manoeuvrability)
                    || (tank1.armorLevel > tank2.armorLevel && tank1.manoeuvrability > tank2.manoeuvrability))
                return tank1;
            else if ((tank1.ammunitionLevel < tank2.ammunitionLevel && tank1.armorLevel < tank2.armorLevel)
                || (tank1.ammunitionLevel < tank2.ammunitionLevel && tank1.manoeuvrability < tank2.manoeuvrability)
                    || (tank1.armorLevel < tank2.armorLevel && tank1.manoeuvrability < tank2.manoeuvrability))
                return tank2;
            else
                return null;
        }

    }
}