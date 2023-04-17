using SplashKitSDK;

namespace ShapeDrawer
{
    public abstract class Shape
    {
        private Color _color;
        private float _x, _y;
        private bool _selected;

        public Shape(Color color)
        {
            _color = color;
        }
        public Shape() : this(Color.Yellow)
        {
        }
        //Drawing a rectangle shape
        //Checking if the mouse is inside the shape
        public abstract bool IsAt(Point2D pt);
        public abstract void Draw();
        public abstract void DrawOutline();
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
