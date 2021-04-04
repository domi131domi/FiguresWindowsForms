using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIApp
{
    public class Document
    {
        public List<Figure> figures = new List<Figure>();

        public event Action<Figure> AddFigureEvent;

        public void AddFigure(Figure figure)
        {
            figures.Add(figure);
            AddFigureEvent?.Invoke(figure);
        }

        public void UpdateFigure(Figure student)
        {
            throw new NotImplementedException();
        }
    }
}
