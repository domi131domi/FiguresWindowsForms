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
    public partial class MainForm : Form
    {
        FiguresDocument document = new FiguresDocument();

        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FiguresForm figuresForm = new FiguresForm(document);
            figuresForm.MdiParent = this;
            figuresForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void noweOknoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton1_Click(sender, e);
        }
    }
}
