using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using negocio;

namespace dominio
{
    internal class ElementoNegocio
    {
        public List<Elemento> listar()
        {
            List<Elemento> lista = new List<Elemento>();
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("select Id, Digimon, Tipe , Atack,  Images ,  from DB_Digimon");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Elemento aux = new Elemento();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Digimon = (string)datos.Lector["Digimon"];
                    aux.Tipe = (string)datos.Lector["Tipe"];
                    aux.Atack = (string)datos.Lector["Atack"];
                    aux.Images = (string)datos.Lector["Images"];

                    lista.Add(aux);
                }

                return lista;
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
    }
}
