using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodega.Entidad
{
    public class EN_Materiales
    {
        int Id;
        string proveedor;
        string materiales;
        string marca;
        string fecha;
        int cantidad;
        string receptor;
        string factura;

        public int Id1 { get => Id; set => Id = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }

        public string Fecha { get => fecha; set => fecha = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Receptor { get => receptor; set => receptor = value; }
        public string Factura { get => factura; set => factura = value; }
        public string Materiales { get => materiales; set => materiales = value; }
        public string Marca { get => marca; set => marca = value; }
    }
}

