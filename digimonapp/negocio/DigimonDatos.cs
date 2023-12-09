using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using dominio;
using negocio;

namespace negocio
{
    public class DigimonDatos
    {
        public List<Digimonss> listar()
        {
            List<Digimonss> listar = new List<Digimonss>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DB_DIGIMON; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select D.Id, D.Digimon, D.Tipe , D.Atack , D.Images from  Digimons D";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) 
                {
                    Digimonss aux = new Digimonss();
                    if (!(lector.IsDBNull(lector.GetOrdinal("Id"))))
                        aux.Id = lector.GetInt32(0);


                    aux.Digimon = (string)lector["Digimon"];
                    aux.Tipe = (string)lector["Tipe"];
                    aux.Atack = (string)lector["Atack"];
                    aux.Images = (string)lector["Images"];

                  //  if(!(lector.IsDBNull(lector.GetOrdinal("Images"))))
                    
                                                        

                    listar.Add(aux);
                    
                }
                conexion.Close();
                return listar;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            
        }

        public void agregar(Digimonss nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //podemos probar con agregar id luego del video 
                datos.setearConsulta("insert into Digimons ( Digimon, Tipe, Atack, Images)values (  '" + nuevo.Digimon + "', '" + nuevo.Tipe + "' , '" + nuevo.Atack + "', '"  + nuevo.Images + "'  ) ");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                
                throw;
            }
            finally
            { datos.cerrarConexion(); 
            }
        }

        public void modificar(Digimonss modificar )
        {

        }


    }
}
