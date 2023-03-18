namespace uc8ativ5_Robinson.Models
{
    public class UsuarioOBJ
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public int Matricula {get; set;}
        public int Turma {get; set;}
        public string Cpf {get; set;}
        public string Telefone {get; set;}
        public string Email {get; set;}
        public string Login {get; set;}
        public string Senha {get; set;}
        public int Grupo {get; set;}
        public bool Status {get; set;}
        public string Token {get; set;}//Para futura integração e acesso por API
        public int ResponsavelID {get; set;}
        public string ResponsavelNome {get; set;}
        public string TurmaNome {get; set;}
        public bool EhAluno {get; set;}
        public bool EhProfessor {get; set;}
        public bool EhFuncionario {get; set;}
        public bool EhResponsavel {get; set;}
        public string Endereco {get; set;}
    }
}