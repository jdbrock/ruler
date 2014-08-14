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

namespace Ruler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Double _minHeight = 20;
        private Double _minWidth = 20;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Thumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            var width = e.HorizontalChange;
            var height = e.VerticalChange;

            var newWidth = RulerBorder.ActualWidth + width;
            var newHeight = RulerBorder.ActualHeight + height;

            if (newWidth < _minWidth)
                newWidth = _minWidth;

            if (newHeight < _minHeight)
                newHeight = _minHeight;

            RulerBorder.Width = newWidth;
            RulerBorder.Height = newHeight;
        }
    }
}
