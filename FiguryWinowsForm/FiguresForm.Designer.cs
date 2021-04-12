namespace FiguryWinowsForm
{
    partial class FiguresForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiguresForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiguresListView = new System.Windows.Forms.ListView();
            this.ColumnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLabel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edycjaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(543, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.Visible = false;
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAdd,
            this.ToolStripMenuItemEdit,
            this.ToolStripMenuItemDelete});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // ToolStripMenuItemAdd
            // 
            this.ToolStripMenuItemAdd.Name = "ToolStripMenuItemAdd";
            this.ToolStripMenuItemAdd.Size = new System.Drawing.Size(133, 26);
            this.ToolStripMenuItemAdd.Text = "Dodaj";
            // 
            // ToolStripMenuItemEdit
            // 
            this.ToolStripMenuItemEdit.Name = "ToolStripMenuItemEdit";
            this.ToolStripMenuItemEdit.Size = new System.Drawing.Size(133, 26);
            this.ToolStripMenuItemEdit.Text = "Edytuj";
            // 
            // ToolStripMenuItemDelete
            // 
            this.ToolStripMenuItemDelete.Name = "ToolStripMenuItemDelete";
            this.ToolStripMenuItemDelete.Size = new System.Drawing.Size(133, 26);
            this.ToolStripMenuItemDelete.Text = "Usuń";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonDelete,
            this.toolStripComboBox1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(543, 47);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.Visible = false;
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(54, 44);
            this.toolStripButtonAdd.Text = "Dodaj";
            this.toolStripButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(54, 44);
            this.toolStripButtonEdit.Text = "Edytuj";
            this.toolStripButtonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(45, 44);
            this.toolStripButtonDelete.Text = "Usuń";
            this.toolStripButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "No filters",
            "Surface area < 100",
            "Surface area >= 100"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(150, 47);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.Filter_change);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(120, 76);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.addToolStripMenuItem.Text = "Dodaj";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.editToolStripMenuItem.Text = "Edytuj";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.removeToolStripMenuItem.Text = "Usuń";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // FiguresListView
            // 
            this.FiguresListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderType,
            this.ColumnHeaderX,
            this.columnHeaderY,
            this.columnHeaderSA,
            this.columnHeaderLabel,
            this.columnHeaderColor});
            this.FiguresListView.ContextMenuStrip = this.contextMenuStrip;
            this.FiguresListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiguresListView.HideSelection = false;
            this.FiguresListView.Location = new System.Drawing.Point(0, 0);
            this.FiguresListView.Name = "FiguresListView";
            this.FiguresListView.Size = new System.Drawing.Size(543, 327);
            this.FiguresListView.TabIndex = 3;
            this.FiguresListView.UseCompatibleStateImageBehavior = false;
            this.FiguresListView.View = System.Windows.Forms.View.Details;
            this.FiguresListView.SelectedIndexChanged += new System.EventHandler(this.FiguresForm_SelectedIndexChanged);
            // 
            // ColumnHeaderType
            // 
            this.ColumnHeaderType.Tag = "";
            this.ColumnHeaderType.Text = "Type";
            this.ColumnHeaderType.Width = 80;
            // 
            // ColumnHeaderX
            // 
            this.ColumnHeaderX.Text = "X";
            this.ColumnHeaderX.Width = 90;
            // 
            // columnHeaderY
            // 
            this.columnHeaderY.Text = "Y";
            // 
            // columnHeaderSA
            // 
            this.columnHeaderSA.Text = "Surface Area";
            this.columnHeaderSA.Width = 100;
            // 
            // columnHeaderLabel
            // 
            this.columnHeaderLabel.DisplayIndex = 5;
            this.columnHeaderLabel.Text = "Label";
            this.columnHeaderLabel.Width = 120;
            // 
            // columnHeaderColor
            // 
            this.columnHeaderColor.DisplayIndex = 4;
            this.columnHeaderColor.Text = "Color";
            this.columnHeaderColor.Width = 90;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 303);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(543, 24);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // FiguresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 327);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.FiguresListView);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FiguresForm";
            this.Text = "FiguresForm";
            this.Activated += new System.EventHandler(this.FiguresForm_Activated);
            this.Deactivate += new System.EventHandler(this.FiguresForm_Deactivated);
            this.Load += new System.EventHandler(this.FigutesForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAdd;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ListView FiguresListView;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader ColumnHeaderType;
        private System.Windows.Forms.ColumnHeader ColumnHeaderX;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ColumnHeader columnHeaderY;
        private System.Windows.Forms.ColumnHeader columnHeaderSA;
        private System.Windows.Forms.ColumnHeader columnHeaderLabel;
        private System.Windows.Forms.ColumnHeader columnHeaderColor;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelete;
    }
}