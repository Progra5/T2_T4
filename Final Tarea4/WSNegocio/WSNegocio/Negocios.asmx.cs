using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using Newtonsoft.Json;
using WSNegocio.SRBaseDatos;

namespace WSNegocio
{
    /// <summary>
    /// Descripción breve de Negocios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Negocios : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public string CuerpoCeleste(string nombre, string descubridor, string archivos)
        {
            try
            {
                WSNegocio.SRBaseDatos.BaseDatosSoapClient WSBaseDatos = new WSNegocio.SRBaseDatos.BaseDatosSoapClient();

                int resultado = WSBaseDatos.InsertarCuerpo(nombre, descubridor);

                if (resultado != 0)
                {
                    try
                    {
                        WSBaseDatos.InsertarFoto(resultado, Encoding.UTF8.GetBytes(archivos));
                        return "Los datos se ingresaron correctamente";
                    }
                    catch (Exception)
                    {
                        return "Ocurrio un error a la hora de insertar las imagenes";
                    }
                }
                else
                {
                    return "Ocurrio un error con la inserción de los datos";
                }

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        [WebMethod]
        public string asociar(int idCuerpo, int idAsociado, int idTipo)
        {
            try
            {
                WSNegocio.SRBaseDatos.BaseDatosSoapClient WSBaseDatos = new WSNegocio.SRBaseDatos.BaseDatosSoapClient();

                string salida = WSBaseDatos.InsertarAsociados(idCuerpo, idAsociado, idTipo);

                return "Los datos se guardaron correctamente";
            }
            catch (Exception)
            {
                return "Ocurrio un error";
            }
        }

        [WebMethod]
        public string insertarTipo(string descripcion)
        {
            try
            {
                WSNegocio.SRBaseDatos.BaseDatosSoapClient WSBaseDatos = new WSNegocio.SRBaseDatos.BaseDatosSoapClient();

                string salida = WSBaseDatos.insertarTipo(descripcion);

                if (salida == "" || salida == " " || salida == null)
                {
                    return "Los datos se ingresaron correctamente";
                }
                else
                {
                    return salida;
                }
            }
            catch (Exception)
            {
                return "Ocurrio un error";
            }
        }



        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public void getConsultarTipo()
        {
            Context.Response.Write(consultarTipo());
        }

        public string consultarTipo()
        {
            try
            {
                WSNegocio.SRBaseDatos.BaseDatosSoapClient WSBaseDatos = new WSNegocio.SRBaseDatos.BaseDatosSoapClient();

                string txt = WSBaseDatos.consultarTipos();

                //var JSon = JsonConvert.DeserializeObject<dynamic>(txt);
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(txt, (typeof(DataTable)));


                string salida = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        salida = salida + " - " + dt.Columns[j].ColumnName.ToString() + " : " + Convert.ToString(dt.Rows[i][j].ToString());
                    }
                }
                return salida;
            }
            catch (Exception)
            {
                return "";
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        /*public void getCuerpos()
        {
            Context.Response.Write(consultarCuerpo());
        }*/
        public string consultarCuerpo()
        {
            try
            {
                WSNegocio.SRBaseDatos.BaseDatosSoapClient WSBaseDatos = new WSNegocio.SRBaseDatos.BaseDatosSoapClient();

                string txt = (WSBaseDatos.ConsultaCuerpos());

                DataTable dt = (DataTable)JsonConvert.DeserializeObject(txt, (typeof(DataTable)));
                string salida = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        salida = salida + " - " + dt.Columns[j].ColumnName.ToString() + " : " + Convert.ToString(dt.Rows[i][j].ToString());
                    }
                }
                return salida;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
