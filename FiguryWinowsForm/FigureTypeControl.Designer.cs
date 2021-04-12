namespace FiguryWinowsForm
{
    partial class FigureTypeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Typebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Typebtn
            // 
            this.Typebtn.BackgroundImage = global::FiguryWinowsForm.Properties.Resources.circle;
            this.Typebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Typebtn.Location = new System.Drawing.Point(10, 10);
            this.Typebtn.Name = "Typebtn";
            this.Typebtn.Size = new System.Drawing.Size(80, 80);
            this.Typebtn.TabIndex = 0;
            this.Typebtn.UseVisualStyleBackColor = true;
            this.Typebtn.Click += new System.EventHandler(this.Button_Click);
            // 
            // FigureTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Typebtn);
            this.Name = "FigureTypeControl";
            this.Size = new System.Drawing.Size(100, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Typebtn;
    }
}
