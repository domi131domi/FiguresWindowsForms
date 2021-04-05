using MDIApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguryWinowsForm
{
    public partial class FigureForm : Form
    {
        private Figure figure;
        private List<Figure> figures;

        public string FigureName
        {
            get { return textBox1.Text; }
        }

        public string FigureSurname
        {
            get { return textBox2.Text; }
        }

        public FigureForm(Figure figure, List<Figure> figures)
        {
            InitializeComponent();
            this.figure = figure;
            this.figures = figures;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
