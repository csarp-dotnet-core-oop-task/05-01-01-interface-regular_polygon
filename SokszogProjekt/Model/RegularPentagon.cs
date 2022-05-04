using System;
using System.Collections.Generic;
using System.Text;

using SokszogProjekt.Model.Interfaces;

namespace SokszogProjekt.Model
{
    class RegularPentagon : IRegularPolygon, IComparable
    {
        public double SideLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double Area => throw new NotImplementedException();

        public double District => throw new NotImplementedException();

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
