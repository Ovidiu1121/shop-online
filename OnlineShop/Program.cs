using System.Diagnostics;

namespace OnlineShop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ApplicationConfiguration.Initialize();
            //Application.Run(new FrmHome());

            ControlOrderDetails c=new ControlOrderDetails();

            OrderDetails a=new OrderDetails(534,12,3,1,2);

            OrderDetails b = new OrderDetails(534, 22222, 3222, 122, 22);
            c.update(534, b);
            c.salvareFisier();

            Debug.WriteLine(c.afisare());

        }
    }
}