namespace Nograph
{
    partial class ResizeDialog
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
            this.rateB = new System.Windows.Forms.NumericUpDown();
            this.rateA = new System.Windows.Forms.NumericUpDown();
            this.sc_aspect = new System.Windows.Forms.Label();
            this.keepAspect = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HeightInput = new System.Windows.Forms.NumericUpDown();
            this.WidthInput = new System.Windows.Forms.NumericUpDown();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rateB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(174, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = ":";
            // 
            // rateB
            // 
            this.rateB.Enabled = false;
            this.rateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rateB.Location = new System.Drawing.Point(191, 97);
            this.rateB.Margin = new System.Windows.Forms.Padding(2);
            this.rateB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rateB.Name = "rateB";
            this.rateB.Size = new System.Drawing.Size(44, 26);
            this.rateB.TabIndex = 7;
            this.rateB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rateA
            // 
            this.rateA.Enabled = false;
            this.rateA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rateA.Location = new System.Drawing.Point(126, 97);
            this.rateA.Margin = new System.Windows.Forms.Padding(2);
            this.rateA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rateA.Name = "rateA";
            this.rateA.Size = new System.Drawing.Size(44, 26);
            this.rateA.TabIndex = 7;
            this.rateA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sc_aspect
            // 
            this.sc_aspect.AutoSize = true;
            this.sc_aspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sc_aspect.Location = new System.Drawing.Point(75, 99);
            this.sc_aspect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sc_aspect.Name = "sc_aspect";
            this.sc_aspect.Size = new System.Drawing.Size(47, 20);
            this.sc_aspect.TabIndex = 6;
            this.sc_aspect.Text = "Ratio";
            // 
            // keepAspect
            // 
            this.keepAspect.AutoSize = true;
            this.keepAspect.Checked = true;
            this.keepAspect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keepAspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keepAspect.Location = new System.Drawing.Point(90, 43);
            this.keepAspect.Margin = new System.Windows.Forms.Padding(2);
            this.keepAspect.Name = "keepAspect";
            this.keepAspect.Size = new System.Drawing.Size(152, 24);
            this.keepAspect.TabIndex = 5;
            this.keepAspect.Text = "Keep aspect ratio";
            this.keepAspect.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "New size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(175, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(282, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "px";
            // 
            // HeightInput
            // 
            this.HeightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeightInput.Location = new System.Drawing.Point(197, 12);
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
            this.HeightInput.TabIndex = 17;
            this.HeightInput.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.HeightInput.ValueChanged += new System.EventHandler(this.HeightInput_ValueChanged);
            // 
            // WidthInput
            // 
            this.WidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WidthInput.Location = new System.Drawing.Point(90, 12);
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
            this.WidthInput.TabIndex = 16;
            this.WidthInput.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.WidthInput.ValueChanged += new System.EventHandler(this.WidthInput_ValueChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(12, 151);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(226, 151);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 13;
            this.OkButton.Text = "Resize";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // ResizeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 183);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rateB);
            this.Controls.Add(this.rateA);
            this.Controls.Add(this.sc_aspect);
            this.Controls.Add(this.keepAspect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "ResizeDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resize image";
            ((System.ComponentModel.ISupportInitialize)(this.rateB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown rateB;
        private System.Windows.Forms.NumericUpDown rateA;
        private System.Windows.Forms.Label sc_aspect;
        private System.Windows.Forms.CheckBox keepAspect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown HeightInput;
        private System.Windows.Forms.NumericUpDown WidthInput;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
    }
}