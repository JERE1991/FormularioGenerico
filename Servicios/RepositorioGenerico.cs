using Dapper;
using FormularioGenerico1._5.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FormularioGenerico1._5.Servicios
{public interface IRepositorioGenerico{
        void FormulariadoGenerizado(FormularioGenerico formularioGenerico);
    }
        public class RepositorioGenerico : IRepositorioGenerico
    { 
        private readonly string connectionStrings;

        public RepositorioGenerico(IConfiguration configuration)
        {
            connectionStrings = configuration.GetConnectionString("DefaultConnection");

        }

        public void FormulariadoGenerizado(FormularioGenerico formularioGenerico)
        {
            throw new NotImplementedException();
        }

        public void FormularioGenerico(FormularioGenerico formularioGenerico)
        {
              using (var conexion = new SqlConnection(connectionStrings))
            {
                conexion.Query("$@fcinsert into FormularioGenerico" +
                     "(nombre_usuario, apellido_usuario, sexo_usuario, fecha_usuario, edad_usuario)" +
                     "values" +
                     "(@nombre_usuario, @apellido_usuario, @sexo_usuario, @fecha_usuario, @edad_usuario) ", formularioGenerico);

            }
        }

    }

}
