using ProyectoEcuniShopP2.Models;
using System;
using System.IO;
using Microsoft.Maui.Controls;

namespace ProyectoEcuniShopP2.Views
{
    public partial class ComprasPage : ContentPage
    {
        private AllCompras allCompras = new AllCompras();

        public ComprasPage()
        {
            InitializeComponent();
        }

        private void OnConfirmClicked(object sender, EventArgs e)
        {
            string appDataPath = FileSystem.AppDataDirectory;
            string fileName = Path.Combine(appDataPath, $"{Path.GetRandomFileName()}.compra.txt");

            Compra nuevaCompra = new Compra
            {
                Filename = fileName,
                NombreProducto = NombreProductoEntry.Text,
                Categoria = CategoriaPicker.SelectedItem?.ToString(),
                Cantidad = Convert.ToInt32(CantidadPicker.SelectedItem?.ToString()),
                Precio = Convert.ToDecimal(PrecioEntry.Text),
                Date = DateTime.Now
            };

            File.WriteAllLines(fileName, new string[]
            {
                nuevaCompra.NombreProducto,
                nuevaCompra.Categoria,
                nuevaCompra.Cantidad.ToString(),
                nuevaCompra.Precio.ToString()
            });

            allCompras.LoadCompras();
            LimpiarCampos();
        }

        private void OnVerHistorialClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistorialComprasPage(allCompras.Compras));
        }

        private void LimpiarCampos()
        {
            NombreProductoEntry.Text = string.Empty;
            CategoriaPicker.SelectedIndex = -1;
            CantidadPicker.SelectedIndex = -1;
            PrecioEntry.Text = string.Empty;
        }
    }
}
