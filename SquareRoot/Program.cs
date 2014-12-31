
using System.Windows.Forms;


namespace SquareRoot
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [System.STAThread]
        static void Main()
        {
            bool bShowWindow = false;

            if (bShowWindow)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }

            HelperClass.Test();


            if (!bShowWindow)
            {
                System.Console.WriteLine(System.Environment.NewLine);
                System.Console.WriteLine(" --- Press any key to continue --- ");
                System.Console.ReadKey();
            }

        } // End Sub Main 


    }


}
