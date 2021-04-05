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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FigureForm figureform = new FigureForm(null, Document.figures);
            if (figureform.ShowDialog() == DialogResult.OK)
            {
                Figure newFigure = new Figure(figureform.FigureName, figureform.FigureSurname);

                Document.AddFigure(newFigure);

                //ListViewItem item = new ListViewItem();
                //item.Tag = newStudent;
                //UpdateItem(item);
                //studentsListView.Items.Add(item);
            }
        }

        private void FigutesForm_Load(object sender, EventArgs e)
        {
            UpdateItems();
            Document.AddFigureEvent += Document_AddFigureEvent;
        }

        private void Document_AddFigureEvent(Figure obj)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = obj;
            UpdateItem(item);
            FiguresListView.Items.Add(item);
        }

        private void UpdateItem(ListViewItem item)
        {
            Figure figure = (Figure)item.Tag;
            while (item.SubItems.Count < 3)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = figure.Name;
            item.SubItems[1].Text = figure.Surname;
        }

        private void UpdateItems()
        {
            FiguresListView.Items.Clear();
            foreach (Figure figure in Document.figures)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = figure;
                UpdateItem(item);
                FiguresListView.Items.Add(item);
            }
        }
    }
}
