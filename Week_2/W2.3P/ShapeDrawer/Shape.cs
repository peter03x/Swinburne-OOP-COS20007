using SplashKitSDK;

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
        //Drawing a rectangle shape
        public void Draw() 
        {
            //Write SplashKit. to see more shape to draw
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }
        //Checking if the mouse is inside the shape
        public bool LsAt(Point2D pt) 
        {
            if ((pt.X - _x <= _width) && (pt.Y - _y <= _height))
            {
                return true;
            }
            else
            {
                return false;
            }   
        }
        public Color Color
        { 
            get 
            { 
                return _color; 
            } 
            set 
            { 
                _color = value; 
            } 
        }
        public float X
        { 
            get 
            { 
                return _x; 
            } 
            set 
            { 
                _x = value; 
            } 
        }
        public float Y { 
            get 
            { 
                return _y; 
            } 
            set 
            { 
                _y = value; 
            } 
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
