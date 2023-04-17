using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Shape Drawer", 800, 600);
            Drawing myDrawing = new Drawing();
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                // function to check if the mouse clicked and which mouse button has been clicked (Left, Right)
                if (SplashKit.MouseClicked(MouseButton.LeftButton)) 
                {
                    myDrawing.AddShape(new Shape((int)SplashKit.MousePosition().X, (int)SplashKit.MousePosition().Y));
                }
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    //number in the bracket indicatethe opacity
                    myDrawing.Background = Color.RandomRGB(255);
                }
                if (SplashKit.KeyTyped(KeyCode.BackspaceKey) || SplashKit.KeyTyped(KeyCode.DeleteKey))
                {
                    myDrawing.DeleteShapes();
                }
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    myDrawing.SelectShapesAt(SplashKit.MousePosition());
                }

                myDrawing.Draw();
                //Draw() must always be the last function before refreshing the screen, otherwise it'll be 1 frame behind
                
                SplashKit.RefreshScreen();

            } while (!window.CloseRequested);


        }
    }
}
