using System;
using System.Windows;
using System.Windows.Media;

namespace HolaMundo2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Esto no se toca porque deja de funcionar//
        // Es el metodo que traduce el XAML en objetos ejecutables//
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MensajeTextBlock.Text = "Hola" + NombreTextBox.Text;
            MensajeTextBlock.Foreground = Brushes.Blue;
      ;   
        }
    }
}
