using FiguryWinowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MDIApp
{
    public class Figure
    {
        public string color { get; set; }
        public FigureType type { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public double surfaceArea { get; set; }
        public string label { get; set; }

        public Figure(string color, FigureType type, double x, double y, double surfaceArea, string label)
        {
            this.color = color;
            this.type = type;
            this.x = x;
            this.y = y;
            this.surfaceArea = surfaceArea;
            this.label = label;
        }
    }
}
