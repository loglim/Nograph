using System.ComponentModel;
using System.Windows.Forms;

namespace Nograph
{
    partial class ImageScale
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rateB = new System.Windows.Forms.NumericUpDown();
            this.rateA = new System.Windows.Forms.NumericUpDown();
            this.sc_aspect = new System.Windows.Forms.Label();
            this.keepAspect = new System.Windows.Forms.CheckBox();
            this.sc_info = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rateB);
            this.groupBox1.Controls.Add(this.rateA);
            this.groupBox1.Controls.Add(this.sc_aspect);
            this.groupBox1.Controls.Add(this.keepAspect);
            this.groupBox1.Controls.Add(this.sc_info);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.height);
            this.groupBox1.Controls.Add(this.width);
            this.groupBox1.Location = new System.Drawing.Point(0, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 141);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roztáhnout/zmenšit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = ":";
            // 
            // rateB
            // 
            this.rateB.Enabled = false;
            this.rateB.Location = new System.Drawing.Point(112, 80);
            this.rateB.Margin = new System.Windows.Forms.Padding(2);
            this.rateB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rateB.Name = "rateB";
            this.rateB.Size = new System.Drawing.Size(34, 20);
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
            this.rateA.Location = new System.Drawing.Point(65, 80);
            this.rateA.Margin = new System.Windows.Forms.Padding(2);
            this.rateA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rateA.Name = "rateA";
            this.rateA.Size = new System.Drawing.Size(33, 20);
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
            this.sc_aspect.Location = new System.Drawing.Point(4, 82);
            this.sc_aspect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sc_aspect.Name = "sc_aspect";
            this.sc_aspect.Size = new System.Drawing.Size(63, 13);
            this.sc_aspect.TabIndex = 6;
            this.sc_aspect.Text = "Poměr stran";
            // 
            // keepAspect
            // 
            this.keepAspect.AutoSize = true;
            this.keepAspect.Checked = true;
            this.keepAspect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keepAspect.Location = new System.Drawing.Point(4, 63);
            this.keepAspect.Margin = new System.Windows.Forms.Padding(2);
            this.keepAspect.Name = "keepAspect";
            this.keepAspect.Size = new System.Drawing.Size(130, 17);
            this.keepAspect.TabIndex = 5;
            this.keepAspect.Text = "Zachovat poměr stran";
            this.keepAspect.UseVisualStyleBackColor = true;
            this.keepAspect.CheckedChanged += new System.EventHandler(this.keepAspect_CheckedChanged);
            // 
            // sc_info
            // 
            this.sc_info.AutoSize = true;
            this.sc_info.Location = new System.Drawing.Point(4, 101);
            this.sc_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sc_info.Name = "sc_info";
            this.sc_info.Size = new System.Drawing.Size(115, 13);
            this.sc_info.TabIndex = 4;
            this.sc_info.Text = "Nová velikost = 0x0 px";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "px";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "px";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 117);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 19);
            this.button5.TabIndex = 2;
            this.button5.Text = "Roztáhnout fotografii";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(4, 40);
            this.height.Margin = new System.Windows.Forms.Padding(2);
            this.height.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(117, 20);
            this.height.TabIndex = 1;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.height.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(4, 17);
            this.width.Margin = new System.Windows.Forms.Padding(2);
            this.width.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(117, 20);
            this.width.TabIndex = 0;
            this.width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.width.ValueChanged += new System.EventHandler(this.width_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 20);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 19);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImageScale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ImageScale";
            this.Size = new System.Drawing.Size(148, 161);
            this.Load += new System.EventHandler(this.ImageScale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label sc_info;
        private Label label3;
        private Label label2;
        private Button button5;
        private NumericUpDown height;
        private NumericUpDown width;
        private Panel panel1;
        private Button button1;
        private CheckBox keepAspect;
        private Label sc_aspect;
        private Label label1;
        private NumericUpDown rateB;
        private NumericUpDown rateA;
    }
}
