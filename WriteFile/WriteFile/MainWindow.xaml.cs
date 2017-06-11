using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace WriteFile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\yourfile.txt";

            string content = txtBox.Text;

            File.WriteAllText(filePath, content);

            btnSave.IsEnabled = false;
            MessageBox.Show("File has been saved to desktop!", "File Saved");

            btnSave.IsEnabled = true;
        }
    }
}
