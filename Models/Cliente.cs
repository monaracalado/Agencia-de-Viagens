using CRUD_MVC.Enum;

namespace CRUD_MVC.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set;}
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime DataIda { get; set; }
        public DateTime DataVolta { get; set; }
        public Situacao Situacao { get; set; }
    }
}
