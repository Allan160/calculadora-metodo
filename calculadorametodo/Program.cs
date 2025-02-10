using System.Reflection;
using Calculadora;
using Layout;

repetir: 

Formatacao.Cor("Digite o primeiro valor:",ConsoleColor.Black);
if (!decimal.TryParse(Console.ReadLine(),out decimal valorl))
{
    Console.WriteLine("Valor invalido! ");
   goto repetir; 
}
 repetir_valor2: 

Formatacao.Cor("Digite o segundo valor:",ConsoleColor.Blue);
if (!decimal.TryParse(Console.ReadLine(),out decimal valor2))
{
    Console.WriteLine("Valor invalido! ");
   goto repetir_valor2; 
}
    

Operacoes.RalizarAdicao(valorl,valor2);
    