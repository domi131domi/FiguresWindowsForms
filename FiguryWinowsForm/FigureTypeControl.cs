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
        private FigureType type;
        [BrowsableAttribute(true)]
        public FigureType Type
        {
            get { return type; }
            set { type = value; UpdateImage();  }
        }

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
                Typebtn.BackgroundImage = Properties.Resources.circle;
            }
            else if (type == FigureType.Rectangle)
            {
                Typebtn.BackgroundImage = Properties.Resources.rectangle;
            }
            else if (type == FigureType.Triangle)
            {
                Typebtn.BackgroundImage = Properties.Resources.triangle;
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
