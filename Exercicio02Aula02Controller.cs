using Microsoft.AspNetCore.Mvc;

namespace WebAPIExercicio02Aula02.Controllers
{
    public class Exercicio02Aula02Controller : ControllerBase
        // essa classe herda os atributos da ContollerBase
    {
        [HttpPost("DadosPessoais")]
        public ActionResult <string> DadosPessoaisIndex(string nome, 
            string endereco, string telefone)
        {
            string resultado;
            resultado = $"{nome} - {endereco} - {telefone}";
                //usar assim para interpolar a string
                return resultado;
        }
    }
}