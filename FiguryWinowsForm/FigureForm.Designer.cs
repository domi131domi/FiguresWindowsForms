namespace FiguryWinowsForm
{
    partial class FigureForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Xtb = new System.Windows.Forms.TextBox();
            this.Ytb = new System.Windows.Forms.TextBox();
            this.LabelTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SareaTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ColorTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.figureTypeControl1 = new FiguryWinowsForm.FigureTypeControl();
            this.errorProviderX = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLabel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderY = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSurface = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderColor = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSurface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderColor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Xtb
            // 
            this.Xtb.CausesValidation = false;
            this.Xtb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Xtb.Location = new System.Drawing.Point(154, 83);
            this.Xtb.Name = "Xtb";
            this.Xtb.Size = new System.Drawing.Size(145, 22);
            this.Xtb.TabIndex = 3;
            this.Xtb.Validating += new System.ComponentModel.CancelEventHandler(this.X_Validating);
            // 
            // Ytb
            // 
            this.Ytb.CausesValidation = false;
            this.Ytb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Ytb.Location = new System.Drawing.Point(154, 137);
            this.Ytb.Name = "Ytb";
            this.Ytb.Size = new System.Drawing.Size(145, 22);
            this.Ytb.TabIndex = 4;
            this.Ytb.Validating += new System.ComponentModel.CancelEventHandler(this.Y_Validating);
            // 
            // LabelTb
            // 
            this.LabelTb.CausesValidation = false;
            this.LabelTb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelTb.Location = new System.Drawing.Point(154, 29);
            this.LabelTb.Name = "LabelTb";
            this.LabelTb.Size = new System.Drawing.Size(145, 22);
            this.LabelTb.TabIndex = 6;
            this.LabelTb.Validating += new System.ComponentModel.CancelEventHandler(this.Label_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Label:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SareaTb
            // 
            this.SareaTb.CausesValidation = false;
            this.SareaTb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SareaTb.Location = new System.Drawing.Point(154, 191);
            this.SareaTb.Name = "SareaTb";
            this.SareaTb.Size = new System.Drawing.Size(145, 22);
            this.SareaTb.TabIndex = 8;
            this.SareaTb.Validating += new System.ComponentModel.CancelEventHandler(this.SurfaceArea_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(3, 176);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(145, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "Surface Area (cm^2):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorTb
            // 
            this.ColorTb.CausesValidation = false;
            this.ColorTb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ColorTb.Location = new System.Drawing.Point(154, 245);
            this.ColorTb.Name = "ColorTb";
            this.ColorTb.Size = new System.Drawing.Size(145, 22);
            this.ColorTb.TabIndex = 10;
            this.ColorTb.Validating += new System.ComponentModel.CancelEventHandler(this.Color_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(3, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Color:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Controls.Add(this.ColorTb, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Ytb, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Xtb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SareaTb, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LabelTb, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 280);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(127, 234);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Location = new System.Drawing.Point(50, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(50, 0, 3, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.figureTypeControl1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(343, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(248, 280);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // figureTypeControl1
            // 
            this.figureTypeControl1.CausesValidation = false;
            this.figureTypeControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.figureTypeControl1.Location = new System.Drawing.Point(127, 28);
            this.figureTypeControl1.Name = "figureTypeControl1";
            this.figureTypeControl1.Size = new System.Drawing.Size(118, 99);
            this.figureTypeControl1.TabIndex = 5;
            this.figureTypeControl1.Type = FiguryWinowsForm.FigureType.Rectangle;
            // 
            // errorProviderX
            // 
            this.errorProviderX.ContainerControl = this;
            // 
            // errorProviderLabel
            // 
            this.errorProviderLabel.ContainerControl = this;
            // 
            // errorProviderY
            // 
            this.errorProviderY.ContainerControl = this;
            // 
            // errorProviderSurface
            // 
            this.errorProviderSurface.ContainerControl = this;
            // 
            // errorProviderColor
            // 
            this.errorProviderColor.ContainerControl = this;
            // 
            // FigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 280);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(609, 327);
            this.Name = "FigureForm";
            this.Text = "FigureForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSurface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Xtb;
        private System.Windows.Forms.TextBox Ytb;
        private System.Windows.Forms.TextBox LabelTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SareaTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ColorTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FigureTypeControl figureTypeControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ErrorProvider errorProviderX;
        private System.Windows.Forms.ErrorProvider errorProviderLabel;
        private System.Windows.Forms.ErrorProvider errorProviderY;
        private System.Windows.Forms.ErrorProvider errorProviderSurface;
        private System.Windows.Forms.ErrorProvider errorProviderColor;
    }
}