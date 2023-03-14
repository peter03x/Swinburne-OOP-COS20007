using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer
{
    internal class Shape
    {
        private Color _color;
        private float _x, _y;
        private int _width, _height;

        public Shape()
        {
            _color = Color.Green;
            _x = 0;
            _y = 0;
            _width = 100;
            _height = 100;
        }
        public void Draw() //Drawing a rectangle shape
        {
            SplashKit.FillRectangle (_color, _x, _y, _width, _height);//Write SplashKit. to see more shape to draw
        }
        public bool lsAt(Point2D pt) //Checking if the mouse is inside the shape
        {
            if ((pt.X - _x <= _width) && (pt.Y - _y <= _height)) return true;
             else return false;
        }
        public Color Color
        { get { return _color; } set { _color = value; } }
        public float X
        { get { return _x; } set { _x = value; } }
        public float Y { get { return _y;} set { _y = value; } }
        public int Width
        { get { return _width; } set { _width = value; } }
        public int Height
        { get { return _height; } set { _height = value; } }
        /*To create a property, use the following code:
         * public [TYPE] PropertyName
         * {
         *      get
         *      {
         *          return....
         *      }
         *      set
         *      {
         *          .....=value;
         *      }
         * }
         * Is there is no set, it'll be readonly property*/

    }
}
