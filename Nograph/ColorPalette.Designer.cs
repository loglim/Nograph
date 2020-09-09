namespace Nograph
{
    partial class ColorPalette
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
            this.PalleteNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PalleteNumberLabel
            // 
            this.PalleteNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PalleteNumberLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PalleteNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PalleteNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PalleteNumberLabel.Location = new System.Drawing.Point(0, 94);
            this.PalleteNumberLabel.Name = "PalleteNumberLabel";
            this.PalleteNumberLabel.Size = new System.Drawing.Size(94, 20);
            this.PalleteNumberLabel.TabIndex = 0;
            this.PalleteNumberLabel.Text = "Palette 1/3";
            this.PalleteNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PalleteNumberLabel.Click += new System.EventHandler(this.PalleteNumberLabel_Click);
            // 
            // ColorPalette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PalleteNumberLabel);
            this.Name = "ColorPalette";
            this.Size = new System.Drawing.Size(94, 114);
            this.Load += new System.EventHandler(this.ColorPalette_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ColorPallete_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPallete_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorPallete_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorPalette_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PalleteNumberLabel;
    }
}
