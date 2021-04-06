using MDIApp;
using System;
using System.Windows.Forms;

namespace FiguryWinowsForm
{
    public partial class FigureForm : Form
    {

        public long X
        {
            get { long res; return long.TryParse(Xtb.Text, out res) ? res : throw new Exception("Cannot convert string to long"); }
        }

        public long Y
        {
            get { long res; return long.TryParse(Ytb.Text, out res) ? res : throw new Exception("Cannot convert string to long"); }
        }
        public long SurfaceArea
        {
            get { long res; return long.TryParse(SareaTb.Text, out res) ? res : throw new Exception("Cannot convert string to long"); }
        }
        public string Label
        {
            get { return LabelTb.Text; }
        }
        public string Color
        {
            get { return ColorTb.Text; }
        }
        public FigureType Type
        {
            get { return figureTypeControl1.type; }
        }

        public FigureForm(Figure figure)
        {
            InitializeComponent();
            if (figure != null)
            {
                Xtb.Text = figure.x.ToString();
                Ytb.Text = figure.y.ToString();
                LabelTb.Text = figure.label;
                ColorTb.Text = figure.color;
                figureTypeControl1.type = figure.type;
                figureTypeControl1.UpdateImage();
                SareaTb.Text = figure.surfaceArea.ToString();
                button1.Text = "Edytuj";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
