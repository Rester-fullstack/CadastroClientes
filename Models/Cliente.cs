using System.ComponentModel.DataAnnotations;

namespace CadastroClientes.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nome { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [StringLength(15)]
        public string Telefone { get; set; }
    }
}
