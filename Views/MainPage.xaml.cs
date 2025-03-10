﻿using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
namespace ProyectoEcuniShopP2
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Articulo> Articulos { get; set; }
       
       
        public MainPage()
        {
            InitializeComponent();

            Articulos = new ObservableCollection<Articulo>
            {
                new Articulo { ImageUrl = "libros.jpg" },
                new Articulo { ImageUrl = "iphone.jpg" },
                new Articulo { ImageUrl = "saco.jpg" },
                new Articulo { ImageUrl = "reloj.jpg" },
                new Articulo { ImageUrl = "ingles.jpg" },
                new Articulo { ImageUrl = "spinner.jpg" },
                new Articulo { ImageUrl = "gorra.jpg" },
                new Articulo { ImageUrl = "ps5.jpg" },
                new Articulo { ImageUrl = "curso.jpg" }
            };

            BindingContext = this;


        }
    }

    public class Articulo
    {
        public string ImageUrl { get; set; }
    }


}

