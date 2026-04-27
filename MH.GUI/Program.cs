namespace MyHotel
{
    using System;
    using System.Windows.Forms;

    namespace MH.GUI
    {
        internal static class Program
        {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

               
                Application.Run(new global::MH.GUI.Forms.Auth.frmLogin());
            }
        }
    }
}