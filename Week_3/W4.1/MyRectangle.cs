using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer
{
    public class MyRectangle: Shape
    {
        private int _width, _height;
        public MyRectangle (Color clr, float x, float y, int width, int height): base(clr)
        {
            X = x;
            Y= y;
            Width = width;
            Height = height;
        }
        public MyRectangle() : this(Color.Green, 0, 0, 100, 100 )
        {

        }
        public override void Draw()
        {
            //Write SplashKit. to see more shape to draw
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(Color, X, Y, _width, _height);
        }
        public override bool IsAt(Point2D pt)
        {
            if ((pt.X - X <= _width) && (pt.Y - Y <= _height))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void DrawOutline()
        {
            SplashKit.DrawRectangle(Color.Black, X - 2, Y - 2, _width + 4, _height + 4);
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
    }
}
