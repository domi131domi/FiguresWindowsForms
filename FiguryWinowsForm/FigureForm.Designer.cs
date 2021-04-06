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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Xtb = new System.Windows.Forms.TextBox();
            this.Ytb = new System.Windows.Forms.TextBox();
            this.figureTypeControl1 = new FiguryWinowsForm.FigureTypeControl();
            this.LabelTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SareaTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ColorTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Xtb
            // 
            this.Xtb.Location = new System.Drawing.Point(65, 31);
            this.Xtb.Name = "Xtb";
            this.Xtb.Size = new System.Drawing.Size(100, 22);
            this.Xtb.TabIndex = 3;
            // 
            // Ytb
            // 
            this.Ytb.Location = new System.Drawing.Point(65, 73);
            this.Ytb.Name = "Ytb";
            this.Ytb.Size = new System.Drawing.Size(100, 22);
            this.Ytb.TabIndex = 4;
            // 
            // figureTypeControl1
            // 
            this.figureTypeControl1.Location = new System.Drawing.Point(65, 115);
            this.figureTypeControl1.Name = "figureTypeControl1";
            this.figureTypeControl1.Size = new System.Drawing.Size(100, 100);
            this.figureTypeControl1.TabIndex = 5;
            // 
            // LabelTb
            // 
            this.LabelTb.Location = new System.Drawing.Point(379, 160);
            this.LabelTb.Name = "LabelTb";
            this.LabelTb.Size = new System.Drawing.Size(100, 22);
            this.LabelTb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Label";
            // 
            // SareaTb
            // 
            this.SareaTb.Location = new System.Drawing.Point(397, 73);
            this.SareaTb.Name = "SareaTb";
            this.SareaTb.Size = new System.Drawing.Size(100, 22);
            this.SareaTb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Surface Area";
            // 
            // ColorTb
            // 
            this.ColorTb.Location = new System.Drawing.Point(361, 217);
            this.ColorTb.Name = "ColorTb";
            this.ColorTb.Size = new System.Drawing.Size(100, 22);
            this.ColorTb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Color";
            // 
            // FigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 288);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ColorTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SareaTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelTb);
            this.Controls.Add(this.figureTypeControl1);
            this.Controls.Add(this.Ytb);
            this.Controls.Add(this.Xtb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FigureForm";
            this.Text = "FigureForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Xtb;
        private System.Windows.Forms.TextBox Ytb;
        private FigureTypeControl figureTypeControl1;
        private System.Windows.Forms.TextBox LabelTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SareaTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ColorTb;
        private System.Windows.Forms.Label label5;
    }
}