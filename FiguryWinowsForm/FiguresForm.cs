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

        private FiguresDocument Document { get; }

        public FiguresForm(FiguresDocument document)
        {
            Document = document;
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FigureForm figureform = new FigureForm(null);
            if (figureform.ShowDialog() == DialogResult.OK)
            {
                Figure newFigure = new Figure(figureform.Color, figureform.Type, figureform.X, figureform.Y, figureform.SurfaceArea, figureform.Label);

                Document.AddFigure(newFigure);

            }
        }

        private void FigutesForm_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 0;
            UpdateItems();
            Document.AddFigureEvent += Document_AddFigureEvent;
            Document.UpdateFigureEvent += Document_UpdateFigureEvent;
            Document.RemoveFigureEvent += Document_RemoveFigureEvent;
            UpdateCommandAvailability();

        }

        private void UpdateCommandAvailability()
        {
            editToolStripMenuItem.Enabled = FiguresListView.SelectedItems.Count == 1;
            toolStripButtonDelete.Enabled = FiguresListView.SelectedItems.Count > 0;
            toolStripButtonEdit.Enabled = FiguresListView.SelectedItems.Count == 1;
            removeToolStripMenuItem.Enabled = FiguresListView.SelectedItems.Count > 0;
            toolStripButtonEdit.Enabled = FiguresListView.SelectedItems.Count == 1;
            ToolStripMenuItemDelete.Enabled = FiguresListView.SelectedItems.Count > 0;
        }

        private void Document_RemoveFigureEvent(Figure obj)
        {
            foreach (ListViewItem item in FiguresListView.Items)
            {
                if (ReferenceEquals(item.Tag, obj))
                {
                    FiguresListView.Items.Remove(item);
                    UpdateFiguresCount();
                    return;
                }
            }
        }

        private void Document_UpdateFigureEvent(Figure obj)
        {
            foreach (ListViewItem item in FiguresListView.Items)
            {
                if (ReferenceEquals(item.Tag, obj))
                {
                    if (isFigureVisible(obj))
                    {
                        UpdateItem(item);
                    }
                    else
                    {
                        FiguresListView.Items.Remove(item);
                        UpdateFiguresCount();
                    }
                    return;
                }
            }
        }

        private bool isFigureVisible(Figure figure)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                return true;
            }
            else if (toolStripComboBox1.SelectedIndex == 1)
            {
                return figure.surfaceArea < 100;
            }
            else if (toolStripComboBox1.SelectedIndex == 2)
            {
                return figure.surfaceArea >= 100;
            }
            else
            {
                throw new Exception("Invalid filter");
            }
        }

        private void Document_AddFigureEvent(Figure obj)
        {
            if (isFigureVisible(obj))
            {
                ListViewItem item = new ListViewItem();
                item.Tag = obj;
                UpdateItem(item);
                FiguresListView.Items.Add(item);
                UpdateFiguresCount();
            }
        }

        private void UpdateFiguresCount()
        {
            statusStrip.Text = FiguresListView.Items.Count.ToString();
        }

        private void UpdateItem(ListViewItem item)
        {
            Figure figure = (Figure)item.Tag;
            while (item.SubItems.Count < 6)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = figure.type.ToString();
            item.SubItems[1].Text = figure.x.ToString();
            item.SubItems[2].Text = figure.y.ToString();
            item.SubItems[3].Text = figure.surfaceArea.ToString();
            item.SubItems[4].Text = figure.color;
            item.SubItems[5].Text = figure.label;
        }

        private void UpdateItems()
        {
            FiguresListView.Items.Clear();
            foreach (Figure figure in Document.figures)
            {
                if (isFigureVisible(figure))
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = figure;
                    UpdateItem(item);
                    FiguresListView.Items.Add(item);
                }
            }
            UpdateFiguresCount();
        }

        private void FiguresForm_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(toolStrip, ((MainForm)MdiParent).toolStrip);
            ToolStripManager.Merge(statusStrip, ((MainForm)MdiParent).statusStrip);
        }

        private void FiguresForm_Deactivated(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)MdiParent).toolStrip, toolStrip);
            ToolStripManager.RevertMerge(((MainForm)MdiParent).statusStrip, statusStrip);
        }

        private void FiguresForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCommandAvailability();
        }

        private void Filter_change(object sender, EventArgs e)
        {
            UpdateItems();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem_Click(sender, e);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Figure> toDel = new List<Figure>();
            foreach (ListViewItem item in FiguresListView.SelectedItems)
            {
                for (int i = Document.figures.Count - 1; i >= 0; i--)
                {
                    if (ReferenceEquals(item.Tag, Document.figures[i]))
                    {
                        Document.RemoveFigure(Document.figures[i]);
                    }
                }

            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            removeToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in FiguresListView.SelectedItems)
            {
                foreach (Figure figure in Document.figures)
                {
                    if (ReferenceEquals(item.Tag, figure))
                    {
                        FigureForm figureform = new FigureForm(figure);
                        if (figureform.ShowDialog() == DialogResult.OK)
                        {
                            figure.color = figureform.Color;
                            figure.label = figureform.Label;
                            figure.x = figureform.X;
                            figure.y = figureform.Y;
                            figure.type = figureform.Type;
                            figure.surfaceArea = figureform.SurfaceArea;
                            Document.UpdateFigure(figure);
                        }
                    }
                }

            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonEdit_Click(sender, e);
        }

        private void Double_click_edit(object sender, EventArgs e)
        {
            if(FiguresListView.SelectedItems.Count == 1)
            {
                toolStripButtonEdit_Click(sender, e);
            }
        }

        private void ToolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem_Click(sender, e);
        }

        private void ToolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            toolStripButtonEdit_Click(sender, e);
        }

        private void ToolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            removeToolStripMenuItem_Click(sender, e);
        }
    }
}
