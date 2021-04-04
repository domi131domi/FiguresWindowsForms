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
    public partial class FiguresForm : Form
    {

        private Document Document { get; set; }

        public FiguresForm(Document document)
        {
            InitializeComponent();
            Document = document;
        }
    }
}
