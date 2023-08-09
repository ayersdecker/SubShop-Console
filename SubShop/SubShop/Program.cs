using Spectre.Console;
namespace SubShop
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Display.Login();
            //Display.Loading();
            switch(Display.Home())
            {
                case "New Order":
                    break;
                case "Past Orders":
                    break;
                case "Kiosk Information":
                    break;
                case "Logout":
                    break;
                default: 
                    break;
            }
        }
    }
}