using SplashKitSDK;

namespace ShapeDrawer
{
    public class Shape
    {
        private Color _color;
        private float _x, _y;
        private int _width, _height;
        private bool _selected;

        public Shape(int x, int y)
        {
            _color = Color.Green;
            _x = x;
            _y = y;
            _width = 100;
            _height = 100;
        }
        public Shape() : this(0, 0)
        {

        }
        //Drawing a rectangle shape
        public void Draw()
        {
            //Write SplashKit. to see more shape to draw
            if (_selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }
        //Checking if the mouse is inside the shape
        public bool IsAt(Point2D pt)
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
        public void DrawOutline()
        {
            SplashKit.DrawRectangle(Color.Black, _x - 2, _y - 2, _width + 4, _height + 4);
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
        public float Y
        {
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
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set 
            { 
                _selected = value;
            }
        }
        /*To create a property, use t
         * he following code:
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
