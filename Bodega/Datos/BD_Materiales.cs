using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bodega.Entidad;

namespace Bodega.Datos
{
    public class BD_Materiales : Conexion
    {
        public DataTable BD_Mostrar_Materiales()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("bodega.SP_LISTAR_MATERIALES", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable data = new DataTable();

                da.Fill(data);
                da = null;
                return data;

            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al consultar: " + ex.Message, "Capa Datos Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

        }
        public DataTable BD_Buscar_Material_xValor(string valor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_BUSCAR_MATERIAL_NOMBRE", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@vId", valor);
                DataTable dato = new DataTable();

                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public static bool Guardar = false;
        public void BD_IngresoMateriales(EN_Materiales Prod)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("bodega.SP_AGREGAR_MATERIAL", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //agregamos los parametros del precedimiento de almacenado
                cmd.Parameters.AddWithValue("@vProveedor", Prod.Proveedor);
                cmd.Parameters.AddWithValue("@vNombre", Prod.Materiales);
                cmd.Parameters.AddWithValue("@vFecha", Prod.Fecha);
                cmd.Parameters.AddWithValue("@vCantidad", Prod.Cantidad);
                cmd.Parameters.AddWithValue("@vRecepcion", Prod.Receptor);
                cmd.Parameters.AddWithValue("@vFactura", Prod.Factura);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                Guardar = true;
            }
            catch (Exception ex)
            {
                Guardar = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void BD_IngresoProductos(string nombre, string descripcion, int stock)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("SP_AGREGAR_PRODUCTOS", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //agregamos los parametros del precedimiento de almacenado

                cmd.Parameters.AddWithValue("@vNombre", nombre);
                cmd.Parameters.AddWithValue("@vdescripcion", descripcion);
                cmd.Parameters.AddWithValue("@vstock", stock);


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                Guardar = true;
            }
            catch (Exception ex)
            {
                Guardar = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public DataTable BD_Buscar_Materiales_xid(string id)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_BUSCAR_MATERIAL_PARA_EDITAR", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@vId", id);
                DataTable dato = new DataTable();

                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public void BD_ActualizarStock_Sumar_Materiales(int id, int stock)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("SP_ACTUALIZAR_STOCK_SUMAR", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //agregamos los parametros del precedimiento de almacenado

                cmd.Parameters.AddWithValue("@vCodigo", id);
                cmd.Parameters.AddWithValue("@vstock", stock);


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                Guardar = true;
            }
            catch (Exception ex)
            {
                Guardar = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public DataTable BD_Listar_Personal()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_LISTAR_PERSONAL", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable data = new DataTable();

                da.Fill(data);
                da = null;
                return data;

            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al consultar: " + ex.Message, "Capa Datos Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

        }
        public void BD_SalidaMateriales(EN_EntregaMateriales Prod)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("bodega.SP_AGREGAR_SALIDA_MATERIALES", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //agregamos los parametros del precedimiento de almacenado
                cmd.Parameters.AddWithValue("@vProducto", Prod.Producto);
                cmd.Parameters.AddWithValue("@vIdProd", Prod.Id_prod);
                cmd.Parameters.AddWithValue("@vDescripcion", Prod.Descripcion);
                cmd.Parameters.AddWithValue("@vRetiradoPor", Prod.RecibidoPor1);
                cmd.Parameters.AddWithValue("@vAutorizadoPor", Prod.EntregadoPor1);
                cmd.Parameters.AddWithValue("@vCantidad", Prod.Cantidad);
                cmd.Parameters.AddWithValue("@vFecha", Prod.Fecha);
                cmd.Parameters.AddWithValue("@rol", Prod.Rol);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                Guardar = true;

            }
            catch (Exception ex)
            {
                Guardar = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public static bool eliminar = false;
        public void BD_EliminarMaterial(string id)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("bodega.SP_ELIMINAR_MATERIAL", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //agregamos los parametros del precedimiento de almacenado
                cmd.Parameters.AddWithValue("@vCodigo", id);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                eliminar = true;

            }
            catch (Exception ex)
            {
                eliminar = false;

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public DataTable BD_Mostrar_Materiales_Salida()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("bodega.SP_LISTAR_SALIDA_MATERIALES", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable data = new DataTable();

                da.Fill(data);
                da = null;
                return data;

            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al consultar: " + ex.Message, "Capa Datos Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

        }
        public void BD_Actualizar_Estado_Materiales(int id)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("bodega.SP_ACTUALIZAR_ESTADO_SALIDA", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //agregamos los parametros del precedimiento de almacenado

                cmd.Parameters.AddWithValue("@vCodigo", id);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                Guardar = true;
            }
            catch (Exception ex)
            {
                Guardar = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
