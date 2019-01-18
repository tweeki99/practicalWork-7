using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalWork_7
{
    public class FirstTask      //описывает физические свойства тела(объем, плотность). 
    {                           //Перегруженные операторы == и != высчитывают массы тел по формуле m=ρV и сравнивают
        int Volume { get; set; }
        int Density { get; set; }

        public FirstTask()
        {
            Volume = 0;
            Density = 0;
        }

        public FirstTask(int volume, int density)
        {
            Volume = volume;
            Density = density;
        }

        public static bool operator ==(FirstTask obj1, FirstTask obj2)
        {
            int massObj1 = obj1.Volume * obj1.Density;
            int massObj2 = obj2.Volume * obj2.Density;

            if(massObj1 == massObj2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(FirstTask obj1, FirstTask obj2)
        {
            int massObj1 = obj1.Volume * obj1.Density;
            int massObj2 = obj2.Volume * obj2.Density;

            if (massObj1 == massObj2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
