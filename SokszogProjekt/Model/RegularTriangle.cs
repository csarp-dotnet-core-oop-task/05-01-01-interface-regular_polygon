using System;
using System.Collections.Generic;
using System.Text;

using SokszogProjekt.Model.Interfaces;

namespace SokszogProjekt.Model
{
    class RegularTriangle : IRegularPolygon, IComparable
    {

        double sideLength;
        public double SideLength
        {
            get
            {
                return sideLength;
            }
            set
            {
                sideLength = value;
            }
        }

        public double Area
        {
            get
            {
                return Math.Pow(sideLength, 2) * Math.Sqrt(3) / 4;
            }
        }

        public int CompareTo(object obj)
        {
            if (obj is RegularTriangle)
            {
                RegularTriangle rt = (RegularTriangle)obj;
                if (sideLength < rt.SideLength)
                    return 1;
                else if (sideLength > rt.sideLength)
                    return -1;
                else
                    return 0;
            }
            else
                return 0;
        }

        public double District
        {
            get
            {
                return 3 * sideLength;
            }
        }
    }
}
