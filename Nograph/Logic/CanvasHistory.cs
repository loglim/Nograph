using System;
using System.Drawing;

namespace Nograph.Logic
{
    class CanvasHistory
    {
        // Private
        private int Size;
        private Bitmap[] _data;
        private int _position;

        public CanvasHistory(int size)
        {
            Size = size;
            _data = new Bitmap[size];
        }

        internal void Save(Bitmap canvas)
        {
            if (canvas == null) return;

            if (_position >= Size)
            {
                // Shift-down history entries
                for (int i = 1; i < _data.Length; i++)
                {
                    _data[i - 1] = _data[i];
                }
                _position--;
            }

            Console.WriteLine($"Saving canvas state to position {_position} / {Size}");
            _data[++_position] = (Bitmap)canvas.Clone();

            // Erase previously saved states in further positions
            for (int i = _position + 1; i < Size; i++)
            {
                if (_data[i] != null)
                {
                    _data[i].Dispose();
                    _data[i] = null;
                }
            }
        }

        internal void Reset(Bitmap canvas)
        {
            if (canvas == null) return;

            // Dispose all the old history canvases
            if (_data != null)
            {
                for (int i = 0; i < _data.Length; i++)
                {
                    _data[i]?.Dispose();
                    _data[i] = null;
                }
            }
            else
            {
                _data = new Bitmap[Size];
            }

            _position = -1;
            Save(canvas);
        }

        private bool LoadFromHistory(int change, ref Bitmap canvas)
        {
            var pos = _position - change;
            if (pos < 0 || pos >= Size || _data[pos] == null) return false;

            canvas = _data[pos];
            _position = pos;
            Console.WriteLine($"Setting {pos} / {Size}");
            return true;
        }

        internal bool Undo(ref Bitmap canvas) => LoadFromHistory(1, ref canvas);

        internal bool Redo(ref Bitmap canvas) => LoadFromHistory(-1, ref canvas);
    }
}
