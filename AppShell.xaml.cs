namespace ProyectoEcuniShopP2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.CompraDetailPage), typeof(Views.CompraDetailPage));
        }
    }
}
