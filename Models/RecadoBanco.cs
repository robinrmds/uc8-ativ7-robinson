using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace uc8ativ5_Robinson.Models
{
    public class RecadoBanco
    {
        private const string DadosConexao = "Database=uc8_sistema; Data Source=localhost; User Id=root;Convert Zero Datetime=True";

       

         public RecadoOBJ LoadRecadoFromDB(MySqlDataReader Reader)
        {
            RecadoOBJ  RecadoEncontrado = new RecadoOBJ();
                RecadoEncontrado.Id = Reader.GetInt32("idrecados");
                
                if(!Reader.IsDBNull(Reader.GetOrdinal("assunto")))                    
                     RecadoEncontrado.Assunto = Reader.GetString("assunto");
                if(!Reader.IsDBNull(Reader.GetOrdinal("sequencia")))                    
                     RecadoEncontrado.Sequencia = Reader.GetInt32("sequencia");
                if(!Reader.IsDBNull(Reader.GetOrdinal("recado")))                    
                     RecadoEncontrado.Recado = Reader.GetString("recado");
                if(!Reader.IsDBNull(Reader.GetOrdinal("id_usuario")))                    
                     RecadoEncontrado.IdUsuario = Reader.GetInt32("id_usuario");
                if(!Reader.IsDBNull(Reader.GetOrdinal("data")))                    
                     RecadoEncontrado.DataPublicacao = (string)Reader.GetDateTime("data").ToString();
                if(!Reader.IsDBNull(Reader.GetOrdinal("ativo")))                    
                    RecadoEncontrado.Ativo = Reader.GetBoolean("ativo");

                return  RecadoEncontrado;
        }
        public List<RecadoOBJ> ListarRecados(string opcao)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM Recados";
            if(opcao == "vitrine"){
                Query = "SELECT * FROM Recados where ativo = 1 order by sequencia asc";
            }
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            MySqlDataReader Reader = Comando.ExecuteReader();

            List<RecadoOBJ> Lista = new List<RecadoOBJ>();

            while (Reader.Read())
            {
                RecadoOBJ  RecadoEncontrado = new RecadoOBJ();
                Lista.Add(LoadRecadoFromDB(Reader));
            }
            Conexao.Close();
            return Lista;            
        }

        
        public void Inserir(RecadoOBJ Recado)
        {   
            //string nome = Recado.Nome;
           
            
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "INSERT INTO Recados (assunto, sequencia,recado, id_usuario, data, ativo) VALUES (@assunto,@sequencia, @recado, @id_usuario, @data, @ativo);";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@assunto", Recado.Assunto);
            Comando.Parameters.AddWithValue("@sequencia", Recado.Sequencia);
            Comando.Parameters.AddWithValue("@recado", Recado.Recado);
            Comando.Parameters.AddWithValue("@id_usuario", Recado.IdUsuario);
            Comando.Parameters.AddWithValue("@data", DateTime.Now);
            Comando.Parameters.AddWithValue("@ativo", Recado.Ativo);
           
            Comando.ExecuteNonQuery();
            //Comando.ExecuteReader();
            Conexao.Close();
        }

        public void Atualizar(RecadoOBJ Recado)
        {
           MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "UPDATE Recados SET recado=@recado,sequencia=@sequencia, assunto=@assunto,id_usuario=@id_usuario, ativo=@ativo where idrecados=@idrecado;";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@idrecado", Recado.Id);
            Comando.Parameters.AddWithValue("@assunto", Recado.Assunto);
            Comando.Parameters.AddWithValue("@sequencia", Recado.Sequencia);
            Comando.Parameters.AddWithValue("@recado", Recado.Recado);
            Comando.Parameters.AddWithValue("@id_usuario", Recado.IdUsuario);
            Comando.Parameters.AddWithValue("@ativo", Recado.Ativo);
           
            Comando.ExecuteNonQuery();
            
            Conexao.Close();           
        }

        public void Remover(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "DELETE FROM Recados WHERE idrecados=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Id", Id);
            Comando.ExecuteNonQuery();
            Conexao.Close();  
        }

        public RecadoOBJ BuscarPorId(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM Recados WHERE idrecados=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Id", Id);
            MySqlDataReader Reader = Comando.ExecuteReader();
            RecadoOBJ  RecadoEncontrado = new RecadoOBJ();
            if(Reader.Read())
            {
                 RecadoEncontrado = (LoadRecadoFromDB(Reader));
            }
            Conexao.Close();
            return  RecadoEncontrado;            
        }
       
    }
}