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

namespace Puzzle
{
    public partial class MainWindow : Window
    {
        public static Image global_sender;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image lbl = sender as Image;
            global_sender = lbl;
            DragDrop.DoDragDrop(lbl, lbl.Source, DragDropEffects.Copy);
        }
        private void Image_Drop(object sender, DragEventArgs e)
        {
            ((Image)sender).Source = global_sender.Source;
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(puzzle.ShowGridLines == true)
                puzzle.ShowGridLines = false;
            else
                puzzle.ShowGridLines = true;
        }
    }
}
