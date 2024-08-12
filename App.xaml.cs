using System.Configuration;
using System.Data;
using System.Windows;

namespace NotePad_In_CSharp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {

            string filePath = e.Args.Length > 0 ? e.Args[0] : null;
            if (filePath == null)
            {
                MainWindow mainWindow = new MainWindow(filePath);
               /* mainWindow.Show();*/
            }
            base.OnStartup(e);
        }
    }

}
