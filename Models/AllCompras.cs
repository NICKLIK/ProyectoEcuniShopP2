using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEcuniShopP2.Models
{
    public class AllCompras
    {
        public ObservableCollection<Compra> Compras { get; set; } = new ObservableCollection<Compra>();

        public AllCompras()
        {
            LoadCompras();
        }

        public void LoadCompras()
        {
            Compras.Clear();

            // Get the folder where the compras are stored.
            string appDataPath = FileSystem.AppDataDirectory;

            // Use Linq extensions to load the *.compra.txt files.
            var compras = Directory
                .EnumerateFiles(appDataPath, "*.compra.txt")
                .Select(filename => new Compra
                {
                    Filename = filename,
                    NombreProducto = File.ReadAllLines(filename)[0],
                    Categoria = File.ReadAllLines(filename)[1],
                    Cantidad = int.Parse(File.ReadAllLines(filename)[2]),
                    Precio = decimal.Parse(File.ReadAllLines(filename)[3]),
                    Date = File.GetLastWriteTime(filename)
                })
                .OrderBy(compra => compra.Date);

            foreach (var compra in compras)
                Compras.Add(compra);
        }
    }
}
