using ProyectoEcuniShopP2.Models;
using System.IO;
using System;

namespace ProyectoEcuniShopP2.Views
{
    public partial class CompraDetailPage : ContentPage
    {
        private Compra compra;

        public CompraDetailPage(Compra compra)
        {
            InitializeComponent();
            this.compra = compra;
            BindingContext = this.compra;
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            compra.NombreProducto = NombreProductoEditor.Text;
            compra.Categoria = CategoriaEditor.Text;
            compra.Cantidad = int.Parse(CantidadEditor.Text);
            compra.Precio = decimal.Parse(PrecioEditor.Text);

            File.WriteAllLines(compra.Filename, new string[]
            {
                compra.NombreProducto,
                compra.Categoria,
                compra.Cantidad.ToString(),
                compra.Precio.ToString()
            });

            await Navigation.PopAsync();
        }

        private async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            if (File.Exists(compra.Filename))
                File.Delete(compra.Filename);

            await Navigation.PopAsync();
        }
    }
}
