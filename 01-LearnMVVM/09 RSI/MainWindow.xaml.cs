using _09_RSI.Service;
using _09_RSI.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace _09_RSI {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private ShutdownAnimationService animationService;
        public MainWindow() {
            animationService = new ShutdownAnimationService(this);
            InitializeComponent();
            MouseDown += (s, e) => DragMove();
        }

        private void OnClosing(object sender, CancelEventArgs e) {
            e.Cancel = true;
            ViewModelLocator.Main.ShutdownCommand.Execute(null);
        }
    }
}
