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

            ControlCustomer c = new ControlCustomer();

           Customer a=new Customer(12,"da","dee","wf");

            c.add(a);
            c.salvareFisier();

            Debug.WriteLine(c.afisare());

        }
    }
}