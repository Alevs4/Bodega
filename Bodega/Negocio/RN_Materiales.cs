using Bodega.Datos;
using Bodega.Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodega.Negocio
{
    public class RN_Materiales
    {
        public DataTable RN_Mostrar_Materiales()
        {
            BD_Materiales obj = new BD_Materiales();
            return obj.BD_Mostrar_Materiales();
        }
        public DataTable RN_Buscar_Material_xValor(string valor)
        {
            BD_Materiales obj = new BD_Materiales();
            return obj.BD_Buscar_Material_xValor(valor);
        }
        public void RN_IngresoMateriales(EN_Materiales Prod)
        {
            BD_Materiales obj = new BD_Materiales();
            obj.BD_IngresoMateriales(Prod);

        }
        public void RN_IngresoProductos(string nombre, string descripcion, int stock)
        {
            BD_Materiales obj = new BD_Materiales();
            obj.BD_IngresoProductos(nombre, descripcion, stock);
        }
        public DataTable RN_Buscar_Materiales_xid(string id)
        {
            BD_Materiales obj = new BD_Materiales();
            return obj.BD_Buscar_Materiales_xid(id);
        }
        public void RN_ActualizarStock_Sumar_Materiales(int id, int stock)
        {
            BD_Materiales obj = new BD_Materiales();
            obj.BD_ActualizarStock_Sumar_Materiales(id, stock);
        }
        public DataTable RN_Listar_Personal()
        {
            BD_Materiales obj = new BD_Materiales();
            return obj.BD_Listar_Personal();
        }
        public void RN_SalidaMateriales(EN_EntregaMateriales Prod)
        {
            BD_Materiales obj = new BD_Materiales();
            obj.BD_SalidaMateriales(Prod);

        }
        public void RN_EliminarMaterial(string id)
        {
            BD_Materiales obj = new BD_Materiales();
            obj.BD_EliminarMaterial(id);    
        }
        public DataTable RN_Mostrar_Materiales_Salida()
        {
            BD_Materiales obj = new BD_Materiales();
            return obj.BD_Mostrar_Materiales_Salida();
        }
        public void RN_Actualizar_Estado_Materiales(int id)
        {
            BD_Materiales obj = new BD_Materiales();
            obj.BD_Actualizar_Estado_Materiales(id);
        }
    }
}
