using Dapper;
using FormularioGenerico1._5.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;

namespace RepositorioGenerico.Servcicios { 
public interface IRepositorioGenerico{
    void FormulariadoGenerizado(FormularioGenerico formularioGenerico);

    }
    public class Class1 : IRepositorioGenerico
    {
        private readonly string connectionsStrings;

        public Class1(IConfiguration configuration)
        {
            connectionsStrings = configuration.GetConnectionString("DefaultConnection"); 

        }
        public void FormulariadoGenerizado(FormularioGenerico formularioGenerico)
        {
            using (var conexion = new SqlConnection(connectionsStrings))
            {
                conexion.Query("$@fcinsert into FormularioGenerico" +
                    "(nombre_usuario, apellido_usuario, sexo_usuario, fecha_usuario, edad_usuario)" +
                    "values" +
                    "(@nombre_usuario, @apellido_usuario, @sexo_usuario, @fecha_usuario, @edad_usuario) ", formularioGenerico);
            }

        }


    }
}