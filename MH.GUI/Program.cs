namespace MyHotel
{
    using global::MH.GUI.Forms.Auth;
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

                // Gọi đúng Class Main trong Namespace MH.GUI.Forms.Main
                Application.Run(new frmLogin());
            }
        }
    }
}