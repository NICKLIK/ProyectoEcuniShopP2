using ProyectoEcuniShopP2.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace ProyectoEcuniShopP2.Views
{
    public partial class HistorialComprasPage : ContentPage
    {
        public ObservableCollection<Compra> Compras { get; set; }

        public HistorialComprasPage(ObservableCollection<Compra> compras)
        {
            InitializeComponent();
            Compras = compras;
            BindingContext = this;
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count != 0)
            {
                var compra = (Compra)e.CurrentSelection[0];
                await Navigation.PushAsync(new CompraDetailPage(compra));
                comprasCollectionView.SelectedItem = null;
            }
        }
    }
}