using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Documents;


namespace NotePad_In_CSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String openFilePath { get; set; }
        String openFileName { get; set; }

        public MainWindow():this(null)
        {
        }
        public MainWindow(string filePath = null)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                openFilePath = filePath;
                TextArea.AppendText(File.ReadAllText(openFilePath));
            }
        }

        // Funciton to open a new window of the notepad when NEW is clicked
        private void MenuNew_Click(object sender, RoutedEventArgs e)
        {
            //Process.Start start a process and AppDomain gives its path to the .exe / for some reason Locaiton is
            // is not working so executable name has to be given manualy it needs resolving
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + "NotePad In CSharp.exe");
        }
        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {
            //openfileDialog create a file open window to open a file
            OpenFileDialog openFileDialog = new();

            // Check if a file is selected and if selected execute the following
            if (openFileDialog.ShowDialog().Equals(true))
            {
                try
                {
                    // get the file path of the opened file
                    openFilePath = openFileDialog.FileName;
                    // append the content of the opened file to the text area using File.ReadAllText(Path to the file)
                    TextArea.AppendText(File.ReadAllText(openFilePath));

                    openFileName = Path.GetFileName(openFilePath + "- Note");

                    this.Title = openFileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Line 45 Exception");
                }
            }
        }
        private void MenuSave_Click(object sender, RoutedEventArgs e)
        {
            TextRange Content = new TextRange(TextArea.Document.ContentStart, TextArea.Document.ContentEnd);
            File.WriteAllText(openFilePath,Content.Text);
        }
        private void MenuClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}