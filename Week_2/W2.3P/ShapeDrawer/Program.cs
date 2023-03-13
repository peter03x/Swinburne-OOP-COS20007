using System;
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
                if (SplashKit.MouseClicked(MouseButton.LeftButton)) // function to check if the mouse clicked and which mouse button has been clicked (Left, Right)
                {
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();

                }
                if (myShape.lsAt(SplashKit.MousePosition()) && SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myShape.Color = SplashKit.RandomRGBColor(255);//number in the bracket indicatethe opacity
                }
                myShape.Draw();
                //Draw() must always be the last function before refreshing the screen, otherwise it'll be 1 frame behind
                SplashKit.RefreshScreen();

            } while (!window.CloseRequested);


        }
    }
}
