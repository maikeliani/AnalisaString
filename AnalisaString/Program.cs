using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string texto;
        int qtdCaracteres, qtdVogais, qtdConsoantes;


        Console.WriteLine("Informe um texto");
        texto = Console.ReadLine();

        Console.WriteLine(ContaCaracteres(texto));
        Console.WriteLine(" numero de vogais é : " + ContaVogais(texto));
        Console.WriteLine(" O mumero de consoantes é :" + ContaConsoante(texto));
        Console.WriteLine(AlternaMaiusculaMinuscula(texto));
        Console.WriteLine( (EspelhaFrase(texto)));


        int ContaCaracteres(string textoB)
        {
            string aux = textoB.Replace(" ", "");
            return aux.Length;
        }

        int ContaVogais(string textoB)
        {
            int contador = 0;
            string aux = textoB.ToLower();
            for (int x = 0; x < aux.Length; x++)
            {
                if (Char.IsDigit(aux[x]) || Char.IsWhiteSpace(aux[x]))
                {
                    continue;
                }
                else if (aux[x].Equals('a') || aux[x].Equals('á') || aux[x].Equals('à') || aux[x].Equals('ã')
                    || aux[x].Equals('â') || aux[x].Equals('e') || aux[x].Equals('é') || aux[x].Equals('è') || aux[x].Equals('ê') ||
                        aux[x].Equals('i') || aux[x].Equals('í') || aux[x].Equals('o') || aux[x].Equals('ô') || aux[x].Equals('õ') ||
                        aux[x].Equals('ó') || aux[x].Equals('u') || aux[x].Equals('ú'))
                {
                    contador++;
                }

            }
            return contador;
        }

        int ContaConsoante(string textoB)
        {
            int contador = 0;
            string aux = textoB.ToLower();
            for (int x = 0; x < aux.Length; x++)
            {
                if (Char.IsDigit(aux[x]) || Char.IsWhiteSpace(aux[x]))
                {
                    continue;
                }
                else if (aux[x].Equals('a') || aux[x].Equals('á') || aux[x].Equals('à') || aux[x].Equals('ã')
                         || aux[x].Equals('â') || aux[x].Equals('e') || aux[x].Equals('é') || aux[x].Equals('è') || aux[x].Equals('ê')
                        || aux[x].Equals('i') || aux[x].Equals('í') || aux[x].Equals('o') || aux[x].Equals('ô') || aux[x].Equals('õ') ||
                        aux[x].Equals('ó') || aux[x].Equals('ò') || aux[x].Equals('u') || aux[x].Equals('ú') || aux[x].Equals('ù'))
                {
                    continue;
                }
                else
                {
                    contador++;
                }

            }
            return contador;
        }



        char[] AlternaMaiusculaMinuscula(string texto)
        {
            char[] aux = new char[texto.Length];

            for (int x = 0; x < texto.Length; x++)
            {
                if(x %2 == 0)
                {
                    aux[x] = Char.ToUpper(texto[x]);
                }
                else
                {
                    aux[x] = Char.ToLower(texto[x]);
                }
                
            }
            return aux;

            
        }

        char[] EspelhaFrase(string texto)
        {  
            int i = 1;
            char[] aux = new char[texto.Length];
            do
            {
                aux[i-1] = texto[texto.Length - i];
                i++;

            }while (i <= texto.Length );

            return aux;

        }



    }
}