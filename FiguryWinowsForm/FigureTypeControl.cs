using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguryWinowsForm
{
    public partial class FigureTypeControl : UserControl
    {
        public FigureType type { get; set; }

        public FigureTypeControl()
        {
            InitializeComponent();
            type = FigureType.Circle;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if(type == FigureType.Circle)
            {
                type = FigureType.Rectangle;
            }
            else if (type == FigureType.Rectangle)
            {
                type = FigureType.Triangle;
            }
            else if (type == FigureType.Triangle)
            {
                type = FigureType.Circle;
            }
            UpdateImage();
        }
        
        public void UpdateImage()
        {
            if (type == FigureType.Circle)
            {
                Button.BackgroundImage = Properties.Resources.rectangle;
            }
            else if (type == FigureType.Rectangle)
            {
                Button.BackgroundImage = Properties.Resources.triangle;
            }
            else if (type == FigureType.Triangle)
            {
                Button.BackgroundImage = Properties.Resources.circle;
            }
        }
    }


    public enum FigureType
    {
        Triangle,
        Circle,
        Rectangle
    };
}
