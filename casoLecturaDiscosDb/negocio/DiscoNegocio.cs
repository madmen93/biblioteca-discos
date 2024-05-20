using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class DiscoNegocio
    {
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Estilo, T.Descripcion Edicion, D.IdEstilo, D.IdTipoEdicion, D.Id from DISCOS D, ESTILOS E, TIPOSEDICION T where E.Id = D.IdEstilo AND T.Id = D.IdTipoEdicion";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)lector["Id"];
                    aux.Titulo = (string)lector["Titulo"];
                    if (!(lector["FechaLanzamiento"] is DBNull))
                        aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
                    if (!(lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    aux.Estilo = new Estilo();
                    aux.Estilo.Id = (int)lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)lector["Estilo"];
                    aux.Edicion = new TipoEdicion();
                    aux.Edicion.Id = (int)lector["IdTipoEdicion"];
                    aux.Edicion.Descripcion = (string)lector["Edicion"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void agregar(Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //datos.setearConsulta("Insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, IdEstilo, IdTipoEdicion) values ('" + nuevo.Titulo + "' ,'" + nuevo.FechaLanzamiento +"' ," + nuevo.CantidadCanciones + ", @estilo, @tipoEdicion)");
                datos.setearConsulta("Insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, IdEstilo, IdTipoEdicion, UrlImagenTapa) values ('" + nuevo.Titulo + "' ,@fechaLanzamiento ," + nuevo.CantidadCanciones + ", @estilo, @tipoEdicion, @urlImagen)");

                //datos.setearParametro("@titulo", nuevo.Titulo);
                //datos.setearParametro("@cantidadCanciones", nuevo.CantidadCanciones);
                datos.setearParametro("@fechaLanzamiento", nuevo.FechaLanzamiento);
                datos.setearParametro("@estilo", nuevo.Estilo.Id);
                datos.setearParametro("@tipoEdicion", nuevo.Edicion.Id);
                datos.setearParametro("@urlImagen", nuevo.UrlImagenTapa);
                datos.ejecutarAccion();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Disco modificado)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update DISCOS set Titulo = @titulo, FechaLanzamiento = @fecha, CantidadCanciones = @cantidad, UrlImagenTapa = @img, IdEstilo = @idEstilo, IdTipoEdicion = @idEdicion where Id = @id");
                datos.setearParametro("@titulo", modificado.Titulo);
                datos.setearParametro("@fecha", modificado.FechaLanzamiento);
                datos.setearParametro("@cantidad", modificado.CantidadCanciones);
                datos.setearParametro("@img", modificado.UrlImagenTapa);
                datos.setearParametro("@idEstilo", modificado.Estilo.Id);
                datos.setearParametro("@idEdicion", modificado.Edicion.Id);
                datos.setearParametro("@id", modificado.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminarFisico(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("delete from DISCOS where Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Disco> filtrar(string campo, string criterio, string filtro)
        {
            List<Disco> lista = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "Select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Estilo, T.Descripcion Edicion, D.IdEstilo, D.IdTipoEdicion, D.Id from DISCOS D, ESTILOS E, TIPOSEDICION T where E.Id = D.IdEstilo AND T.Id = D.IdTipoEdicion And ";
                switch (campo)
                {
                    case "Título":
                        switch (criterio) 
                        {
                            case "Comienza con":
                                consulta += "Titulo like '" + filtro +"%'";
                                break;
                            case "Termina con":
                                consulta += "Titulo like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "Titulo like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Estilo":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "E.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "E.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "E.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Edición":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "T.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "T.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "T.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Cantidad de canciones":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "CantidadCanciones > " + filtro;
                                break;
                            case "Menor a":
                                consulta += "CantidadCanciones < " + filtro;
                                break;
                            default:
                                consulta += "CantidadCanciones = " + filtro;
                                break;
                        }
                        break;
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    if (!(datos.Lector["FechaLanzamiento"] is DBNull))
                        aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];
                    aux.Estilo = new Estilo();
                    aux.Estilo.Id = (int)datos.Lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.Edicion = new TipoEdicion();
                    aux.Edicion.Id = (int)datos.Lector["IdTipoEdicion"];
                    aux.Edicion.Descripcion = (string)datos.Lector["Edicion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
