namespace Nograph
{
    partial class EditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FileButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.turnLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnRight90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fipVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.colorizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ResizeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutButton = new System.Windows.Forms.ToolStripButton();
            this.ToggleDrawingButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.VersionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BrushPreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.BrushSizeInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UndoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ImagePanel = new Nograph.CustomImagePanel();
            this.QuickStartPanel = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.canvasPictureBox = new System.Windows.Forms.PictureBox();
            this.colorPallete1 = new Nograph.ColorPalette();
            this.ForegroundColorPicker = new Nograph.ColorPicker();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.DrawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrushPreviewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrushSizeInput)).BeginInit();
            this.ImagePanel.SuspendLayout();
            this.QuickStartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileButton,
            this.EditButton,
            this.AboutButton,
            this.ToggleDrawingButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FileButton
            // 
            this.FileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.FileButton.Image = ((System.Drawing.Image)(resources.GetObject("FileButton.Image")));
            this.FileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(38, 22);
            this.FileButton.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // EditButton
            // 
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoButton,
            this.RedoButton,
            this.toolStripSeparator4,
            this.turnRight90ToolStripMenuItem,
            this.turnLeftToolStripMenuItem,
            this.fipVerticalToolStripMenuItem,
            this.flipHorizontalToolStripMenuItem,
            this.toolStripSeparator2,
            this.colorizeToolStripMenuItem,
            this.toolStripSeparator3,
            this.ResizeButton});
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(40, 22);
            this.EditButton.Text = "Edit";
            // 
            // turnLeftToolStripMenuItem
            // 
            this.turnLeftToolStripMenuItem.Name = "turnLeftToolStripMenuItem";
            this.turnLeftToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.turnLeftToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.turnLeftToolStripMenuItem.Text = "Turn Left 90°";
            this.turnLeftToolStripMenuItem.Click += new System.EventHandler(this.turnLeftToolStripMenuItem_Click);
            // 
            // turnRight90ToolStripMenuItem
            // 
            this.turnRight90ToolStripMenuItem.Name = "turnRight90ToolStripMenuItem";
            this.turnRight90ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.turnRight90ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.turnRight90ToolStripMenuItem.Text = "Turn Right 90°";
            this.turnRight90ToolStripMenuItem.Click += new System.EventHandler(this.turnRight90ToolStripMenuItem_Click);
            // 
            // fipVerticalToolStripMenuItem
            // 
            this.fipVerticalToolStripMenuItem.Name = "fipVerticalToolStripMenuItem";
            this.fipVerticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fipVerticalToolStripMenuItem.Text = "Flip vertical";
            this.fipVerticalToolStripMenuItem.Click += new System.EventHandler(this.fipVerticalToolStripMenuItem_Click);
            // 
            // flipHorizontalToolStripMenuItem
            // 
            this.flipHorizontalToolStripMenuItem.Name = "flipHorizontalToolStripMenuItem";
            this.flipHorizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.flipHorizontalToolStripMenuItem.Text = "Flip horizontal";
            this.flipHorizontalToolStripMenuItem.Click += new System.EventHandler(this.flipHorizontalToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // colorizeToolStripMenuItem
            // 
            this.colorizeToolStripMenuItem.Name = "colorizeToolStripMenuItem";
            this.colorizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorizeToolStripMenuItem.Text = "Colorize";
            this.colorizeToolStripMenuItem.Click += new System.EventHandler(this.colorizeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // ResizeButton
            // 
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.ResizeButton.Size = new System.Drawing.Size(180, 22);
            this.ResizeButton.Text = "Resize";
            this.ResizeButton.Click += new System.EventHandler(this.ResizeButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton.Image")));
            this.AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(44, 22);
            this.AboutButton.Text = "About";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ToggleDrawingButton
            // 
            this.ToggleDrawingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToggleDrawingButton.Image = ((System.Drawing.Image)(resources.GetObject("ToggleDrawingButton.Image")));
            this.ToggleDrawingButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToggleDrawingButton.Name = "ToggleDrawingButton";
            this.ToggleDrawingButton.Size = new System.Drawing.Size(81, 22);
            this.ToggleDrawingButton.Text = "Start drawing";
            this.ToggleDrawingButton.Click += new System.EventHandler(this.ToggleDrawingButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.VersionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(712, 17);
            this.StatusLabel.Spring = true;
            this.StatusLabel.Text = "Status: Ready";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VersionLabel
            // 
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(73, 17);
            this.VersionLabel.Text = "VersionLabel";
            // 
            // DrawPanel
            // 
            this.DrawPanel.Controls.Add(this.label7);
            this.DrawPanel.Controls.Add(this.colorPallete1);
            this.DrawPanel.Controls.Add(this.label4);
            this.DrawPanel.Controls.Add(this.BrushPreviewPictureBox);
            this.DrawPanel.Controls.Add(this.listView1);
            this.DrawPanel.Controls.Add(this.label3);
            this.DrawPanel.Controls.Add(this.BrushSizeInput);
            this.DrawPanel.Controls.Add(this.label2);
            this.DrawPanel.Controls.Add(this.ForegroundColorPicker);
            this.DrawPanel.Controls.Add(this.label1);
            this.DrawPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DrawPanel.Location = new System.Drawing.Point(0, 25);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(160, 403);
            this.DrawPanel.TabIndex = 4;
            this.DrawPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Brush";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Brush preview";
            // 
            // BrushPreviewPictureBox
            // 
            this.BrushPreviewPictureBox.BackgroundImage = global::Nograph.Properties.Resources.brushPreviewBackground;
            this.BrushPreviewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BrushPreviewPictureBox.Location = new System.Drawing.Point(12, 240);
            this.BrushPreviewPictureBox.Name = "BrushPreviewPictureBox";
            this.BrushPreviewPictureBox.Size = new System.Drawing.Size(136, 80);
            this.BrushPreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BrushPreviewPictureBox.TabIndex = 6;
            this.BrushPreviewPictureBox.TabStop = false;
            this.BrushPreviewPictureBox.MouseEnter += new System.EventHandler(this.BrushPreviewPictureBox_MouseEnter);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 31);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(154, 97);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseEnter += new System.EventHandler(this.listView1_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "px";
            // 
            // BrushSizeInput
            // 
            this.BrushSizeInput.Location = new System.Drawing.Point(45, 321);
            this.BrushSizeInput.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.BrushSizeInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BrushSizeInput.Name = "BrushSizeInput";
            this.BrushSizeInput.Size = new System.Drawing.Size(51, 20);
            this.BrushSizeInput.TabIndex = 3;
            this.BrushSizeInput.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.BrushSizeInput.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color";
            // 
            // UndoButton
            // 
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoButton.Size = new System.Drawing.Size(180, 22);
            this.UndoButton.Text = "Undo";
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoButton.Size = new System.Drawing.Size(180, 22);
            this.RedoButton.Text = "Redo";
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // ImagePanel
            // 
            this.ImagePanel.AllowDrop = true;
            this.ImagePanel.AutoScroll = true;
            this.ImagePanel.Controls.Add(this.QuickStartPanel);
            this.ImagePanel.Controls.Add(this.canvasPictureBox);
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePanel.Location = new System.Drawing.Point(160, 25);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(640, 403);
            this.ImagePanel.TabIndex = 3;
            this.ImagePanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.ImagePanel_DragDrop);
            this.ImagePanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.ImagePanel_DragEnter);
            // 
            // QuickStartPanel
            // 
            this.QuickStartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.QuickStartPanel.Controls.Add(this.listView2);
            this.QuickStartPanel.Controls.Add(this.button2);
            this.QuickStartPanel.Controls.Add(this.label5);
            this.QuickStartPanel.Controls.Add(this.label6);
            this.QuickStartPanel.Controls.Add(this.button1);
            this.QuickStartPanel.Location = new System.Drawing.Point(159, 35);
            this.QuickStartPanel.Name = "QuickStartPanel";
            this.QuickStartPanel.Size = new System.Drawing.Size(469, 316);
            this.QuickStartPanel.TabIndex = 1;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(15, 180);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(440, 72);
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(144, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Open picture";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(163, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Open a recent file?";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(15, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "What do you want to do?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(144, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Draw new image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // canvasPictureBox
            // 
            this.canvasPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasPictureBox.Location = new System.Drawing.Point(0, 0);
            this.canvasPictureBox.Name = "canvasPictureBox";
            this.canvasPictureBox.Size = new System.Drawing.Size(128, 128);
            this.canvasPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.canvasPictureBox.TabIndex = 0;
            this.canvasPictureBox.TabStop = false;
            this.canvasPictureBox.Visible = false;
            this.canvasPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.canvasPictureBox.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.canvasPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.canvasPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // colorPallete1
            // 
            this.colorPallete1.BackColor = System.Drawing.Color.Black;
            this.colorPallete1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colorPallete1.BackgroundImage")));
            this.colorPallete1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.colorPallete1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPallete1.Location = new System.Drawing.Point(32, 175);
            this.colorPallete1.Name = "colorPallete1";
            this.colorPallete1.Size = new System.Drawing.Size(96, 116);
            this.colorPallete1.TabIndex = 1;
            this.colorPallete1.Visible = false;
            this.colorPallete1.OnColorPicked += new Nograph.ColorPalette.ColorPickEvent(this.colorPalette1_OnColorPicked);
            this.colorPallete1.OnColorFocused += new Nograph.ColorPalette.ColorPickEvent(this.colorPallete1_OnColorFocused);
            // 
            // ForegroundColorPicker
            // 
            this.ForegroundColorPicker.BackColor = System.Drawing.Color.Black;
            this.ForegroundColorPicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ForegroundColorPicker.Color = System.Drawing.Color.Black;
            this.ForegroundColorPicker.Location = new System.Drawing.Point(64, 143);
            this.ForegroundColorPicker.Name = "ForegroundColorPicker";
            this.ForegroundColorPicker.Size = new System.Drawing.Size(32, 32);
            this.ForegroundColorPicker.TabIndex = 1;
            this.ForegroundColorPicker.OnColorChanged += new Nograph.ColorPicker.ColorChangedEvent(this.colorPicker1_OnColorChanged);
            this.ForegroundColorPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ForegroundColorPicker_MouseClick);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditorForm";
            this.Text = "Nograph - Image editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorForm_FormClosing);
            this.Load += new System.EventHandler(this.EditorForm_Load);
            this.ResizeEnd += new System.EventHandler(this.EditorForm_Resize);
            this.Resize += new System.EventHandler(this.EditorForm_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.DrawPanel.ResumeLayout(false);
            this.DrawPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrushPreviewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrushSizeInput)).EndInit();
            this.ImagePanel.ResumeLayout(false);
            this.QuickStartPanel.ResumeLayout(false);
            this.QuickStartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvasPictureBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton FileButton;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton EditButton;
        private System.Windows.Forms.ToolStripMenuItem turnLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnRight90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fipVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipHorizontalToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton AboutButton;
        private CustomImagePanel ImagePanel;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.ToolStripButton ToggleDrawingButton;
        private ColorPicker ForegroundColorPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown BrushSizeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox BrushPreviewPictureBox;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel VersionLabel;
        private System.Windows.Forms.ToolStripMenuItem colorizeToolStripMenuItem;
        private ColorPalette colorPallete1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ResizeButton;
        private System.Windows.Forms.Panel QuickStartPanel;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem UndoButton;
        private System.Windows.Forms.ToolStripMenuItem RedoButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

