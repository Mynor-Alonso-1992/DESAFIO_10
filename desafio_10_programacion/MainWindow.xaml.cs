using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace CargarEquiposApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CargarButton_Click(object sender, RoutedEventArgs e)
        {
            string rutaArchivo = RutaArchivoTextBox.Text;
            if (File.Exists(rutaArchivo))
            {
                try
                {
                    List<string> equipos = new List<string>(File.ReadAllLines(rutaArchivo));
                    EquiposListBox.ItemsSource = equipos;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("El archivo no existe. Por favor, verifica la ruta.", "Archivo no encontrado", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
