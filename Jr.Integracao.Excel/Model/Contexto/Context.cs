using Jr.Integracao.Excel.Model.Base;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Net.NetworkInformation;

namespace Jr.Integracao.Excel.Model.Contexto
{


    public class Context
    {
        static void Main(string[] args)
        {
            string connString = "Server=localhost;Port=5432;Database=teste;User Id=postgres;Password=Origem@2022;";

            NpgsqlConnection conn = new NpgsqlConnection(connString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM PROD_DATABASE_030423_VF;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // Acessa os dados da linha atual com dr["nome_da_coluna"]
                    Console.WriteLine(dr["date"]);
                }

                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}


