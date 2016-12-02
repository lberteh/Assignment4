using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Assignment4.Models;

namespace Assignment4
{
    static class Program
    {
        public static ComputerStoreContext db = new ComputerStoreContext();
        public static List<Product> productList = new List<Product>();
        public static Product product;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // create a public static object that we can use throughout the application
            product = new Product();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());

            
        }
    }
}
