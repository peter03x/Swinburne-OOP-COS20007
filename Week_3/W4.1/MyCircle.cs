using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer
{
    public class MyCircle : Shape
    {
        private int _radius;
        public MyCircle(Color color, float x, float y, int radius)
        {
            Color = color;
            X = x;
            Y = y;
            Radius = radius;
        }
        public MyCircle() : this(Color.Blue, 0, 0, 50)
        {

        }
        public override void Draw()
        {
            //Write SplashKit. to see more shape to draw
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillCircle(Color, X, Y, _radius);
        }
        public override void DrawOutline()
        {
            SplashKit.DrawCircle(Color.Black, X-2, Y-2, _radius +2);
        }
        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointInCircle(pt, SplashKit.CircleAt(X, Y, Radius));
        }
        public int Radius 
        { 
            get 
            { 
                return _radius; 
            } 
            set 
            { 
                _radius = value; 
            } 
        }
    }

}
