using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nograph
{
    public partial class EditorForm : Form
    {
        // Constants
        private const float ZoomMin = 0.1f;
        private const float ZoomMax = 32f;
        private const string DefaultFileName = "canvas01.png";

        // Private
        private readonly string[] _supportedExtensions = {"*", "jpg", "png", "bmp", "gif", "ico"};
        private readonly string _fileFilter;
        private Bitmap _canvas;
        private Graphics _graphics;

        private int _lastX = -1;
        private int _lastY = -1;
        private int _mouseOriginX = -1;
        private int _mouseOriginY = -1;
        private Brush _activeBrush;
        private Pen _activePen;
        private int _brushRadius;
        private Image _sourceBrush;
        private Image _activeBrushImage;
        private float _zoom = 1f;
        private Size _lastRefreshSize;
        private bool _hasCanvasChanged;
        private int _lastScrollX;
        private int _lastScrollY;
        private bool _unsavedChanges;
        private string _activePath;
        private string _activeFilename;

        // Input modifiers
        private bool _isMouseDown;

        private enum EditMode
        {
            Empty,
            HideAll,
            View,
            Draw
        }

        private EditMode _editMode;
        private EditMode _lastMode;

        private EditMode Mode
        {
            get => _editMode;
            set
            {
                _lastMode = _editMode;
                _editMode = value;
                var showDrawPanel = false;
                var showCanvas = false;
                var showQuickStart = false;
                var showEditButton = true;
                var showToggleDrawingButton = true;
                switch (value)
                {
                    case EditMode.Empty:
                        showQuickStart = true;
                        showEditButton = false;
                        showToggleDrawingButton = false;
                        break;
                    case EditMode.View:
                        showCanvas = true;
                        break;
                    case EditMode.Draw:
                        showCanvas = true;
                        showDrawPanel = true;
                        UpdateBrush();
                        //RefreshCanvas(false);
                        break;
                    case EditMode.HideAll:
                        showEditButton = false;
                        showToggleDrawingButton = false;
                        break;
                }

                QuickStartPanel.Visible = showQuickStart;
                DrawPanel.Visible = showDrawPanel;
                canvasPictureBox.Visible = showCanvas;
                EditButton.Visible = showEditButton;
                ToggleDrawingButton.Visible = showToggleDrawingButton;
                ToggleDrawingButton.Text = showDrawPanel ? "View" : "Draw";
            }
        }

        private void RestoreLastMode()
        {
            Mode = _lastMode;
        }

        public EditorForm()
        {
            InitializeComponent();

            // Create file filter from supported extensions
            _fileFilter = _supportedExtensions
                .Aggregate("", (current, extension) => $"{current}|{extension.ToUpper()} file|*.{extension}")
                .Substring(1);
        }

        private void EditorForm_Load(object sender, EventArgs e)
        {
            canvasPictureBox.MouseWheel += CanvasPictureBoxMouseWheel;
            canvasPictureBox.MouseClick += CanvasPictureBoxMouseClick;
            BrushPreviewPictureBox.MouseWheel += BrushPreviewPictureBox_MouseWheel;
            listView1.MouseWheel += ListView1_MouseWheel;

            // Generate previews for brushes
            var il = new ImageList();
            il.Images.AddRange(BrushLibrary.Brushes);

            listView1.SmallImageList = il;
            //listView1.LargeImageList = il;
            for (var i = 0; i < il.Images.Count; i++)
            {
                var brushName = $"Brush {i + 1}";
                listView1.Items.Add(brushName, brushName, i);
            }

            listView1.Items[0].Selected = true;

            // Update version label
            VersionLabel.Text = $"v.{Assembly.GetExecutingAssembly().GetName().Version}";

            // TODO: Persist choice to disable
            //runLater(1);

            Mode = EditMode.Empty;

            var args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                var path = args[1];
                LoadImage(path);
            }
        }

        private async Task runLater(int delay)
        {
            await Task.Delay(delay * 1000);
            new SplashForm().Show(this);
        }

        private void ListView1_MouseWheel(object sender, MouseEventArgs e)
        {
            /*var pos = listView1.SelectedItems[0].Index;
            listView1.Items[pos].Selected = false;
            pos += Math.Sign(e.Delta);
            if (pos < 0)
                pos = listView1.SelectedItems.Count;
            else if (pos >= listView1.SelectedItems.Count)
                pos = 0;
            listView1.Items[pos].Selected = true;*/
        }

        private void BrushPreviewPictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            const int brushResizeSpeed = 3;
            var newSize = BrushSizeInput.Value + Math.Sign(e.Delta) * brushResizeSpeed;
            BrushSizeInput.Value = newSize.Clamp(BrushSizeInput.Minimum, BrushSizeInput.Maximum);
        }

        private void RefreshCanvas(bool refreshGraphics)
        {
            if (refreshGraphics)
            {
                _graphics = Graphics.FromImage(_canvas);
            }

            canvasPictureBox.Image = _canvas;
            if (_hasCanvasChanged)
            {
                _hasCanvasChanged = false;
                _unsavedChanges = true;
            }

            var size = new Size((int) (_zoom * _canvas.Width), (int) (_zoom * _canvas.Height));
            if (size != _lastRefreshSize)
            {
                canvasPictureBox.Size = size;
                _lastRefreshSize = canvasPictureBox.Size;
                canvasPictureBox.Focus();
            }

            SetStatus($"Zoom @ {Math.Round(_zoom * 100)}% | Size {_canvas.Width} x {_canvas.Height} px");
            //canvasPictureBox.Size = _canvas.Size;
            //canvasPictureBox.BringToFront();
        }

        private void ZoomToSize()
        {
            var aspX = (double) ImagePanel.Width / _canvas.Width;
            var aspY = (double) ImagePanel.Height / _canvas.Height;
            _zoom = (float) (aspX > aspY ? aspX : aspY);
            RefreshCanvas(false);
        }

        private string LoadImage(string path)
        {
            CheckUnsavedChanges();
            if (!File.Exists(path)) return "File does not exist!";

            if (!IsFileSupported(path)) return "File is not supported!";

            try
            {
                CloseImage();
                _canvas = Utils.LoadBitmap(path);
                RefreshCanvas(true);
                ZoomToSize();
                UpdateFileInfo(path);
                Mode = EditMode.View;
                _unsavedChanges = false;
                return $"Successfully loaded file {path}";
            }
            catch (Exception)
            {
                return $"err: Can't open file {path}";
            }
        }

        /**
         * Cleanup image resources
         */
        private void CloseImage()
        {
            _canvas?.Dispose();
            _graphics?.Dispose();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void NewFile()
        {
            CheckUnsavedChanges();
            using (var dialog = new NewFileDialog())
            {
                Mode = EditMode.HideAll;
                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    RestoreLastMode();
                    return;
                }

                CloseImage();
                _canvas = new Bitmap(dialog.ImageWidth, dialog.ImageHeight);
                _hasCanvasChanged = true;
                _unsavedChanges = false;
                RefreshCanvas(true);
                _graphics.Clear(dialog.TransparentBackground ? Color.Empty : dialog.BackgroundColor);
                _graphics.SmoothingMode = SmoothingMode.Default;
                _graphics.InterpolationMode = InterpolationMode.Default;
                _activePath = null;
                _activeFilename = DefaultFileName;
                Mode = EditMode.Draw;
            }
        }

        private void OpenFile()
        {
            using (var dialog = new OpenFileDialog { Filter = _fileFilter })
            {
                Mode = EditMode.HideAll;
                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    RestoreLastMode();
                    return;
                }

                LoadImage(dialog.FileName);
                Mode = EditMode.View;
            }
        }

        private bool SaveFile(string path = null)
        {
            if (path == null)
            {
                if (_activePath == null)
                {
                    return SaveFileAs();
                }

                path = Path.Combine(_activePath, _activeFilename);
            }

            var ext = path.Substring(path.Length - 3);
            var quality = 1L;
            var format = ImageFormat.Jpeg;
            switch (ext)
            {
                // TODO: Mingle with the output (input?) quality
                case "jpg":
                {
                    quality = 95L;
                    format = ImageFormat.Jpeg;
                    break;
                }
                case "png":
                {
                    quality = 1L;
                    format = ImageFormat.Png;
                    break;
                }
                case "bmp":
                {
                    quality = 1L;
                    format = ImageFormat.Bmp;
                    break;
                }
                case "gif":
                {
                    quality = 1L;
                    format = ImageFormat.Gif;
                    break;
                }
                case "ico":
                {
                    quality = 1L;
                    format = ImageFormat.Icon;
                    break;
                }
            }

            try
            {
                _canvas.Save(path, GetEncoder(format), new EncoderParameters(1)
                {
                    Param = {[0] = new EncoderParameter(Encoder.Quality, quality)}
                });
                UpdateFileInfo(path);
                _unsavedChanges = false;
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show($"err: Cannot save file!", "Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void UpdateFileInfo(string path)
        {
            var fi = new FileInfo(path);
            _activeFilename = fi.Name;
            _activePath = fi.DirectoryName;
        }

        private bool SaveFileAs()
        {
            using (var dialog = new SaveFileDialog {Filter = _fileFilter})
            {
                dialog.InitialDirectory = _activePath;
                dialog.FileName = _activeFilename;
                if (dialog.ShowDialog(this) != DialogResult.OK) return false;

                if (SaveFile(dialog.FileName))
                {
                    SetStatus($"Saved as {dialog.FileName}");
                    return true;
                }
            }

            return false;
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().FirstOrDefault(codec => codec.FormatID == format.Guid);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckUnsavedChanges();
            Close();
        }

        private void turnLeftToolStripMenuItem_Click(object sender, EventArgs e) => ApplyRotateFlip(RotateFlipType.Rotate270FlipNone);

        private void turnRight90ToolStripMenuItem_Click(object sender, EventArgs e) => ApplyRotateFlip(RotateFlipType.Rotate90FlipNone);

        private void fipVerticalToolStripMenuItem_Click(object sender, EventArgs e) => ApplyRotateFlip(RotateFlipType.RotateNoneFlipY);

        private void flipHorizontalToolStripMenuItem_Click(object sender, EventArgs e) => ApplyRotateFlip(RotateFlipType.RotateNoneFlipX);

        private void ApplyRotateFlip(RotateFlipType type)
        {
            _canvas.RotateFlip(type);
            _unsavedChanges = true;
            RefreshCanvas(true);
        }

        private void CanvasPictureBoxMouseClick(object sender, MouseEventArgs e) => canvasPictureBox.Focus();

        private void CanvasPictureBoxMouseWheel(object sender, MouseEventArgs e)
        {
            /*var targetValue = ImagePanel.HorizontalScroll.Value + e.Delta / 10;
            
            if (targetValue < 0) return;

            if (targetValue > 100) return;*/

            var change = 0.1f;
            if (_zoom > 2)
            {
                change = 0.2f;
            }

            if (_zoom > 3)
            {
                change = 0.25f;
            }

            if (_zoom > 4)
            {
                change = 0.4f;
            }

            if (_zoom > 8)
            {
                change = 0.6f;
            }

            _zoom = (Math.Sign(e.Delta) * change + _zoom).Clamp(ZoomMin, ZoomMax);
            if (_zoom > 0.9f && _zoom < 1.1f)
            {
                _zoom = 1f;
            }

            RefreshCanvas(false);
            var x = ImagePanel.AutoScrollOffset;
            x.X += e.X > canvasPictureBox.Width / 2 ? 1 : -1;
            ImagePanel.AutoScrollOffset = x;

            if (Mode == EditMode.Draw)
            {
                UpdateBrush();
            }

            //panel1.HorizontalScroll.Value = targetValue;
            //panel1.VerticalScroll.Value += e.Delta;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e) => canvasPictureBox.Focus();

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                _lastScrollX = 0;
                _lastScrollY = 0;
                ZoomToSize();
                RefreshCanvas(false);
                return;
            }

            _isMouseDown = true;
            _mouseOriginX = MousePosition.X;
            _mouseOriginY = MousePosition.Y;
            _lastScrollX = ImagePanel.HorizontalScroll.Value;
            _lastScrollY = ImagePanel.VerticalScroll.Value;

            if (Mode != EditMode.Draw) return;
            _lastX = (int) (e.X / _zoom);
            _lastY = (int) (e.Y / _zoom);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;

            if (Mode != EditMode.Draw) return;
            _lastX = -1;
            _lastY = -1;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mode == EditMode.View || (Mode == EditMode.Draw && e.Button == MouseButtons.Right))
            {
                if (_zoom > 1)
                {
                    canvasPictureBox.Cursor = Cursors.Hand;
                    if (_isMouseDown)
                    {
                        ImagePanel.HorizontalScroll.Value =
                            (_lastScrollX + _mouseOriginX - MousePosition.X).Clamp(0, (int) (_canvas.Width * _zoom));
                        ImagePanel.VerticalScroll.Value =
                            (_lastScrollY + _mouseOriginY - MousePosition.Y).Clamp(0, (int) (_canvas.Height * _zoom));
                        //canvasPictureBox.Top = e.Y;
                    }
                }
                else
                {
                    canvasPictureBox.Cursor = Cursors.Arrow;
                }

                return;
            }
            else
            {
                canvasPictureBox.Cursor = Cursors.Arrow;
            }

            if (Mode != EditMode.Draw || !_isMouseDown) return;

            var x = (int) (e.X / _zoom);
            var y = (int) (e.Y / _zoom);

            // Interpolate greater steps
            if (_lastX + _lastY >= 0)
            {
                // Line interpolation
                //_graphics.DrawLine(_activePen, _lastX, _lastY, e.X, e.Y);

                // Linear interpolation between two points
                var distance = Math.Sqrt(Math.Pow(_lastX - x, 2) + Math.Pow(_lastY - y, 2));
                if (distance > _brushRadius / 5) // Brush interpolation intensity
                {
                    var hDiff = ((double) x - _lastX) / distance;
                    var vDiff = ((double) y - _lastY) / distance;
                    for (var i = 0; i < distance; i++)
                    {
                        DrawBrushAtPoint((int) (_lastX + i * hDiff), (int) (_lastY + i * vDiff));
                    }
                }
            }

            // Update last position
            _lastX = x;
            _lastY = y;

            //_graphics.FillEllipse(_activeBrush, e.X - _brushRadius, e.Y - _brushRadius, _brushRadius * 2,
            //    _brushRadius * 2);

            DrawBrushAtPoint(x, y);

            //_graphics.Save();
            RefreshCanvas(false);
        }

        private void DrawBrushAtPoint(int x, int y)
        {
            var b = _activeBrushImage;
            _graphics.DrawImage(b, x - _brushRadius / 2, y - _brushRadius / 2, _brushRadius, _brushRadius);
            _hasCanvasChanged = true;
        }

        private void UpdateBrush()
        {
            _brushRadius = (int) BrushSizeInput.Value;
            _activeBrush = new SolidBrush(ForegroundColorPicker.Color);
            _activePen = new Pen(_activeBrush, _brushRadius * 2);

            Bitmap previewImage = null;
            if (_sourceBrush != null)
            {
                _activeBrushImage = Utils.ColorizeBitmap(
                    Utils.ResizeBrushImage((Bitmap) _sourceBrush, _brushRadius, _brushRadius),
                    new ColorMatrix(Utils.MatrixFromColor(ForegroundColorPicker.Color)));

                previewImage = Utils.ColorizeBitmap(
                    Utils.ResizeBrushImage((Bitmap)_sourceBrush, (int)(_brushRadius * _zoom), (int)(_brushRadius * _zoom)),
                    new ColorMatrix(Utils.MatrixFromColor(ForegroundColorPicker.Color)));


                /*using (var bmp = new Bitmap((int)(_brushRadius * _zoom), (int)(_brushRadius * _zoom)))
                {
                    using (var gfx = Graphics.FromImage(bmp))
                    {
                        gfx.SmoothingMode = SmoothingMode.HighQuality;
                        gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;

                        gfx.DrawImage(_sourceBrush, 0, 0, _brushRadius * _zoom, _brushRadius * _zoom);
                        gfx.Save();

                        _activeBrushImage =
                            Utils.ColorizeBitmap(bmp,
                                new ColorMatrix(Utils.MatrixFromColor(ForegroundColorPicker.Color)));
                    }
                }*/

                /*_activeBrushImage =
                    Utils.ColorizeBitmap((Bitmap)_sourceBrush,
                        new ColorMatrix(Utils.MatrixFromColor(ForegroundColorPicker.Color)));*/
            }

            BrushPreviewPictureBox.Image = previewImage;
        }

        private void ToggleDrawingButton_Click(object sender, EventArgs e)
        {
            switch (Mode)
            {
                // Toggle paint mode
                case EditMode.View:
                    Mode = EditMode.Draw;
                    break;
                case EditMode.Draw:
                    Mode = EditMode.View;
                    break;
            }
        }

        private void colorPicker1_OnColorChanged(Color color) => UpdateBrush();

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) => UpdateBrush();

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            var index = listView1.SelectedItems[0].ImageIndex;
            _sourceBrush = BrushLibrary.Brushes[index];
            UpdateBrush();
        }

        private void AboutButton_Click(object sender, EventArgs e) => new ColorMatrixTester().Show(this);

        private bool IsFileSupported(string filename) => _supportedExtensions.Contains(filename.Substring(filename.Length - 3).ToLower());

        private void ImagePanel_DragEnter(object sender, DragEventArgs e)
        {
            var fileName = Utils.GetDroppedFileNames(e.Data);
            if (fileName.Length > 3 && IsFileSupported(fileName))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ImagePanel_DragDrop(object sender, DragEventArgs e)
        {
            // Drop open image
            LoadImage(Utils.GetDroppedFileNames(e.Data));
        }

        private void colorizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new EffectColorize())
            {
                dialog.SetBitmap(_canvas);
                if (dialog.ShowDialog() != DialogResult.OK) return;

                _canvas = Utils.ColorizeBitmap(_canvas, dialog.ColMatrix);
                RefreshCanvas(true);
            }
        }

        private void colorPalette1_OnColorPicked(Color color)
        {
            ForegroundColorPicker.Color = color;
            colorPallete1.Hide();
            UpdateBrush();
        }

        private void colorPallete1_OnColorFocused(Color color)
        {
            ForegroundColorPicker.Color = color;
            UpdateBrush();
        }

        private void ForegroundColorPicker_MouseClick(object sender, MouseEventArgs e) => colorPallete1.Visible = !colorPallete1.Visible;

        private void BrushPreviewPictureBox_MouseEnter(object sender, EventArgs e)
        {
            BrushPreviewPictureBox.Focus();
        }

        private void listView1_MouseEnter(object sender, EventArgs e)
        {
            listView1.Focus();
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new ResizeDialog(_canvas))
            {
                if (dialog.ShowDialog() != DialogResult.OK || !dialog.ShouldResize) return;

                using (var tmpCanvas = new Bitmap(dialog.TargetWidth, dialog.TargetHeight))
                {
                    using (var graphics = Graphics.FromImage(tmpCanvas))
                    {
                        graphics.DrawImage(_canvas, 0, 0, tmpCanvas.Width, tmpCanvas.Height);
                    }

                    _canvas = (Bitmap) tmpCanvas.Clone();
                    RefreshCanvas(true);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) => NewFile();

        private void button2_Click(object sender, EventArgs e) => OpenFile();

        private void EditorForm_ResizeEnd(object sender, EventArgs e)
        {
            var container = QuickStartPanel.Parent;
            QuickStartPanel.Left = container.Left + container.Width / 2 - QuickStartPanel.Width / 2;
            QuickStartPanel.Top = container.Top + container.Height / 2 - QuickStartPanel.Height / 2;
        }

        private void SetStatus(string message)
        {
            StatusLabel.Text = message;
        }

        private void CheckUnsavedChanges()
        {
            if (!_unsavedChanges) return;

            if (MessageBox.Show("Do you wish to save changes first?",
                "Unsaved changes warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SaveFile();
            }
        }

        private void EditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckUnsavedChanges();
        }

        // TODO: Implement batch/macro mode - save set of transformations applicable repeatedly, autonomously to multiple files

        // TODO: Layers

        // TODO: Autocorrection draw shapes (rectangles, ellipses...)

        // TODO: Cut, copy, paste, selection types, magic select...

        // TODO: edit tools - rubber, cloning tool, effects
    }
}
