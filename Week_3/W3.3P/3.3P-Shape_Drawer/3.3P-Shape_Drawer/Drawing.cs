using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _3._3P_Shape_Drawer
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;

        public Drawing (Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }
        public Drawing (): this (Color.White)
        {

        }
        private void AddShape(Shape s)
        {
            _shapes.Add(s);
        }
        public int ShapeCount
        {
            get
            {
                return _shapes.Count;
            }
        }
        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }

    }
}
