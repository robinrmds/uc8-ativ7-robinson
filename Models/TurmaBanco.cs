using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace uc8ativ5_Robinson.Models
{
    public class TurmaBanco
    {
        private const string DadosConexao = "Database=uc8_sistema; Data Source=localhost; User Id=root;Convert Zero Datetime=True";

       

         public TurmaOBJ LoadTurmaFromDB(MySqlDataReader Reader)
        {
            TurmaOBJ  TurmaEncontrada = new TurmaOBJ();
                TurmaEncontrada.Id = Reader.GetInt32("idturmas");
                
                if(!Reader.IsDBNull(Reader.GetOrdinal("turma")))
                     TurmaEncontrada.Turma = Reader.GetString("turma");
                if(!Reader.IsDBNull(Reader.GetOrdinal("serie")))                    
                     TurmaEncontrada.Serie = Reader.GetString("serie");
                if(!Reader.IsDBNull(Reader.GetOrdinal("ano_letivo")))                    
                     TurmaEncontrada.AnoLetivo = Reader.GetInt32("ano_letivo");
                if(!Reader.IsDBNull(Reader.GetOrdinal("turno")))                    
                     TurmaEncontrada.Turno = Reader.GetString("turno");
                if(!Reader.IsDBNull(Reader.GetOrdinal("ativo")))                    
                     TurmaEncontrada.Ativo = Reader.GetBoolean("ativo");

                return  TurmaEncontrada;
        }
        public List<TurmaOBJ> ListarTurmas()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM turmas";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            MySqlDataReader Reader = Comando.ExecuteReader();

            List<TurmaOBJ> Lista = new List<TurmaOBJ>();

            while (Reader.Read())
            {
                TurmaOBJ  TurmaEncontrada = new TurmaOBJ();
                Lista.Add(LoadTurmaFromDB(Reader));
            }
            Conexao.Close();
            return Lista;            
        }
        
        public void Inserir(TurmaOBJ turma)
        {   
            //string nome = turma.Nome;
           
            
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "INSERT INTO turmas (turma, serie, ano_letivo,turno,ativo) VALUES (@turma, @serie, @anoLetivo, @turno,@ativo);";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@turma", turma.Turma);
            Comando.Parameters.AddWithValue("@serie", turma.Serie);
            Comando.Parameters.AddWithValue("@anoLetivo", turma.AnoLetivo);
            Comando.Parameters.AddWithValue("@turno", turma.Turno);
            Comando.Parameters.AddWithValue("@ativo", turma.Ativo);
           
            Comando.ExecuteNonQuery();
            //Comando.ExecuteReader();
            Conexao.Close();
        }

        public void Atualizar(TurmaOBJ turma)
        {
           MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "UPDATE turmas SET turma=@turma, serie=@serie, ano_letivo=@anoLetivo, turno=@turno, ativo=@ativo where idturmas=@idturma;";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@idturma", turma.Id);
            Comando.Parameters.AddWithValue("@turma", turma.Turma);
            Comando.Parameters.AddWithValue("@serie", turma.Serie);
            Comando.Parameters.AddWithValue("@anoLetivo", turma.AnoLetivo);
            Comando.Parameters.AddWithValue("@turno", turma.Turno);
            Comando.Parameters.AddWithValue("@ativo", turma.Ativo);
            
            
            Comando.ExecuteNonQuery();
            
            Conexao.Close();           
        }

        public void Remover(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "DELETE FROM turmas WHERE idturmas=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Id", Id);
            Comando.ExecuteNonQuery();
            Conexao.Close();  
        }

        public TurmaOBJ BuscarPorId(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM turmas WHERE idturmas=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Id", Id);
            MySqlDataReader Reader = Comando.ExecuteReader();
            TurmaOBJ  TurmaEncontrada = new TurmaOBJ();
            if(Reader.Read())
            {
                 TurmaEncontrada = (LoadTurmaFromDB(Reader));
            }
            Conexao.Close();
            return  TurmaEncontrada;            
        }
       
    }
}