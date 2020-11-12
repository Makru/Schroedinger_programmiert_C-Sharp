using System;

namespace Abstrakte_Kunst {
    abstract class Shape {
        public int Top { get; set; }
        public int Left { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public ConsoleColor Color { get; set; }
        public bool IsCollission(Shape s) {
            return (s.Top < this.Top && s.Top + s.Height > this.Top ||
                this.Top < s.Top && this.Top + this.Height > s.Top) &&
                (s.Left < this.Left && s.Left + s.Width > this.Left ||
                this.Left < s.Left && this.Left + this.Width > s.Left);
        }
        public void DrawShapeBeforeMe(Shape s) {
            s.Draw();
            this.Draw();
        }
        public abstract void Draw();
    }
}
