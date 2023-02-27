using System.ComponentModel.DataAnnotations;

namespace CadastroDeContatos.Models
{
    public class AlterarSenhaModel
    {
        public int Id { get; set; }
        [Required]
        public string SenhaAtual { get; set; }
        public string NovaSenha { get; set; }
        public string ConfirmarNovaSenha { get; set; }
    }
}