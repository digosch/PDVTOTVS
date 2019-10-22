using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TPDV.Models;

namespace PDVT.Models
{
    public class TransacaoDAO
    {
        private IConfiguration _configuracoes;
        public TransacaoDAO(IConfiguration config)
        {
            _configuracoes = config;
        }

        public Transacao Obter(int Id)
        {
            using (SqlConnection conexao = new SqlConnection(
                _configuracoes.GetConnectionString("TPDVContext")))
            {
                return conexao.QueryFirstOrDefault<Transacao>(
                    "SELECT " +
                        "Id, " +
                        "ValorPagar, " +
                        "ValorPago " +
                    "FROM dbo.Resultado " +
                    "WHERE Id = @Idtransacaofinal ",
                    new { Idtransacaofinal = Id });
            }
        }

    }
}
