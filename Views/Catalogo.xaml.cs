using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
namespace ProyectoEcuniShopP2.Views
{
    public partial class Catalogo : ContentPage
    {
        public ObservableCollection<CatalogoItem> Entretenimiento { get; set; }
        public ObservableCollection<CatalogoItem> Electrodomesticos { get; set; }
        public ObservableCollection<CatalogoItem> Servicios { get; set; }
        public ObservableCollection<CatalogoItem> Vestimenta { get; set; }
        public ObservableCollection<CatalogoItem> Descuentos { get; set; }

        public Catalogo()
        {
            InitializeComponent();

            // Inicialización de las colecciones
            Entretenimiento = new ObservableCollection<CatalogoItem>
            {
                new CatalogoItem { ImageUrl = "ajedrez.jpg" },
                new CatalogoItem { ImageUrl = "cartas.jpg" },
                new CatalogoItem { ImageUrl = "spinner.jpg" },
                new CatalogoItem { ImageUrl = "yoyo.jpg" },
                new CatalogoItem { ImageUrl = "legos.jpg" },
                new CatalogoItem { ImageUrl = "trompo.jpg" }
            };

            Electrodomesticos = new ObservableCollection<CatalogoItem>
            {
                new CatalogoItem { ImageUrl = "telefono.jpg" },
                new CatalogoItem { ImageUrl = "ps5.jpg" },
                new CatalogoItem { ImageUrl = "reloj.jpg" },
                new CatalogoItem { ImageUrl = "xbox.jpg" },
                new CatalogoItem { ImageUrl = "switch.jpg" },
                new CatalogoItem { ImageUrl = "refri.jpg" }
            };

            Servicios = new ObservableCollection<CatalogoItem>
            {
                new CatalogoItem { ImageUrl = "curso.jpg" },
                new CatalogoItem { ImageUrl = "frances.jpg" },
                new CatalogoItem { ImageUrl = "redes.jpg" },
                new CatalogoItem { ImageUrl = "ingles.jpg" },
                new CatalogoItem { ImageUrl = "social.jpg" },
                new CatalogoItem { ImageUrl = "diseno.jpg" }
            };

            Vestimenta = new ObservableCollection<CatalogoItem>
            {
                new CatalogoItem { ImageUrl = "nike.jpg" },
                new CatalogoItem { ImageUrl = "gorra.jpg" },
                new CatalogoItem { ImageUrl = "saco.jpg" },
                new CatalogoItem { ImageUrl = "adidas.jpg" },
                new CatalogoItem { ImageUrl = "piercings.jpg" },
                new CatalogoItem { ImageUrl = "camiseta.jpg" }
            };

            Descuentos = new ObservableCollection<CatalogoItem>
            {
                new CatalogoItem { ImageUrl = "ingles.jpg" },
                new CatalogoItem { ImageUrl = "nike.jpg" },
                new CatalogoItem { ImageUrl = "reloj.jpg" },
                new CatalogoItem { ImageUrl = "legos.jpg" },
                new CatalogoItem { ImageUrl = "diseno.jpg" },
                new CatalogoItem { ImageUrl = "saco.jpg" }
            };

            BindingContext = this;
        }

        public class CatalogoItem
        {
            public string ImageUrl { get; set; }
        }
    }
}
