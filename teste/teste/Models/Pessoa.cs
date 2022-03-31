namespace teste.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String CPF { get; set; }

        public IList<Endereco>? enderecos { get; set; }
    }
}
