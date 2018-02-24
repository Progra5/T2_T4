
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.Services;

namespace WSBaseDatos
{
    /// <summary>
    /// Descripción breve de BaseDatos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class BaseDatos : System.Web.Services.WebService
    {
        public static string Conexion = @"Data Source=KEVIN-PC\SQLSERVER;Initial Catalog=Androide17;User ID=kpb;Password=kpb";
        SqlConnection cn = new SqlConnection(Conexion);
        SqlCommand comando = new SqlCommand();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public int InsertarCuerpo(string nombre, string descubridor)
        {
            int numero = 0;
            try //protejemos la consulta
            {
                using (SqlConnection cn = new SqlConnection(Conexion))
                using (SqlCommand cmd = new SqlCommand("INRCUE", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@_Nombre", SqlDbType.VarChar, 100);
                    cmd.Parameters.Add("@_Descubridor", SqlDbType.VarChar, 100);
                    cmd.Parameters.Add("@Salida", SqlDbType.BigInt).Direction = ParameterDirection.Output;

                    cmd.Parameters["@_Nombre"].Value = nombre;
                    cmd.Parameters["@_Descubridor"].Value = descubridor;

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    numero = Convert.ToInt32(cmd.Parameters["@Salida"].Value);

                    cn.Close();
                }
                return numero;
            }
            catch (Exception ex)
            {
                cn.Close();
                comando.Dispose();
                return 0;
            }
        }

        [WebMethod]
        public string insertarTipo(string descripcion)
        {
            try //protejemos la consulta
            {
                using (SqlConnection cn = new SqlConnection(Conexion))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("INSTIP", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                return "";
            }
            catch (Exception ex)
            {
                cn.Close();
                comando.Dispose();
                return ex.ToString();
            }
        }

        [WebMethod]
        public string InsertarFoto(int num, byte[] archivo)
        {
            try //protejemos la consulta
            {
                using (SqlConnection cn = new SqlConnection(Conexion))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("INRFOTO", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", num);
                    cmd.Parameters.AddWithValue("@_FOTO", archivo);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                return "";
            }
            catch (Exception ex)
            {
                cn.Close();
                comando.Dispose();
                return ex.ToString();
            }
        }

        [WebMethod]
        public string ConsultaCuerpos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (cn = new SqlConnection(Conexion))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELCUE", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    cn.Close();

                    string txt = Newtonsoft.Json.JsonConvert.SerializeObject(dt);

                    /*for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string txtCol = "";
                        for (int j = 0;  j < dt.Columns.Count;  j++)
                        {
                            if (j == 0)
                            {
                                txtCol = dt.Rows[i][j].ToString();
                            }
                            else
                            {
                                txtCol = txtCol + "," + dt.Rows[i][j].ToString();
                            }
                        }
                        if (i == 0)
                        {
                            txt = txtCol;
                        }
                        else
                        {
                            txt = txt + "+" + txtCol;
                        }
                    }*/
                    
                    return txt;
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                return "";
            }
        }

        [WebMethod]
        public string consultarTipos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (cn = new SqlConnection(Conexion))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELTIP", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    cn.Close();
                    string txt = Newtonsoft.Json.JsonConvert.SerializeObject(dt);

                    /*for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string txtCol = "";
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            if (j == 0)
                            {
                                txtCol = dt.Rows[i][j].ToString();
                            }
                            else
                            {
                                txtCol = txtCol + "," + dt.Rows[i][j].ToString();
                            }
                        }
                        if (i == 0)
                        {
                            txt = txtCol;
                        }
                        else
                        {
                            txt = txt + "+" + txtCol;
                        }
                    }*/

                    return txt;
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                return "";
            }
        }

        [WebMethod]
        public string InsertarAsociados(int idCuerpo, int idAsociado, int idtipo)
        {
            try //protejemos la consulta
            {
                using (SqlConnection cn = new SqlConnection(Conexion))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("INSASO", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_CUERPO", idCuerpo);
                    cmd.Parameters.AddWithValue("@ID_ASOCIADO", idAsociado);
                    cmd.Parameters.AddWithValue("@ID_TIPO", idtipo);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                return "";
            }
            catch (Exception ex)
            {
                cn.Close();
                comando.Dispose();
                return ex.ToString();
            }
        }

    }
}
