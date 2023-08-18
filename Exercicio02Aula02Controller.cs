using Microsoft.AspNetCore.Mvc;

namespace WebAPIExercicio02Aula02.Controllers
{
    public class Exercicio02Aula02Controller : ControllerBase
    // essa classe herda os atributos da ContollerBase
    {
        [HttpPost("DadosPessoais")]
        public ActionResult<string> DadosPessoaisIndex(string nome,
            string endereco, string telefone)
        {
            string resultado;
            resultado = $"{nome} - {endereco} - {telefone}";
            //usar assim para interpolar a string
            return resultado;
        }

        [HttpPost("SucessorAntecessorNumero")]
        public ActionResult<string> AntecessorSucessorNumero(int numero) //aqui eu coloco as variaveis de entrada.
        {
            int antecessor, sucessor;
            antecessor = numero - 1;
            sucessor = numero + 1;
            return $"O número {numero} tem como antecessor {antecessor} e como sucessor {sucessor}";
        }

        [HttpPost("Media")]
        public ActionResult<string> Media(double numero1, double numero2, double numero3)
        {
            double media = Math.Round(numero1 + numero2 + numero3) / 3; // Math.Round para arredondar o resultado
            return $"A média dos números é {media}";
        }

        [HttpPost("MediaNota")]
        public ActionResult<string> MediaNota(double nota1, double nota2, double nota3, double nota4)
        {
            double mediaNota = Math.Round(nota1 + nota2 + nota3 + nota4) / 4; // Math.Round para arredondar o resultado
            return $"A média do aluno é {mediaNota}";

        }
        [HttpPost("AreaTrapezio")]
        public ActionResult<string> AreaTrapezio(double baseMaior, double baseMenor, double altura)
        {
            double areaTrapezio = Math.Round(((baseMaior + baseMenor * altura) / 2), 2); // Math.Round para arredondar o resultado
            return $"A área do trapézio é {areaTrapezio}";

        }

        [HttpPost("Saldo")]
        public ActionResult<string> Saldo(double saldo)
        {
            double novoSaldo = Math.Round((saldo * 1.01),2); // Math.Round para arredondar o resultado
            return $"O novo saldo é {novoSaldo}";