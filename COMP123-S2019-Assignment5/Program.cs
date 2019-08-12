using COMP123_S2019_Assignment5.Data;
using COMP123_S2019_Assignment5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Assignment 5: Dollar Computers
 * Author: Mushfika Farzana
 * ID#: 301051702
 * Version: 1.2 Finalized Splash Screen, Start Form and About Form functionalities for Dollar Computers
 * Modified on: August 10, 2019
 */

namespace COMP123_S2019_Assignment5
{
    public static class Program
    {
        // static members
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static AboutForm aboutForm;

        public static Product product;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // instantiate all forms here
            splashForm = new SplashForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();

            product = new Product();

            Application.Run(splashForm);
        }
    }
}
