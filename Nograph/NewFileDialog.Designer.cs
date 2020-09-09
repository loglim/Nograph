namespace Nograph
{
    partial class NewFileDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFileDialog));
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WidthInput = new System.Windows.Forms.NumericUpDown();
            this.HeightInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TransparentBackgroundcheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorPicker1 = new Nograph.ColorPicker();
            this.colorPalette1 = new Nograph.ColorPalette();
            ((System.ComponentModel.ISupportInitialize)(this.WidthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightInput)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(217, 118);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Create";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(12, 118);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size";
            // 
            // WidthInput
            // 
            this.WidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WidthInput.Location = new System.Drawing.Point(64, 66);
            this.WidthInput.Maximum = new decimal(new int[] {
            25600,
            0,
            0,
            0});
            this.WidthInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(79, 26);
            this.WidthInput.TabIndex = 5;
            this.WidthInput.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // HeightInput
            // 
            this.HeightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeightInput.Location = new System.Drawing.Point(171, 66);
            this.HeightInput.Maximum = new decimal(new int[] {
            25600,
            0,
            0,
            0});
            this.HeightInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(79, 26);
            this.HeightInput.TabIndex = 6;
            this.HeightInput.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(256, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "px";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(15, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Background";
            // 
            // TransparentBackgroundcheckBox
            // 
            this.TransparentBackgroundcheckBox.AutoSize = true;
            this.TransparentBackgroundcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TransparentBackgroundcheckBox.Location = new System.Drawing.Point(171, 12);
            this.TransparentBackgroundcheckBox.Name = "TransparentBackgroundcheckBox";
            this.TransparentBackgroundcheckBox.Size = new System.Drawing.Size(118, 24);
            this.TransparentBackgroundcheckBox.TabIndex = 11;
            this.TransparentBackgroundcheckBox.Text = "Transparent ";
            this.TransparentBackgroundcheckBox.UseVisualStyleBackColor = true;
            this.TransparentBackgroundcheckBox.CheckedChanged += new System.EventHandler(this.TransparentBackgroundcheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(149, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "x";
            // 
            // colorPicker1
            // 
            this.colorPicker1.BackColor = System.Drawing.Color.White;
            this.colorPicker1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorPicker1.Color = System.Drawing.Color.White;
            this.colorPicker1.Location = new System.Drawing.Point(122, 12);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Size = new System.Drawing.Size(32, 32);
            this.colorPicker1.TabIndex = 10;
            this.colorPicker1.OnColorChanged += new Nograph.ColorPicker.ColorChangedEvent(this.colorPicker1_OnColorChanged);
            this.colorPicker1.Click += new System.EventHandler(this.colorPicker1_Click);
            // 
            // colorPalette1
            // 
            this.colorPalette1.BackColor = System.Drawing.Color.Black;
            this.colorPalette1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colorPalette1.BackgroundImage")));
            this.colorPalette1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPalette1.Location = new System.Drawing.Point(91, 36);
            this.colorPalette1.Name = "colorPalette1";
            this.colorPalette1.Size = new System.Drawing.Size(94, 114);
            this.colorPalette1.TabIndex = 13;
            this.colorPalette1.Visible = false;
            this.colorPalette1.OnColorPicked += new Nograph.ColorPalette.ColorPickEvent(this.colorPalette1_OnColorPicked);
            this.colorPalette1.OnColorFocused += new Nograph.ColorPalette.ColorPickEvent(this.colorPalette1_OnColorFocused);
            // 
            // NewFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 152);
            this.Controls.Add(this.colorPalette1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransparentBackgroundcheckBox);
            this.Controls.Add(this.colorPicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewFileDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New image";
            this.Load += new System.EventHandler(this.NewFileDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WidthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown WidthInput;
        private System.Windows.Forms.NumericUpDown HeightInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private ColorPicker colorPicker1;
        private System.Windows.Forms.CheckBox TransparentBackgroundcheckBox;
        private System.Windows.Forms.Label label2;
        private ColorPalette colorPalette1;
    }
}