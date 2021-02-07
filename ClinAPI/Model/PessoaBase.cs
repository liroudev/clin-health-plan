namespace ClinAPI.Model
{
    public class PessoaBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{this.Nome} {this.Sobrenome}";
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Plano { get; set; }
    }
}