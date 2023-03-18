using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace uc8ativ5_Robinson.Models
{
    public class UsuarioBanco
    {
        private const string DadosConexao = "Database=uc8_sistema; Data Source=localhost; User Id=root;Convert Zero Datetime=True";

        private string CriaToken()
        {       
                int tamanho = 12;
                const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%&";
                StringBuilder res = new StringBuilder();
                Random rnd = new Random();
                while (0 <  tamanho--)
                {
                    res.Append(valid[rnd.Next(valid.Length)]);
                }
                return res.ToString();
        }

       
        public UsuarioOBJ ValidarLogin(UsuarioOBJ usuario)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM Usuario WHERE Login=@Login AND Senha=@Senha AND isActive=1";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Login", usuario.Login);
            Comando.Parameters.AddWithValue("@Senha", usuario.Senha);
            Comando.Parameters.AddWithValue("@Status", usuario.Status);
            MySqlDataReader Reader = Comando.ExecuteReader();

            UsuarioOBJ UsuarioEncontrado = new UsuarioOBJ();

            if(Reader.Read())
            {
                UsuarioEncontrado.Id = Reader.GetInt32("Id");
                
                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Login")))                    
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Senha")))                    
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");
            }
            Conexao.Close();
            return UsuarioEncontrado;
        }
        public int ValidarLoginID(UsuarioOBJ usuario)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM Usuario WHERE Login=@Login AND Senha=@Senha AND isActive=1";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Login", usuario.Login);
            Comando.Parameters.AddWithValue("@Senha", usuario.Senha);
            Comando.Parameters.AddWithValue("@Status", usuario.Status);
            MySqlDataReader Reader = Comando.ExecuteReader();
            
            UsuarioOBJ UsuarioEncontrado = new UsuarioOBJ();
            if(Reader.Read())
            {
                UsuarioEncontrado.Id = Reader.GetInt32("idusuario");
                if(!Reader.IsDBNull(Reader.GetOrdinal("isActive")))                    
                    UsuarioEncontrado.Status = Reader.GetBoolean("isActive");
                   
            }
            Conexao.Close();
            return  UsuarioEncontrado.Id;
        }

         public UsuarioOBJ LoadUserFromDB(MySqlDataReader Reader)
        {
            UsuarioOBJ UsuarioEncontrado = new UsuarioOBJ();
            TurmaOBJ TurmaEcontrada = new TurmaOBJ();
            TurmaBanco turmabanco = new TurmaBanco();
                UsuarioEncontrado.Id = Reader.GetInt32("idusuario");
                
                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Login")))                    
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Senha")))                    
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");
               /* if(!Reader.IsDBNull(Reader.GetOrdinal("Grupo")))                    
                    UsuarioEncontrado.Grupo = Reader.GetInt32("Grupo");*/
                if(!Reader.IsDBNull(Reader.GetOrdinal("Token")))                    
                    UsuarioEncontrado.Token = Reader.GetString("Token");
                if(!Reader.IsDBNull(Reader.GetOrdinal("isActive")))                    
                    UsuarioEncontrado.Status = Reader.GetBoolean("isActive");
                if(!Reader.IsDBNull(Reader.GetOrdinal("matricula")))                    
                    UsuarioEncontrado.Matricula = Reader.GetInt32("matricula");
                if(!Reader.IsDBNull(Reader.GetOrdinal("turma")))                    
                    UsuarioEncontrado.Turma = Reader.GetInt32("turma");
                    UsuarioEncontrado.TurmaNome = turmabanco.BuscarPorId(UsuarioEncontrado.Turma).Turma;
                if(!Reader.IsDBNull(Reader.GetOrdinal("cpf")))                    
                    UsuarioEncontrado.Cpf = Reader.GetString("cpf");
                if(!Reader.IsDBNull(Reader.GetOrdinal("telefone")))                    
                    UsuarioEncontrado.Telefone = Reader.GetString("telefone");
                if(!Reader.IsDBNull(Reader.GetOrdinal("email")))                    
                    UsuarioEncontrado.Email = Reader.GetString("email");
                if(!Reader.IsDBNull(Reader.GetOrdinal("responsavel_ID")))                    
                    UsuarioEncontrado.ResponsavelID = Reader.GetInt32("responsavel_ID");
                    UsuarioEncontrado.ResponsavelNome = (BuscarPorId(UsuarioEncontrado.ResponsavelID)).Nome;
                if(!Reader.IsDBNull(Reader.GetOrdinal("isAluno")))                    
                    UsuarioEncontrado.EhAluno = Reader.GetBoolean("isAluno");
                if(!Reader.IsDBNull(Reader.GetOrdinal("isProfessor")))                    
                    UsuarioEncontrado.EhProfessor = Reader.GetBoolean("isProfessor");
                if(!Reader.IsDBNull(Reader.GetOrdinal("isFuncionario")))                    
                    UsuarioEncontrado.EhFuncionario = Reader.GetBoolean("isFuncionario");
                if(!Reader.IsDBNull(Reader.GetOrdinal("isResponsavel")))                    
                    UsuarioEncontrado.EhResponsavel = Reader.GetBoolean("isResponsavel");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Endereco")))                    
                    UsuarioEncontrado.Endereco = Reader.GetString("Endereco");
                    

                    return UsuarioEncontrado;
        }
        public List<UsuarioOBJ> ListarUsuarios()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM Usuario";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            MySqlDataReader Reader = Comando.ExecuteReader();

            List<UsuarioOBJ> Lista = new List<UsuarioOBJ>();

            while (Reader.Read())
            {
                UsuarioOBJ UsuarioEncontrado = new UsuarioOBJ();
                Lista.Add(LoadUserFromDB(Reader));
            }
            Conexao.Close();
            return Lista;            
        }
        public List<UsuarioOBJ> isResponsavel()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM Usuario where isResponsavel = true;";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            MySqlDataReader Reader = Comando.ExecuteReader();

            List<UsuarioOBJ> Lista = new List<UsuarioOBJ>();

            while (Reader.Read())
            {
                UsuarioOBJ UsuarioEncontrado = new UsuarioOBJ();
                Lista.Add(LoadUserFromDB(Reader));
            }
            Conexao.Close();
            return Lista;            
        }

        public void Inserir(UsuarioOBJ usuario)
        {   
            //string nome = usuario.Nome;
           
            
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "INSERT INTO Usuario (nome, matricula, turma, cpf, telefone, email, login, senha, responsavel_ID, isAluno, isProfessor,isFuncionario, isResponsavel, isActive, token, endereco) VALUES (@nome, @matricula, @turma, @cpf, @telefone, @email, @login, @senha, @responsavel_ID, @isAluno, @isProfessor,@isFuncionario, @isResponsavel, @isActive, @token, @endereco)";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@nome", usuario.Nome);
            Comando.Parameters.AddWithValue("@login", usuario.Login);
            Comando.Parameters.AddWithValue("@senha", usuario.Senha);
            Comando.Parameters.AddWithValue("@Grupo", "1");
            Comando.Parameters.AddWithValue("@matricula", usuario.Matricula);
            Comando.Parameters.AddWithValue("@turma", usuario.Turma);
            Comando.Parameters.AddWithValue("@cpf",  usuario.Cpf);
            Comando.Parameters.AddWithValue("@telefone",  usuario.Telefone);
            Comando.Parameters.AddWithValue("@email",  usuario.Email);
            Comando.Parameters.AddWithValue("@responsavel_ID",  usuario.ResponsavelID);
            Comando.Parameters.AddWithValue("@isAluno",  usuario.EhAluno);
            Comando.Parameters.AddWithValue("@isProfessor",  usuario.EhProfessor);
            Comando.Parameters.AddWithValue("@isFuncionario", usuario.EhFuncionario);
            Comando.Parameters.AddWithValue("@isResponsavel", usuario.EhResponsavel);
            Comando.Parameters.AddWithValue("@isActive", usuario.Status);
            Comando.Parameters.AddWithValue("@token", CriaToken());
            Comando.Parameters.AddWithValue("@endereco", usuario.Endereco);
            //Console.WriteLine(Query);
            Comando.ExecuteNonQuery();
            //Comando.ExecuteReader();
            Conexao.Close();
        }

        public void Atualizar(UsuarioOBJ usuario)
        {
           MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "UPDATE usuario SET nome=@nome, matricula=@matricula, turma=@turma, cpf=@cpf, telefone=@telefone, email=@email, login=@login, senha=@senha, responsavel_ID=@responsavel_ID, isAluno=@isAluno, isProfessor=@isProfessor, isFuncionario=@isFuncionario, isResponsavel=@isResponsavel, isActive=@isActive,token=@token, endereco=@endereco WHERE idusuario=@id;";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@id", usuario.Id);
            Comando.Parameters.AddWithValue("@Nome", usuario.Nome);
            Comando.Parameters.AddWithValue("@Login", usuario.Login);
            Comando.Parameters.AddWithValue("@senha", usuario.Senha);
            Comando.Parameters.AddWithValue("@Grupo", "1");
            Comando.Parameters.AddWithValue("@matricula", usuario.Matricula);
            Comando.Parameters.AddWithValue("@turma", usuario.Turma);
            Comando.Parameters.AddWithValue("@cpf",  usuario.Cpf);
            Comando.Parameters.AddWithValue("@telefone",  usuario.Telefone);
            Comando.Parameters.AddWithValue("@email",  usuario.Email);
            Comando.Parameters.AddWithValue("@responsavel_ID",  usuario.ResponsavelID);
            Comando.Parameters.AddWithValue("@isAluno",  usuario.EhAluno);
            Comando.Parameters.AddWithValue("@isProfessor",  usuario.EhProfessor);
            Comando.Parameters.AddWithValue("@isFuncionario", usuario.EhFuncionario);
            Comando.Parameters.AddWithValue("@isResponsavel", usuario.EhResponsavel);
            Comando.Parameters.AddWithValue("@isActive", usuario.Status);
            Comando.Parameters.AddWithValue("@token", usuario.Token);
            Comando.Parameters.AddWithValue("@endereco", usuario.Endereco);
            
            Comando.ExecuteNonQuery();
            
            Conexao.Close();           
        }

        public void Remover(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "DELETE FROM Usuario WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Id", Id);
            Comando.ExecuteNonQuery();
            Conexao.Close();  
        }

        public UsuarioOBJ BuscarPorId(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM Usuario WHERE idusuario=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Id", Id);
            MySqlDataReader Reader = Comando.ExecuteReader();
            UsuarioOBJ UsuarioEncontrado = new UsuarioOBJ();
            if(Reader.Read())
            {
                UsuarioEncontrado = LoadUserFromDB(Reader);
            }
            Conexao.Close();
            return UsuarioEncontrado;            
        }
       
    }
}