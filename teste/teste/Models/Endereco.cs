namespace teste.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public String Rua { get; set; }
        public String CEP { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public int pessoaId { get; set; }
        public Pessoa? pessoa { get; set; }
    }
}
