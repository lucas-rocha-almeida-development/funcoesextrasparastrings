using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcoesextrasparastrings {
    internal class Program {
        static void Main(string[] args) {
            string Original = "abcde FGHIJ ABC abc DEFG  ";
            //Converter todo mundo para maiusculo 
            string Maiusculo = Original.ToUpper();
            Console.WriteLine("Original ** " +Original+ " **");
            Console.WriteLine("ToUpper ** " + Maiusculo + " **");
            Console.WriteLine("------------------------------------------------");
            //Convertendo tudo para minusculo
            string Minusculo = Original.ToLower();
            Console.WriteLine("Original ** " + Original + " ** ");
            Console.WriteLine("ToLower ** " + Minusculo + " **" );
            Console.WriteLine("----------------------------------");
            string s3 = Original.Trim(); //TrimEnd final direita // TrimStar inicio //
            //irar apagar os espaços em branco nas laterais (esquerda e direita)
            Console.WriteLine("Veja o metodo Trim:" + s3);
            Console.WriteLine("----------------------------------");
            //criando uma função procura
            int Procura = Original.IndexOf("bc");
            Console.WriteLine("IndexOf (bc): " + " começa no indice: " + Procura);
            int Procura2 = Original.LastIndexOf("bc"); // ira buscar ultima ocorrencia bc
            Console.WriteLine("A ultima ocorrencia do (bc) se encontra no indice: "+ Procura2);

            Console.WriteLine("-----------------------------------------");
            //fatiando uma string
            string CorteString = Original.Substring(3);
            string CorteString2 = Original.Substring(3,5);
            Console.WriteLine("Recortando (3) caracteres a apartir do indice 3 " +CorteString);
            Console.WriteLine("Imprimindo 5 caracteres a partir do indice (3) " +CorteString2);
            Console.WriteLine("------------------------------------------------");
            //imprimindo e substituindo determinado caractere por outro replace
            string MetodoSubstituicaoReplace = Original.Replace("a" ,"y");//ira substituir tudo que tiver a por y
            Console.WriteLine("Troque os caracteres'a' por 'y' : " +MetodoSubstituicaoReplace);
            Console.WriteLine("\n");
            Console.WriteLine("---------------consulta de string vazia utilizando para formulario -------");
            bool VerificaNullOuVazia = String.IsNullOrEmpty(Original);
            bool VerificaNull2 = string.IsNullOrWhiteSpace(Original);
            Console.WriteLine("Ira dizer se string Original É NULL OU EMPYTE (VAZIA) : "+ VerificaNullOuVazia);
            //basicamente mais rigorosa e objetiva
            Console.WriteLine("Ira verificar se string possui - empty,null ou espaço em branco " + VerificaNull2);
        }
    }
}
