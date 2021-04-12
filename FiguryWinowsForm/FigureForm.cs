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
            get { return figureTypeControl1.Type; }
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
                figureTypeControl1.Type = figure.type;
                figureTypeControl1.UpdateImage();
                SareaTb.Text = figure.surfaceArea.ToString();
                button1.Text = "Edytuj";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Xtb.CausesValidation = true;
            Ytb.CausesValidation = true;
            SareaTb.CausesValidation = true;
            ColorTb.CausesValidation = true;
            LabelTb.CausesValidation = true;
            if(ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
            Xtb.CausesValidation = false;
            Ytb.CausesValidation = false;
            SareaTb.CausesValidation = false;
            ColorTb.CausesValidation = false;
            LabelTb.CausesValidation = false;
        }

        private void X_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(Xtb.Text))
            {
                errorProviderX.SetError(Xtb, "Value mandatory");
                e.Cancel = true;
            }
            else
            {
                float res;
                if(!float.TryParse(Xtb.Text, out res))
                {
                    errorProviderX.SetError(Xtb, "Value should be a real number");
                    e.Cancel = true;
                }
                else
                {
                    errorProviderX.Clear();
                }
            }
        }

        private void Label_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(LabelTb.Text))
            {
                errorProviderLabel.SetError(LabelTb, "Value mandatory");
                e.Cancel = true;
            }
            else
            {
                errorProviderLabel.Clear();
            }
        }

        private void Y_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Ytb.Text))
            {
                errorProviderY.SetError(Ytb, "Value mandatory");
                e.Cancel = true;
            }
            else
            {
                float res;
                if (!float.TryParse(Ytb.Text, out res))
                {
                    errorProviderY.SetError(Ytb, "Value should be a real number");
                    e.Cancel = true;
                }
                else
                {
                    errorProviderY.Clear();
                }
            }
        }

        private void SurfaceArea_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(SareaTb.Text))
            {
                errorProviderSurface.SetError(SareaTb, "Value mandatory");
                e.Cancel = true;
            }
            else
            {
                float res;
                if (!float.TryParse(SareaTb.Text, out res))
                {
                    errorProviderSurface.SetError(SareaTb, "Value should be a real number");
                    e.Cancel = true;
                }
                else
                {
                    errorProviderSurface.Clear();
                }
            }
        }

        private void Color_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ColorTb.Text))
            {
                errorProviderColor.SetError(ColorTb, "Value mandatory");
                e.Cancel = true;
            }
            else
            {
                errorProviderColor.Clear();
            }
           
        }
    }
}
