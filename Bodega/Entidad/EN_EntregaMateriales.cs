using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodega.Entidad
{
    public class EN_EntregaMateriales
    {
        int Id;
        int id_prod;
        string EntregadoPor;
        string producto;
        string fecha;
        int cantidad;
        string RecibidoPor;
        string descripcion;
        string rol;
        string talla;
        string categoria;
        string estado;

        public int Id1 { get => Id; set => Id = value; }
        public string EntregadoPor1 { get => EntregadoPor; set => EntregadoPor = value; }
        public string Producto { get => producto; set => producto = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string RecibidoPor1 { get => RecibidoPor; set => RecibidoPor = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Rol { get => rol; set => rol = value; }
        public int Id_prod { get => id_prod; set => id_prod = value; }
        public string Talla { get => talla; set => talla = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
