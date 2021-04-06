using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIApp
{
    public class FiguresDocument
    {
        public List<Figure> figures { get; set; } = new List<Figure>();

        public event Action<Figure> AddFigureEvent;
        public event Action<Figure> UpdateFigureEvent;
        public event Action<Figure> RemoveFigureEvent;

        public void AddFigure(Figure figure)
        {
            figures.Add(figure);
            AddFigureEvent?.Invoke(figure);
        }

        public void RemoveFigure(Figure figure)
        {
            figures.Remove(figure);
            RemoveFigureEvent?.Invoke(figure);
        }

        public void UpdateFigure(Figure figure)
        {
            UpdateFigureEvent?.Invoke(figure);
        }
    }
}
