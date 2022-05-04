using System;
using System.Collections.Generic;
using System.Text;

namespace SokszogProjekt.Model.Interfaces
{
    interface IRegularPolygon
    {
        double SideLength { get; set; }
        double Area { get; }
        double District { get; }
    }
}
