using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Nograph
{
    internal class Utils
    {
        public static void ShowDirInExplorer(string dir)
        {
            if (dir == null) return;

            Process.Start(dir);
        }

        public static void ShowFileInExplorer(string path)
        {
            if (!File.Exists(path)) return;

            var argument = $"/select, \"{path}\"";
            Process.Start("explorer.exe", argument);
        }

        public static float[][] MatrixGrayScale =
        {
            new[] {.3f, .3f, .3f, 0, 0},
            new[] {.59f, .59f, .59f, 0, 0},
            new[] {.11f, .11f, .11f, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {0, 0, 0, 0, 1}
        };

        public static float[][] MatrixNegative =
        {
            new float[] {-1, 0, 0, 0, 0},
            new float[] {0, -1, 0, 0, 0},
            new float[] {0, 0, -1, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {1, 1, 1, 0, 1}
        };

        public static float[][] MatrixFromColor(Color c)
        {
            var r = c.R / 255f;
            var g = c.G / 255f;
            var b = c.B / 255f;

            return new[]
            {
                new[] {0f, 0f, 0f, -1f, 0f},
                new[] {0f, 0f, 0f, 0, 0f},
                new[] {0f, 0f, 0f, 0, 0f},
                new[] {r, g, b, 1f, 0f},
                new[] {0f, 0f, 0f, 0f, 0f}
            };
        }

        public static Bitmap ImgToGrayScale(Bitmap original)
        {
            return ColorizeBitmap(original, new ColorMatrix(MatrixGrayScale));
        }

        public static Bitmap ImgToNegative(Bitmap original)
        {
            return ColorizeBitmap(original, new ColorMatrix(MatrixNegative));
        }

        public static Bitmap ColorizeBitmap(Bitmap original, ColorMatrix colorMatrix)
        {
            var newBitmap = new Bitmap(original.Width, original.Height);
            var g = Graphics.FromImage(newBitmap);
            var attributes = new ImageAttributes();
            attributes.SetColorMatrix(colorMatrix);

            // Draw the original image on the new image using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            g.Dispose();
            return newBitmap;
        }

        public static Bitmap LoadBitmap(string path)
        {
            try
            {
                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        var memoryStream = new MemoryStream(reader.ReadBytes((int) stream.Length));
                        return new Bitmap(memoryStream); // Make a new Bitmap object the owner of the MemoryStream
                    }
                }

                //return (Bitmap) ImageLoader.LoadImageFile(path);
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Please try again later!");
            }

            return null;
        }

        public static Bitmap LoadBitmapPreview(string file, int w, int h)
        {
            var bmp = LoadBitmap(file);
            if (bmp == null) return null;

            var tmp = new Bitmap(w, h);
            var g = Graphics.FromImage(tmp);
            g.DrawImage(bmp, new Rectangle(0, 0, w, h), new Rectangle(0, 0, bmp.Width, bmp.Height),
                GraphicsUnit.Pixel);
            g.Save();
            return tmp;
        }

        public static Bitmap LoadBitmapFromFile(string path)
        {
            Bitmap bmp = null;
            using (var bitmap = new Bitmap(path))
            {
                bmp = new Bitmap(bitmap);
            }

            return bmp;
        }

        public static string GetExifCreation(string path)
        {
            var image = Image.FromFile(path);
            var date = Encoding.UTF8.GetString(image.GetPropertyItem(0x0132).Value);

            return date;
        }

        public static string GetDroppedFileNames(IDataObject data)
        {
            var files = (string[]) data.GetData(DataFormats.FileDrop, false);
            return files.Length > 0 ? files[0] : "";
        }

        public static void AddDialogEscapeCancel(Form dialog)
        {
            dialog.KeyPreview = true;
            dialog.KeyDown += Dialog_KeyDown;
        }

        public static Bitmap RotateImage(Image image, float angle)
        {
            Bitmap bitmap;
            var w = image.Width;
            var h = image.Height;
            using (var bmp = new Bitmap(w, h))
            {
                using (var gfx = Graphics.FromImage(bmp))
                {
                    gfx.SmoothingMode = SmoothingMode.HighQuality;
                    gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    gfx.TranslateTransform((float)w / 2, (float)h / 2);
                    gfx.RotateTransform(angle);
                    gfx.TranslateTransform((float)-w / 2, (float)-h / 2);
                    gfx.DrawImage(image, 0, 0);
                    gfx.Save();
                    bitmap = (Bitmap)bmp.Clone();
                }
            }

            return bitmap;
        }

        public static Bitmap ResizeBrushImage(Bitmap image, int w, int h)
        {
            Bitmap bitmap;
            using (var bmp = new Bitmap(w, h))
            {
                using (var gfx = Graphics.FromImage(bmp))
                {
                    gfx.SmoothingMode = SmoothingMode.HighQuality;
                    gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    gfx.DrawImage(image, 0, 0, w, h);
                    gfx.Save();
                    bitmap = (Bitmap) bmp.Clone();
                }
            }

            return bitmap;
        }

        public static Bitmap CreateImagePreview(Bitmap image, int w, int h)
        {
            Bitmap bitmap;
            using (var bmp = new Bitmap(w, h))
            {
                using (var gfx = Graphics.FromImage(bmp))
                {
                    gfx.SmoothingMode = SmoothingMode.HighSpeed;
                    gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
                    gfx.PixelOffsetMode = PixelOffsetMode.HighSpeed;
                    gfx.DrawImage(image, 0, 0, w, h);
                    gfx.Save();
                    bitmap = (Bitmap) bmp.Clone();
                }
            }

            return bitmap;
        }

        private static void Dialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ((Form) sender).Close();
            }
        }

        public static int Clamp(int min, int max, int value)
        {
            if (value > max)
                return max;
            if (value < min)
                return min;
            return value;
        }

        public static float Lerp(int from, int to, float step)
        {
            return from + (to - from) * step;
        }
    }
}
