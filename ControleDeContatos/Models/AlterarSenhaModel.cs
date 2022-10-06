using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class AlterarSenhaModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Digite a senha atual do usuario")]
        public string SenhaAtual { get; set; }
        [Required(ErrorMessage = "Digite a nova senha")]
        public string NovaSenha { get; set; }
        [Required(ErrorMessage = "Digite a confirmação da senha atual")]
        [Compare("NovaSenha", ErrorMessage = "A senha digitada não confere com a nova senha")]
        public string ConfirmarNovaSenha { get; set; }



    }
}
