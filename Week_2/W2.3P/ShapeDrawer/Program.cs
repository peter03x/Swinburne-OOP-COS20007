using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Shape Drawer", 800, 600);
            Shape myShape = new Shape();
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                // function to check if the mouse clicked and which mouse button has been clicked (Left, Right)
                if (SplashKit.MouseClicked(MouseButton.LeftButton)) 
                {
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                }
                if (myShape.LsAt(SplashKit.MousePosition()) && SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    //number in the bracket indicatethe opacity
                    myShape.Color = SplashKit.RandomRGBColor(255);
                }
                myShape.Draw();
                //Draw() must always be the last function before refreshing the screen, otherwise it'll be 1 frame behind
                SplashKit.RefreshScreen();

            } while (!window.CloseRequested);


        }
    }
}
